using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TH8201S
{
    public partial class frmLogin : Form
    {
        MySqlConnection strconn;
        MySqlCommandBuilder cmd;
        MySqlCommand cmdsend;
        MySqlDataAdapter dtp;
        string conn = "Server = 222.252.4.119; port =1433; Database = th8201s; UId = root; Pwd = Adatek2vn@server3; Pooling=false;Character Set = utf8";
        DataTable mytable, mytable1;
        int index;
        int c;
        public int lap()
        {
            try
            {
                strconn = new MySqlConnection(conn);
                string query = "select * from dangnhap order by ID DESC";
                dtp = new MySqlDataAdapter(query, conn);
                cmd = new MySqlCommandBuilder(dtp);
                strconn.Open();
                mytable1 = new DataTable();
                dtp.Fill(mytable1);
                strconn.Close();
                for (int a = 0; a < mytable1.Rows.Count; a++)
                {
                    if (txtuser.Text == mytable1.Rows[a]["username"].ToString()
                       && txtpass.Text == mytable1.Rows[a]["pass"].ToString())
                    {
                        index = Convert.ToInt16(mytable1.Rows[a]["ID"].ToString());
                        c = 1;
                    }


                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return c;
        }
        

        private void DangNhap()
        {
            int a = lap();
            if (a == 1)
            {
                if (ckbsave.Checked)
                {
                    try
                    {
                        strconn = new MySqlConnection(conn);
                        string query1 = "update dangnhap set trangthai = 1 where ID =" + index;
                        strconn.Open();
                        cmdsend = new MySqlCommand(query1, strconn);
                        cmdsend.ExecuteNonQuery();
                        strconn.Close();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    try
                    {
                        strconn = new MySqlConnection(conn);
                        string query1 = "update dangnhap set trangthai = 0 where ID =" + index;
                        strconn.Open();
                        cmdsend = new MySqlCommand(query1, strconn);
                        cmdsend.ExecuteNonQuery();
                        strconn.Close();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                frmSCADA scada = new frmSCADA();
                scada.Show();
                this.Hide();
            }
            else
            {
                ckbsave.Checked = false;
                txtuser.Text = "";
                txtpass.Text = "";
                MessageBox.Show("Thông báo", "Đăng nhập thất bại. Sai tài khoản hoặc mật khẩu!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnlog_Click_1(object sender, EventArgs e)
        {
            DangNhap();
        }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                strconn = new MySqlConnection(conn);
                string query = "select*from dangnhap where trangthai = 1";
                dtp = new MySqlDataAdapter(query, conn);
                cmd = new MySqlCommandBuilder(dtp);
                strconn.Open();
                mytable = new DataTable();
                dtp.Fill(mytable);
                try
                {
                    txtuser.Text = mytable.Rows[0]["username"].ToString();
                    txtpass.Text = mytable.Rows[0]["pass"].ToString();
                }
                catch (Exception)
                {
                    txtpass.Text = "";
                    txtuser.Text = "";
                }
                if (!string.IsNullOrEmpty(txtuser.Text) && !string.IsNullOrEmpty(txtpass.Text))
                {
                    ckbsave.Checked = true;
                }
                else
                {
                    ckbsave.Checked = false;
                }
                strconn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
