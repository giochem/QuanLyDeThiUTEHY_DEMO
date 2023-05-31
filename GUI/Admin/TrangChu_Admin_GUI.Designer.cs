namespace GUI.Admin
{
    partial class TrangChu_Admin_GUI
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
            this.PnlNoiDung = new System.Windows.Forms.Panel();
            this.GrbChucNang = new System.Windows.Forms.GroupBox();
            this.BtnLop = new System.Windows.Forms.Button();
            this.BtnNguoiDung = new System.Windows.Forms.Button();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.BtnBaoCaoThongKe = new System.Windows.Forms.Button();
            this.BtnMonHoc = new System.Windows.Forms.Button();
            this.BtnDeThi = new System.Windows.Forms.Button();
            this.BtnCauHoi = new System.Windows.Forms.Button();
            this.LblTieuDe = new System.Windows.Forms.Button();
            this.PnlNoiDung.SuspendLayout();
            this.GrbChucNang.SuspendLayout();
            this.SuspendLayout();
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
            this.PnlNoiDung.TabIndex = 6;
            // 
            // GrbChucNang
            // 
            this.GrbChucNang.BackColor = System.Drawing.Color.White;
            this.GrbChucNang.Controls.Add(this.BtnLop);
            this.GrbChucNang.Controls.Add(this.BtnNguoiDung);
            this.GrbChucNang.Controls.Add(this.BtnThoat);
            this.GrbChucNang.Controls.Add(this.BtnBaoCaoThongKe);
            this.GrbChucNang.Controls.Add(this.BtnMonHoc);
            this.GrbChucNang.Controls.Add(this.BtnDeThi);
            this.GrbChucNang.Controls.Add(this.BtnCauHoi);
            this.GrbChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrbChucNang.Location = new System.Drawing.Point(0, 85);
            this.GrbChucNang.Name = "GrbChucNang";
            this.GrbChucNang.Size = new System.Drawing.Size(982, 368);
            this.GrbChucNang.TabIndex = 6;
            this.GrbChucNang.TabStop = false;
            this.GrbChucNang.Text = "Chức năng Admin";
            // 
            // BtnLop
            // 
            this.BtnLop.Location = new System.Drawing.Point(280, 50);
            this.BtnLop.Name = "BtnLop";
            this.BtnLop.Size = new System.Drawing.Size(150, 100);
            this.BtnLop.TabIndex = 2;
            this.BtnLop.Text = "Quản lý lớp học";
            this.BtnLop.UseVisualStyleBackColor = true;
            this.BtnLop.Click += new System.EventHandler(this.BtnLop_Click);
            // 
            // BtnNguoiDung
            // 
            this.BtnNguoiDung.Location = new System.Drawing.Point(565, 50);
            this.BtnNguoiDung.Name = "BtnNguoiDung";
            this.BtnNguoiDung.Size = new System.Drawing.Size(150, 100);
            this.BtnNguoiDung.TabIndex = 3;
            this.BtnNguoiDung.Text = "Quản lý người dùng";
            this.BtnNguoiDung.UseVisualStyleBackColor = true;
            this.BtnNguoiDung.Click += new System.EventHandler(this.BtnNguoiDung_Click);
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(565, 194);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(150, 100);
            this.BtnThoat.TabIndex = 7;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // BtnBaoCaoThongKe
            // 
            this.BtnBaoCaoThongKe.Location = new System.Drawing.Point(280, 194);
            this.BtnBaoCaoThongKe.Name = "BtnBaoCaoThongKe";
            this.BtnBaoCaoThongKe.Size = new System.Drawing.Size(150, 100);
            this.BtnBaoCaoThongKe.TabIndex = 6;
            this.BtnBaoCaoThongKe.Text = "Báo cáo thống kê";
            this.BtnBaoCaoThongKe.UseVisualStyleBackColor = true;
            this.BtnBaoCaoThongKe.Click += new System.EventHandler(this.BtnBaoCaoThongKe_Click);
            // 
            // BtnMonHoc
            // 
            this.BtnMonHoc.Location = new System.Drawing.Point(37, 50);
            this.BtnMonHoc.Name = "BtnMonHoc";
            this.BtnMonHoc.Size = new System.Drawing.Size(150, 100);
            this.BtnMonHoc.TabIndex = 1;
            this.BtnMonHoc.Text = "Quản lý môn học";
            this.BtnMonHoc.UseVisualStyleBackColor = true;
            this.BtnMonHoc.Click += new System.EventHandler(this.BtnMonHoc_Click);
            // 
            // BtnDeThi
            // 
            this.BtnDeThi.Location = new System.Drawing.Point(37, 194);
            this.BtnDeThi.Name = "BtnDeThi";
            this.BtnDeThi.Size = new System.Drawing.Size(150, 100);
            this.BtnDeThi.TabIndex = 5;
            this.BtnDeThi.Text = "Quản lý đề thi";
            this.BtnDeThi.UseVisualStyleBackColor = true;
            this.BtnDeThi.Click += new System.EventHandler(this.BtnDeThi_Click);
            // 
            // BtnCauHoi
            // 
            this.BtnCauHoi.Location = new System.Drawing.Point(782, 50);
            this.BtnCauHoi.Name = "BtnCauHoi";
            this.BtnCauHoi.Size = new System.Drawing.Size(150, 100);
            this.BtnCauHoi.TabIndex = 4;
            this.BtnCauHoi.Text = "Quản lý câu hỏi";
            this.BtnCauHoi.UseVisualStyleBackColor = true;
            this.BtnCauHoi.Click += new System.EventHandler(this.BtnCauHoi_Click);
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
            this.LblTieuDe.Text = "TRANG CHỦ ADMIN";
            this.LblTieuDe.UseVisualStyleBackColor = false;
            // 
            // TrangChu_Admin_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.PnlNoiDung);
            this.Name = "TrangChu_Admin_GUI";
            this.Text = "TrangChu_GUI";
            this.PnlNoiDung.ResumeLayout(false);
            this.GrbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlNoiDung;
        private System.Windows.Forms.Button LblTieuDe;
        private System.Windows.Forms.GroupBox GrbChucNang;
        private System.Windows.Forms.Button BtnNguoiDung;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button BtnBaoCaoThongKe;
        private System.Windows.Forms.Button BtnMonHoc;
        private System.Windows.Forms.Button BtnDeThi;
        private System.Windows.Forms.Button BtnCauHoi;
        private System.Windows.Forms.Button BtnLop;
    }
}