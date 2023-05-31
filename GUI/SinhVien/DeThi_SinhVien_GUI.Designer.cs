namespace GUI.SinhVien
{
    partial class DeThi_SinhVien_GUI
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
            this.components = new System.ComponentModel.Container();
            this.LblTieuDe = new System.Windows.Forms.Button();
            this.PnlNoiDung = new System.Windows.Forms.Panel();
            this.GrbChucNang = new System.Windows.Forms.GroupBox();
            this.PnlCauHoi = new System.Windows.Forms.Panel();
            this.PnlDapAn = new System.Windows.Forms.Panel();
            this.LblTimer = new System.Windows.Forms.Label();
            this.Rdb4 = new System.Windows.Forms.RadioButton();
            this.Rdb3 = new System.Windows.Forms.RadioButton();
            this.Rdb2 = new System.Windows.Forms.RadioButton();
            this.Rdb1 = new System.Windows.Forms.RadioButton();
            this.LblCauHoi = new System.Windows.Forms.Button();
            this.ClbCauHoi = new System.Windows.Forms.CheckedListBox();
            this.PnlNoiDungCauHoi = new System.Windows.Forms.Panel();
            this.BtnNopBai = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LblPhut = new System.Windows.Forms.Label();
            this.LblTemp = new System.Windows.Forms.Label();
            this.PnlNoiDung.SuspendLayout();
            this.GrbChucNang.SuspendLayout();
            this.PnlCauHoi.SuspendLayout();
            this.PnlDapAn.SuspendLayout();
            this.PnlNoiDungCauHoi.SuspendLayout();
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
            this.LblTieuDe.Size = new System.Drawing.Size(1924, 85);
            this.LblTieuDe.TabIndex = 0;
            this.LblTieuDe.TabStop = false;
            this.LblTieuDe.Text = "ĐỀ THI";
            this.LblTieuDe.UseVisualStyleBackColor = false;
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
            this.PnlNoiDung.Size = new System.Drawing.Size(1924, 804);
            this.PnlNoiDung.TabIndex = 9;
            // 
            // GrbChucNang
            // 
            this.GrbChucNang.BackColor = System.Drawing.Color.White;
            this.GrbChucNang.Controls.Add(this.PnlCauHoi);
            this.GrbChucNang.Controls.Add(this.PnlNoiDungCauHoi);
            this.GrbChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrbChucNang.Location = new System.Drawing.Point(0, 85);
            this.GrbChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrbChucNang.Name = "GrbChucNang";
            this.GrbChucNang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GrbChucNang.Size = new System.Drawing.Size(1924, 719);
            this.GrbChucNang.TabIndex = 6;
            this.GrbChucNang.TabStop = false;
            this.GrbChucNang.Text = "Chức năng sinh viên";
            // 
            // PnlCauHoi
            // 
            this.PnlCauHoi.Controls.Add(this.PnlDapAn);
            this.PnlCauHoi.Controls.Add(this.ClbCauHoi);
            this.PnlCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCauHoi.Location = new System.Drawing.Point(3, 17);
            this.PnlCauHoi.Margin = new System.Windows.Forms.Padding(4);
            this.PnlCauHoi.Name = "PnlCauHoi";
            this.PnlCauHoi.Size = new System.Drawing.Size(1918, 577);
            this.PnlCauHoi.TabIndex = 1;
            // 
            // PnlDapAn
            // 
            this.PnlDapAn.Controls.Add(this.LblTemp);
            this.PnlDapAn.Controls.Add(this.LblPhut);
            this.PnlDapAn.Controls.Add(this.LblTimer);
            this.PnlDapAn.Controls.Add(this.Rdb4);
            this.PnlDapAn.Controls.Add(this.Rdb3);
            this.PnlDapAn.Controls.Add(this.Rdb2);
            this.PnlDapAn.Controls.Add(this.Rdb1);
            this.PnlDapAn.Controls.Add(this.LblCauHoi);
            this.PnlDapAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDapAn.Location = new System.Drawing.Point(176, 0);
            this.PnlDapAn.Margin = new System.Windows.Forms.Padding(4);
            this.PnlDapAn.Name = "PnlDapAn";
            this.PnlDapAn.Size = new System.Drawing.Size(1742, 577);
            this.PnlDapAn.TabIndex = 1;
            // 
            // LblTimer
            // 
            this.LblTimer.AutoSize = true;
            this.LblTimer.Location = new System.Drawing.Point(924, 51);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Size = new System.Drawing.Size(42, 16);
            this.LblTimer.TabIndex = 5;
            this.LblTimer.Text = "Timer";
            // 
            // Rdb4
            // 
            this.Rdb4.AutoSize = true;
            this.Rdb4.Location = new System.Drawing.Point(112, 339);
            this.Rdb4.Name = "Rdb4";
            this.Rdb4.Size = new System.Drawing.Size(103, 20);
            this.Rdb4.TabIndex = 4;
            this.Rdb4.TabStop = true;
            this.Rdb4.Text = "radioButton4";
            this.Rdb4.UseVisualStyleBackColor = true;
            this.Rdb4.CheckedChanged += new System.EventHandler(this.Rdb4_CheckedChanged);
            // 
            // Rdb3
            // 
            this.Rdb3.AutoSize = true;
            this.Rdb3.Location = new System.Drawing.Point(112, 291);
            this.Rdb3.Name = "Rdb3";
            this.Rdb3.Size = new System.Drawing.Size(103, 20);
            this.Rdb3.TabIndex = 3;
            this.Rdb3.TabStop = true;
            this.Rdb3.Text = "radioButton3";
            this.Rdb3.UseVisualStyleBackColor = true;
            this.Rdb3.CheckedChanged += new System.EventHandler(this.Rdb3_CheckedChanged);
            // 
            // Rdb2
            // 
            this.Rdb2.AutoSize = true;
            this.Rdb2.Location = new System.Drawing.Point(112, 238);
            this.Rdb2.Name = "Rdb2";
            this.Rdb2.Size = new System.Drawing.Size(103, 20);
            this.Rdb2.TabIndex = 2;
            this.Rdb2.TabStop = true;
            this.Rdb2.Text = "radioButton2";
            this.Rdb2.UseVisualStyleBackColor = true;
            this.Rdb2.CheckedChanged += new System.EventHandler(this.Rdb2_CheckedChanged);
            // 
            // Rdb1
            // 
            this.Rdb1.AutoSize = true;
            this.Rdb1.Location = new System.Drawing.Point(112, 185);
            this.Rdb1.Name = "Rdb1";
            this.Rdb1.Size = new System.Drawing.Size(103, 20);
            this.Rdb1.TabIndex = 1;
            this.Rdb1.TabStop = true;
            this.Rdb1.Text = "radioButton1";
            this.Rdb1.UseVisualStyleBackColor = true;
            this.Rdb1.CheckedChanged += new System.EventHandler(this.Rdb1_CheckedChanged);
            // 
            // LblCauHoi
            // 
            this.LblCauHoi.Location = new System.Drawing.Point(71, 13);
            this.LblCauHoi.Name = "LblCauHoi";
            this.LblCauHoi.Size = new System.Drawing.Size(399, 104);
            this.LblCauHoi.TabIndex = 0;
            this.LblCauHoi.Text = "câu hỏi";
            this.LblCauHoi.UseVisualStyleBackColor = true;
            // 
            // ClbCauHoi
            // 
            this.ClbCauHoi.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClbCauHoi.FormattingEnabled = true;
            this.ClbCauHoi.Location = new System.Drawing.Point(0, 0);
            this.ClbCauHoi.Margin = new System.Windows.Forms.Padding(4);
            this.ClbCauHoi.Name = "ClbCauHoi";
            this.ClbCauHoi.Size = new System.Drawing.Size(176, 577);
            this.ClbCauHoi.TabIndex = 0;
            this.ClbCauHoi.SelectedIndexChanged += new System.EventHandler(this.ClbCauHoi_SelectedIndexChanged);
            // 
            // PnlNoiDungCauHoi
            // 
            this.PnlNoiDungCauHoi.Controls.Add(this.BtnNopBai);
            this.PnlNoiDungCauHoi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlNoiDungCauHoi.Location = new System.Drawing.Point(3, 594);
            this.PnlNoiDungCauHoi.Margin = new System.Windows.Forms.Padding(4);
            this.PnlNoiDungCauHoi.Name = "PnlNoiDungCauHoi";
            this.PnlNoiDungCauHoi.Size = new System.Drawing.Size(1918, 123);
            this.PnlNoiDungCauHoi.TabIndex = 0;
            // 
            // BtnNopBai
            // 
            this.BtnNopBai.Location = new System.Drawing.Point(176, 37);
            this.BtnNopBai.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNopBai.Name = "BtnNopBai";
            this.BtnNopBai.Size = new System.Drawing.Size(329, 52);
            this.BtnNopBai.TabIndex = 0;
            this.BtnNopBai.Text = "Nộp bài";
            this.BtnNopBai.UseVisualStyleBackColor = true;
            this.BtnNopBai.Click += new System.EventHandler(this.BtnNopBai_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LblPhut
            // 
            this.LblPhut.AutoSize = true;
            this.LblPhut.Location = new System.Drawing.Point(988, 51);
            this.LblPhut.Name = "LblPhut";
            this.LblPhut.Size = new System.Drawing.Size(42, 16);
            this.LblPhut.TabIndex = 6;
            this.LblPhut.Text = "Timer";
            // 
            // LblTemp
            // 
            this.LblTemp.AutoSize = true;
            this.LblTemp.Location = new System.Drawing.Point(972, 51);
            this.LblTemp.Name = "LblTemp";
            this.LblTemp.Size = new System.Drawing.Size(10, 16);
            this.LblTemp.TabIndex = 7;
            this.LblTemp.Text = ":";
            // 
            // DeThi_SinhVien_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 804);
            this.Controls.Add(this.PnlNoiDung);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeThi_SinhVien_GUI";
            this.Text = "DeThi_SinhVien_GUI";
            this.Load += new System.EventHandler(this.DeThi_SinhVien_GUI_Load);
            this.PnlNoiDung.ResumeLayout(false);
            this.GrbChucNang.ResumeLayout(false);
            this.PnlCauHoi.ResumeLayout(false);
            this.PnlDapAn.ResumeLayout(false);
            this.PnlDapAn.PerformLayout();
            this.PnlNoiDungCauHoi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LblTieuDe;
        private System.Windows.Forms.Panel PnlNoiDung;
        private System.Windows.Forms.GroupBox GrbChucNang;
        private System.Windows.Forms.Panel PnlCauHoi;
        private System.Windows.Forms.Panel PnlDapAn;
        private System.Windows.Forms.CheckedListBox ClbCauHoi;
        private System.Windows.Forms.Panel PnlNoiDungCauHoi;
        private System.Windows.Forms.Button BtnNopBai;
        private System.Windows.Forms.RadioButton Rdb4;
        private System.Windows.Forms.RadioButton Rdb3;
        private System.Windows.Forms.RadioButton Rdb2;
        private System.Windows.Forms.RadioButton Rdb1;
        private System.Windows.Forms.Button LblCauHoi;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LblTimer;
        private System.Windows.Forms.Label LblPhut;
        private System.Windows.Forms.Label LblTemp;
    }
}