namespace GUI.Admin
{
    partial class QuanLyChiTietDeThi_Admin_GUI
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
            this.TxtTimKiem = new System.Windows.Forms.TextBox();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.BtnTimKiem = new System.Windows.Forms.Button();
            this.PnlNoiDung = new System.Windows.Forms.Panel();
            this.DgvDuLieu = new System.Windows.Forms.DataGridView();
            this.GrbChucNang = new System.Windows.Forms.GroupBox();
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
            this.PnlTieuDe.Text = "QUẢN LÝ CHI TIẾT ĐỀ THI";
            this.PnlTieuDe.UseVisualStyleBackColor = false;
            // 
            // TxtTimKiem
            // 
            this.TxtTimKiem.Location = new System.Drawing.Point(103, 21);
            this.TxtTimKiem.Name = "TxtTimKiem";
            this.TxtTimKiem.Size = new System.Drawing.Size(113, 22);
            this.TxtTimKiem.TabIndex = 1;
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(457, 27);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(120, 80);
            this.BtnThoat.TabIndex = 6;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
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
            // PnlNoiDung
            // 
            this.PnlNoiDung.Controls.Add(this.DgvDuLieu);
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
            this.DgvDuLieu.Location = new System.Drawing.Point(0, 80);
            this.DgvDuLieu.Name = "DgvDuLieu";
            this.DgvDuLieu.RowHeadersWidth = 51;
            this.DgvDuLieu.RowTemplate.Height = 24;
            this.DgvDuLieu.Size = new System.Drawing.Size(1582, 450);
            this.DgvDuLieu.TabIndex = 3;
            // 
            // GrbChucNang
            // 
            this.GrbChucNang.Controls.Add(this.BtnThoat);
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
            // QuanLyChiTietDeThi_Admin_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 653);
            this.Controls.Add(this.PnlNoiDung);
            this.Name = "QuanLyChiTietDeThi_Admin_GUI";
            this.Text = "QuanLyChiTietDeThi_Admin_GUI";
            this.Load += new System.EventHandler(this.QuanLyChiTietDeThi_Admin_GUI_Load);
            this.PnlNoiDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDuLieu)).EndInit();
            this.GrbChucNang.ResumeLayout(false);
            this.GrbChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PnlTieuDe;
        private System.Windows.Forms.TextBox TxtTimKiem;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button BtnTimKiem;
        private System.Windows.Forms.Panel PnlNoiDung;
        private System.Windows.Forms.DataGridView DgvDuLieu;
        private System.Windows.Forms.GroupBox GrbChucNang;
    }
}