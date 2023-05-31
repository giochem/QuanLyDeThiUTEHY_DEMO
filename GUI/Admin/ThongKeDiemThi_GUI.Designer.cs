namespace GUI.Admin
{
    partial class ThongKeDiemThi_GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CbbMonHoc = new System.Windows.Forms.ComboBox();
            this.BtnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            chartArea2.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart.Legends.Add(legend2);
            this.Chart.Location = new System.Drawing.Point(-2, 2);
            this.Chart.Name = "Chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "Số lượng sinh viên";
            series2.Name = "Chart";
            this.Chart.Series.Add(series2);
            this.Chart.Size = new System.Drawing.Size(899, 521);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "chart1";
            title2.Name = "Biểu đồ điểm sinh viên theo môn học";
            this.Chart.Titles.Add(title2);
            // 
            // CbbMonHoc
            // 
            this.CbbMonHoc.FormattingEnabled = true;
            this.CbbMonHoc.Location = new System.Drawing.Point(906, 62);
            this.CbbMonHoc.Name = "CbbMonHoc";
            this.CbbMonHoc.Size = new System.Drawing.Size(151, 24);
            this.CbbMonHoc.TabIndex = 1;
            this.CbbMonHoc.SelectedIndexChanged += new System.EventHandler(this.CbbMonHoc_SelectedIndexChanged);
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(906, 440);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(151, 71);
            this.BtnThoat.TabIndex = 3;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // ThongKeDiemThi_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 523);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.CbbMonHoc);
            this.Controls.Add(this.Chart);
            this.Name = "ThongKeDiemThi_GUI";
            this.Text = "ThongKeDiemThi_GUI";
            this.Load += new System.EventHandler(this.ThongKeDiemThi_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.ComboBox CbbMonHoc;
        private System.Windows.Forms.Button BtnThoat;
    }
}