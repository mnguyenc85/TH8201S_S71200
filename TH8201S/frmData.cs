using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

using OxyPlot.Series;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Annotations;
using OxyPlot.Legends;
using TH8201S.Data;
using TH8201S.Db;

namespace TH8201S
{
    public partial class FrmData : Form
    {
        private MySqlConnection _conn;
        private MySqlCommandBuilder _cmdBuilder;
        private MySqlCommand _cmd;
        private MySqlDataAdapter _dataAdapter;
        // Đồ thị OxyPlot
        private PlotModel _plotModel;
        private LineSeries _lineSeries;
        private Axis _axX;
        private Axis _axY;
        private OxyPlot.Annotations.LineAnnotation _annoMaxForcePoint;
        private TensileFeatures tensileFeatures = new TensileFeatures();

        public FrmData()
        {
            InitializeComponent();

            InitChart();
        }
        private void BtStart_Click(object sender, EventArgs e)
        {
            LoadAndFillData();
        }
        private void FrmData_Load(object sender, EventArgs e)
        {
            LoadMaxBill();
        }

        private void BtDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bill đã chạy  ", "Xóa dữ liệu đơn hàng", MessageBoxButtons.YesNoCancel);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    _conn = new MySqlConnection(DbBridge.Instance.ConnStr);
                    _conn.Open();
                    string querydel = "delete from phieutest where BILL_NUMBER = '" + (int)numBillId.Value + "'";
                    _cmd = new MySqlCommand(querydel, _conn);
                    _cmd.ExecuteNonQuery();
                    _conn.Close();

                }

                catch
                {
                    MessageBox.Show("Không thể xóa được dữ liệu trên");
                }

                try
                {
                    string query = "select  * from phieutest where BIll_NUMBER = '" + (int)numBillId.Value + "'";

                    _conn = new MySqlConnection(DbBridge.Instance.ConnStr);
                    _conn.Open();
                    _dataAdapter = new MySqlDataAdapter(query, _conn);
                    DataTable tam1 = new DataTable();
                    _dataAdapter.Fill(tam1);
                    _conn.Close();

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

        private void BtSave_Click(object sender, EventArgs e)
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

        private void btZoomAll_Click(object sender, EventArgs e)
        {
            _axX.Minimum = tensileFeatures.StrainMin - 2;
            _axX.Maximum = tensileFeatures.StrainMax + 23;
            _axY.Minimum = tensileFeatures.ForceMin - 2;
            _axY.Maximum = tensileFeatures.ForceMax + 23;
            _plotModel.InvalidatePlot(true);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            _axX.Reset();
            _axY.Reset();
            _plotModel.InvalidatePlot(true);
        }

        private async void LoadAndFillData()
        {
            BtSearch.Enabled = false;
            int bill_id = (int)numBillId.Value;
            
            DataTable tbl = await LoadData(bill_id);

            if (tbl != null)
            {
                dataGridView1.DataSource = tbl;
                dataGridView1.Columns[0].HeaderText = "Bill number";
                dataGridView1.Columns[1].HeaderText = "Thời gian";
                dataGridView1.Columns[2].HeaderText = "Strain";
                dataGridView1.Columns[3].HeaderText = "Force";
                dataGridView1.Columns[4].HeaderText = "Stress";
                dataGridView1.Columns[5].HeaderText = "Elong";

                FillChart(tbl);
            }
            BtSearch.Enabled = true;
        }
        private async Task<DataTable> LoadData(int bill_id)
        {
            DataTable tbl = new DataTable();
            try
            {
                string query = string.Format("SELECT * FROM phieutest WHERE BIll_NUMBER='{0}' ORDER BY DATE_TIME", bill_id);
                _conn = new MySqlConnection(DbBridge.Instance.ConnStr);
                _conn.Open();
                _dataAdapter = new MySqlDataAdapter(query, _conn);
                await _dataAdapter.FillAsync(tbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối CSDL!");
                System.Diagnostics.Debug.WriteLine(ex.Message);
                tbl = null;
            }
            finally
            {
                _conn.Close();
            }
            return tbl;
        }

        private async void LoadMaxBill()
        {
            BtSearch.Enabled = false;

            try
            {
                _conn = new MySqlConnection(DbBridge.Instance.ConnStr);
                _conn.Open();
                string query = "SELECT MAX(BILL_NUMBER) FROM phieutest";
                _cmd = new MySqlCommand(query, _conn);
                var ret = await _cmd.ExecuteScalarAsync();
                lblMaxBill.Text = string.Format("/{0}", (int)ret);
                numBillId.Maximum = (int)ret;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối CSDL!");
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            BtSearch.Enabled = true;
        }

        private void InitChart()
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

            _annoMaxForcePoint = new LineAnnotation()
            {
                Type = LineAnnotationType.Horizontal,
                Text = "",
                TextVerticalAlignment = VerticalAlignment.Bottom,
                TextHorizontalAlignment = OxyPlot.HorizontalAlignment.Right,
                LineStyle = LineStyle.Dash,
                Color = OxyColors.Green,
            };

            _plotModel.Axes.Add(_axX);
            _plotModel.Axes.Add(_axY);
            _plotModel.Series.Add(_lineSeries);
            _plotModel.Annotations.Add(annoOx);
            _plotModel.Annotations.Add(annoOy);
            _plotModel.Annotations.Add(_annoMaxForcePoint);
            plotData.Model = _plotModel;
        }

        private void FillChart(DataTable tbl)
        {
            tensileFeatures.Reset();
            _lineSeries.Points.Clear();
            foreach (DataRow r in tbl.Rows)
            {
                double strain = (double)r["REAL_STRAIN"];
                double force = (double)r["REAl_FORCE"];
                tensileFeatures.Check(strain, force);
                _lineSeries.Points.Add(new DataPoint(strain, force));
            }

            _annoMaxForcePoint.Text = string.Format("Force: {0} N, Strain: {1} mm", tensileFeatures.ForceMax, tensileFeatures.ForceMaxStrain);
            _annoMaxForcePoint.MaximumX = tensileFeatures.ForceMaxStrain;
            _annoMaxForcePoint.Y = tensileFeatures.ForceMax;

            _plotModel.InvalidatePlot(true);

            txt_Strain_max.Text = string.Format("{0:#,#0.0}", tensileFeatures.ForceMaxStrain);
            txt_Force_max.Text = string.Format("{0:#,##0.00}", tensileFeatures.ForceMax);
        }

        private void chkAnnotation_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (!_plotModel.Annotations.Contains(_annoMaxForcePoint))
                {
                    _plotModel.Annotations.Add(_annoMaxForcePoint);
                }
            }
            else
            {
                if (_plotModel.Annotations.Contains(_annoMaxForcePoint))
                {
                    _plotModel.Annotations.Remove(_annoMaxForcePoint);
                }
            }
            _plotModel.InvalidatePlot(false);
        }
    }
}
