namespace TH8201S
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.ckbsave = new System.Windows.Forms.CheckBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.myCustomPanel1 = new TH8201S.UserControls.MyCustomPanel();
            this.BtLogin = new TH8201S.UserControls.GlassButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.myCustomPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TH8201S.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(13, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(428, 60);
            this.label3.TabIndex = 18;
            this.label3.Text = "Đăng nhập hệ thống";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Trạng thái :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mật khẩu :";
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(288, 84);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(155, 32);
            this.txtpass.TabIndex = 15;
            // 
            // ckbsave
            // 
            this.ckbsave.AutoSize = true;
            this.ckbsave.Location = new System.Drawing.Point(288, 167);
            this.ckbsave.Margin = new System.Windows.Forms.Padding(4);
            this.ckbsave.Name = "ckbsave";
            this.ckbsave.Size = new System.Drawing.Size(18, 17);
            this.ckbsave.TabIndex = 13;
            this.ckbsave.UseVisualStyleBackColor = true;
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(288, 124);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(155, 32);
            this.txtuser.TabIndex = 12;
            this.txtuser.Text = "123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên đăng nhập :";
            // 
            // myCustomPanel1
            // 
            this.myCustomPanel1.Controls.Add(this.BtLogin);
            this.myCustomPanel1.Controls.Add(this.txtpass);
            this.myCustomPanel1.Controls.Add(this.ckbsave);
            this.myCustomPanel1.Controls.Add(this.label4);
            this.myCustomPanel1.Controls.Add(this.label3);
            this.myCustomPanel1.Controls.Add(this.label2);
            this.myCustomPanel1.Controls.Add(this.txtuser);
            this.myCustomPanel1.Controls.Add(this.pictureBox1);
            this.myCustomPanel1.Controls.Add(this.label1);
            this.myCustomPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myCustomPanel1.Location = new System.Drawing.Point(0, 0);
            this.myCustomPanel1.Name = "myCustomPanel1";
            this.myCustomPanel1.Padding = new System.Windows.Forms.Padding(12);
            this.myCustomPanel1.Size = new System.Drawing.Size(452, 263);
            this.myCustomPanel1.TabIndex = 1;
            // 
            // BtLogin
            // 
            this.BtLogin.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLogin.FontAntiAlias = true;
            this.BtLogin.ForeColor = System.Drawing.Color.DimGray;
            this.BtLogin.Location = new System.Drawing.Point(149, 207);
            this.BtLogin.Name = "BtLogin";
            this.BtLogin.RoundedCornerRadius = 6;
            this.BtLogin.Size = new System.Drawing.Size(294, 41);
            this.BtLogin.TabIndex = 20;
            this.BtLogin.Text = "Login";
            this.BtLogin.UseVisualStyleBackColor = true;
            this.BtLogin.Click += new System.EventHandler(this.btnlog_Click_1);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 263);
            this.Controls.Add(this.myCustomPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(470, 310);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.myCustomPanel1.ResumeLayout(false);
            this.myCustomPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.CheckBox ckbsave;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label1;
        private UserControls.MyCustomPanel myCustomPanel1;
        private UserControls.GlassButton BtLogin;
    }
}

