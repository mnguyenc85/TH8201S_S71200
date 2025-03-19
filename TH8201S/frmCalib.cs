using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPCAutomation;


namespace TH8201S
{
    public partial class frmCalib : Form
    {
        public frmCalib()
        {
            InitializeComponent();
        }

        private void btt_SET_ZERO_MouseDown(object sender, MouseEventArgs e)
        {
            WriteItems.SetValue(1, 19);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void Calib_Load(object sender, EventArgs e)
        {
            KEPServerEX_Connect();

        }
        //=====================KEPServerEX CONNECT=====================
        static int tagNumber = 71;       // Cài đặt số lượng tag của project
        static int PLCscantime = 100;  // Cài đặt thời gian quét PLC
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
        //=====================ĐỌC DỮ LIỆU TAG=====================


        private void dataScan(int ID, int NumItems, ref Array tagID,
                    ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            for (int i = 1; i <= NumItems; i++)
            {
                // Khai báo biến chung
                int getTagID = Convert.ToInt32(tagID.GetValue(i));
                string tagValue = ItemValues.GetValue(i)?.ToString();
                // Lấy giá trị tag


                if (getTagID == 11)
                {
                    txt_RealWeight.Text = string.Format("{0:#,###0.000}", double.Parse(tagValue));
                }
                if (getTagID == 22)
                {
                    txt_Span.Text = string.Format("{0:#,######0.000000}", double.Parse(tagValue));
                }
                if (getTagID == 34)
                {
                    txt_ZERO.Text = string.Format("{0:####0000}", int.Parse(tagValue));
                }

                if (getTagID == 38)
                {
                    txt_Chanel_AI.Text = string.Format("{0:#0}", int.Parse(tagValue));
                }
                if (getTagID == 39)
                {
                    txt_Set_Mass.Text = string.Format("{0:#,#0.0}", double.Parse(tagValue));
                }
            }
        }

        private void btt_SET_ZERO_MouseUp(object sender, MouseEventArgs e)
        {
            WriteItems.SetValue(0, 19);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void btt_SET_SPAN_MouseDown(object sender, MouseEventArgs e)
        {
            WriteItems.SetValue(1, 18);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void btt_SET_SPAN_MouseUp(object sender, MouseEventArgs e)
        {
            WriteItems.SetValue(0, 18);
            PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
        }

        private void txt_ZERO_KeyDown(object sender, KeyEventArgs e)
        {
            int ZERO;
            if (e.KeyCode == Keys.Enter)
                if (int.TryParse(this.txt_ZERO.Text, out ZERO))
                {
                    if (ZERO >= 0 && ZERO <= 30000)
                    {
                        txt_ZERO.Text = string.Format("{0:#0}", ZERO);
                        WriteItems.SetValue(ZERO, 34);
                        PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
                    }
                    else
                    {
                        txt_ZERO.Text = "3000";
                        WriteItems.SetValue(txt_ZERO.Text, 34);
                        PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);

                    }

                }
                else
                {
                    txt_ZERO.Text = "3000";
                    WriteItems.SetValue(txt_ZERO.Text, 34);
                    PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
                }
        }

        private void txt_Span_KeyDown(object sender, KeyEventArgs e)
        {
            float SPAN;
            if (e.KeyCode == Keys.Enter)


                if (float.TryParse(this.txt_Span.Text, out SPAN))
                {

                    if (SPAN > 0 && SPAN < 9.999)
                    {
                        txt_Span.Text = string.Format("{0:#,#0.0}", SPAN);
                        WriteItems.SetValue(SPAN, 22);
                        PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
                    }
                    else
                    {
                        txt_Span.Text = "0.0043";
                        WriteItems.SetValue(txt_Span.Text, 22);
                        PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);

                    }
                }
                else
                {
                    txt_Span.Text = "0.0043";
                    WriteItems.SetValue(txt_Span.Text, 22);
                    PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);

                }
        }

        private void txt_Set_Mass_KeyDown(object sender, KeyEventArgs e)
        {
            float SET_MASS;
            if (e.KeyCode == Keys.Enter)
            {
                if (float.TryParse(this.txt_Set_Mass.Text, out SET_MASS))
                {

                    if (SET_MASS > 0 && SET_MASS < 10000)
                    {
                        txt_Set_Mass.Text = string.Format("{0:#,#0.0}", SET_MASS);
                        WriteItems.SetValue(SET_MASS, 39);
                        PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
                    }
                    else
                    {
                        txt_Set_Mass.Text = "0.0";
                        WriteItems.SetValue(txt_Set_Mass.Text, 39);
                        PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
                    }
                }
                else
                {
                    txt_Set_Mass.Text = "0.0";
                    WriteItems.SetValue(txt_Set_Mass.Text, 39);
                    PLC.SyncWrite(tagNumber, ref tagHandles, ref WriteItems, out OPCError);
                }
            }
        }
    }
}
