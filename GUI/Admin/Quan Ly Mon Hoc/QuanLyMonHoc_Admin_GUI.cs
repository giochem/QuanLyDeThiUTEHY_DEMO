using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI.Admin
{
    public partial class QuanLyMonHoc_Admin_GUI : Form
    {
        MonHoc_BUS _monHoc_BUS = new MonHoc_BUS();
        public QuanLyMonHoc_Admin_GUI ( )
        {
            InitializeComponent();
        }
        private bool KiemTraNhap ( )
        {
            if ( TxtTen.Text == "" )
            {
                return false;
            }
            return true;
        }
        private void BtnThem_Click ( object sender, EventArgs e )
        {
            if ( KiemTraNhap() )
            {
                KetQuaTruyVan ketQua = _monHoc_BUS.ThemMonHoc( new MonHoc_DTO { Ten = TxtTen.Text } );
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
                KetQuaTruyVan ketQua = _monHoc_BUS.SuaMonHoc( new MonHoc_DTO { ID = id, Ten = TxtTen.Text } );
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
                KetQuaTruyVan ketQua = _monHoc_BUS.XoaMonHoc( new MonHoc_DTO { ID = id } );
                MessageBox.Show( ketQua.LoiNhan );
            }
            else
            {
                MessageBox.Show( "Vui lòng nhập đầy đủ dữ liệu" );
            }
        }
        private void BtnLamMoi_Click ( object sender, EventArgs e )
        {
            DgvDuLieu.DataSource = _monHoc_BUS.TimToanBoMonHoc().DuLieu.Tables[ 0 ];
            TxtID.Clear();
            TxtTen.Clear();
        }
        private void BtnChiTietMonHoc_Click ( object sender, EventArgs e )
        {
            if ( Int32.TryParse( TxtID.Text, out int id ) )
            {
                QuanLyChiTietMonHoc_Admin_GUI chuyenForm = new QuanLyChiTietMonHoc_Admin_GUI( new MonHoc_DTO { ID = id } );
                Hide();
                chuyenForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show( "Vui lòng chọn môn học" );
            }
        }
        private void BtnThoat_Click ( object sender, EventArgs e )
        {
            TrangChu_Admin_GUI chuyenForm = new TrangChu_Admin_GUI();
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }
        private void QuanLyMonHoc_Admin_GUI_Load ( object sender, EventArgs e )
        {
            DgvDuLieu.DataSource = _monHoc_BUS.TimToanBoMonHoc().DuLieu.Tables[ 0 ];
        }

        private void DgvDuLieu_CellClick ( object sender, DataGridViewCellEventArgs e )
        {
            int i = e.RowIndex;
            if ( i >= 0 && Int32.TryParse( DgvDuLieu[ 0, i ].Value.ToString(), out int id ) )
            {
                TxtID.Text = id.ToString();
                TxtTen.Text = DgvDuLieu[ 1, i ].Value.ToString();
            }
        }

        private void BtnTimKiem_Click ( object sender, EventArgs e )
        {
            DgvDuLieu.DataSource = _monHoc_BUS.TimMonHocTheoTen( new MonHoc_DTO { Ten = TxtTimKiem.Text } ).DuLieu.Tables[ 0 ];
        }
    }
}
