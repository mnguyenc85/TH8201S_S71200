namespace TH8201S
{
    partial class frmSCADA
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
            this.components = new System.ComponentModel.Container();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.hiệuChỉnhCânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer_Watchdog = new System.Windows.Forms.Timer(this.components);
            this.timer_start = new System.Windows.Forms.Timer(this.components);
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl13 = new System.Windows.Forms.Panel();
            this.pnl12 = new System.Windows.Forms.Panel();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.slblTime1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblTime2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnl131 = new TH8201S.UserControls.MyCustomPanel();
            this.plotTensile = new OxyPlot.WindowsForms.PlotView();
            this.pnlPlotControls = new System.Windows.Forms.Panel();
            this.btPlotReset = new System.Windows.Forms.Button();
            this.chkZoomAll = new System.Windows.Forms.CheckBox();
            this.pnl122 = new TH8201S.UserControls.MyCustomPanel();
            this.txt_Elong_min = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Force_min = new System.Windows.Forms.TextBox();
            this.txt_Elong_max = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Stress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Force_max = new System.Windows.Forms.TextBox();
            this.txt_Elong = new System.Windows.Forms.TextBox();
            this.tbx_strain = new System.Windows.Forms.TextBox();
            this.txt_Strain = new System.Windows.Forms.TextBox();
            this.txt_Stress_min = new System.Windows.Forms.TextBox();
            this.txt_Strain_max = new System.Windows.Forms.TextBox();
            this.txt_Force = new System.Windows.Forms.TextBox();
            this.txt_Strain_min = new System.Windows.Forms.TextBox();
            this.txt_Stress_max = new System.Windows.Forms.TextBox();
            this.pnl121 = new TH8201S.UserControls.MyCustomPanel();
            this.txtbox_chieurong = new System.Windows.Forms.TextBox();
            this.txt_mode = new System.Windows.Forms.TextBox();
            this.txtbox_chieuday = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAutoSpeed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl11 = new TH8201S.UserControls.MyCustomPanel();
            this.btt_Start = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.cbx_man_auto = new System.Windows.Forms.ComboBox();
            this.btt_Setzero = new System.Windows.Forms.Button();
            this.btt_Return = new System.Windows.Forms.Button();
            this.btt_Slowdown = new System.Windows.Forms.Button();
            this.btt_Slowup = new System.Windows.Forms.Button();
            this.btt_Fastup = new System.Windows.Forms.Button();
            this.btt_Stop = new System.Windows.Forms.Button();
            this.btt_Fastdown = new System.Windows.Forms.Button();
            this.mnuMain.SuspendLayout();
            this.pnl1.SuspendLayout();
            this.pnl13.SuspendLayout();
            this.pnl12.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.pnl131.SuspendLayout();
            this.pnlPlotControls.SuspendLayout();
            this.pnl122.SuspendLayout();
            this.pnl121.SuspendLayout();
            this.pnl11.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiệuChỉnhCânToolStripMenuItem,
            this.mniThongKe,
            this.càiĐặtToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(1582, 30);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // hiệuChỉnhCânToolStripMenuItem
            // 
            this.hiệuChỉnhCânToolStripMenuItem.Name = "hiệuChỉnhCânToolStripMenuItem";
            this.hiệuChỉnhCânToolStripMenuItem.Size = new System.Drawing.Size(57, 26);
            this.hiệuChỉnhCânToolStripMenuItem.Text = "Calib";
            this.hiệuChỉnhCânToolStripMenuItem.Click += new System.EventHandler(this.MniHieuChinhCan_Click);
            // 
            // mniThongKe
            // 
            this.mniThongKe.Name = "mniThongKe";
            this.mniThongKe.Size = new System.Drawing.Size(55, 26);
            this.mniThongKe.Text = "Data";
            this.mniThongKe.Click += new System.EventHandler(this.mniThongKe_Click);
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.càiĐặtToolStripMenuItem.Text = "Setting";
            // 
            // Timer_Watchdog
            // 
            this.Timer_Watchdog.Enabled = true;
            this.Timer_Watchdog.Interval = 3000;
            this.Timer_Watchdog.Tick += new System.EventHandler(this.Timer_Watchdog_Tick);
            // 
            // timer_start
            // 
            this.timer_start.Interval = 25;
            this.timer_start.Tick += new System.EventHandler(this.timer_start_Tick);
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.pnl13);
            this.pnl1.Controls.Add(this.pnl12);
            this.pnl1.Controls.Add(this.pnl11);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl1.Location = new System.Drawing.Point(0, 30);
            this.pnl1.Margin = new System.Windows.Forms.Padding(4);
            this.pnl1.Name = "pnl1";
            this.pnl1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pnl1.Size = new System.Drawing.Size(1582, 841);
            this.pnl1.TabIndex = 110;
            // 
            // pnl13
            // 
            this.pnl13.Controls.Add(this.pnl131);
            this.pnl13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl13.Location = new System.Drawing.Point(199, 155);
            this.pnl13.Margin = new System.Windows.Forms.Padding(4);
            this.pnl13.Name = "pnl13";
            this.pnl13.Padding = new System.Windows.Forms.Padding(8, 7, 0, 0);
            this.pnl13.Size = new System.Drawing.Size(1375, 679);
            this.pnl13.TabIndex = 111;
            // 
            // pnl12
            // 
            this.pnl12.Controls.Add(this.pnl122);
            this.pnl12.Controls.Add(this.pnl121);
            this.pnl12.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl12.Location = new System.Drawing.Point(199, 7);
            this.pnl12.Margin = new System.Windows.Forms.Padding(4);
            this.pnl12.Name = "pnl12";
            this.pnl12.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.pnl12.Size = new System.Drawing.Size(1375, 148);
            this.pnl12.TabIndex = 110;
            // 
            // statusMain
            // 
            this.statusMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblTime1,
            this.slblTime2,
            this.slblCount});
            this.statusMain.Location = new System.Drawing.Point(0, 871);
            this.statusMain.Name = "statusMain";
            this.statusMain.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusMain.Size = new System.Drawing.Size(1582, 26);
            this.statusMain.TabIndex = 111;
            this.statusMain.Text = "statusMain";
            // 
            // slblTime1
            // 
            this.slblTime1.AutoSize = false;
            this.slblTime1.Name = "slblTime1";
            this.slblTime1.Size = new System.Drawing.Size(48, 20);
            this.slblTime1.Text = "0 ms";
            this.slblTime1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // slblTime2
            // 
            this.slblTime2.AutoSize = false;
            this.slblTime2.Name = "slblTime2";
            this.slblTime2.Size = new System.Drawing.Size(48, 20);
            this.slblTime2.Text = "0 ms";
            this.slblTime2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // slblCount
            // 
            this.slblCount.AutoSize = false;
            this.slblCount.Name = "slblCount";
            this.slblCount.Size = new System.Drawing.Size(48, 20);
            this.slblCount.Text = "0";
            this.slblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl131
            // 
            this.pnl131.Controls.Add(this.plotTensile);
            this.pnl131.Controls.Add(this.pnlPlotControls);
            this.pnl131.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl131.Location = new System.Drawing.Point(8, 7);
            this.pnl131.Margin = new System.Windows.Forms.Padding(4);
            this.pnl131.Name = "pnl131";
            this.pnl131.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pnl131.Size = new System.Drawing.Size(1367, 672);
            this.pnl131.TabIndex = 0;
            // 
            // plotTensile
            // 
            this.plotTensile.BackColor = System.Drawing.Color.White;
            this.plotTensile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotTensile.Location = new System.Drawing.Point(8, 7);
            this.plotTensile.Name = "plotTensile";
            this.plotTensile.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotTensile.Size = new System.Drawing.Size(1351, 620);
            this.plotTensile.TabIndex = 0;
            this.plotTensile.Text = "plotView1";
            this.plotTensile.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotTensile.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotTensile.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // pnlPlotControls
            // 
            this.pnlPlotControls.Controls.Add(this.btPlotReset);
            this.pnlPlotControls.Controls.Add(this.chkZoomAll);
            this.pnlPlotControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPlotControls.Location = new System.Drawing.Point(8, 627);
            this.pnlPlotControls.Name = "pnlPlotControls";
            this.pnlPlotControls.Padding = new System.Windows.Forms.Padding(3);
            this.pnlPlotControls.Size = new System.Drawing.Size(1351, 38);
            this.pnlPlotControls.TabIndex = 1;
            // 
            // btPlotReset
            // 
            this.btPlotReset.Location = new System.Drawing.Point(94, 6);
            this.btPlotReset.Name = "btPlotReset";
            this.btPlotReset.Size = new System.Drawing.Size(63, 26);
            this.btPlotReset.TabIndex = 1;
            this.btPlotReset.Text = "Reset";
            this.btPlotReset.UseVisualStyleBackColor = true;
            this.btPlotReset.Click += new System.EventHandler(this.btPlotReset_Click);
            // 
            // chkZoomAll
            // 
            this.chkZoomAll.AutoSize = true;
            this.chkZoomAll.Checked = true;
            this.chkZoomAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkZoomAll.Location = new System.Drawing.Point(6, 10);
            this.chkZoomAll.Name = "chkZoomAll";
            this.chkZoomAll.Size = new System.Drawing.Size(82, 20);
            this.chkZoomAll.TabIndex = 0;
            this.chkZoomAll.Text = "Zoom All";
            this.chkZoomAll.UseVisualStyleBackColor = true;
            this.chkZoomAll.CheckedChanged += new System.EventHandler(this.chkZoomAll_CheckedChanged);
            // 
            // pnl122
            // 
            this.pnl122.Controls.Add(this.txt_Elong_min);
            this.pnl122.Controls.Add(this.label9);
            this.pnl122.Controls.Add(this.txt_Force_min);
            this.pnl122.Controls.Add(this.txt_Elong_max);
            this.pnl122.Controls.Add(this.label8);
            this.pnl122.Controls.Add(this.label7);
            this.pnl122.Controls.Add(this.txt_Stress);
            this.pnl122.Controls.Add(this.label6);
            this.pnl122.Controls.Add(this.txt_Force_max);
            this.pnl122.Controls.Add(this.txt_Elong);
            this.pnl122.Controls.Add(this.tbx_strain);
            this.pnl122.Controls.Add(this.txt_Strain);
            this.pnl122.Controls.Add(this.txt_Stress_min);
            this.pnl122.Controls.Add(this.txt_Strain_max);
            this.pnl122.Controls.Add(this.txt_Force);
            this.pnl122.Controls.Add(this.txt_Strain_min);
            this.pnl122.Controls.Add(this.txt_Stress_max);
            this.pnl122.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl122.Location = new System.Drawing.Point(8, 0);
            this.pnl122.Margin = new System.Windows.Forms.Padding(4);
            this.pnl122.Name = "pnl122";
            this.pnl122.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pnl122.Size = new System.Drawing.Size(1022, 148);
            this.pnl122.TabIndex = 111;
            // 
            // txt_Elong_min
            // 
            this.txt_Elong_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txt_Elong_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Elong_min.Location = new System.Drawing.Point(888, 110);
            this.txt_Elong_min.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Elong_min.Multiline = true;
            this.txt_Elong_min.Name = "txt_Elong_min";
            this.txt_Elong_min.Size = new System.Drawing.Size(79, 29);
            this.txt_Elong_min.TabIndex = 12;
            this.txt_Elong_min.Text = "0";
            this.txt_Elong_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(540, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 31);
            this.label9.TabIndex = 14;
            this.label9.Text = "ELONG(%)";
            // 
            // txt_Force_min
            // 
            this.txt_Force_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txt_Force_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Force_min.Location = new System.Drawing.Point(888, 41);
            this.txt_Force_min.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Force_min.Multiline = true;
            this.txt_Force_min.Name = "txt_Force_min";
            this.txt_Force_min.Size = new System.Drawing.Size(79, 29);
            this.txt_Force_min.TabIndex = 12;
            this.txt_Force_min.Text = "0";
            this.txt_Force_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Elong_max
            // 
            this.txt_Elong_max.BackColor = System.Drawing.Color.Red;
            this.txt_Elong_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Elong_max.Location = new System.Drawing.Point(888, 81);
            this.txt_Elong_max.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Elong_max.Multiline = true;
            this.txt_Elong_max.Name = "txt_Elong_max";
            this.txt_Elong_max.Size = new System.Drawing.Size(79, 29);
            this.txt_Elong_max.TabIndex = 11;
            this.txt_Elong_max.Text = "0";
            this.txt_Elong_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(540, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "FORCE(N)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(12, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "STRESS(MPa)";
            // 
            // txt_Stress
            // 
            this.txt_Stress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Stress.Location = new System.Drawing.Point(244, 81);
            this.txt_Stress.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_Stress.Multiline = true;
            this.txt_Stress.Name = "txt_Stress";
            this.txt_Stress.ReadOnly = true;
            this.txt_Stress.Size = new System.Drawing.Size(173, 58);
            this.txt_Stress.TabIndex = 7;
            this.txt_Stress.Text = "0.0";
            this.txt_Stress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(12, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "STRAIN";
            // 
            // txt_Force_max
            // 
            this.txt_Force_max.BackColor = System.Drawing.Color.Red;
            this.txt_Force_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Force_max.Location = new System.Drawing.Point(888, 11);
            this.txt_Force_max.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Force_max.Multiline = true;
            this.txt_Force_max.Name = "txt_Force_max";
            this.txt_Force_max.Size = new System.Drawing.Size(79, 29);
            this.txt_Force_max.TabIndex = 11;
            this.txt_Force_max.Text = "0";
            this.txt_Force_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Elong
            // 
            this.txt_Elong.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Elong.Location = new System.Drawing.Point(707, 81);
            this.txt_Elong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Elong.Multiline = true;
            this.txt_Elong.Name = "txt_Elong";
            this.txt_Elong.ReadOnly = true;
            this.txt_Elong.Size = new System.Drawing.Size(173, 58);
            this.txt_Elong.TabIndex = 3;
            this.txt_Elong.Text = "0.0";
            this.txt_Elong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Elong.TextChanged += new System.EventHandler(this.txtELong_TextChanged);
            // 
            // tbx_strain
            // 
            this.tbx_strain.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_strain.Location = new System.Drawing.Point(244, 11);
            this.tbx_strain.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_strain.Multiline = true;
            this.tbx_strain.Name = "tbx_strain";
            this.tbx_strain.ReadOnly = true;
            this.tbx_strain.Size = new System.Drawing.Size(173, 58);
            this.tbx_strain.TabIndex = 0;
            this.tbx_strain.Text = "0.0";
            this.tbx_strain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Strain
            // 
            this.txt_Strain.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Strain.Location = new System.Drawing.Point(244, 11);
            this.txt_Strain.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Strain.Multiline = true;
            this.txt_Strain.Name = "txt_Strain";
            this.txt_Strain.ReadOnly = true;
            this.txt_Strain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Strain.Size = new System.Drawing.Size(173, 58);
            this.txt_Strain.TabIndex = 2;
            this.txt_Strain.Text = "0.0";
            this.txt_Strain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Stress_min
            // 
            this.txt_Stress_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txt_Stress_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Stress_min.Location = new System.Drawing.Point(427, 111);
            this.txt_Stress_min.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Stress_min.Multiline = true;
            this.txt_Stress_min.Name = "txt_Stress_min";
            this.txt_Stress_min.Size = new System.Drawing.Size(79, 29);
            this.txt_Stress_min.TabIndex = 12;
            this.txt_Stress_min.Text = "0";
            this.txt_Stress_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Strain_max
            // 
            this.txt_Strain_max.BackColor = System.Drawing.Color.Red;
            this.txt_Strain_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Strain_max.Location = new System.Drawing.Point(427, 11);
            this.txt_Strain_max.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Strain_max.Multiline = true;
            this.txt_Strain_max.Name = "txt_Strain_max";
            this.txt_Strain_max.Size = new System.Drawing.Size(79, 29);
            this.txt_Strain_max.TabIndex = 9;
            this.txt_Strain_max.Text = "0";
            this.txt_Strain_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Force
            // 
            this.txt_Force.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Force.Location = new System.Drawing.Point(708, 11);
            this.txt_Force.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txt_Force.Multiline = true;
            this.txt_Force.Name = "txt_Force";
            this.txt_Force.ReadOnly = true;
            this.txt_Force.Size = new System.Drawing.Size(173, 58);
            this.txt_Force.TabIndex = 5;
            this.txt_Force.Text = "0.0";
            this.txt_Force.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Strain_min
            // 
            this.txt_Strain_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txt_Strain_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Strain_min.Location = new System.Drawing.Point(427, 41);
            this.txt_Strain_min.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Strain_min.Multiline = true;
            this.txt_Strain_min.Name = "txt_Strain_min";
            this.txt_Strain_min.Size = new System.Drawing.Size(79, 29);
            this.txt_Strain_min.TabIndex = 10;
            this.txt_Strain_min.Text = "0";
            this.txt_Strain_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Stress_max
            // 
            this.txt_Stress_max.BackColor = System.Drawing.Color.Red;
            this.txt_Stress_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Stress_max.Location = new System.Drawing.Point(427, 81);
            this.txt_Stress_max.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Stress_max.Multiline = true;
            this.txt_Stress_max.Name = "txt_Stress_max";
            this.txt_Stress_max.Size = new System.Drawing.Size(79, 29);
            this.txt_Stress_max.TabIndex = 11;
            this.txt_Stress_max.Text = "0";
            this.txt_Stress_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl121
            // 
            this.pnl121.Controls.Add(this.txtbox_chieurong);
            this.pnl121.Controls.Add(this.txt_mode);
            this.pnl121.Controls.Add(this.txtbox_chieuday);
            this.pnl121.Controls.Add(this.label23);
            this.pnl121.Controls.Add(this.label3);
            this.pnl121.Controls.Add(this.label4);
            this.pnl121.Controls.Add(this.txtBill);
            this.pnl121.Controls.Add(this.label2);
            this.pnl121.Controls.Add(this.cboAutoSpeed);
            this.pnl121.Controls.Add(this.label1);
            this.pnl121.Controls.Add(this.label5);
            this.pnl121.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl121.Location = new System.Drawing.Point(1030, 0);
            this.pnl121.Margin = new System.Windows.Forms.Padding(4);
            this.pnl121.Name = "pnl121";
            this.pnl121.Padding = new System.Windows.Forms.Padding(4);
            this.pnl121.Size = new System.Drawing.Size(345, 148);
            this.pnl121.TabIndex = 0;
            // 
            // txtbox_chieurong
            // 
            this.txtbox_chieurong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_chieurong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_chieurong.Location = new System.Drawing.Point(139, 114);
            this.txtbox_chieurong.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_chieurong.Multiline = true;
            this.txtbox_chieurong.Name = "txtbox_chieurong";
            this.txtbox_chieurong.Size = new System.Drawing.Size(83, 25);
            this.txtbox_chieurong.TabIndex = 120;
            this.txtbox_chieurong.Text = "0.0";
            this.txtbox_chieurong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_chieurong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_chieurong_KeyDown);
            // 
            // txt_mode
            // 
            this.txt_mode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_mode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mode.Location = new System.Drawing.Point(95, 11);
            this.txt_mode.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mode.Multiline = true;
            this.txt_mode.Name = "txt_mode";
            this.txt_mode.ReadOnly = true;
            this.txt_mode.Size = new System.Drawing.Size(60, 30);
            this.txt_mode.TabIndex = 97;
            this.txt_mode.Text = "0.0";
            this.txt_mode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbox_chieuday
            // 
            this.txtbox_chieuday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_chieuday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_chieuday.Location = new System.Drawing.Point(139, 80);
            this.txtbox_chieuday.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_chieuday.Multiline = true;
            this.txtbox_chieuday.Name = "txtbox_chieuday";
            this.txtbox_chieuday.Size = new System.Drawing.Size(83, 25);
            this.txtbox_chieuday.TabIndex = 119;
            this.txtbox_chieuday.Text = "0.0";
            this.txtbox_chieuday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbox_chieuday.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_chieuday_KeyDown);
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(8, 14);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(104, 28);
            this.label23.TabIndex = 94;
            this.label23.Text = "Chế độ :";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 28);
            this.label3.TabIndex = 116;
            this.label3.Text = "Bill number:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 28);
            this.label4.TabIndex = 117;
            this.label4.Text = "Chiều dầy :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBill
            // 
            this.txtBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill.Location = new System.Drawing.Point(212, 7);
            this.txtBill.Margin = new System.Windows.Forms.Padding(4);
            this.txtBill.Multiline = true;
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(121, 32);
            this.txtBill.TabIndex = 115;
            this.txtBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 114;
            this.label2.Text = "mm/p";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboAutoSpeed
            // 
            this.cboAutoSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAutoSpeed.FormattingEnabled = true;
            this.cboAutoSpeed.Items.AddRange(new object[] {
            "100",
            "150",
            "200",
            "250",
            "300",
            "350",
            "450",
            "500"});
            this.cboAutoSpeed.Location = new System.Drawing.Point(95, 46);
            this.cboAutoSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.cboAutoSpeed.Name = "cboAutoSpeed";
            this.cboAutoSpeed.Size = new System.Drawing.Size(81, 28);
            this.cboAutoSpeed.TabIndex = 113;
            this.cboAutoSpeed.SelectedValueChanged += new System.EventHandler(this.cboSpeed_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 112;
            this.label1.Text = "Tốc độ :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 28);
            this.label5.TabIndex = 118;
            this.label5.Text = "Chiều rộng :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl11
            // 
            this.pnl11.Controls.Add(this.btt_Start);
            this.pnl11.Controls.Add(this.BtnRefresh);
            this.pnl11.Controls.Add(this.cbx_man_auto);
            this.pnl11.Controls.Add(this.btt_Setzero);
            this.pnl11.Controls.Add(this.btt_Return);
            this.pnl11.Controls.Add(this.btt_Slowdown);
            this.pnl11.Controls.Add(this.btt_Slowup);
            this.pnl11.Controls.Add(this.btt_Fastup);
            this.pnl11.Controls.Add(this.btt_Stop);
            this.pnl11.Controls.Add(this.btt_Fastdown);
            this.pnl11.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl11.Location = new System.Drawing.Point(8, 7);
            this.pnl11.Margin = new System.Windows.Forms.Padding(4);
            this.pnl11.Name = "pnl11";
            this.pnl11.Padding = new System.Windows.Forms.Padding(4);
            this.pnl11.Size = new System.Drawing.Size(191, 827);
            this.pnl11.TabIndex = 109;
            // 
            // btt_Start
            // 
            this.btt_Start.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btt_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Start.Location = new System.Drawing.Point(8, 7);
            this.btt_Start.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Start.Name = "btt_Start";
            this.btt_Start.Size = new System.Drawing.Size(175, 59);
            this.btt_Start.TabIndex = 1;
            this.btt_Start.Text = "START";
            this.btt_Start.UseVisualStyleBackColor = false;
            this.btt_Start.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btStart_MouseDown);
            this.btt_Start.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btt_Start_MouseUp);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.Location = new System.Drawing.Point(9, 140);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(175, 59);
            this.BtnRefresh.TabIndex = 108;
            this.BtnRefresh.Text = "REFESH";
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            this.BtnRefresh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnRefresh_MouseUp);
            // 
            // cbx_man_auto
            // 
            this.cbx_man_auto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_man_auto.FormattingEnabled = true;
            this.cbx_man_auto.Items.AddRange(new object[] {
            "AUTO",
            "MANUAL"});
            this.cbx_man_auto.Location = new System.Drawing.Point(9, 642);
            this.cbx_man_auto.Margin = new System.Windows.Forms.Padding(4, 11, 4, 4);
            this.cbx_man_auto.Name = "cbx_man_auto";
            this.cbx_man_auto.Size = new System.Drawing.Size(173, 37);
            this.cbx_man_auto.TabIndex = 1;
            this.cbx_man_auto.SelectedValueChanged += new System.EventHandler(this.cbx_man_auto_SelectedValueChanged);
            // 
            // btt_Setzero
            // 
            this.btt_Setzero.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btt_Setzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Setzero.Location = new System.Drawing.Point(8, 569);
            this.btt_Setzero.Margin = new System.Windows.Forms.Padding(4, 11, 4, 4);
            this.btt_Setzero.Name = "btt_Setzero";
            this.btt_Setzero.Size = new System.Drawing.Size(175, 59);
            this.btt_Setzero.TabIndex = 19;
            this.btt_Setzero.Text = "SET ZERO";
            this.btt_Setzero.UseVisualStyleBackColor = false;
            this.btt_Setzero.Click += new System.EventHandler(this.btt_Setzero_Click);
            this.btt_Setzero.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btt_Setzero_MouseDown);
            this.btt_Setzero.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btt_Setzero_MouseUp);
            // 
            // btt_Return
            // 
            this.btt_Return.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btt_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Return.Location = new System.Drawing.Point(9, 214);
            this.btt_Return.Margin = new System.Windows.Forms.Padding(4, 11, 4, 4);
            this.btt_Return.Name = "btt_Return";
            this.btt_Return.Size = new System.Drawing.Size(175, 59);
            this.btt_Return.TabIndex = 18;
            this.btt_Return.Text = "RETURN";
            this.btt_Return.UseVisualStyleBackColor = false;
            this.btt_Return.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btt_Return_MouseDown);
            this.btt_Return.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btt_Return_MouseUp);
            // 
            // btt_Slowdown
            // 
            this.btt_Slowdown.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btt_Slowdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Slowdown.Location = new System.Drawing.Point(9, 495);
            this.btt_Slowdown.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Slowdown.Name = "btt_Slowdown";
            this.btt_Slowdown.Size = new System.Drawing.Size(175, 59);
            this.btt_Slowdown.TabIndex = 17;
            this.btt_Slowdown.Text = "SLOW DOWN";
            this.btt_Slowdown.UseVisualStyleBackColor = false;
            this.btt_Slowdown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btt_Slowdown_MouseDown);
            this.btt_Slowdown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btt_Slowdown_MouseUp);
            // 
            // btt_Slowup
            // 
            this.btt_Slowup.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btt_Slowup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Slowup.Location = new System.Drawing.Point(9, 354);
            this.btt_Slowup.Name = "btt_Slowup";
            this.btt_Slowup.Size = new System.Drawing.Size(175, 59);
            this.btt_Slowup.TabIndex = 16;
            this.btt_Slowup.Text = "SLOW UP";
            this.btt_Slowup.UseVisualStyleBackColor = false;
            this.btt_Slowup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btt_Slowup_MouseDown);
            this.btt_Slowup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btt_Slowup_MouseUp);
            // 
            // btt_Fastup
            // 
            this.btt_Fastup.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btt_Fastup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Fastup.Location = new System.Drawing.Point(8, 288);
            this.btt_Fastup.Margin = new System.Windows.Forms.Padding(4, 11, 4, 4);
            this.btt_Fastup.Name = "btt_Fastup";
            this.btt_Fastup.Size = new System.Drawing.Size(175, 59);
            this.btt_Fastup.TabIndex = 15;
            this.btt_Fastup.Text = "FAST UP";
            this.btt_Fastup.UseVisualStyleBackColor = false;
            this.btt_Fastup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btt_Fastup_MouseDown);
            this.btt_Fastup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btt_Fastup_MouseUp);
            // 
            // btt_Stop
            // 
            this.btt_Stop.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btt_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Stop.Location = new System.Drawing.Point(9, 74);
            this.btt_Stop.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Stop.Name = "btt_Stop";
            this.btt_Stop.Size = new System.Drawing.Size(175, 59);
            this.btt_Stop.TabIndex = 13;
            this.btt_Stop.Text = "STOP";
            this.btt_Stop.UseVisualStyleBackColor = false;
            this.btt_Stop.Click += new System.EventHandler(this.btStop_Click);
            this.btt_Stop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btt_Stop_MouseDown);
            this.btt_Stop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btt_Stop_MouseUp);
            // 
            // btt_Fastdown
            // 
            this.btt_Fastdown.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btt_Fastdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Fastdown.Location = new System.Drawing.Point(9, 428);
            this.btt_Fastdown.Margin = new System.Windows.Forms.Padding(4);
            this.btt_Fastdown.Name = "btt_Fastdown";
            this.btt_Fastdown.Size = new System.Drawing.Size(175, 59);
            this.btt_Fastdown.TabIndex = 14;
            this.btt_Fastdown.Text = "FAST DOWN";
            this.btt_Fastdown.UseVisualStyleBackColor = false;
            this.btt_Fastdown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btFastdown_MouseDown);
            this.btt_Fastdown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btFastdown_MouseUp);
            // 
            // frmSCADA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 897);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.statusMain);
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1600, 800);
            this.Name = "frmSCADA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCADA";
            this.Load += new System.EventHandler(this.SCADA_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnl1.ResumeLayout(false);
            this.pnl13.ResumeLayout(false);
            this.pnl12.ResumeLayout(false);
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.pnl131.ResumeLayout(false);
            this.pnlPlotControls.ResumeLayout(false);
            this.pnlPlotControls.PerformLayout();
            this.pnl122.ResumeLayout(false);
            this.pnl122.PerformLayout();
            this.pnl121.ResumeLayout(false);
            this.pnl121.PerformLayout();
            this.pnl11.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem hiệuChỉnhCânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniThongKe;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_Strain;
        private System.Windows.Forms.TextBox txt_Stress;
        private System.Windows.Forms.TextBox txt_Force;
        private System.Windows.Forms.TextBox txt_Elong;
        private System.Windows.Forms.TextBox txt_Elong_min;
        private System.Windows.Forms.TextBox txt_Force_min;
        private System.Windows.Forms.TextBox txt_Elong_max;
        private System.Windows.Forms.TextBox txt_Stress_min;
        private System.Windows.Forms.TextBox txt_Force_max;
        private System.Windows.Forms.TextBox txt_Strain_min;
        private System.Windows.Forms.TextBox txt_Stress_max;
        private System.Windows.Forms.TextBox txt_Strain_max;
        private System.Windows.Forms.TextBox txt_mode;
        private System.Windows.Forms.TextBox tbx_strain;
        private System.Windows.Forms.Timer Timer_Watchdog;
        private System.Windows.Forms.Button btt_Fastdown;
        private System.Windows.Forms.Timer timer_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAutoSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_chieurong;
        private System.Windows.Forms.TextBox txtbox_chieuday;
        private System.Windows.Forms.Button btt_Start;
        private System.Windows.Forms.Button btt_Stop;
        private System.Windows.Forms.Button btt_Fastup;
        private System.Windows.Forms.Button btt_Slowup;
        private System.Windows.Forms.Button btt_Slowdown;
        private System.Windows.Forms.Button btt_Return;
        private System.Windows.Forms.Button btt_Setzero;
        private System.Windows.Forms.ComboBox cbx_man_auto;
        private System.Windows.Forms.Button BtnRefresh;
        private UserControls.MyCustomPanel pnl11;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl12;
        private UserControls.MyCustomPanel pnl121;
        private UserControls.MyCustomPanel pnl122;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnl13;
        private UserControls.MyCustomPanel pnl131;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel slblTime1;
        private System.Windows.Forms.ToolStripStatusLabel slblTime2;
        private System.Windows.Forms.ToolStripStatusLabel slblCount;
        private OxyPlot.WindowsForms.PlotView plotTensile;
        private System.Windows.Forms.Panel pnlPlotControls;
        private System.Windows.Forms.CheckBox chkZoomAll;
        private System.Windows.Forms.Button btPlotReset;
    }
}