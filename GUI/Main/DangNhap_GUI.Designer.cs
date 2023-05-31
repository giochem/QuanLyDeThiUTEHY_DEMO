namespace GUI.Main
{
    partial class DangNhap_GUI
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
            this.LblNoiDung = new System.Windows.Forms.Panel();
            this.GrbNhapDuLieu = new System.Windows.Forms.GroupBox();
            this.CbbVaiTro = new System.Windows.Forms.ComboBox();
            this.BtnDangNhap = new System.Windows.Forms.Button();
            this.TxtMatKhau = new System.Windows.Forms.TextBox();
            this.LblMatKhau = new System.Windows.Forms.Label();
            this.TxtTaiKhoan = new System.Windows.Forms.TextBox();
            this.LblTaiKhoan = new System.Windows.Forms.Label();
            this.LblTieuDe = new System.Windows.Forms.Button();
            this.PtbLogo = new System.Windows.Forms.PictureBox();
            this.LblNoiDung.SuspendLayout();
            this.GrbNhapDuLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNoiDung
            // 
            this.LblNoiDung.Controls.Add(this.GrbNhapDuLieu);
            this.LblNoiDung.Controls.Add(this.LblTieuDe);
            this.LblNoiDung.Controls.Add(this.PtbLogo);
            this.LblNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblNoiDung.Location = new System.Drawing.Point(0, 0);
            this.LblNoiDung.Name = "LblNoiDung";
            this.LblNoiDung.Size = new System.Drawing.Size(882, 453);
            this.LblNoiDung.TabIndex = 1;
            // 
            // GrbNhapDuLieu
            // 
            this.GrbNhapDuLieu.BackColor = System.Drawing.Color.White;
            this.GrbNhapDuLieu.Controls.Add(this.CbbVaiTro);
            this.GrbNhapDuLieu.Controls.Add(this.BtnDangNhap);
            this.GrbNhapDuLieu.Controls.Add(this.TxtMatKhau);
            this.GrbNhapDuLieu.Controls.Add(this.LblMatKhau);
            this.GrbNhapDuLieu.Controls.Add(this.TxtTaiKhoan);
            this.GrbNhapDuLieu.Controls.Add(this.LblTaiKhoan);
            this.GrbNhapDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrbNhapDuLieu.Location = new System.Drawing.Point(318, 119);
            this.GrbNhapDuLieu.Name = "GrbNhapDuLieu";
            this.GrbNhapDuLieu.Size = new System.Drawing.Size(564, 334);
            this.GrbNhapDuLieu.TabIndex = 2;
            this.GrbNhapDuLieu.TabStop = false;
            this.GrbNhapDuLieu.Text = "Dữ liệu đăng nhập";
            // 
            // CbbVaiTro
            // 
            this.CbbVaiTro.BackColor = System.Drawing.Color.White;
            this.CbbVaiTro.FormattingEnabled = true;
            this.CbbVaiTro.Items.AddRange(new object[] {
            "SinhVien",
            "admin"});
            this.CbbVaiTro.Location = new System.Drawing.Point(120, 39);
            this.CbbVaiTro.Name = "CbbVaiTro";
            this.CbbVaiTro.Size = new System.Drawing.Size(229, 24);
            this.CbbVaiTro.TabIndex = 0;
            this.CbbVaiTro.Text = "SinhVien";
            // 
            // BtnDangNhap
            // 
            this.BtnDangNhap.Location = new System.Drawing.Point(120, 242);
            this.BtnDangNhap.Name = "BtnDangNhap";
            this.BtnDangNhap.Size = new System.Drawing.Size(229, 70);
            this.BtnDangNhap.TabIndex = 3;
            this.BtnDangNhap.Text = "Đăng nhập";
            this.BtnDangNhap.UseVisualStyleBackColor = true;
            this.BtnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // TxtMatKhau
            // 
            this.TxtMatKhau.Location = new System.Drawing.Point(120, 196);
            this.TxtMatKhau.Name = "TxtMatKhau";
            this.TxtMatKhau.Size = new System.Drawing.Size(229, 22);
            this.TxtMatKhau.TabIndex = 2;
            // 
            // LblMatKhau
            // 
            this.LblMatKhau.AutoSize = true;
            this.LblMatKhau.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblMatKhau.Location = new System.Drawing.Point(117, 160);
            this.LblMatKhau.Name = "LblMatKhau";
            this.LblMatKhau.Size = new System.Drawing.Size(61, 16);
            this.LblMatKhau.TabIndex = 2;
            this.LblMatKhau.Text = "Mật khẩu";
            // 
            // TxtTaiKhoan
            // 
            this.TxtTaiKhoan.Location = new System.Drawing.Point(120, 119);
            this.TxtTaiKhoan.Name = "TxtTaiKhoan";
            this.TxtTaiKhoan.Size = new System.Drawing.Size(229, 22);
            this.TxtTaiKhoan.TabIndex = 1;
            // 
            // LblTaiKhoan
            // 
            this.LblTaiKhoan.AutoSize = true;
            this.LblTaiKhoan.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblTaiKhoan.Location = new System.Drawing.Point(117, 89);
            this.LblTaiKhoan.Name = "LblTaiKhoan";
            this.LblTaiKhoan.Size = new System.Drawing.Size(98, 16);
            this.LblTaiKhoan.TabIndex = 1;
            this.LblTaiKhoan.Text = "Tên đăng nhập";
            // 
            // LblTieuDe
            // 
            this.LblTieuDe.BackColor = System.Drawing.Color.White;
            this.LblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTieuDe.FlatAppearance.BorderSize = 0;
            this.LblTieuDe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.LblTieuDe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.LblTieuDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTieuDe.Location = new System.Drawing.Point(318, 0);
            this.LblTieuDe.Name = "LblTieuDe";
            this.LblTieuDe.Size = new System.Drawing.Size(564, 119);
            this.LblTieuDe.TabIndex = 4;
            this.LblTieuDe.TabStop = false;
            this.LblTieuDe.Text = "PHẦN MỀM ĐỀ THI TRẮC NGHIỆM";
            this.LblTieuDe.UseVisualStyleBackColor = false;
            // 
            // PtbLogo
            // 
            this.PtbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PtbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PtbLogo.Image = global::GUI.Properties.Resources.logo_truong;
            this.PtbLogo.Location = new System.Drawing.Point(0, 0);
            this.PtbLogo.Name = "PtbLogo";
            this.PtbLogo.Size = new System.Drawing.Size(318, 453);
            this.PtbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PtbLogo.TabIndex = 0;
            this.PtbLogo.TabStop = false;
            // 
            // DangNhap_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.LblNoiDung);
            this.Name = "DangNhap_GUI";
            this.Text = "DangNhap_GUI";
            this.LblNoiDung.ResumeLayout(false);
            this.LblNoiDung.PerformLayout();
            this.GrbNhapDuLieu.ResumeLayout(false);
            this.GrbNhapDuLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LblNoiDung;
        private System.Windows.Forms.GroupBox GrbNhapDuLieu;
        private System.Windows.Forms.Button LblTieuDe;
        private System.Windows.Forms.PictureBox PtbLogo;
        private System.Windows.Forms.TextBox TxtTaiKhoan;
        private System.Windows.Forms.Label LblTaiKhoan;
        private System.Windows.Forms.ComboBox CbbVaiTro;
        private System.Windows.Forms.Button BtnDangNhap;
        private System.Windows.Forms.TextBox TxtMatKhau;
        private System.Windows.Forms.Label LblMatKhau;
    }
}