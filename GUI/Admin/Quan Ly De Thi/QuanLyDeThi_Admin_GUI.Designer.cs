namespace GUI.Admin
{
    partial class QuanLyDeThi_Admin_GUI
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
            this.BtnChiTietDeThi = new System.Windows.Forms.Button();
            this.PnlNoiDung = new System.Windows.Forms.Panel();
            this.DgvDuLieu = new System.Windows.Forms.DataGridView();
            this.GrbNhapThongTin = new System.Windows.Forms.GroupBox();
            this.TxtSoCauHoi = new System.Windows.Forms.TextBox();
            this.LblSoCauHoi = new System.Windows.Forms.Label();
            this.LblNgayKetThuc = new System.Windows.Forms.Label();
            this.LblDiemToiThieu = new System.Windows.Forms.Label();
            this.TxtNgayBatDau = new System.Windows.Forms.TextBox();
            this.TxtNgayKetThuc = new System.Windows.Forms.TextBox();
            this.McThoiGianThi = new System.Windows.Forms.MonthCalendar();
            this.LblNgayBatDau = new System.Windows.Forms.Label();
            this.TxtSoCauToiThieu = new System.Windows.Forms.TextBox();
            this.LblSoCauToiThieu = new System.Windows.Forms.Label();
            this.CbbThoiGian = new System.Windows.Forms.ComboBox();
            this.CbbMonHoc = new System.Windows.Forms.ComboBox();
            this.LblThoiGian = new System.Windows.Forms.Label();
            this.LblTieuDe = new System.Windows.Forms.Label();
            this.TxtTieuDe = new System.Windows.Forms.TextBox();
            this.LblID = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblTen = new System.Windows.Forms.Label();
            this.GrbChucNang = new System.Windows.Forms.GroupBox();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.BtnLamMoi = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            this.TxtTimKiem = new System.Windows.Forms.TextBox();
            this.BtnTimKiem = new System.Windows.Forms.Button();
            this.PnlTieuDe = new System.Windows.Forms.Button();
            this.PnlNoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDuLieu)).BeginInit();
            this.GrbNhapThongTin.SuspendLayout();
            this.GrbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnChiTietDeThi
            // 
            this.BtnChiTietDeThi.Location = new System.Drawing.Point(920, 22);
            this.BtnChiTietDeThi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnChiTietDeThi.Name = "BtnChiTietDeThi";
            this.BtnChiTietDeThi.Size = new System.Drawing.Size(90, 65);
            this.BtnChiTietDeThi.TabIndex = 7;
            this.BtnChiTietDeThi.Text = "ChiTiết Đề Thi";
            this.BtnChiTietDeThi.UseVisualStyleBackColor = true;
            this.BtnChiTietDeThi.Click += new System.EventHandler(this.BtnChiTietDeThi_Click);
            // 
            // PnlNoiDung
            // 
            this.PnlNoiDung.Controls.Add(this.DgvDuLieu);
            this.PnlNoiDung.Controls.Add(this.GrbNhapThongTin);
            this.PnlNoiDung.Controls.Add(this.GrbChucNang);
            this.PnlNoiDung.Controls.Add(this.PnlTieuDe);
            this.PnlNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlNoiDung.Location = new System.Drawing.Point(0, 0);
            this.PnlNoiDung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PnlNoiDung.Name = "PnlNoiDung";
            this.PnlNoiDung.Size = new System.Drawing.Size(1262, 531);
            this.PnlNoiDung.TabIndex = 3;
            // 
            // DgvDuLieu
            // 
            this.DgvDuLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDuLieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDuLieu.Location = new System.Drawing.Point(464, 65);
            this.DgvDuLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvDuLieu.Name = "DgvDuLieu";
            this.DgvDuLieu.RowHeadersWidth = 51;
            this.DgvDuLieu.RowTemplate.Height = 24;
            this.DgvDuLieu.Size = new System.Drawing.Size(798, 366);
            this.DgvDuLieu.TabIndex = 3;
            this.DgvDuLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDuLieu_CellClick);
            // 
            // GrbNhapThongTin
            // 
            this.GrbNhapThongTin.Controls.Add(this.TxtSoCauHoi);
            this.GrbNhapThongTin.Controls.Add(this.LblSoCauHoi);
            this.GrbNhapThongTin.Controls.Add(this.LblNgayKetThuc);
            this.GrbNhapThongTin.Controls.Add(this.LblDiemToiThieu);
            this.GrbNhapThongTin.Controls.Add(this.TxtNgayBatDau);
            this.GrbNhapThongTin.Controls.Add(this.TxtNgayKetThuc);
            this.GrbNhapThongTin.Controls.Add(this.McThoiGianThi);
            this.GrbNhapThongTin.Controls.Add(this.LblNgayBatDau);
            this.GrbNhapThongTin.Controls.Add(this.TxtSoCauToiThieu);
            this.GrbNhapThongTin.Controls.Add(this.LblSoCauToiThieu);
            this.GrbNhapThongTin.Controls.Add(this.CbbThoiGian);
            this.GrbNhapThongTin.Controls.Add(this.CbbMonHoc);
            this.GrbNhapThongTin.Controls.Add(this.LblThoiGian);
            this.GrbNhapThongTin.Controls.Add(this.LblTieuDe);
            this.GrbNhapThongTin.Controls.Add(this.TxtTieuDe);
            this.GrbNhapThongTin.Controls.Add(this.LblID);
            this.GrbNhapThongTin.Controls.Add(this.TxtID);
            this.GrbNhapThongTin.Controls.Add(this.LblTen);
            this.GrbNhapThongTin.Dock = System.Windows.Forms.DockStyle.Left;
            this.GrbNhapThongTin.Location = new System.Drawing.Point(0, 65);
            this.GrbNhapThongTin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrbNhapThongTin.Name = "GrbNhapThongTin";
            this.GrbNhapThongTin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrbNhapThongTin.Size = new System.Drawing.Size(464, 366);
            this.GrbNhapThongTin.TabIndex = 2;
            this.GrbNhapThongTin.TabStop = false;
            this.GrbNhapThongTin.Text = "Nhập thông tin";
            // 
            // TxtSoCauHoi
            // 
            this.TxtSoCauHoi.Location = new System.Drawing.Point(12, 197);
            this.TxtSoCauHoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtSoCauHoi.Name = "TxtSoCauHoi";
            this.TxtSoCauHoi.ReadOnly = true;
            this.TxtSoCauHoi.Size = new System.Drawing.Size(82, 20);
            this.TxtSoCauHoi.TabIndex = 28;
            this.TxtSoCauHoi.Text = "10";
            // 
            // LblSoCauHoi
            // 
            this.LblSoCauHoi.AutoSize = true;
            this.LblSoCauHoi.Location = new System.Drawing.Point(10, 170);
            this.LblSoCauHoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSoCauHoi.Name = "LblSoCauHoi";
            this.LblSoCauHoi.Size = new System.Drawing.Size(65, 15);
            this.LblSoCauHoi.TabIndex = 27;
            this.LblSoCauHoi.Text = "Số câu hỏi";
            // 
            // LblNgayKetThuc
            // 
            this.LblNgayKetThuc.AutoSize = true;
            this.LblNgayKetThuc.Location = new System.Drawing.Point(224, 301);
            this.LblNgayKetThuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNgayKetThuc.Name = "LblNgayKetThuc";
            this.LblNgayKetThuc.Size = new System.Drawing.Size(80, 15);
            this.LblNgayKetThuc.TabIndex = 25;
            this.LblNgayKetThuc.Text = "Ngày kết thúc";
            // 
            // LblDiemToiThieu
            // 
            this.LblDiemToiThieu.AutoSize = true;
            this.LblDiemToiThieu.Location = new System.Drawing.Point(10, 303);
            this.LblDiemToiThieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDiemToiThieu.Name = "LblDiemToiThieu";
            this.LblDiemToiThieu.Size = new System.Drawing.Size(162, 15);
            this.LblDiemToiThieu.TabIndex = 26;
            this.LblDiemToiThieu.Text = "Điểm tối thiểu qua môn 5/10";
            // 
            // TxtNgayBatDau
            // 
            this.TxtNgayBatDau.Location = new System.Drawing.Point(316, 250);
            this.TxtNgayBatDau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNgayBatDau.Name = "TxtNgayBatDau";
            this.TxtNgayBatDau.Size = new System.Drawing.Size(92, 20);
            this.TxtNgayBatDau.TabIndex = 22;
            // 
            // TxtNgayKetThuc
            // 
            this.TxtNgayKetThuc.Location = new System.Drawing.Point(316, 301);
            this.TxtNgayKetThuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNgayKetThuc.Name = "TxtNgayKetThuc";
            this.TxtNgayKetThuc.Size = new System.Drawing.Size(92, 20);
            this.TxtNgayKetThuc.TabIndex = 24;
            // 
            // McThoiGianThi
            // 
            this.McThoiGianThi.Location = new System.Drawing.Point(219, 24);
            this.McThoiGianThi.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.McThoiGianThi.Name = "McThoiGianThi";
            this.McThoiGianThi.TabIndex = 13;
            this.McThoiGianThi.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.McThoiGianThi_DateChanged);
            // 
            // LblNgayBatDau
            // 
            this.LblNgayBatDau.AutoSize = true;
            this.LblNgayBatDau.Location = new System.Drawing.Point(224, 250);
            this.LblNgayBatDau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNgayBatDau.Name = "LblNgayBatDau";
            this.LblNgayBatDau.Size = new System.Drawing.Size(79, 15);
            this.LblNgayBatDau.TabIndex = 23;
            this.LblNgayBatDau.Text = "Ngày bắt đầu";
            // 
            // TxtSoCauToiThieu
            // 
            this.TxtSoCauToiThieu.Location = new System.Drawing.Point(12, 258);
            this.TxtSoCauToiThieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtSoCauToiThieu.Name = "TxtSoCauToiThieu";
            this.TxtSoCauToiThieu.Size = new System.Drawing.Size(82, 20);
            this.TxtSoCauToiThieu.TabIndex = 26;
            // 
            // LblSoCauToiThieu
            // 
            this.LblSoCauToiThieu.AutoSize = true;
            this.LblSoCauToiThieu.Location = new System.Drawing.Point(10, 232);
            this.LblSoCauToiThieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSoCauToiThieu.Name = "LblSoCauToiThieu";
            this.LblSoCauToiThieu.Size = new System.Drawing.Size(122, 15);
            this.LblSoCauToiThieu.TabIndex = 20;
            this.LblSoCauToiThieu.Text = "Số câu đúng tối thiểu";
            // 
            // CbbThoiGian
            // 
            this.CbbThoiGian.FormattingEnabled = true;
            this.CbbThoiGian.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30",
            "40",
            "50",
            "60",
            "90"});
            this.CbbThoiGian.Location = new System.Drawing.Point(309, 202);
            this.CbbThoiGian.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbbThoiGian.Name = "CbbThoiGian";
            this.CbbThoiGian.Size = new System.Drawing.Size(92, 21);
            this.CbbThoiGian.TabIndex = 19;
            // 
            // CbbMonHoc
            // 
            this.CbbMonHoc.FormattingEnabled = true;
            this.CbbMonHoc.Location = new System.Drawing.Point(102, 84);
            this.CbbMonHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbbMonHoc.Name = "CbbMonHoc";
            this.CbbMonHoc.Size = new System.Drawing.Size(92, 21);
            this.CbbMonHoc.TabIndex = 18;
            // 
            // LblThoiGian
            // 
            this.LblThoiGian.AutoSize = true;
            this.LblThoiGian.Location = new System.Drawing.Point(217, 209);
            this.LblThoiGian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblThoiGian.Name = "LblThoiGian";
            this.LblThoiGian.Size = new System.Drawing.Size(99, 15);
            this.LblThoiGian.TabIndex = 17;
            this.LblThoiGian.Text = "Thời gian làm đề";
            // 
            // LblTieuDe
            // 
            this.LblTieuDe.AutoSize = true;
            this.LblTieuDe.Location = new System.Drawing.Point(10, 130);
            this.LblTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTieuDe.Name = "LblTieuDe";
            this.LblTieuDe.Size = new System.Drawing.Size(48, 15);
            this.LblTieuDe.TabIndex = 15;
            this.LblTieuDe.Text = "Tiêu đề";
            // 
            // TxtTieuDe
            // 
            this.TxtTieuDe.Location = new System.Drawing.Point(102, 130);
            this.TxtTieuDe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtTieuDe.Name = "TxtTieuDe";
            this.TxtTieuDe.Size = new System.Drawing.Size(92, 20);
            this.TxtTieuDe.TabIndex = 14;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(10, 39);
            this.LblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(19, 15);
            this.LblID.TabIndex = 11;
            this.LblID.Text = "ID";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(102, 39);
            this.TxtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(92, 20);
            this.TxtID.TabIndex = 10;
            // 
            // LblTen
            // 
            this.LblTen.AutoSize = true;
            this.LblTen.Location = new System.Drawing.Point(10, 84);
            this.LblTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTen.Name = "LblTen";
            this.LblTen.Size = new System.Drawing.Size(54, 15);
            this.LblTen.TabIndex = 1;
            this.LblTen.Text = "MonHoc";
            // 
            // GrbChucNang
            // 
            this.GrbChucNang.Controls.Add(this.BtnChiTietDeThi);
            this.GrbChucNang.Controls.Add(this.BtnThoat);
            this.GrbChucNang.Controls.Add(this.BtnLamMoi);
            this.GrbChucNang.Controls.Add(this.BtnXoa);
            this.GrbChucNang.Controls.Add(this.BtnSua);
            this.GrbChucNang.Controls.Add(this.BtnThem);
            this.GrbChucNang.Controls.Add(this.TxtTimKiem);
            this.GrbChucNang.Controls.Add(this.BtnTimKiem);
            this.GrbChucNang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrbChucNang.Location = new System.Drawing.Point(0, 431);
            this.GrbChucNang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrbChucNang.Name = "GrbChucNang";
            this.GrbChucNang.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GrbChucNang.Size = new System.Drawing.Size(1262, 100);
            this.GrbChucNang.TabIndex = 1;
            this.GrbChucNang.TabStop = false;
            this.GrbChucNang.Text = "Chức năng";
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(1049, 22);
            this.BtnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(90, 65);
            this.BtnThoat.TabIndex = 6;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // BtnLamMoi
            // 
            this.BtnLamMoi.Location = new System.Drawing.Point(752, 22);
            this.BtnLamMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnLamMoi.Name = "BtnLamMoi";
            this.BtnLamMoi.Size = new System.Drawing.Size(90, 65);
            this.BtnLamMoi.TabIndex = 5;
            this.BtnLamMoi.Text = "Làm mới";
            this.BtnLamMoi.UseVisualStyleBackColor = true;
            this.BtnLamMoi.Click += new System.EventHandler(this.BtnLamMoi_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(571, 22);
            this.BtnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(90, 65);
            this.BtnXoa.TabIndex = 4;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(396, 22);
            this.BtnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(90, 65);
            this.BtnSua.TabIndex = 3;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(221, 22);
            this.BtnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(90, 65);
            this.BtnThem.TabIndex = 2;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // TxtTimKiem
            // 
            this.TxtTimKiem.Location = new System.Drawing.Point(77, 17);
            this.TxtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtTimKiem.Name = "TxtTimKiem";
            this.TxtTimKiem.Size = new System.Drawing.Size(86, 20);
            this.TxtTimKiem.TabIndex = 1;
            // 
            // BtnTimKiem
            // 
            this.BtnTimKiem.Location = new System.Drawing.Point(77, 45);
            this.BtnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnTimKiem.Name = "BtnTimKiem";
            this.BtnTimKiem.Size = new System.Drawing.Size(85, 42);
            this.BtnTimKiem.TabIndex = 0;
            this.BtnTimKiem.Text = "Tìm kiếm";
            this.BtnTimKiem.UseVisualStyleBackColor = true;
            // 
            // PnlTieuDe
            // 
            this.PnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTieuDe.FlatAppearance.BorderSize = 0;
            this.PnlTieuDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PnlTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.PnlTieuDe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PnlTieuDe.Name = "PnlTieuDe";
            this.PnlTieuDe.Size = new System.Drawing.Size(1262, 65);
            this.PnlTieuDe.TabIndex = 0;
            this.PnlTieuDe.TabStop = false;
            this.PnlTieuDe.Text = "QUẢN LÝ ĐỀ THI";
            this.PnlTieuDe.UseVisualStyleBackColor = false;
            // 
            // QuanLyDeThi_Admin_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 531);
            this.Controls.Add(this.PnlNoiDung);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QuanLyDeThi_Admin_GUI";
            this.Text = "QuanLyDeThi_Admin_GUI";
            this.Load += new System.EventHandler(this.QuanLyDeThi_Admin_GUI_Load);
            this.PnlNoiDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDuLieu)).EndInit();
            this.GrbNhapThongTin.ResumeLayout(false);
            this.GrbNhapThongTin.PerformLayout();
            this.GrbChucNang.ResumeLayout(false);
            this.GrbChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnChiTietDeThi;
        private System.Windows.Forms.Panel PnlNoiDung;
        private System.Windows.Forms.DataGridView DgvDuLieu;
        private System.Windows.Forms.GroupBox GrbNhapThongTin;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblTen;
        private System.Windows.Forms.GroupBox GrbChucNang;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button BtnLamMoi;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.TextBox TxtTimKiem;
        private System.Windows.Forms.Button BtnTimKiem;
        private System.Windows.Forms.Button PnlTieuDe;
        private System.Windows.Forms.ComboBox CbbThoiGian;
        private System.Windows.Forms.ComboBox CbbMonHoc;
        private System.Windows.Forms.Label LblThoiGian;
        private System.Windows.Forms.Label LblTieuDe;
        private System.Windows.Forms.TextBox TxtTieuDe;
        private System.Windows.Forms.MonthCalendar McThoiGianThi;
        private System.Windows.Forms.Label LblNgayKetThuc;
        private System.Windows.Forms.TextBox TxtNgayBatDau;
        private System.Windows.Forms.TextBox TxtNgayKetThuc;
        private System.Windows.Forms.Label LblNgayBatDau;
        private System.Windows.Forms.TextBox TxtSoCauToiThieu;
        private System.Windows.Forms.Label LblSoCauToiThieu;
        private System.Windows.Forms.Label LblDiemToiThieu;
        private System.Windows.Forms.TextBox TxtSoCauHoi;
        private System.Windows.Forms.Label LblSoCauHoi;
    }
}