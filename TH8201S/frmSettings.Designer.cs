namespace TH8201S
{
    partial class frmSettings
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
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabpgCSDL = new System.Windows.Forms.TabPage();
            this.BtTestConnection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboConnSources = new System.Windows.Forms.ComboBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.BtAccept = new System.Windows.Forms.Button();
            this.tab1.SuspendLayout();
            this.tabpgCSDL.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tab1.Controls.Add(this.tabpgCSDL);
            this.tab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab1.Location = new System.Drawing.Point(0, 0);
            this.tab1.Multiline = true;
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(624, 405);
            this.tab1.TabIndex = 0;
            // 
            // tabpgCSDL
            // 
            this.tabpgCSDL.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabpgCSDL.Controls.Add(this.BtTestConnection);
            this.tabpgCSDL.Controls.Add(this.label1);
            this.tabpgCSDL.Controls.Add(this.cboConnSources);
            this.tabpgCSDL.Location = new System.Drawing.Point(23, 4);
            this.tabpgCSDL.Name = "tabpgCSDL";
            this.tabpgCSDL.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgCSDL.Size = new System.Drawing.Size(597, 397);
            this.tabpgCSDL.TabIndex = 0;
            this.tabpgCSDL.Text = "CSDL";
            // 
            // BtTestConnection
            // 
            this.BtTestConnection.Location = new System.Drawing.Point(320, 6);
            this.BtTestConnection.Name = "BtTestConnection";
            this.BtTestConnection.Size = new System.Drawing.Size(96, 26);
            this.BtTestConnection.TabIndex = 2;
            this.BtTestConnection.Text = "Thử kết nối";
            this.BtTestConnection.UseVisualStyleBackColor = true;
            this.BtTestConnection.Click += new System.EventHandler(this.BtTestConnection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nguồn dữ liệu";
            // 
            // cboConnSources
            // 
            this.cboConnSources.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConnSources.FormattingEnabled = true;
            this.cboConnSources.Location = new System.Drawing.Point(101, 8);
            this.cboConnSources.Name = "cboConnSources";
            this.cboConnSources.Size = new System.Drawing.Size(213, 24);
            this.cboConnSources.TabIndex = 0;
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.BtAccept);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl1.Location = new System.Drawing.Point(0, 405);
            this.pnl1.Name = "pnl1";
            this.pnl1.Padding = new System.Windows.Forms.Padding(3);
            this.pnl1.Size = new System.Drawing.Size(624, 36);
            this.pnl1.TabIndex = 1;
            // 
            // BtAccept
            // 
            this.BtAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAccept.Location = new System.Drawing.Point(522, 6);
            this.BtAccept.Name = "BtAccept";
            this.BtAccept.Size = new System.Drawing.Size(96, 25);
            this.BtAccept.TabIndex = 0;
            this.BtAccept.Text = "Chấp nhận";
            this.BtAccept.UseVisualStyleBackColor = true;
            this.BtAccept.Click += new System.EventHandler(this.BtAccept_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tab1);
            this.Controls.Add(this.pnl1);
            this.Name = "frmSettings";
            this.Text = "Cài đặt";
            this.tab1.ResumeLayout(false);
            this.tabpgCSDL.ResumeLayout(false);
            this.tabpgCSDL.PerformLayout();
            this.pnl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabpgCSDL;
        private System.Windows.Forms.Button BtTestConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboConnSources;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Button BtAccept;
    }
}