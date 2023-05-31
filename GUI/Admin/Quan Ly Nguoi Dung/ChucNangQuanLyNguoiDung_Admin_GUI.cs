using System;
using System.Windows.Forms;

namespace GUI.Admin.QuanLyNguoiDung
{
    public partial class ChucNangQuanLyNguoiDung_Admin_GUI : Form
    {
        public ChucNangQuanLyNguoiDung_Admin_GUI ( )
        {
            InitializeComponent();
        }

        private void BtnSinhVien_Click ( object sender, EventArgs e )
        {
            QuanLySinhVien_Admin_GUI chuyenForm = new QuanLySinhVien_Admin_GUI();
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }

        private void BtnAdmin_Click ( object sender, EventArgs e )
        {
            QuanLyAdmin_Admin_GUI chuyenForm = new QuanLyAdmin_Admin_GUI();
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }

        private void BtnThoat_Click ( object sender, EventArgs e )
        {
            TrangChu_Admin_GUI chuyenForm = new TrangChu_Admin_GUI();
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }
    }
}
