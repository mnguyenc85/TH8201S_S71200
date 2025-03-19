using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TH8201S
{
    public partial class data : Form
    {
        MySqlConnection strconn;
        MySqlCommandBuilder cmd;
        MySqlCommand cmdsend;
        MySqlDataAdapter dtp;
        string connserver = "Server=222.252.4.119;port=1433;Database=th8201s;UId=root;Pwd=Adatek2vn@server3;Pooling=false;Character Set=utf8";
        //string connlocalhost = "Server=localhost;Database=th8201s;UId=root;Pwd=Adatek2vn@server3; Pooling=false;Character Set=utf8";
        string connlocalhost = "Server=localhost;Database=th8201s;UId=root;Pwd=manh123;Pooling=false;Character Set=utf8";
        //DataTable mytable, mytable1, mytable2;

        private void btt_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bill đã chạy  ", "Xóa dữ liệu đơn hàng", MessageBoxButtons.YesNoCancel);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    strconn = new MySqlConnection(connlocalhost);
                    strconn.Open();
                    string querydel = "delete from phieutest where BILL_NUMBER = '" + Convert.ToInt32(txtbill.Text) + "'";
                    cmdsend = new MySqlCommand(querydel, strconn);
                    cmdsend.ExecuteNonQuery();
                    strconn.Close();

                }

                catch
                {
                    MessageBox.Show("Không thể xóa được dữ liệu trên");
                }

                try
                {
                    strconn = new MySqlConnection(connlocalhost);
                    strconn.Open();
                    string query = "select  * from phieutest where BIll_NUMBER = '" + Convert.ToInt32(txtbill.Text) + "'";
                    dtp = new MySqlDataAdapter(query, connlocalhost);
                    cmd = new MySqlCommandBuilder(dtp);
                    DataTable tam1 = new DataTable();
                    dtp.Fill(tam1);
                    strconn.Close();
                    dataGridView1.DataSource = tam1;
                    dataGridView1.Columns[0].HeaderText = "Bill number";
                    dataGridView1.Columns[1].HeaderText = "Time";
                    dataGridView1.Columns[2].HeaderText = "Strain";
                    dataGridView1.Columns[3].HeaderText = "Force";
                    dataGridView1.Columns[4].HeaderText = "Stress";
                    dataGridView1.Columns[5].HeaderText = "Elong";
                }
                catch
                {
                    MessageBox.Show("không thể kết nối CSDL!");
                }


            }



        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // export to excell 
            sFDialog.InitialDirectory = "C";
            sFDialog.Title = "SAVE AS EXCEL FILE";
            sFDialog.FileName = "";
            sFDialog.Filter = "Excel Files (2007|*.xlsx|Excel Files(.CSV)|*.csv";
            if (sFDialog.ShowDialog() != DialogResult.Cancel)
            {
                Cursor.Current = Cursors.WaitCursor;
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);
                // change properties
                excelApp.Columns.ColumnWidth = 28;
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 1; i < dataGridView1.Rows.Count;i++)
                {  
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
            
                    excelApp.ActiveWorkbook.SaveCopyAs(sFDialog.FileName.ToString());
                    excelApp.ActiveWorkbook.Saved = true;
                    excelApp.Quit();
                    MessageBox.Show("Export Done");
            }
                Cursor.Current = Cursors.Default;
                                   
        }

        private void btt_Start_Click(object sender, EventArgs e)
        {
            FillChart();
            try
            { 
            strconn = new MySqlConnection(connlocalhost);
            strconn.Open();
            string query = "select  * from phieutest where BIll_NUMBER = '" + Convert.ToInt32(txtbill.Text) + "'";
            dtp = new MySqlDataAdapter(query, connlocalhost);
            cmd = new MySqlCommandBuilder(dtp);
            DataTable tam1 = new DataTable();
            dtp.Fill(tam1);            
            strconn.Close();
                txt_Strain_max.Text = string.Format("{0:#,#0.0}", Convert.ToString(tam1.AsEnumerable().Max(row => row["REAL_STRAIN"])));
                txt_Force_max.Text = string.Format("{0:#,##0.00}", Convert.ToString(tam1.AsEnumerable().Max(row => row["REAL_FORCE"])));
                dataGridView1.DataSource = tam1;
            dataGridView1.Columns[0].HeaderText = "Bill number";
            dataGridView1.Columns[1].HeaderText = "Thời gian";
            dataGridView1.Columns[2].HeaderText = "Strain";
            dataGridView1.Columns[3].HeaderText = "Force";
            dataGridView1.Columns[4].HeaderText = "Stress";
            dataGridView1.Columns[5].HeaderText = "Elong";
            }
            catch
            {
                MessageBox.Show("không thể kết nối CSDL!");
            }
        }

        public data()
        {
            InitializeComponent();
        }
        void FillChart()
        {

            // string b = lbl_ID_ODER.Text;
            strconn = new MySqlConnection(connlocalhost);
            strconn.Open();
            string query = "select  * from phieutest where BIll_NUMBER = '" + Convert.ToInt32(txtbill.Text) + "'";
            dtp = new MySqlDataAdapter(query, connlocalhost);
            cmd = new MySqlCommandBuilder(dtp);
            DataTable tam1 = new DataTable();
            dtp.Fill(tam1);
            chart_tensile.DataSource = tam1;
            strconn.Close();
            chart_tensile.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            chart_tensile.ChartAreas["ChartArea1"].AxisX.Title = "STRAIN(mm)";
            chart_tensile.ChartAreas["ChartArea1"].AxisY.Minimum = 0;
            chart_tensile.ChartAreas["ChartArea1"].AxisY.Title = "FORCE(N)";
            chart_tensile.ChartAreas["ChartArea1"].AxisX.LineWidth = 1;
            chart_tensile.ChartAreas["ChartArea1"].AxisY.LineWidth = 1;

            chart_tensile.ChartAreas["ChartArea1"].AxisY.TitleForeColor = Color.Blue;
            chart_tensile.ChartAreas["ChartArea1"].AxisX.TitleForeColor = Color.Blue;

            chart_tensile.Series["Tensile"].BorderWidth = 3;
            chart_tensile.Legends.Clear();
            chart_tensile.Series["Tensile"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart_tensile.Series[0].Points.Clear();
            chart_tensile.Series["Tensile"].XValueMember = "REAL_STRAIN";
            chart_tensile.Series["Tensile"].YValueMembers = "REAL_FORCE";
            chart_tensile.DataBind();
            tam1.Clear();
        }
    }
}
