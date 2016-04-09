namespace Step01DrawThousandsOfLines
{
    partial class frmMain
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
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.btnBenchmark = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbxResult = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cnvsCommon = new Step01DrawThousandsOfLines.Canvas();
            this.cnvsOptimized = new Step01DrawThousandsOfLines.Canvas();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(12, 12);
            this.numCount.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(122, 26);
            this.numCount.TabIndex = 2;
            this.numCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnBenchmark
            // 
            this.btnBenchmark.AutoSize = true;
            this.btnBenchmark.Location = new System.Drawing.Point(12, 44);
            this.btnBenchmark.Name = "btnBenchmark";
            this.btnBenchmark.Size = new System.Drawing.Size(122, 29);
            this.btnBenchmark.TabIndex = 3;
            this.btnBenchmark.Text = "Benchmark";
            this.btnBenchmark.UseVisualStyleBackColor = true;
            this.btnBenchmark.Click += new System.EventHandler(this.btnBenchmark_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.cnvsCommon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 366);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Common ";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.cnvsOptimized);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 366);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Optimized ";
            // 
            // txtbxResult
            // 
            this.txtbxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtbxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbxResult.Location = new System.Drawing.Point(140, 12);
            this.txtbxResult.Multiline = true;
            this.txtbxResult.Name = "txtbxResult";
            this.txtbxResult.ReadOnly = true;
            this.txtbxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbxResult.Size = new System.Drawing.Size(632, 61);
            this.txtbxResult.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numCount);
            this.panel1.Controls.Add(this.txtbxResult);
            this.panel1.Controls.Add(this.btnBenchmark);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 83);
            this.panel1.TabIndex = 8;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 83);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(784, 366);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.TabIndex = 9;
            // 
            // cnvsCommon
            // 
            this.cnvsCommon.BackColor = System.Drawing.Color.DimGray;
            this.cnvsCommon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cnvsCommon.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnvsCommon.Location = new System.Drawing.Point(3, 22);
            this.cnvsCommon.Margin = new System.Windows.Forms.Padding(4);
            this.cnvsCommon.Name = "cnvsCommon";
            this.cnvsCommon.Size = new System.Drawing.Size(384, 341);
            this.cnvsCommon.TabIndex = 0;
            // 
            // cnvsOptimized
            // 
            this.cnvsOptimized.BackColor = System.Drawing.Color.DimGray;
            this.cnvsOptimized.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cnvsOptimized.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnvsOptimized.Location = new System.Drawing.Point(3, 22);
            this.cnvsOptimized.Margin = new System.Windows.Forms.Padding(4);
            this.cnvsOptimized.Name = "cnvsOptimized";
            this.cnvsOptimized.Size = new System.Drawing.Size(384, 341);
            this.cnvsOptimized.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 449);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "Draw Thousands Of Lines";
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Button btnBenchmark;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbxResult;
        private System.Windows.Forms.Panel panel1;
        private Canvas cnvsCommon;
        private Canvas cnvsOptimized;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

