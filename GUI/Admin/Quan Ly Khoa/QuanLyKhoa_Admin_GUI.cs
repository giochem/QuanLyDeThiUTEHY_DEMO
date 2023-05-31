using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI.Admin.QuanLyLop
{
    public partial class QuanLyKhoa_Admin_GUI : Form
    {
        Khoa_BUS _khoa_BUS = new Khoa_BUS();
        public QuanLyKhoa_Admin_GUI ( )
        {
            InitializeComponent();
        }

        private void QuanLyLopHoc_Admin_GUI_Load ( object sender, EventArgs e )
        {
            DgvDuLieu.DataSource = _khoa_BUS.TimToanBoKhoa().DuLieu.Tables[ 0 ];
        }
        private bool KiemTraNhap ( )
        {
            if ( TxtTenKhoa.Text == "" || TxtDienThoai.Text == "" || TxtDiaDiem.Text == "" )
            {
                return false;
            }
            return true;
        }

        private void DgvDuLieu_CellClick ( object sender, DataGridViewCellEventArgs e )
        {
            int i = e.RowIndex;
            if ( i >= 0 && Int32.TryParse( DgvDuLieu[ 0, i ].Value.ToString(), out int id ) )
            {
                TxtID.Text = id.ToString();
                TxtTenKhoa.Text = DgvDuLieu[ 1, i ].Value.ToString();
                TxtDienThoai.Text = DgvDuLieu[ 2, i ].Value.ToString();
                TxtDiaDiem.Text = DgvDuLieu[ 3, i ].Value.ToString();
            }
        }

        private void BtnThem_Click ( object sender, EventArgs e )
        {
            if ( KiemTraNhap() )
            {
                KetQuaTruyVan ketQua = _khoa_BUS.ThemKhoa( new Khoa_DTO { TenKhoa = TxtTenKhoa.Text, DienThoai = TxtDienThoai.Text, DiaDiem = TxtDiaDiem.Text } );
                MessageBox.Show( ketQua.LoiNhan );
            }
            else
            {
                MessageBox.Show( "Vui lòng nhập đầy đủ dữ liệu" );
            }
        }

        private void BtnSua_Click ( object sender, EventArgs e )
        {
            if ( KiemTraNhap() && Int32.TryParse( TxtID.Text, out int id ) )
            {
                KetQuaTruyVan ketQua = _khoa_BUS.SuaKhoa( new Khoa_DTO { ID = id, TenKhoa = TxtTenKhoa.Text, DienThoai = TxtDienThoai.Text, DiaDiem = TxtDiaDiem.Text } );
                MessageBox.Show( ketQua.LoiNhan );
            }
            else
            {
                MessageBox.Show( "Vui lòng nhập đầy đủ dữ liệu" );
            }
        }

        private void BtnXoa_Click ( object sender, EventArgs e )
        {
            if ( KiemTraNhap() && Int32.TryParse( TxtID.Text, out int id ) )
            {
                KetQuaTruyVan ketQua = _khoa_BUS.XoaKhoa( new Khoa_DTO { ID = id } );
                MessageBox.Show( ketQua.LoiNhan );
            }
            else
            {
                MessageBox.Show( "Vui lòng nhập đầy đủ dữ liệu" );
            }
        }

        private void BtnLamMoi_Click ( object sender, EventArgs e )
        {
            DgvDuLieu.DataSource = _khoa_BUS.TimToanBoKhoa().DuLieu.Tables[ 0 ];
            TxtID.Clear();
            TxtTenKhoa.Clear();
            TxtDienThoai.Clear();
            TxtDiaDiem.Clear();
        }

        private void BtnLop_Click ( object sender, EventArgs e )
        {
            if ( Int32.TryParse( TxtID.Text, out int id ) )
            {

                QuanLyLop_Admin_GUI chuyenForm = new QuanLyLop_Admin_GUI( new Khoa_DTO { ID = id } );
                Hide();
                chuyenForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show( "Vui lòng chọn khoa" );
            }
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
