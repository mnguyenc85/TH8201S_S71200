﻿namespace TH8201S
{
    partial class FrmData
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmData));
            this.sFDialog = new System.Windows.Forms.SaveFileDialog();
            this.pnl13 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnl12 = new TH8201S.UserControls.MyCustomPanel();
            this.chart_tensile = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl11 = new TH8201S.UserControls.MyCustomPanel();
            this.numBillId = new System.Windows.Forms.NumericUpDown();
            this.lblMaxBill = new System.Windows.Forms.Label();
            this.btt_Delete = new System.Windows.Forms.Button();
            this.txt_Strain_max = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Force_max = new System.Windows.Forms.TextBox();
            this.pnl2 = new TH8201S.UserControls.MyCustomPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnl12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_tensile)).BeginInit();
            this.pnl11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBillId)).BeginInit();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl13
            // 
            this.pnl13.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl13.Location = new System.Drawing.Point(207, 6);
            this.pnl13.Name = "pnl13";
            this.pnl13.Size = new System.Drawing.Size(6, 539);
            this.pnl13.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnl12);
            this.splitContainer1.Panel1.Controls.Add(this.pnl13);
            this.splitContainer1.Panel1.Controls.Add(this.pnl11);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnl2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.splitContainer1.Size = new System.Drawing.Size(1262, 721);
            this.splitContainer1.SplitterDistance = 551;
            this.splitContainer1.TabIndex = 127;
            // 
            // pnl12
            // 
            this.pnl12.Controls.Add(this.chart_tensile);
            this.pnl12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl12.Location = new System.Drawing.Point(213, 6);
            this.pnl12.Name = "pnl12";
            this.pnl12.Padding = new System.Windows.Forms.Padding(6);
            this.pnl12.Size = new System.Drawing.Size(1043, 539);
            this.pnl12.TabIndex = 126;
            // 
            // chart_tensile
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_tensile.ChartAreas.Add(chartArea1);
            this.chart_tensile.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_tensile.Legends.Add(legend1);
            this.chart_tensile.Location = new System.Drawing.Point(6, 6);
            this.chart_tensile.Margin = new System.Windows.Forms.Padding(4);
            this.chart_tensile.Name = "chart_tensile";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Tensile";
            this.chart_tensile.Series.Add(series1);
            this.chart_tensile.Size = new System.Drawing.Size(1031, 527);
            this.chart_tensile.TabIndex = 1;
            this.chart_tensile.Text = "chart1";
            // 
            // pnl11
            // 
            this.pnl11.Controls.Add(this.numBillId);
            this.pnl11.Controls.Add(this.lblMaxBill);
            this.pnl11.Controls.Add(this.btt_Delete);
            this.pnl11.Controls.Add(this.txt_Strain_max);
            this.pnl11.Controls.Add(this.btn_save);
            this.pnl11.Controls.Add(this.label3);
            this.pnl11.Controls.Add(this.label1);
            this.pnl11.Controls.Add(this.BtSearch);
            this.pnl11.Controls.Add(this.label2);
            this.pnl11.Controls.Add(this.txt_Force_max);
            this.pnl11.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl11.Location = new System.Drawing.Point(6, 6);
            this.pnl11.Name = "pnl11";
            this.pnl11.Padding = new System.Windows.Forms.Padding(3);
            this.pnl11.Size = new System.Drawing.Size(201, 539);
            this.pnl11.TabIndex = 125;
            // 
            // numBillId
            // 
            this.numBillId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBillId.Location = new System.Drawing.Point(6, 40);
            this.numBillId.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numBillId.Name = "numBillId";
            this.numBillId.Size = new System.Drawing.Size(110, 30);
            this.numBillId.TabIndex = 124;
            this.numBillId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMaxBill
            // 
            this.lblMaxBill.AutoSize = true;
            this.lblMaxBill.BackColor = System.Drawing.Color.Transparent;
            this.lblMaxBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxBill.Location = new System.Drawing.Point(122, 42);
            this.lblMaxBill.Name = "lblMaxBill";
            this.lblMaxBill.Size = new System.Drawing.Size(73, 25);
            this.lblMaxBill.TabIndex = 123;
            this.lblMaxBill.Text = "/99999";
            // 
            // btt_Delete
            // 
            this.btt_Delete.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btt_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Delete.Location = new System.Drawing.Point(6, 403);
            this.btt_Delete.Name = "btt_Delete";
            this.btt_Delete.Size = new System.Drawing.Size(189, 59);
            this.btt_Delete.TabIndex = 110;
            this.btt_Delete.Text = "DELETE";
            this.btt_Delete.UseVisualStyleBackColor = false;
            this.btt_Delete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // txt_Strain_max
            // 
            this.txt_Strain_max.BackColor = System.Drawing.Color.Red;
            this.txt_Strain_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Strain_max.Location = new System.Drawing.Point(6, 285);
            this.txt_Strain_max.Multiline = true;
            this.txt_Strain_max.Name = "txt_Strain_max";
            this.txt_Strain_max.Size = new System.Drawing.Size(186, 41);
            this.txt_Strain_max.TabIndex = 122;
            this.txt_Strain_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(6, 338);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(189, 59);
            this.btn_save.TabIndex = 111;
            this.btn_save.Text = "EXPORT EXCEL";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 25);
            this.label3.TabIndex = 118;
            this.label3.Text = "Bill";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 28);
            this.label1.TabIndex = 120;
            this.label1.Text = "Max. Strain";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtSearch
            // 
            this.BtSearch.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSearch.Location = new System.Drawing.Point(6, 84);
            this.BtSearch.Name = "BtSearch";
            this.BtSearch.Size = new System.Drawing.Size(189, 59);
            this.BtSearch.TabIndex = 109;
            this.BtSearch.Text = "SEARCH";
            this.BtSearch.UseVisualStyleBackColor = false;
            this.BtSearch.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 28);
            this.label2.TabIndex = 121;
            this.label2.Text = "Max. Force";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Force_max
            // 
            this.txt_Force_max.BackColor = System.Drawing.Color.Red;
            this.txt_Force_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Force_max.Location = new System.Drawing.Point(6, 204);
            this.txt_Force_max.Multiline = true;
            this.txt_Force_max.Name = "txt_Force_max";
            this.txt_Force_max.Size = new System.Drawing.Size(186, 41);
            this.txt_Force_max.TabIndex = 119;
            this.txt_Force_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.dataGridView1);
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl2.Location = new System.Drawing.Point(6, 0);
            this.pnl2.Margin = new System.Windows.Forms.Padding(6);
            this.pnl2.Name = "pnl2";
            this.pnl2.Padding = new System.Windows.Forms.Padding(6);
            this.pnl2.Size = new System.Drawing.Size(1250, 160);
            this.pnl2.TabIndex = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(64, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1238, 148);
            this.dataGridView1.TabIndex = 119;
            // 
            // FrmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 721);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review data";
            this.Load += new System.EventHandler(this.FrmData_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnl12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_tensile)).EndInit();
            this.pnl11.ResumeLayout(false);
            this.pnl11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBillId)).EndInit();
            this.pnl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SaveFileDialog sFDialog;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_tensile;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btt_Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtSearch;
        private System.Windows.Forms.TextBox txt_Force_max;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Strain_max;
        private System.Windows.Forms.Panel pnl13;
        private UserControls.MyCustomPanel pnl11;
        private UserControls.MyCustomPanel pnl12;
        private UserControls.MyCustomPanel pnl2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblMaxBill;
        private System.Windows.Forms.NumericUpDown numBillId;
    }
}