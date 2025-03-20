using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TH8201S.Db;

namespace TH8201S
{
    public partial class frmSettings: Form
    {
        private DbBridge _db = DbBridge.Instance;

        public frmSettings()
        {
            InitializeComponent();

            foreach (string s in _db.Sources.Keys)
                cboConnSources.Items.Add(s);

            cboConnSources.SelectedItem = _db.SourceName;
        }

        private void BtTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                string src = (string)cboConnSources.SelectedItem;                
                if (_db.Sources.ContainsKey(src))
                {
                    string connStr = _db.Sources[src].ConnectionString;
                    var conn = new MySqlConnection(connStr);
                    conn.Open();
                    conn.Clone();

                    MessageBox.Show("Kết nối thành công", "Thử kết nối");
                }
                else
                {
                    MessageBox.Show("Không có nguồn này!", "Chọn nguồn kết nối");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Lỗi kết nối: {0}", ex.Message), "Thử kết nối");
            }
        }

        private void BtAccept_Click(object sender, EventArgs e)
        {
            _db.SetSource((string)cboConnSources.SelectedItem);
            _db.SaveSettings();

            Close();
        }
    }
}
