namespace GUI.Admin
{
    partial class BaoCaoThongKe_Admin_GUI
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
            this.LblTieuDe = new System.Windows.Forms.Button();
            this.PnlNoiDung = new System.Windows.Forms.Panel();
            this.GrbChucNang = new System.Windows.Forms.GroupBox();
            this.BtnBaoCao = new System.Windows.Forms.Button();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.BtnThongKe = new System.Windows.Forms.Button();
            this.PnlNoiDung.SuspendLayout();
            this.GrbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTieuDe
            // 
            this.LblTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTieuDe.FlatAppearance.BorderSize = 0;
            this.LblTieuDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.LblTieuDe.Name = "LblTieuDe";
            this.LblTieuDe.Size = new System.Drawing.Size(982, 85);
            this.LblTieuDe.TabIndex = 0;
            this.LblTieuDe.TabStop = false;
            this.LblTieuDe.Text = "BÁO CÁO THỐNG KÊ";
            this.LblTieuDe.UseVisualStyleBackColor = false;
            // 
            // PnlNoiDung
            // 
            this.PnlNoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PnlNoiDung.Controls.Add(this.GrbChucNang);
            this.PnlNoiDung.Controls.Add(this.LblTieuDe);
            this.PnlNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlNoiDung.Location = new System.Drawing.Point(0, 0);
            this.PnlNoiDung.Name = "PnlNoiDung";
            this.PnlNoiDung.Size = new System.Drawing.Size(982, 453);
            this.PnlNoiDung.TabIndex = 7;
            // 
            // GrbChucNang
            // 
            this.GrbChucNang.BackColor = System.Drawing.Color.White;
            this.GrbChucNang.Controls.Add(this.BtnBaoCao);
            this.GrbChucNang.Controls.Add(this.BtnThoat);
            this.GrbChucNang.Controls.Add(this.BtnThongKe);
            this.GrbChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrbChucNang.Location = new System.Drawing.Point(0, 85);
            this.GrbChucNang.Name = "GrbChucNang";
            this.GrbChucNang.Size = new System.Drawing.Size(982, 368);
            this.GrbChucNang.TabIndex = 6;
            this.GrbChucNang.TabStop = false;
            this.GrbChucNang.Text = "Chức năng";
            // 
            // BtnBaoCao
            // 
            this.BtnBaoCao.Location = new System.Drawing.Point(103, 118);
            this.BtnBaoCao.Name = "BtnBaoCao";
            this.BtnBaoCao.Size = new System.Drawing.Size(150, 100);
            this.BtnBaoCao.TabIndex = 12;
            this.BtnBaoCao.Text = "Báo cáo sinh viên và đề thi";
            this.BtnBaoCao.UseVisualStyleBackColor = true;
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(654, 118);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(150, 100);
            this.BtnThoat.TabIndex = 17;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // BtnThongKe
            // 
            this.BtnThongKe.Location = new System.Drawing.Point(389, 118);
            this.BtnThongKe.Name = "BtnThongKe";
            this.BtnThongKe.Size = new System.Drawing.Size(150, 100);
            this.BtnThongKe.TabIndex = 13;
            this.BtnThongKe.Text = "Thống kê sinh viên và đề thi";
            this.BtnThongKe.UseVisualStyleBackColor = true;
            this.BtnThongKe.Click += new System.EventHandler(this.BtnThongKe_Click);
            // 
            // BaoCaoThongKe_Admin_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.PnlNoiDung);
            this.Name = "BaoCaoThongKe_Admin_GUI";
            this.Text = "BaoCaoThongKe_Admin_GUI";
            this.PnlNoiDung.ResumeLayout(false);
            this.GrbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LblTieuDe;
        private System.Windows.Forms.Panel PnlNoiDung;
        private System.Windows.Forms.GroupBox GrbChucNang;
        private System.Windows.Forms.Button BtnBaoCao;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button BtnThongKe;
    }
}