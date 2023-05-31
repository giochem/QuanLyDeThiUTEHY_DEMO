namespace GUI.SinhVien
{
    partial class Thi_SinhVien_GUI
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
            this.BtnThoat = new System.Windows.Forms.Button();
            this.PnlNoiDung = new System.Windows.Forms.Panel();
            this.GrbChucNang = new System.Windows.Forms.GroupBox();
            this.LblDeThi = new System.Windows.Forms.Label();
            this.BtnBatDau = new System.Windows.Forms.Button();
            this.CbbMonHoc = new System.Windows.Forms.ComboBox();
            this.LblThoiGian = new System.Windows.Forms.Label();
            this.LblSoCauHoi = new System.Windows.Forms.Label();
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
            this.LblTieuDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LblTieuDe.Name = "LblTieuDe";
            this.LblTieuDe.Size = new System.Drawing.Size(1067, 85);
            this.LblTieuDe.TabIndex = 0;
            this.LblTieuDe.TabStop = false;
            this.LblTieuDe.Text = "TRANG CHỦ SINH VIÊN";
            this.LblTieuDe.UseVisualStyleBackColor = false;
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(319, 342);
            this.BtnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(223, 100);
            this.BtnThoat.TabIndex = 7;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // PnlNoiDung
            // 
            this.PnlNoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PnlNoiDung.Controls.Add(this.GrbChucNang);
            this.PnlNoiDung.Controls.Add(this.LblTieuDe);
            this.PnlNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlNoiDung.Location = new System.Drawing.Point(0, 0);
            this.PnlNoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlNoiDung.Name = "PnlNoiDung";
            this.PnlNoiDung.Size = new System.Drawing.Size(1067, 554);
            this.PnlNoiDung.TabIndex = 8;
            // 
            // GrbChucNang
            // 
            this.GrbChucNang.BackColor = System.Drawing.Color.White;
            this.GrbChucNang.Controls.Add(this.LblSoCauHoi);
            this.GrbChucNang.Controls.Add(this.LblThoiGian);
            this.GrbChucNang.Controls.Add(this.LblDeThi);
            this.GrbChucNang.Controls.Add(this.BtnBatDau);
            this.GrbChucNang.Controls.Add(this.CbbMonHoc);
            this.GrbChucNang.Controls.Add(this.BtnThoat);
            this.GrbChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrbChucNang.Location = new System.Drawing.Point(0, 85);
            this.GrbChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrbChucNang.Name = "GrbChucNang";
            this.GrbChucNang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrbChucNang.Size = new System.Drawing.Size(1067, 469);
            this.GrbChucNang.TabIndex = 6;
            this.GrbChucNang.TabStop = false;
            this.GrbChucNang.Text = "Chức năng sinh viên";
            // 
            // LblDeThi
            // 
            this.LblDeThi.AutoSize = true;
            this.LblDeThi.Location = new System.Drawing.Point(315, 97);
            this.LblDeThi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDeThi.Name = "LblDeThi";
            this.LblDeThi.Size = new System.Drawing.Size(39, 16);
            this.LblDeThi.TabIndex = 10;
            this.LblDeThi.Text = "đề thi";
            // 
            // BtnBatDau
            // 
            this.BtnBatDau.Location = new System.Drawing.Point(319, 247);
            this.BtnBatDau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBatDau.Name = "BtnBatDau";
            this.BtnBatDau.Size = new System.Drawing.Size(223, 69);
            this.BtnBatDau.TabIndex = 9;
            this.BtnBatDau.Text = "Vào thi";
            this.BtnBatDau.UseVisualStyleBackColor = true;
            this.BtnBatDau.Click += new System.EventHandler(this.BtnBatDau_Click);
            // 
            // CbbMonHoc
            // 
            this.CbbMonHoc.FormattingEnabled = true;
            this.CbbMonHoc.Location = new System.Drawing.Point(319, 38);
            this.CbbMonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbbMonHoc.Name = "CbbMonHoc";
            this.CbbMonHoc.Size = new System.Drawing.Size(221, 24);
            this.CbbMonHoc.TabIndex = 8;
            this.CbbMonHoc.SelectedIndexChanged += new System.EventHandler(this.CbbMonHoc_SelectedIndexChanged);
            // 
            // LblThoiGian
            // 
            this.LblThoiGian.AutoSize = true;
            this.LblThoiGian.Location = new System.Drawing.Point(316, 175);
            this.LblThoiGian.Name = "LblThoiGian";
            this.LblThoiGian.Size = new System.Drawing.Size(57, 16);
            this.LblThoiGian.TabIndex = 11;
            this.LblThoiGian.Text = "thời gian";
            // 
            // LblSoCauHoi
            // 
            this.LblSoCauHoi.AutoSize = true;
            this.LblSoCauHoi.Location = new System.Drawing.Point(316, 138);
            this.LblSoCauHoi.Name = "LblSoCauHoi";
            this.LblSoCauHoi.Size = new System.Drawing.Size(68, 16);
            this.LblSoCauHoi.TabIndex = 12;
            this.LblSoCauHoi.Text = "số câu hỏi";
            // 
            // Thi_SinhVien_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PnlNoiDung);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Thi_SinhVien_GUI";
            this.Text = "Thi_SinhVien_GUI";
            this.Load += new System.EventHandler(this.Thi_SinhVien_GUI_Load);
            this.PnlNoiDung.ResumeLayout(false);
            this.GrbChucNang.ResumeLayout(false);
            this.GrbChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LblTieuDe;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Panel PnlNoiDung;
        private System.Windows.Forms.GroupBox GrbChucNang;
        private System.Windows.Forms.Label LblDeThi;
        private System.Windows.Forms.Button BtnBatDau;
        private System.Windows.Forms.ComboBox CbbMonHoc;
        private System.Windows.Forms.Label LblSoCauHoi;
        private System.Windows.Forms.Label LblThoiGian;
    }
}