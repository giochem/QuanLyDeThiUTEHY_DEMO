using BUS;
using DTO;
using GUI.Admin;
using GUI.SinhVien;
using System;
using System.Windows.Forms;
namespace GUI.Main
{
    public partial class DangNhap_GUI : Form
    {
        readonly NguoiDung_BUS _nguoiDung_BUS = new NguoiDung_BUS();
        NguoiDung_DTO _nguoiDung_DTO = new NguoiDung_DTO();
        public DangNhap_GUI ( )
        {
            InitializeComponent();
        }

        private void BtnDangNhap_Click ( object sender, EventArgs e )
        {
            KetQuaTruyVan nguoiDung = _nguoiDung_BUS.DangNhap( new NguoiDung_DTO { TaiKhoan = TxtTaiKhoan.Text, MatKhau = TxtMatKhau.Text, VaiTro = CbbVaiTro.Text } );
            if ( nguoiDung.ThanhCong )
            {
                string vaiTro = nguoiDung.DuLieu.Tables[ "NguoiDung" ].Rows[ 0 ][ "VaiTro" ].ToString();
                if ( vaiTro != CbbVaiTro.Text )
                {
                    MessageBox.Show( "Vui lòng chọn đúng vai trò" );
                }
                else
                {
                    Hide();

                    if ( vaiTro == "admin" )
                    {
                        TrangChu_Admin_GUI chuyenForm = new TrangChu_Admin_GUI();
                        chuyenForm.ShowDialog();
                        Close();
                    }
                    if ( vaiTro == "SinhVien" )
                    {
                        TrangChuNguoiDung_GUI trangNguoiDun = new TrangChuNguoiDung_GUI( new NguoiDung_DTO { ID = (int) nguoiDung.DuLieu.Tables[ "NguoiDung" ].Rows[ 0 ][ "ID" ] } );
                        Hide();
                        trangNguoiDun.ShowDialog();
                        Close();
                    }
                    Close();
                }
            }
            else
            {
                MessageBox.Show( nguoiDung.LoiNhan );
            }

        }


    }
}
