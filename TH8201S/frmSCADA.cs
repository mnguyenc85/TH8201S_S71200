using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using MySql.Data.MySqlClient;
using OPCAutomation;

using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;
using OxyPlot.Legends;
using OxyPlot.Annotations;

namespace TH8201S
{
    public partial class frmSCADA : Form
    {
        private MySqlConnection _conn;
        private MySqlCommand cmdsend;
        //private string connserver = "Server=222.252.4.119;port=1433;Database=th8201s;UId=root;Pwd=Adatek2vn@server3;Pooling=false;Character Set = utf8";
        //private string connlocalhost = "Server=localhost;Database=th8201s;UId=root;Pwd=Adatek2vn@server3;Pooling=false;Character Set = utf8";
        private string connlocalhost = "Server=localhost;Database=th8201s;UId=root;Pwd=manh123;Pooling=false;Character Set = utf8";
        //DataTable mytable, mytable1, mytable2;
        //==========================WATCHDOG================================
        string Watchdog_value = "0";
        //=====================KEPServerEX CONNECT=====================
        static int tagNumber = 71;    // Cài đặt số lượng tag của project
        static int PLCscantime = 10;    // Cài đặt thời gian quét PLC
                                        // Gọi các kết nối OPC
        public OPCAutomation.OPCServer AnOPCServer;
        public OPCAutomation.OPCServer OPCServer;
        public OPCAutomation.OPCGroups OPCGroup;
        public OPCAutomation.OPCGroup PLC;
        public string Groupname;

        static int arrlength = tagNumber + 1;
        Array OPtags = ClassKEPServerEX.tagread(arrlength);
        Array tagID = ClassKEPServerEX.tagID(arrlength);
        Array WriteItems = Array.CreateInstance(typeof(object), arrlength);
        Array tagHandles = Array.CreateInstance(typeof(Int32), arrlength);
        Array OPCError = Array.CreateInstance(typeof(Int32), arrlength);
        Array dataType = Array.CreateInstance(typeof(Int16), arrlength);
        Array AccessPaths = Array.CreateInstance(typeof(string), arrlength);
        //=====================ĐỌC DỮ LIỆU TAG=====================
        bool AU_MAN;
        bool FINISH;

        private int BillMax;
        bool report_trigger;

        // Đồ thị OxyPlot
        private PlotModel _plotModel;
        private LineSeries _lineSeries;
        private Axis _axX;
        private Axis _axY;
        private LineAnnotation _annoMaxForce;
        private LineAnnotation _annoMaxForceStrain;

        int cur_spd = 0;
        // Lưu giá trị đọc mới nhất đọc từ PLC
        private Data.ClassMeasurePoint _cur_point = new Data.ClassMeasurePoint();
        private Data.ClassBill _cur_bill = new Data.ClassBill();

        // Dùng tính thời gian
        private long _t0_KEPSrv = 0;
        private long _t0_Chart = 0;

        public frmSCADA()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            InitPlot();

            tbx_strain.Visible = false;
        }
        private void SCADA_Load(object sender, EventArgs e)
        {
            KEPServerEX_Connect();
            _t0_KEPSrv = DateTime.Now.Ticks;
        }
        private void InitPlot()
        {
            _plotModel = new PlotModel();
            _lineSeries = new LineSeries() { Title = "Tensile", Color = OxyColors.Blue };
            _lineSeries.TrackerFormatString = "{0}\r\n{1}: {2:0.00}\r\n{3}: {4:0.00}";

            _plotModel.Legends.Add(new Legend()
            {
                LegendPosition = LegendPosition.LeftTop
            });

            _axX = new LinearAxis()
            {
                Position = AxisPosition.Bottom,
                Title = "STRAIN (mm)",
                MajorGridlineStyle = LineStyle.Solid,
                //MinorGridlineStyle = LineStyle.Dot,
                TitleColor = OxyColors.Blue,
                Minimum = -5,
                Maximum = 455
            };
            _axY = new LinearAxis()
            {
                Position = AxisPosition.Left,
                Title = "FORCE (N)",
                MajorGridlineStyle = LineStyle.Solid,
                //MinorGridlineStyle = LineStyle.Dot,
                TitleColor = OxyColors.Blue,
                Minimum = -10,
                Maximum = 260                
            };

            var annoOx = new LineAnnotation()
            {
                Type = LineAnnotationType.Horizontal,
                LineStyle = LineStyle.Solid,
            };
            var annoOy = new LineAnnotation()
            {
                Type = LineAnnotationType.Vertical,
                LineStyle = LineStyle.Solid,
            };

            _annoMaxForce = new LineAnnotation()
            {
                Type = LineAnnotationType.Horizontal,
                TextVerticalAlignment = VerticalAlignment.Bottom,
                Color = OxyColors.Green,
            };
            _annoMaxForceStrain = new LineAnnotation()
            {
                Type = LineAnnotationType.Vertical,
                TextVerticalAlignment = VerticalAlignment.Bottom,
                Color = OxyColors.Yellow,
            };

            _plotModel.Axes.Add(_axX);
            _plotModel.Axes.Add(_axY);
            _plotModel.Series.Add(_lineSeries);
            _plotModel.Annotations.Add(annoOx);
            _plotModel.Annotations.Add(annoOy);
            _plotModel.Annotations.Add(_annoMaxForce);
            _plotModel.Annotations.Add(_annoMaxForceStrain);
            plotTensile.Model = _plotModel;
        }

        #region UI: Buttons & Menu
        private void txtELong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btt_Stop_MouseDown(object sender, MouseEventArgs e)
        {
            WriteItems.SetValue(1, 23);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void btt_Stop_MouseUp(object sender, MouseEventArgs e)
        {
            WriteItems.SetValue(0, 23);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            btt_Start.Visible = true;
            btt_Stop.Visible = false;
        }

        private void btt_Fastup_MouseDown(object sender, MouseEventArgs e)
        {
            WriteItems.SetValue(1, 8);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void btt_Fastup_MouseUp(object sender, MouseEventArgs e)
        {
            WriteItems.SetValue(0, 8);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void btt_Slowup_MouseDown(object sender, MouseEventArgs e)
        {
            WriteItems.SetValue(1, 21);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void btt_Slowup_MouseUp(object sender, MouseEventArgs e)
        {
            WriteItems.SetValue(0, 21);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void btt_Slowdown_MouseDown(object sender, MouseEventArgs e)
        {
            WriteItems.SetValue(1, 20);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void btt_Slowdown_MouseUp(object sender, MouseEventArgs e)
        {
            WriteItems.SetValue(0, 20);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void btt_Return_MouseDown(object sender, MouseEventArgs e)
        {
            WriteItems.SetValue(1, 13);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void btt_Return_MouseUp(object sender, MouseEventArgs e)
        {
            WriteItems.SetValue(0, 13);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void btFastdown_MouseDown(object sender, MouseEventArgs e)
        {
            WriteItems.SetValue(1, 7);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void btFastdown_MouseUp(object sender, MouseEventArgs e)
        {
            WriteItems.SetValue(0, 7);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void cbx_man_auto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbx_man_auto.Text == "AUTO")
            {
                WriteItems.SetValue(1, 3);
                PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);

                btt_Fastdown.Visible = false;
                btt_Fastup.Visible = false;
                btt_Slowdown.Visible = false;
                btt_Slowup.Visible = false;
                btt_Setzero.Visible = false;
                btt_Return.Visible = false;
                btt_Start.Visible = true;
                btt_Stop.Visible = true;
                // btx_update_order.Visible = true;
                BtnRefresh.Visible = true;
            }
            if (cbx_man_auto.Text == "MANUAL")
            {
                WriteItems.SetValue(0, 3);
                PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
                btt_Fastdown.Visible = true;
                btt_Fastup.Visible = true;
                btt_Slowdown.Visible = true;
                btt_Slowup.Visible = true;
                btt_Setzero.Visible = true;
                btt_Return.Visible = true;
                btt_Start.Visible = false;
                btt_Stop.Visible = false;

                // btx_update_order.Visible = false;
                BtnRefresh.Visible = false;
            }
        }

        private void btt_Setzero_MouseDown(object sender, MouseEventArgs e)
        {
            WriteItems.SetValue(1, 36);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void btt_Setzero_MouseUp(object sender, MouseEventArgs e)
        {
            WriteItems.SetValue(0, 36);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void btt_Setzero_Click(object sender, EventArgs e)
        {
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            WriteItems.SetValue(0, 1);      // RESET GIÁ TRỊ START VỀ 0
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            WriteItems.SetValue(0, 23);    // RESET GIÁ TRỊ STOP VỀ 0
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            WriteItems.SetValue(1, 69);     // RESET GIÁ TRỊ ENCODER
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            WriteItems.SetValue(1, 19);   // RESET GIÁ TRỊ SET ZERO CALIB SACLE
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);

            WriteItems.SetValue(1, 19);   // RESET GIÁ TRỊ SET ZERO CALIB SACLE
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            WriteItems.SetValue(1, 36);   // RESET GIÁ TRỊ SET ZERO STRAIN 
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void BtnRefresh_MouseUp(object sender, MouseEventArgs e)
        {
            // Trùng Btn_Refresh_Click
            //WriteItems.SetValue(0, 1);      // RESET GIÁ TRỊ START VỀ 0
            //PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            //WriteItems.SetValue(0, 23);    // RESET GIÁ TRỊ STOP VỀ 0
            //PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            //WriteItems.SetValue(0, 69);     // RESET GIÁ TRỊ ENCODER
            //PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            //WriteItems.SetValue(0, 19);   // RESET GIÁ TRỊ SET ZERO CALIB SACLE
            //PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);

            //WriteItems.SetValue(0, 19);   // RESET GIÁ TRỊ SET ZERO CALIB SACLE
            //PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            //WriteItems.SetValue(0, 36);   // RESET GIÁ TRỊ SET ZERO STRAIN 
            //PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void txtbox_chieuday_KeyDown(object sender, KeyEventArgs e)
        {
            float chieuday;
            if (e.KeyCode == Keys.Enter)
            {
                if (float.TryParse(this.txtbox_chieuday.Text, out chieuday))
                {
                    if (chieuday > 0 && chieuday < 10000.0)
                    {
                        txtbox_chieuday.Text = string.Format("{0:#,#0.0}", chieuday);
                        WriteItems.SetValue(chieuday, 57);
                        PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
                    }
                    else
                    {
                        txtbox_chieuday.Text = "0.0";
                        WriteItems.SetValue(txtbox_chieuday.Text, 57);
                        PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
                    }
                }
                else
                {
                    txtbox_chieuday.Text = "0.0";
                    WriteItems.SetValue(txtbox_chieuday.Text, 57);
                    PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
                }
            }
        }

        private void txtbox_chieurong_KeyDown(object sender, KeyEventArgs e)
        {
            float chieurong;
            if (e.KeyCode == Keys.Enter)
            {
                if (float.TryParse(this.txtbox_chieurong.Text, out chieurong))
                {
                    if (chieurong > 0 && chieurong < 10000.0)
                    {
                        txtbox_chieurong.Text = string.Format("{0:#,#0.0}", chieurong);
                        WriteItems.SetValue(chieurong, 56);
                        PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
                    }
                    else
                    {
                        txtbox_chieurong.Text = "0.0";
                        WriteItems.SetValue(txtbox_chieurong.Text, 56);
                        PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);

                    }
                }
                else
                {
                    txtbox_chieurong.Text = "0.0";
                    WriteItems.SetValue(txtbox_chieurong.Text, 56);
                    PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);

                }
            }
        }

        private void cboSpeed_SelectedValueChanged(object sender, EventArgs e)
        {
            WriteItems.SetValue(0, 62);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);

            cur_spd = int.Parse(cboAutoSpeed.Text);
            WriteItems.SetValue(cur_spd, 61);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void MniHieuChinhCan_Click(object sender, EventArgs e)
        {
            frmCalib calibForm = new frmCalib();
            calibForm.ShowDialog();
        }
        private void mniThongKe_Click(object sender, EventArgs e)
        {
            FrmData calibForm = new FrmData();
            calibForm.ShowDialog();
        }

        private void chkZoomAll_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void btPlotReset_Click(object sender, EventArgs e)
        {
            _axX.Reset();
            _axY.Reset();
            _plotModel.InvalidatePlot(true);
        }
        #endregion

        // Chương trình con kết nối (Connect)
        private void KEPServerEX_Connect()
        {
            string IOServer = "Kepware.KEPServerEX.V6";
            string IOGroup = "OPCGroup1";
            OPCServer = new OPCAutomation.OPCServer();
            OPCServer.Connect(IOServer, "");
            PLC = OPCServer.OPCGroups.Add(IOGroup);
            PLC.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(dataScan);
            PLC.UpdateRate = PLCscantime;
            PLC.IsSubscribed = PLC.IsActive;
            PLC.OPCItems.DefaultIsActive = true;
            PLC.OPCItems.AddItems(tagNumber, ref OPtags, ref tagID,
                        out tagHandles, out OPCError, dataType, AccessPaths);
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            WriteItems.SetValue(1, 23);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            btt_Start.Visible = true;
            btt_Stop.Visible = false;
            timer_start.Enabled = false;

            DialogResult result = MessageBox.Show("Bấm Yes lưu đơn hàng, bấm No để chạy lại đơn hàng  ", "Lưu dữ liệu đơn hàng", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                // Lưu dữ liệu từ Bill vào csdl
                _conn = new MySqlConnection(connlocalhost);
                _conn.Open();
                foreach (var p in _cur_bill.MeasurePoints)
                {
                    string query_send = "insert into phieutest(BILL_NUMBER,DATE_TIME,REAL_STRAIN,REAL_FORCE,REAL_STRESS,REAL_ELONG) values" + "(@BILL_NUMBER,@DATE_TIME,@REAL_STRAIN,@REAL_FORCE,@REAL_STRESS,@REAL_ELONG)";
                    cmdsend = new MySqlCommand(query_send, _conn);
                    cmdsend.Parameters.AddWithValue("BILL_NUMBER", _cur_bill.Id);
                    cmdsend.Parameters.AddWithValue("DATE_TIME", p.T.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmdsend.Parameters.AddWithValue("REAL_STRAIN", p.RealStrain);
                    cmdsend.Parameters.AddWithValue("REAL_FORCE", p.RealForce);
                    cmdsend.Parameters.AddWithValue("REAL_STRESS", p.RealStress);
                    cmdsend.Parameters.AddWithValue("REAL_ELONG", p.RealELong);
                    cmdsend.ExecuteNonQuery();
                }
                _conn.Close();
                _cur_bill.IsSaved = true;
            }
        }

        private void btStart_MouseDown(object sender, MouseEventArgs e)
        {
            if (cur_spd < 100)
            {
                MessageBox.Show("Hãy đặt tốc độ (mm/p) trước khi chạy!", "Chạy tự động");
                return;
            }

            txt_Elong_max.Text = "0.00";
            txt_Force_max.Text = "0.00";
            txt_Strain_max.Text = "0.00";
            txt_Stress_max.Text = "0.00";

            try
            {
                _conn = new MySqlConnection(connlocalhost);
                _conn.Open();
                string query = "SELECT MAX(BILL_NUMBER) FROM phieutest";
                var cmd = new MySqlCommand(query, _conn);
                BillMax = (int)cmd.ExecuteScalar();

                _cur_bill.Renew(BillMax + 1);
                txtBill.Text = _cur_bill.Id.ToString();
                _lineSeries.Points.Clear();

                WriteItems.SetValue(1, 1);
                PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
                WriteItems.SetValue(1, 69);
                PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);

                _t0_Chart = DateTime.Now.Ticks;
                timer_start.Enabled = true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("btStart_MouseDown: ", ex.Message);
            }
        }

        private void btt_Start_MouseUp(object sender, MouseEventArgs e)
        {
            WriteItems.SetValue(0, 1);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            WriteItems.SetValue(0, 69);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
            btt_Start.Visible = false;
            btt_Stop.Visible = true;

        }
        private void dataScan(int ID, int NumItems, ref Array tagID, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            long t = DateTime.Now.Ticks;
            slblTime1.Text = string.Format("{0} ms", (t - _t0_KEPSrv) / 10000);
            _t0_KEPSrv = t;

            for (int i = 1; i <= NumItems; i++)
            {
                // Khai báo biến chung
                int getTagID = Convert.ToInt32(tagID.GetValue(i));
                string tagValue = ItemValues.GetValue(i)?.ToString();
                // Lấy giá trị tag

                switch (getTagID)
                {
                    case 1: break;
                    case 2:
                        _cur_point.RealStrain = Math.Round(float.Parse(tagValue), 1);
                        txt_Strain.Text = string.Format("{0:#,#0.0}", _cur_point.RealStrain);
                        break;
                    case 3:
                        AU_MAN = bool.Parse(tagValue);
                        if (AU_MAN == true)
                        {
                            cbx_man_auto.Text = "AUTO";
                        }
                        else
                        {
                            cbx_man_auto.Text = "MANUAL";
                        }
                        break;
                    case 5:
                        _cur_point.RealELong = Math.Round(double.Parse(tagValue), 2);
                        txt_Elong.Text = string.Format("{0:#,##0.00}", _cur_point.RealELong);
                        break;
                    case 9:
                    case 10:
                        break;
                    case 11:
                        _cur_point.RealForce = Math.Round(double.Parse(tagValue) * 9.8, 2);
                        txt_Force.Text = string.Format("{0:#,##0.00}", _cur_point.RealForce);
                        break;
                    case 12:
                        report_trigger = bool.Parse(tagValue);
                        if (report_trigger == true)
                        {
                        }
                        else
                        {
                        }
                        break;
                    case 23: break;
                    case 24:
                        // txt_Strain_max.Text = string.Format("{0:#,#0.0}", double.Parse(tagValue));
                        break;
                    case 25:
                        // txt_Strain_min.Text = string.Format("{0:#,#0.0}", double.Parse(tagValue));
                        break;
                    case 26:
                        _cur_point.RealStress = Math.Round(double.Parse(tagValue), 1);
                        txt_Stress.Text = string.Format("{0:#,#0.0}", _cur_point.RealStress);
                        break;
                    case 33:
                        // txt_VONG_LAP_HIEN_TAI.Text = string.Format("{0:#0}", int.Parse(tagValue));
                        break;
                    case 34:
                        Watchdog_value = tagValue;
                        break;
                    case 67:
                        if (tagValue == "True")
                        {
                            //timer_chart.Enabled = true;
                        }
                        break;
                    case 70:
                        FINISH = bool.Parse(tagValue);
                        break;
                }
            }
            _cur_point.T = DateTime.Now;
        }

        #region Timers
        private void timer_chart_Tick(object sender, EventArgs e)
        {
            // chart_tensile.Series[0].Points.AddXY(Strain_chart, Force_chart);
        }
        private void timer_start_Tick(object sender, EventArgs e)
        {
            long t = DateTime.Now.Ticks;
            slblTime2.Text = string.Format("{0} ms", (t - _t0_Chart) / 10000);
            _t0_Chart = t;

            if (_cur_bill.AddPoint(_cur_point))
            {
                FillPlot();
                slblCount.Text = _cur_bill.MeasurePoints.Count.ToString();
            }
        }

        private void ClearPlot()
        {
            _lineSeries.Points.Clear();
            _plotModel.InvalidatePlot(true);
        }

        private void FillPlot()
        {
            _lineSeries.Points.Add(new OxyPlot.DataPoint(_cur_point.RealStrain, _cur_point.RealForce));

            var f = _cur_bill.Features;
            _annoMaxForce.Y = f.ForceMax;
            _annoMaxForce.MaximumX = f.ForceMaxStrain;
            _annoMaxForce.Text = f.ForceMax.ToString();
            
            _annoMaxForceStrain.X = f.ForceMaxStrain;
            _annoMaxForceStrain.MaximumY = f.ForceMax;
            _annoMaxForceStrain.Text = f.ForceMaxStrain.ToString();

            if (chkZoomAll.Checked)
            {
                _axX.Minimum = f.StrainMin - 2;
                _axX.Maximum = f.StrainMax + 23;
                _axY.Minimum = f.ForceMin - 2;
                _axY.Maximum = f.ForceMax + 23;
            }

            _plotModel.InvalidatePlot(true);
        }

        private void Timer_Watchdog_Tick(object sender, EventArgs e)
        {

        }
        #endregion
    }
}

