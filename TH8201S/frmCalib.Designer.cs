namespace TH8201S
{
    partial class frmCalib
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
            this.txt_Set_Mass = new System.Windows.Forms.TextBox();
            this.txt_Span = new System.Windows.Forms.TextBox();
            this.txt_ZERO = new System.Windows.Forms.TextBox();
            this.txt_RealWeight = new System.Windows.Forms.TextBox();
            this.txt_Chanel_AI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl1 = new TH8201S.UserControls.MyCustomPanel();
            this.myCustomPanel1 = new TH8201S.UserControls.MyCustomPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.btSetSpan = new Glass.GlassButton();
            this.btSetZero = new Glass.GlassButton();
            this.pnl1.SuspendLayout();
            this.myCustomPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Set_Mass
            // 
            this.txt_Set_Mass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Set_Mass.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Set_Mass.Location = new System.Drawing.Point(279, 340);
            this.txt_Set_Mass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Set_Mass.Name = "txt_Set_Mass";
            this.txt_Set_Mass.Size = new System.Drawing.Size(185, 53);
            this.txt_Set_Mass.TabIndex = 40;
            this.txt_Set_Mass.Text = "0.0";
            this.txt_Set_Mass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Set_Mass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Set_Mass_KeyDown);
            // 
            // txt_Span
            // 
            this.txt_Span.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Span.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Span.Location = new System.Drawing.Point(279, 279);
            this.txt_Span.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Span.Name = "txt_Span";
            this.txt_Span.Size = new System.Drawing.Size(185, 53);
            this.txt_Span.TabIndex = 39;
            this.txt_Span.Text = "0.0";
            this.txt_Span.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Span.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Span_KeyDown);
            // 
            // txt_ZERO
            // 
            this.txt_ZERO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ZERO.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ZERO.Location = new System.Drawing.Point(279, 218);
            this.txt_ZERO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ZERO.Name = "txt_ZERO";
            this.txt_ZERO.Size = new System.Drawing.Size(185, 53);
            this.txt_ZERO.TabIndex = 38;
            this.txt_ZERO.Text = "0";
            this.txt_ZERO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ZERO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ZERO_KeyDown);
            // 
            // txt_RealWeight
            // 
            this.txt_RealWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_RealWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_RealWeight.Location = new System.Drawing.Point(279, 156);
            this.txt_RealWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_RealWeight.Multiline = true;
            this.txt_RealWeight.Name = "txt_RealWeight";
            this.txt_RealWeight.ReadOnly = true;
            this.txt_RealWeight.Size = new System.Drawing.Size(185, 54);
            this.txt_RealWeight.TabIndex = 37;
            this.txt_RealWeight.Text = "0.0";
            this.txt_RealWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_RealWeight.WordWrap = false;
            // 
            // txt_Chanel_AI
            // 
            this.txt_Chanel_AI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Chanel_AI.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Chanel_AI.Location = new System.Drawing.Point(279, 94);
            this.txt_Chanel_AI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Chanel_AI.Multiline = true;
            this.txt_Chanel_AI.Name = "txt_Chanel_AI";
            this.txt_Chanel_AI.ReadOnly = true;
            this.txt_Chanel_AI.Size = new System.Drawing.Size(185, 54);
            this.txt_Chanel_AI.TabIndex = 36;
            this.txt_Chanel_AI.Text = "0";
            this.txt_Chanel_AI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Chanel_AI.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 31);
            this.label5.TabIndex = 35;
            this.label5.Text = "SET MASS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 31);
            this.label4.TabIndex = 34;
            this.label4.Text = "SPAN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 31);
            this.label3.TabIndex = 33;
            this.label3.Text = "ZERO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "MASS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 31);
            this.label2.TabIndex = 31;
            this.label2.Text = "CHANEL AI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.btSetZero);
            this.pnl1.Controls.Add(this.btSetSpan);
            this.pnl1.Controls.Add(this.myCustomPanel1);
            this.pnl1.Controls.Add(this.txt_Chanel_AI);
            this.pnl1.Controls.Add(this.label2);
            this.pnl1.Controls.Add(this.label5);
            this.pnl1.Controls.Add(this.txt_Set_Mass);
            this.pnl1.Controls.Add(this.txt_RealWeight);
            this.pnl1.Controls.Add(this.txt_Span);
            this.pnl1.Controls.Add(this.label4);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Controls.Add(this.txt_ZERO);
            this.pnl1.Controls.Add(this.label3);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Padding = new System.Windows.Forms.Padding(12);
            this.pnl1.Size = new System.Drawing.Size(527, 508);
            this.pnl1.TabIndex = 1;
            // 
            // myCustomPanel1
            // 
            this.myCustomPanel1.Controls.Add(this.label7);
            this.myCustomPanel1.Location = new System.Drawing.Point(65, 15);
            this.myCustomPanel1.Name = "myCustomPanel1";
            this.myCustomPanel1.Padding = new System.Windows.Forms.Padding(12);
            this.myCustomPanel1.Size = new System.Drawing.Size(399, 72);
            this.myCustomPanel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(12, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 48);
            this.label7.TabIndex = 0;
            this.label7.Text = "CALIB SCALE";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSetSpan
            // 
            this.btSetSpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSetSpan.Location = new System.Drawing.Point(279, 423);
            this.btSetSpan.Name = "btSetSpan";
            this.btSetSpan.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btSetSpan.Size = new System.Drawing.Size(185, 56);
            this.btSetSpan.TabIndex = 41;
            this.btSetSpan.Text = "SET SPAN";
            this.btSetSpan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btt_SET_SPAN_MouseDown);
            this.btSetSpan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btt_SET_SPAN_MouseUp);
            // 
            // btSetZero
            // 
            this.btSetZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSetZero.Location = new System.Drawing.Point(65, 423);
            this.btSetZero.Name = "btSetZero";
            this.btSetZero.OuterBorderColor = System.Drawing.Color.Transparent;
            this.btSetZero.Size = new System.Drawing.Size(185, 56);
            this.btSetZero.TabIndex = 42;
            this.btSetZero.Text = "SET ZERO";
            this.btSetZero.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btt_SET_ZERO_MouseDown);
            this.btSetZero.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btt_SET_ZERO_MouseUp);
            // 
            // frmCalib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 508);
            this.Controls.Add(this.pnl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(545, 555);
            this.MinimumSize = new System.Drawing.Size(545, 555);
            this.Name = "frmCalib";
            this.Text = "Calib";
            this.Load += new System.EventHandler(this.Calib_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.myCustomPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Set_Mass;
        private System.Windows.Forms.TextBox txt_Span;
        private System.Windows.Forms.TextBox txt_ZERO;
        private System.Windows.Forms.TextBox txt_RealWeight;
        private System.Windows.Forms.TextBox txt_Chanel_AI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private UserControls.MyCustomPanel pnl1;
        private UserControls.MyCustomPanel myCustomPanel1;
        private System.Windows.Forms.Label label7;
        private Glass.GlassButton btSetZero;
        private Glass.GlassButton btSetSpan;
    }
}