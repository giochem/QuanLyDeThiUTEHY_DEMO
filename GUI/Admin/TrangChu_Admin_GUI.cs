using GUI.Admin.QuanLyLop;
using GUI.Admin.QuanLyNguoiDung;
using GUI.Main;
using System;
using System.Windows.Forms;

namespace GUI.Admin
{
    public partial class TrangChu_Admin_GUI : Form
    {
        public TrangChu_Admin_GUI ( )
        {
            InitializeComponent();
        }

        private void BtnNguoiDung_Click ( object sender, EventArgs e )
        {
            ChucNangQuanLyNguoiDung_Admin_GUI chuyenForm = new ChucNangQuanLyNguoiDung_Admin_GUI();
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }

        private void BtnBaoCaoThongKe_Click ( object sender, EventArgs e )
        {
            BaoCaoThongKe_Admin_GUI chuynForm = new BaoCaoThongKe_Admin_GUI();
            Hide();
            chuynForm.ShowDialog();
            Close();
        }

        private void BtnMonHoc_Click ( object sender, EventArgs e )
        {
            QuanLyMonHoc_Admin_GUI chuyenForm = new QuanLyMonHoc_Admin_GUI();
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }

        private void BtnCauHoi_Click ( object sender, EventArgs e )
        {
            QuanLyCauHoi_Admin_GUI chuynForm = new QuanLyCauHoi_Admin_GUI();
            Hide();
            chuynForm.ShowDialog();
            Close();
        }

        private void BtnDeThi_Click ( object sender, EventArgs e )
        {
            QuanLyDeThi_Admin_GUI chuynForm = new QuanLyDeThi_Admin_GUI();
            Hide();
            chuynForm.ShowDialog();
            Close();
        }

        private void BtnThoat_Click ( object sender, EventArgs e )
        {
            DangNhap_GUI chuynForm = new DangNhap_GUI();
            Hide();
            chuynForm.ShowDialog();
            Close();
        }

        private void BtnLop_Click ( object sender, EventArgs e )
        {
            QuanLyKhoa_Admin_GUI chuyenForm = new QuanLyKhoa_Admin_GUI();
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }
    }
}
