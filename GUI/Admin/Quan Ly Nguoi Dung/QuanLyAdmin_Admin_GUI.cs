using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI.Admin
{
    public partial class QuanLyAdmin_Admin_GUI : Form
    {
        readonly NguoiDung_BUS _nguoiDung_BUS = new NguoiDung_BUS();
        public QuanLyAdmin_Admin_GUI ( )
        {
            InitializeComponent();
        }

        private void QuanLyNguoiDung_Admin_GUI_Load ( object sender, EventArgs e )
        {
            DgvDuLieu.DataSource = _nguoiDung_BUS.TimToanBoAdmin().DuLieu.Tables[ 0 ];
        }

        private void BtnThoat_Click ( object sender, EventArgs e )
        {
            TrangChu_Admin_GUI chuyenForm = new TrangChu_Admin_GUI();
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }
        private bool KiemTraNguoiDung ( )
        {
            if ( TxtTaiKhoan.Text == "" || TxtMatKhau.Text == "" || TxtEmail.Text == "" || CbbVaiTro.Text == "" )
            {
                return false;
            }
            return true;
        }
        private void BtnThem_Click ( object sender, EventArgs e )
        {
            if ( KiemTraNguoiDung() )
            {
                KetQuaTruyVan ketQua = _nguoiDung_BUS.DangKy( new NguoiDung_DTO { TaiKhoan = TxtTaiKhoan.Text, MatKhau = TxtMatKhau.Text, Email = TxtEmail.Text, VaiTro = CbbVaiTro.Text } );
                MessageBox.Show( ketQua.LoiNhan );
            }
            else
            {
                MessageBox.Show( "Vui lòng nhập đầy đủ dữ liệu" );
            }
        }

        private void BtnLamMoi_Click ( object sender, EventArgs e )
        {
            DgvDuLieu.DataSource = _nguoiDung_BUS.TimToanBoAdmin().DuLieu.Tables[ 0 ];
            TxtID.Clear();
            TxtTaiKhoan.Clear();
            TxtMatKhau.Clear();
            TxtEmail.Clear();
        }

        private void BtnSua_Click ( object sender, EventArgs e )
        {
            if ( KiemTraNguoiDung() && Int32.TryParse( TxtID.Text, out int id ) )
            {
                KetQuaTruyVan ketQua = _nguoiDung_BUS.SuaNguoiDung( new NguoiDung_DTO { ID = id, TaiKhoan = TxtTaiKhoan.Text, MatKhau = TxtMatKhau.Text, Email = TxtEmail.Text, VaiTro = CbbVaiTro.Text } );
                MessageBox.Show( ketQua.LoiNhan );
            }
            else
            {
                MessageBox.Show( "Vui lòng nhập đầy đủ dữ liệu" );
            }
        }

        private void BtnXoa_Click ( object sender, EventArgs e )
        {
            if ( Int32.TryParse( TxtID.Text, out int id ) )
            {
                KetQuaTruyVan ketQua = _nguoiDung_BUS.XoaNguoiDung( new NguoiDung_DTO { ID = id } );
                MessageBox.Show( ketQua.LoiNhan );
            }
            else
            {
                MessageBox.Show( "Vui lòng nhập đầy đủ dữ liệu" );
            }
        }

        private void DgvDuLieu_CellClick ( object sender, DataGridViewCellEventArgs e )
        {
            int i = e.RowIndex;
            if ( e.RowIndex >= 0 && Int32.TryParse( DgvDuLieu[ 0, i ].Value.ToString(), out int id ) )
            {

                TxtID.Text = id.ToString();
                TxtTaiKhoan.Text = DgvDuLieu[ 1, i ].Value.ToString();
                TxtMatKhau.Text = DgvDuLieu[ 2, i ].Value.ToString();
                CbbVaiTro.Text = DgvDuLieu[ 3, i ].Value.ToString();
                TxtEmail.Text = DgvDuLieu[ 4, i ].Value.ToString();
            }
        }
    }
}
