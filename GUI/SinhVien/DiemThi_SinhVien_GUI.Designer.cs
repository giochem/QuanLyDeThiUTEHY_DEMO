namespace GUI.SinhVien
{
    partial class DiemThi_SinhVien_GUI
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
            this.LblDiem = new System.Windows.Forms.Button();
            this.LblTieuDe = new System.Windows.Forms.Button();
            this.BtnThoat = new System.Windows.Forms.Button();
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
            this.PnlNoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlNoiDung.Name = "PnlNoiDung";
            this.PnlNoiDung.Size = new System.Drawing.Size(976, 436);
            this.PnlNoiDung.TabIndex = 8;
            // 
            // GrbChucNang
            // 
            this.GrbChucNang.BackColor = System.Drawing.Color.White;
            this.GrbChucNang.Controls.Add(this.BtnThoat);
            this.GrbChucNang.Controls.Add(this.LblDiem);
            this.GrbChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrbChucNang.Location = new System.Drawing.Point(0, 85);
            this.GrbChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrbChucNang.Name = "GrbChucNang";
            this.GrbChucNang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrbChucNang.Size = new System.Drawing.Size(976, 351);
            this.GrbChucNang.TabIndex = 6;
            this.GrbChucNang.TabStop = false;
            this.GrbChucNang.Text = "Chức năng";
            // 
            // LblDiem
            // 
            this.LblDiem.Location = new System.Drawing.Point(288, 38);
            this.LblDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LblDiem.Name = "LblDiem";
            this.LblDiem.Size = new System.Drawing.Size(417, 100);
            this.LblDiem.TabIndex = 1;
            this.LblDiem.Text = "Điểm 0/0";
            this.LblDiem.UseVisualStyleBackColor = true;
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
            this.LblTieuDe.Size = new System.Drawing.Size(976, 85);
            this.LblTieuDe.TabIndex = 0;
            this.LblTieuDe.TabStop = false;
            this.LblTieuDe.Text = "TRANG CHỦ SINH VIÊN";
            this.LblTieuDe.UseVisualStyleBackColor = false;
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(396, 189);
            this.BtnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(149, 100);
            this.BtnThoat.TabIndex = 7;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // DiemThi_SinhVien_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 436);
            this.Controls.Add(this.PnlNoiDung);
            this.Name = "DiemThi_SinhVien_GUI";
            this.Text = "DiemThi_SinhVien_GUI";
            this.PnlNoiDung.ResumeLayout(false);
            this.GrbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlNoiDung;
        private System.Windows.Forms.GroupBox GrbChucNang;
        private System.Windows.Forms.Button LblDiem;
        private System.Windows.Forms.Button LblTieuDe;
        private System.Windows.Forms.Button BtnThoat;
    }
}