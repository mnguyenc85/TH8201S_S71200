# Mo phong may test do keo vat lieu
# Location: phong tn dhbk
# PLC: S7-1200, minhcuonghut
# Datetime: 2025/03/18

import snap7
from snap7.server import Server
from snap7.type import SrvArea
import ctypes, time, struct, random
from datetime import datetime

def float2db(v, db, i):
    buf = struct.pack(">f", v)
    db[i]       = buf[0]
    db[i + 1]   = buf[1]
    db[i + 2]   = buf[2]
    db[i + 3]   = buf[3]

def db2float(db, i):
    return struct.unpack(">f", bytes(db[i:i+4]))[0]

rnd = random.Random(datetime.now().second)

DB7 = (ctypes.c_ubyte * 6)()
DB13 = (ctypes.c_ubyte * 114)()
DB14 = (ctypes.c_ubyte * 68)()
DB21 = (ctypes.c_ubyte * 300)()
IW = (ctypes.c_ubyte * 72)()
# init values
float2db(100, DB21, 282)

SPD_FAST = 10
SPD_SLOW = 1
class Simulator:
    def __init__(self):
        self.d = 10
        self.spd = 0
        self.kg0 = 0
        
        self._start0 = 0
        self._stop0 = 0
        self._setZero0 = 0

        self._delta = 0
        self._bRun = 0
        self._d0 = 0
        self._d_return = 0

        # tham so cua mau
        self.mau_k = 0
        self.mau_max_strain = 0
        self.mau_delta_d = 0
        self.mau_ok = False             # Mau bi huy?
    
    def run(self, delta):
        # doc tin hieu vao
        bFastUp = DB7[0] & 1 == 1
        bFastDown = DB7[0] & 2 == 2
        bSlowUp = DB7[0] & 4 == 4
        bSlowDown = DB7[0] & 8 == 8
        bReturn = DB7[0] & 16 == 16
        bStop = DB7[0] & 32 == 32
        bStart = DB7[0] & 64 == 64
        bAutoManual = DB7[0] & 128 == 128
        bSetZero = DB7[1] & 1 == 1
        fSpeed = db2float(DB21, 282)

        if (bSetZero and not self._setZero0):
            self._d0 = self.d
        if (bStart and not self._start0):
            # gia lap mau
            self.mau_k = rnd.randrange(40, 60) / 980
            self.mau_max_strain = rnd.randrange(150, 350)
            self.mau_delta_d = rnd.randrange(0, 5)
            self.mau_ok = True
            self._bRun = 1
        if (bStop and not self._stop0):
            self._bRun = 0
        if (bReturn):
            self._d_return = 1

        # mo phong voi vong quet 100 ms
        self._delta += delta
        if self._delta < 0.1: return

        spd = 0
        if bAutoManual:
            if self._bRun:
                spd = fSpeed / 60
        else:
            if self._d_return:
                delta_d = self.d - self._d0
                if delta_d > 5: spd = -SPD_FAST
                elif delta_d > 0.05: spd = -delta_d / 2
                elif delta_d < -5: spd = SPD_FAST
                elif delta_d < -0.01: spd = delta_d / 2
                elif abs(delta_d) < 0.00001:
                    self._d = 0
                    self._d_return = 0
            else:
                if bFastUp: spd = SPD_FAST
                if bSlowUp: spd = SPD_SLOW
                if bFastDown: spd -= SPD_FAST
                if bSlowDown: spd -= SPD_SLOW

        # distance (mm)
        self.d += spd * self._delta
        if self.d > 600: self.d = 600
        if self.d < 5: self.d = 5

        strain = self.d - self._d0
        if self.mau_ok:
            real_Strain = strain - self.mau_delta_d
            if (real_Strain > 0):
                self.kg0 = real_Strain * self.mau_k
                if real_Strain > self.mau_max_strain:
                    self.kg0 = 0
                    self.mau_ok = False
        else:
            self.kg0 = 0
            if self._bRun: self._bRun = False

        # force (kg)
        if spd != 0:
            kg = self.kg0 + rnd.random() * 0.02 - 0.01
        else:
            kg = self.kg0 + rnd.random() * 0.06 - 0.03

        #output
        float2db(strain, DB13, 10)
        float2db(kg, DB13, 14)

        #interal
        self._start0 = bStart
        self._stop0 = bStop
        self._setZero0 = bSetZero
        self._delta = 0

sim = Simulator()
srv = Server()
srv.register_area(SrvArea.DB, 7, DB7)
srv.register_area(SrvArea.DB, 13, DB13)
srv.register_area(SrvArea.DB, 14, DB14)
srv.register_area(SrvArea.DB, 21, DB21)
srv.register_area(SrvArea.PE, 0, IW)

srv.start_to("127.0.0.1", 5102)

print("Snap7 Server running... Press Ctrl+C to stop.")

t0 = datetime.now()
try:
    while True:
        t = datetime.now()
        delta  = (t - t0).total_seconds()
        t0 = t
        
        srv.pick_event()        # Process client requests

        sim.run(delta)

        time.sleep(0.025)
except Exception as e:
    print("\nShutting down server...")
    if e:
        print("\nError: ", e)
    srv.stop()
    srv.destroy()