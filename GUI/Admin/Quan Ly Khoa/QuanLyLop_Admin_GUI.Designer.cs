namespace GUI.Admin.QuanLyLop
{
    partial class QuanLyLop_Admin_GUI
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
            this.PnlTieuDe = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            this.TxtTimKiem = new System.Windows.Forms.TextBox();
            this.LblID_Khoa = new System.Windows.Forms.Label();
            this.TxtID_Khoa = new System.Windows.Forms.TextBox();
            this.LblID = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.BtnLamMoi = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnTimKiem = new System.Windows.Forms.Button();
            this.GrbNhapThongTin = new System.Windows.Forms.GroupBox();
            this.PnlNoiDung = new System.Windows.Forms.Panel();
            this.DgvDuLieu = new System.Windows.Forms.DataGridView();
            this.GrbChucNang = new System.Windows.Forms.GroupBox();
            this.LblTenLop = new System.Windows.Forms.Label();
            this.TxtTenLop = new System.Windows.Forms.TextBox();
            this.LblHeDaoTao = new System.Windows.Forms.Label();
            this.TxtHeDaoTao = new System.Windows.Forms.TextBox();
            this.LblNamNhapHoc = new System.Windows.Forms.Label();
            this.TxtNamNhapHoc = new System.Windows.Forms.TextBox();
            this.GrbNhapThongTin.SuspendLayout();
            this.PnlNoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDuLieu)).BeginInit();
            this.GrbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTieuDe
            // 
            this.PnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTieuDe.FlatAppearance.BorderSize = 0;
            this.PnlTieuDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PnlTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.PnlTieuDe.Name = "PnlTieuDe";
            this.PnlTieuDe.Size = new System.Drawing.Size(1582, 80);
            this.PnlTieuDe.TabIndex = 0;
            this.PnlTieuDe.TabStop = false;
            this.PnlTieuDe.Text = "QUẢN LÝ LỚP";
            this.PnlTieuDe.UseVisualStyleBackColor = false;
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(455, 27);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(120, 80);
            this.BtnSua.TabIndex = 3;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(295, 27);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(120, 80);
            this.BtnThem.TabIndex = 2;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // TxtTimKiem
            // 
            this.TxtTimKiem.Location = new System.Drawing.Point(103, 21);
            this.TxtTimKiem.Name = "TxtTimKiem";
            this.TxtTimKiem.Size = new System.Drawing.Size(113, 22);
            this.TxtTimKiem.TabIndex = 1;
            // 
            // LblID_Khoa
            // 
            this.LblID_Khoa.AutoSize = true;
            this.LblID_Khoa.Location = new System.Drawing.Point(13, 67);
            this.LblID_Khoa.Name = "LblID_Khoa";
            this.LblID_Khoa.Size = new System.Drawing.Size(58, 16);
            this.LblID_Khoa.TabIndex = 15;
            this.LblID_Khoa.Text = "ID_Khoa";
            // 
            // TxtID_Khoa
            // 
            this.TxtID_Khoa.Location = new System.Drawing.Point(136, 61);
            this.TxtID_Khoa.Name = "TxtID_Khoa";
            this.TxtID_Khoa.ReadOnly = true;
            this.TxtID_Khoa.Size = new System.Drawing.Size(100, 22);
            this.TxtID_Khoa.TabIndex = 14;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(13, 116);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(20, 16);
            this.LblID.TabIndex = 11;
            this.LblID.Text = "ID";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(136, 116);
            this.TxtID.Name = "TxtID";
            this.TxtID.ReadOnly = true;
            this.TxtID.Size = new System.Drawing.Size(100, 22);
            this.TxtID.TabIndex = 10;
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(1113, 27);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(120, 80);
            this.BtnThoat.TabIndex = 6;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // BtnLamMoi
            // 
            this.BtnLamMoi.Location = new System.Drawing.Point(903, 27);
            this.BtnLamMoi.Name = "BtnLamMoi";
            this.BtnLamMoi.Size = new System.Drawing.Size(120, 80);
            this.BtnLamMoi.TabIndex = 5;
            this.BtnLamMoi.Text = "Làm mới";
            this.BtnLamMoi.UseVisualStyleBackColor = true;
            this.BtnLamMoi.Click += new System.EventHandler(this.BtnLamMoi_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(695, 27);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(120, 80);
            this.BtnXoa.TabIndex = 4;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnTimKiem
            // 
            this.BtnTimKiem.Location = new System.Drawing.Point(103, 55);
            this.BtnTimKiem.Name = "BtnTimKiem";
            this.BtnTimKiem.Size = new System.Drawing.Size(113, 52);
            this.BtnTimKiem.TabIndex = 0;
            this.BtnTimKiem.Text = "Tìm kiếm";
            this.BtnTimKiem.UseVisualStyleBackColor = true;
            this.BtnTimKiem.Click += new System.EventHandler(this.BtnTimKiem_Click);
            // 
            // GrbNhapThongTin
            // 
            this.GrbNhapThongTin.Controls.Add(this.LblNamNhapHoc);
            this.GrbNhapThongTin.Controls.Add(this.TxtNamNhapHoc);
            this.GrbNhapThongTin.Controls.Add(this.LblHeDaoTao);
            this.GrbNhapThongTin.Controls.Add(this.TxtHeDaoTao);
            this.GrbNhapThongTin.Controls.Add(this.LblTenLop);
            this.GrbNhapThongTin.Controls.Add(this.TxtTenLop);
            this.GrbNhapThongTin.Controls.Add(this.LblID_Khoa);
            this.GrbNhapThongTin.Controls.Add(this.TxtID_Khoa);
            this.GrbNhapThongTin.Controls.Add(this.LblID);
            this.GrbNhapThongTin.Controls.Add(this.TxtID);
            this.GrbNhapThongTin.Dock = System.Windows.Forms.DockStyle.Left;
            this.GrbNhapThongTin.Location = new System.Drawing.Point(0, 80);
            this.GrbNhapThongTin.Name = "GrbNhapThongTin";
            this.GrbNhapThongTin.Size = new System.Drawing.Size(267, 450);
            this.GrbNhapThongTin.TabIndex = 2;
            this.GrbNhapThongTin.TabStop = false;
            this.GrbNhapThongTin.Text = "Nhập thông tin";
            // 
            // PnlNoiDung
            // 
            this.PnlNoiDung.Controls.Add(this.DgvDuLieu);
            this.PnlNoiDung.Controls.Add(this.GrbNhapThongTin);
            this.PnlNoiDung.Controls.Add(this.GrbChucNang);
            this.PnlNoiDung.Controls.Add(this.PnlTieuDe);
            this.PnlNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlNoiDung.Location = new System.Drawing.Point(0, 0);
            this.PnlNoiDung.Name = "PnlNoiDung";
            this.PnlNoiDung.Size = new System.Drawing.Size(1582, 653);
            this.PnlNoiDung.TabIndex = 4;
            // 
            // DgvDuLieu
            // 
            this.DgvDuLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDuLieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDuLieu.Location = new System.Drawing.Point(267, 80);
            this.DgvDuLieu.Name = "DgvDuLieu";
            this.DgvDuLieu.RowHeadersWidth = 51;
            this.DgvDuLieu.RowTemplate.Height = 24;
            this.DgvDuLieu.Size = new System.Drawing.Size(1315, 450);
            this.DgvDuLieu.TabIndex = 3;
            this.DgvDuLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDuLieu_CellClick);
            // 
            // GrbChucNang
            // 
            this.GrbChucNang.Controls.Add(this.BtnThoat);
            this.GrbChucNang.Controls.Add(this.BtnLamMoi);
            this.GrbChucNang.Controls.Add(this.BtnXoa);
            this.GrbChucNang.Controls.Add(this.BtnSua);
            this.GrbChucNang.Controls.Add(this.BtnThem);
            this.GrbChucNang.Controls.Add(this.TxtTimKiem);
            this.GrbChucNang.Controls.Add(this.BtnTimKiem);
            this.GrbChucNang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrbChucNang.Location = new System.Drawing.Point(0, 530);
            this.GrbChucNang.Name = "GrbChucNang";
            this.GrbChucNang.Size = new System.Drawing.Size(1582, 123);
            this.GrbChucNang.TabIndex = 1;
            this.GrbChucNang.TabStop = false;
            this.GrbChucNang.Text = "Chức năng";
            // 
            // LblTenLop
            // 
            this.LblTenLop.AutoSize = true;
            this.LblTenLop.Location = new System.Drawing.Point(13, 163);
            this.LblTenLop.Name = "LblTenLop";
            this.LblTenLop.Size = new System.Drawing.Size(57, 16);
            this.LblTenLop.TabIndex = 17;
            this.LblTenLop.Text = "Tên Lớp";
            // 
            // TxtTenLop
            // 
            this.TxtTenLop.Location = new System.Drawing.Point(136, 163);
            this.TxtTenLop.Name = "TxtTenLop";
            this.TxtTenLop.Size = new System.Drawing.Size(100, 22);
            this.TxtTenLop.TabIndex = 16;
            // 
            // LblHeDaoTao
            // 
            this.LblHeDaoTao.AutoSize = true;
            this.LblHeDaoTao.Location = new System.Drawing.Point(14, 217);
            this.LblHeDaoTao.Name = "LblHeDaoTao";
            this.LblHeDaoTao.Size = new System.Drawing.Size(74, 16);
            this.LblHeDaoTao.TabIndex = 19;
            this.LblHeDaoTao.Text = "Hệ đào tạo";
            // 
            // TxtHeDaoTao
            // 
            this.TxtHeDaoTao.Location = new System.Drawing.Point(136, 214);
            this.TxtHeDaoTao.Name = "TxtHeDaoTao";
            this.TxtHeDaoTao.Size = new System.Drawing.Size(100, 22);
            this.TxtHeDaoTao.TabIndex = 18;
            // 
            // LblNamNhapHoc
            // 
            this.LblNamNhapHoc.AutoSize = true;
            this.LblNamNhapHoc.Location = new System.Drawing.Point(13, 269);
            this.LblNamNhapHoc.Name = "LblNamNhapHoc";
            this.LblNamNhapHoc.Size = new System.Drawing.Size(94, 16);
            this.LblNamNhapHoc.TabIndex = 21;
            this.LblNamNhapHoc.Text = "Năm nhập học";
            // 
            // TxtNamNhapHoc
            // 
            this.TxtNamNhapHoc.Location = new System.Drawing.Point(136, 263);
            this.TxtNamNhapHoc.Name = "TxtNamNhapHoc";
            this.TxtNamNhapHoc.Size = new System.Drawing.Size(100, 22);
            this.TxtNamNhapHoc.TabIndex = 20;
            // 
            // QuanLyLop_Admin_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 653);
            this.Controls.Add(this.PnlNoiDung);
            this.Name = "QuanLyLop_Admin_GUI";
            this.Text = "QuanLyKhoa_Admin_GUI";
            this.Load += new System.EventHandler(this.QuanLyLop_Admin_GUI_Load);
            this.GrbNhapThongTin.ResumeLayout(false);
            this.GrbNhapThongTin.PerformLayout();
            this.PnlNoiDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDuLieu)).EndInit();
            this.GrbChucNang.ResumeLayout(false);
            this.GrbChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PnlTieuDe;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.TextBox TxtTimKiem;
        private System.Windows.Forms.Label LblID_Khoa;
        private System.Windows.Forms.TextBox TxtID_Khoa;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button BtnLamMoi;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnTimKiem;
        private System.Windows.Forms.GroupBox GrbNhapThongTin;
        private System.Windows.Forms.Panel PnlNoiDung;
        private System.Windows.Forms.DataGridView DgvDuLieu;
        private System.Windows.Forms.GroupBox GrbChucNang;
        private System.Windows.Forms.Label LblTenLop;
        private System.Windows.Forms.TextBox TxtTenLop;
        private System.Windows.Forms.Label LblHeDaoTao;
        private System.Windows.Forms.TextBox TxtHeDaoTao;
        private System.Windows.Forms.Label LblNamNhapHoc;
        private System.Windows.Forms.TextBox TxtNamNhapHoc;
    }
}