namespace GUI.Admin.QuanLyNguoiDung
{
    partial class QuanLySinhVien_Admin_GUI
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
            this.BtnThem = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LblID = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblMatKhau = new System.Windows.Forms.Label();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.BtnLamMoi = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.TxtMatKhau = new System.Windows.Forms.TextBox();
            this.LblTaiKhoan = new System.Windows.Forms.Label();
            this.TxtTaiKhoan = new System.Windows.Forms.TextBox();
            this.BtnTimKiem = new System.Windows.Forms.Button();
            this.GrbNhapThongTin = new System.Windows.Forms.GroupBox();
            this.LblLop = new System.Windows.Forms.Label();
            this.LblKhoa = new System.Windows.Forms.Label();
            this.CbbLop = new System.Windows.Forms.ComboBox();
            this.CbbKhoa = new System.Windows.Forms.ComboBox();
            this.PnlNoiDung = new System.Windows.Forms.Panel();
            this.DgvDuLieu = new System.Windows.Forms.DataGridView();
            this.GrbChucNang = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
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
            this.PnlTieuDe.Text = "QUẢN LÝ SINH VIÊN";
            this.PnlTieuDe.UseVisualStyleBackColor = false;
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(412, 27);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(120, 80);
            this.BtnThem.TabIndex = 2;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 22);
            this.textBox1.TabIndex = 1;
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
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(13, 222);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(41, 16);
            this.LblEmail.TabIndex = 7;
            this.LblEmail.Text = "Email";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(136, 222);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(100, 22);
            this.TxtEmail.TabIndex = 6;
            // 
            // LblMatKhau
            // 
            this.LblMatKhau.AutoSize = true;
            this.LblMatKhau.Location = new System.Drawing.Point(13, 163);
            this.LblMatKhau.Name = "LblMatKhau";
            this.LblMatKhau.Size = new System.Drawing.Size(61, 16);
            this.LblMatKhau.TabIndex = 3;
            this.LblMatKhau.Text = "Mật khẩu";
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(1317, 27);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(120, 80);
            this.BtnThoat.TabIndex = 6;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click_1);
            // 
            // BtnLamMoi
            // 
            this.BtnLamMoi.Location = new System.Drawing.Point(1121, 27);
            this.BtnLamMoi.Name = "BtnLamMoi";
            this.BtnLamMoi.Size = new System.Drawing.Size(120, 80);
            this.BtnLamMoi.TabIndex = 5;
            this.BtnLamMoi.Text = "Làm mới";
            this.BtnLamMoi.UseVisualStyleBackColor = true;
            this.BtnLamMoi.Click += new System.EventHandler(this.BtnLamMoi_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(870, 27);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(120, 80);
            this.BtnXoa.TabIndex = 4;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(653, 27);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(120, 80);
            this.BtnSua.TabIndex = 3;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // TxtMatKhau
            // 
            this.TxtMatKhau.Location = new System.Drawing.Point(136, 163);
            this.TxtMatKhau.Name = "TxtMatKhau";
            this.TxtMatKhau.Size = new System.Drawing.Size(100, 22);
            this.TxtMatKhau.TabIndex = 2;
            // 
            // LblTaiKhoan
            // 
            this.LblTaiKhoan.AutoSize = true;
            this.LblTaiKhoan.Location = new System.Drawing.Point(13, 103);
            this.LblTaiKhoan.Name = "LblTaiKhoan";
            this.LblTaiKhoan.Size = new System.Drawing.Size(67, 16);
            this.LblTaiKhoan.TabIndex = 1;
            this.LblTaiKhoan.Text = "Tài khoản";
            // 
            // TxtTaiKhoan
            // 
            this.TxtTaiKhoan.Location = new System.Drawing.Point(136, 103);
            this.TxtTaiKhoan.Name = "TxtTaiKhoan";
            this.TxtTaiKhoan.Size = new System.Drawing.Size(100, 22);
            this.TxtTaiKhoan.TabIndex = 0;
            // 
            // BtnTimKiem
            // 
            this.BtnTimKiem.Location = new System.Drawing.Point(211, 61);
            this.BtnTimKiem.Name = "BtnTimKiem";
            this.BtnTimKiem.Size = new System.Drawing.Size(113, 52);
            this.BtnTimKiem.TabIndex = 0;
            this.BtnTimKiem.Text = "Tìm kiếm";
            this.BtnTimKiem.UseVisualStyleBackColor = true;
            // 
            // GrbNhapThongTin
            // 
            this.GrbNhapThongTin.Controls.Add(this.LblLop);
            this.GrbNhapThongTin.Controls.Add(this.LblKhoa);
            this.GrbNhapThongTin.Controls.Add(this.CbbLop);
            this.GrbNhapThongTin.Controls.Add(this.CbbKhoa);
            this.GrbNhapThongTin.Controls.Add(this.LblID);
            this.GrbNhapThongTin.Controls.Add(this.TxtID);
            this.GrbNhapThongTin.Controls.Add(this.LblEmail);
            this.GrbNhapThongTin.Controls.Add(this.TxtEmail);
            this.GrbNhapThongTin.Controls.Add(this.LblMatKhau);
            this.GrbNhapThongTin.Controls.Add(this.TxtMatKhau);
            this.GrbNhapThongTin.Controls.Add(this.LblTaiKhoan);
            this.GrbNhapThongTin.Controls.Add(this.TxtTaiKhoan);
            this.GrbNhapThongTin.Dock = System.Windows.Forms.DockStyle.Left;
            this.GrbNhapThongTin.Location = new System.Drawing.Point(0, 80);
            this.GrbNhapThongTin.Name = "GrbNhapThongTin";
            this.GrbNhapThongTin.Size = new System.Drawing.Size(412, 450);
            this.GrbNhapThongTin.TabIndex = 2;
            this.GrbNhapThongTin.TabStop = false;
            this.GrbNhapThongTin.Text = "Nhập thông tin";
            // 
            // LblLop
            // 
            this.LblLop.AutoSize = true;
            this.LblLop.Location = new System.Drawing.Point(271, 126);
            this.LblLop.Name = "LblLop";
            this.LblLop.Size = new System.Drawing.Size(30, 16);
            this.LblLop.TabIndex = 15;
            this.LblLop.Text = "Lớp";
            // 
            // LblKhoa
            // 
            this.LblKhoa.AutoSize = true;
            this.LblKhoa.Location = new System.Drawing.Point(271, 65);
            this.LblKhoa.Name = "LblKhoa";
            this.LblKhoa.Size = new System.Drawing.Size(38, 16);
            this.LblKhoa.TabIndex = 14;
            this.LblKhoa.Text = "Khoa";
            // 
            // CbbLop
            // 
            this.CbbLop.FormattingEnabled = true;
            this.CbbLop.Location = new System.Drawing.Point(274, 154);
            this.CbbLop.Name = "CbbLop";
            this.CbbLop.Size = new System.Drawing.Size(121, 24);
            this.CbbLop.TabIndex = 13;
            // 
            // CbbKhoa
            // 
            this.CbbKhoa.FormattingEnabled = true;
            this.CbbKhoa.Location = new System.Drawing.Point(274, 95);
            this.CbbKhoa.Name = "CbbKhoa";
            this.CbbKhoa.Size = new System.Drawing.Size(121, 24);
            this.CbbKhoa.TabIndex = 12;
            this.CbbKhoa.SelectedIndexChanged += new System.EventHandler(this.CbbKhoa_SelectedIndexChanged);
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
            this.PnlNoiDung.TabIndex = 2;
            // 
            // DgvDuLieu
            // 
            this.DgvDuLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvDuLieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvDuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDuLieu.Location = new System.Drawing.Point(412, 80);
            this.DgvDuLieu.Name = "DgvDuLieu";
            this.DgvDuLieu.RowHeadersWidth = 51;
            this.DgvDuLieu.RowTemplate.Height = 24;
            this.DgvDuLieu.Size = new System.Drawing.Size(1170, 450);
            this.DgvDuLieu.TabIndex = 3;
            this.DgvDuLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDuLieu_CellClick);
            // 
            // GrbChucNang
            // 
            this.GrbChucNang.Controls.Add(this.comboBox1);
            this.GrbChucNang.Controls.Add(this.label1);
            this.GrbChucNang.Controls.Add(this.BtnThoat);
            this.GrbChucNang.Controls.Add(this.label2);
            this.GrbChucNang.Controls.Add(this.BtnLamMoi);
            this.GrbChucNang.Controls.Add(this.comboBox2);
            this.GrbChucNang.Controls.Add(this.BtnXoa);
            this.GrbChucNang.Controls.Add(this.BtnSua);
            this.GrbChucNang.Controls.Add(this.BtnThem);
            this.GrbChucNang.Controls.Add(this.textBox1);
            this.GrbChucNang.Controls.Add(this.BtnTimKiem);
            this.GrbChucNang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrbChucNang.Location = new System.Drawing.Point(0, 530);
            this.GrbChucNang.Name = "GrbChucNang";
            this.GrbChucNang.Size = new System.Drawing.Size(1582, 123);
            this.GrbChucNang.TabIndex = 1;
            this.GrbChucNang.TabStop = false;
            this.GrbChucNang.Text = "Chức năng";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Khoa";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(70, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 16;
            // 
            // QuanLySinhVien_Admin_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 653);
            this.Controls.Add(this.PnlNoiDung);
            this.Name = "QuanLySinhVien_Admin_GUI";
            this.Text = "QuanLySinhVien_Admin_GUI";
            this.Load += new System.EventHandler(this.QuanLySinhVien_Admin_GUI_Load);
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
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblMatKhau;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button BtnLamMoi;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.TextBox TxtMatKhau;
        private System.Windows.Forms.Label LblTaiKhoan;
        private System.Windows.Forms.TextBox TxtTaiKhoan;
        private System.Windows.Forms.Button BtnTimKiem;
        private System.Windows.Forms.GroupBox GrbNhapThongTin;
        private System.Windows.Forms.Label LblLop;
        private System.Windows.Forms.Label LblKhoa;
        private System.Windows.Forms.ComboBox CbbLop;
        private System.Windows.Forms.ComboBox CbbKhoa;
        private System.Windows.Forms.Panel PnlNoiDung;
        private System.Windows.Forms.DataGridView DgvDuLieu;
        private System.Windows.Forms.GroupBox GrbChucNang;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}