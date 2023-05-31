using DTO;
using GUI.Main;
using System;
using System.Windows.Forms;

namespace GUI.SinhVien
{
    public partial class TrangChuNguoiDung_GUI : Form
    {
        readonly NguoiDung_DTO _nguoiDung_DTO = new NguoiDung_DTO();
        public TrangChuNguoiDung_GUI ( NguoiDung_DTO nguoiDung_DTO )
        {
            InitializeComponent();
            _nguoiDung_DTO = nguoiDung_DTO;
        }
        private void BtnThi_Click ( object sender, EventArgs e )
        {
            Thi_SinhVien_GUI chuyenForm = new Thi_SinhVien_GUI( _nguoiDung_DTO );
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }

        private void BtnThoat_Click ( object sender, EventArgs e )
        {
            DangNhap_GUI chuyenForm = new DangNhap_GUI();
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }
    }
}
