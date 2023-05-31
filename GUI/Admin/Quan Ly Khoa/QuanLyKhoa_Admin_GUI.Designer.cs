namespace GUI.Admin.QuanLyLop
{
    partial class QuanLyKhoa_Admin_GUI
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
            this.BtnLop = new System.Windows.Forms.Button();
            this.PnlNoiDung = new System.Windows.Forms.Panel();
            this.DgvDuLieu = new System.Windows.Forms.DataGridView();
            this.GrbNhapThongTin = new System.Windows.Forms.GroupBox();
            this.LblDiaDiem = new System.Windows.Forms.Label();
            this.TxtDiaDiem = new System.Windows.Forms.TextBox();
            this.LblDienThoai = new System.Windows.Forms.Label();
            this.TxtDienThoai = new System.Windows.Forms.TextBox();
            this.LblID = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblTenKhoa = new System.Windows.Forms.Label();
            this.TxtTenKhoa = new System.Windows.Forms.TextBox();
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
            // BtnLop
            // 
            this.BtnLop.Location = new System.Drawing.Point(951, 27);
            this.BtnLop.Name = "BtnLop";
            this.BtnLop.Size = new System.Drawing.Size(120, 80);
            this.BtnLop.TabIndex = 7;
            this.BtnLop.Text = "Quản lý lớp";
            this.BtnLop.UseVisualStyleBackColor = true;
            this.BtnLop.Click += new System.EventHandler(this.BtnLop_Click);
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
            this.PnlNoiDung.TabIndex = 3;
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
            // GrbNhapThongTin
            // 
            this.GrbNhapThongTin.Controls.Add(this.LblDiaDiem);
            this.GrbNhapThongTin.Controls.Add(this.TxtDiaDiem);
            this.GrbNhapThongTin.Controls.Add(this.LblDienThoai);
            this.GrbNhapThongTin.Controls.Add(this.TxtDienThoai);
            this.GrbNhapThongTin.Controls.Add(this.LblID);
            this.GrbNhapThongTin.Controls.Add(this.TxtID);
            this.GrbNhapThongTin.Controls.Add(this.LblTenKhoa);
            this.GrbNhapThongTin.Controls.Add(this.TxtTenKhoa);
            this.GrbNhapThongTin.Dock = System.Windows.Forms.DockStyle.Left;
            this.GrbNhapThongTin.Location = new System.Drawing.Point(0, 80);
            this.GrbNhapThongTin.Name = "GrbNhapThongTin";
            this.GrbNhapThongTin.Size = new System.Drawing.Size(267, 450);
            this.GrbNhapThongTin.TabIndex = 2;
            this.GrbNhapThongTin.TabStop = false;
            this.GrbNhapThongTin.Text = "Nhập thông tin";
            // 
            // LblDiaDiem
            // 
            this.LblDiaDiem.AutoSize = true;
            this.LblDiaDiem.Location = new System.Drawing.Point(13, 215);
            this.LblDiaDiem.Name = "LblDiaDiem";
            this.LblDiaDiem.Size = new System.Drawing.Size(60, 16);
            this.LblDiaDiem.TabIndex = 15;
            this.LblDiaDiem.Text = "Địa điểm";
            // 
            // TxtDiaDiem
            // 
            this.TxtDiaDiem.Location = new System.Drawing.Point(136, 215);
            this.TxtDiaDiem.Name = "TxtDiaDiem";
            this.TxtDiaDiem.Size = new System.Drawing.Size(100, 22);
            this.TxtDiaDiem.TabIndex = 14;
            // 
            // LblDienThoai
            // 
            this.LblDienThoai.AutoSize = true;
            this.LblDienThoai.Location = new System.Drawing.Point(13, 159);
            this.LblDienThoai.Name = "LblDienThoai";
            this.LblDienThoai.Size = new System.Drawing.Size(66, 16);
            this.LblDienThoai.TabIndex = 13;
            this.LblDienThoai.Text = "Điện thoại";
            // 
            // TxtDienThoai
            // 
            this.TxtDienThoai.Location = new System.Drawing.Point(136, 159);
            this.TxtDienThoai.Name = "TxtDienThoai";
            this.TxtDienThoai.Size = new System.Drawing.Size(100, 22);
            this.TxtDienThoai.TabIndex = 12;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(13, 48);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(20, 16);
            this.LblID.TabIndex = 11;
            this.LblID.Text = "ID";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(136, 48);
            this.TxtID.Name = "TxtID";
            this.TxtID.ReadOnly = true;
            this.TxtID.Size = new System.Drawing.Size(100, 22);
            this.TxtID.TabIndex = 10;
            // 
            // LblTenKhoa
            // 
            this.LblTenKhoa.AutoSize = true;
            this.LblTenKhoa.Location = new System.Drawing.Point(13, 103);
            this.LblTenKhoa.Name = "LblTenKhoa";
            this.LblTenKhoa.Size = new System.Drawing.Size(64, 16);
            this.LblTenKhoa.TabIndex = 1;
            this.LblTenKhoa.Text = "Tên khoa";
            // 
            // TxtTenKhoa
            // 
            this.TxtTenKhoa.Location = new System.Drawing.Point(136, 103);
            this.TxtTenKhoa.Name = "TxtTenKhoa";
            this.TxtTenKhoa.Size = new System.Drawing.Size(100, 22);
            this.TxtTenKhoa.TabIndex = 0;
            // 
            // GrbChucNang
            // 
            this.GrbChucNang.Controls.Add(this.BtnLop);
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
            this.BtnLamMoi.Location = new System.Drawing.Point(792, 27);
            this.BtnLamMoi.Name = "BtnLamMoi";
            this.BtnLamMoi.Size = new System.Drawing.Size(120, 80);
            this.BtnLamMoi.TabIndex = 5;
            this.BtnLamMoi.Text = "Làm mới";
            this.BtnLamMoi.UseVisualStyleBackColor = true;
            this.BtnLamMoi.Click += new System.EventHandler(this.BtnLamMoi_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(627, 27);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(120, 80);
            this.BtnXoa.TabIndex = 4;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
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
            // BtnTimKiem
            // 
            this.BtnTimKiem.Location = new System.Drawing.Point(103, 55);
            this.BtnTimKiem.Name = "BtnTimKiem";
            this.BtnTimKiem.Size = new System.Drawing.Size(113, 52);
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
            this.PnlTieuDe.Name = "PnlTieuDe";
            this.PnlTieuDe.Size = new System.Drawing.Size(1582, 80);
            this.PnlTieuDe.TabIndex = 0;
            this.PnlTieuDe.TabStop = false;
            this.PnlTieuDe.Text = "QUẢN LÝ KHOA";
            this.PnlTieuDe.UseVisualStyleBackColor = false;
            // 
            // QuanLyKhoa_Admin_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 653);
            this.Controls.Add(this.PnlNoiDung);
            this.Name = "QuanLyKhoa_Admin_GUI";
            this.Text = "QuanLyLopHoc_Admin_GUI";
            this.Load += new System.EventHandler(this.QuanLyLopHoc_Admin_GUI_Load);
            this.PnlNoiDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDuLieu)).EndInit();
            this.GrbNhapThongTin.ResumeLayout(false);
            this.GrbNhapThongTin.PerformLayout();
            this.GrbChucNang.ResumeLayout(false);
            this.GrbChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLop;
        private System.Windows.Forms.Panel PnlNoiDung;
        private System.Windows.Forms.DataGridView DgvDuLieu;
        private System.Windows.Forms.GroupBox GrbNhapThongTin;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblTenKhoa;
        private System.Windows.Forms.TextBox TxtTenKhoa;
        private System.Windows.Forms.GroupBox GrbChucNang;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button BtnLamMoi;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.TextBox TxtTimKiem;
        private System.Windows.Forms.Button BtnTimKiem;
        private System.Windows.Forms.Button PnlTieuDe;
        private System.Windows.Forms.Label LblDiaDiem;
        private System.Windows.Forms.TextBox TxtDiaDiem;
        private System.Windows.Forms.Label LblDienThoai;
        private System.Windows.Forms.TextBox TxtDienThoai;
    }
}