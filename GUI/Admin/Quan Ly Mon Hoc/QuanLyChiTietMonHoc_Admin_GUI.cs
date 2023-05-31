using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI.Admin
{
    public partial class QuanLyChiTietMonHoc_Admin_GUI : Form
    {
        MonHoc_DTO _monHoc_DTO = new MonHoc_DTO();
        ChiTietMonHoc_BUS _chiTietMonHoc_BUS = new ChiTietMonHoc_BUS();
        public QuanLyChiTietMonHoc_Admin_GUI ( MonHoc_DTO monHoc_DTO )
        {
            InitializeComponent();
            _monHoc_DTO = monHoc_DTO;
            TxtID_MonHoc.Text = monHoc_DTO.ID.ToString();
        }
        private bool KiemTraNhap ( )
        {
            if ( TxtKienThuc.Text == "" )
            {
                return false;
            }
            return true;
        }
        private void BtnThem_Click ( object sender, System.EventArgs e )
        {
            if ( KiemTraNhap() )
            {
                KetQuaTruyVan ketQua = _chiTietMonHoc_BUS.ThemChiTietMonHoc( new ChiTietMonHoc_DTO { ID_MonHoc = _monHoc_DTO.ID, KienThuc = TxtKienThuc.Text } );
                MessageBox.Show( ketQua.LoiNhan );
            }
            else
            {
                MessageBox.Show( "Vui lòng nhập đầy đủ dữ liệu" );
            }
        }

        private void BtnSua_Click ( object sender, System.EventArgs e )
        {
            if ( KiemTraNhap() && Int32.TryParse( TxtID.Text, out int id ) && Int32.TryParse( TxtID_MonHoc.Text, out int id_MonHoc ) )
            {
                KetQuaTruyVan ketQua = _chiTietMonHoc_BUS.SuaChiTietMonHoc( new ChiTietMonHoc_DTO { ID = id, ID_MonHoc = id_MonHoc, KienThuc = TxtKienThuc.Text } );
                MessageBox.Show( ketQua.LoiNhan );
            }
            else
            {
                MessageBox.Show( "Vui lòng nhập đầy đủ dữ liệu" );
            }
        }

        private void BtnXoa_Click ( object sender, System.EventArgs e )
        {
            if ( KiemTraNhap() && Int32.TryParse( TxtID.Text, out int id ) )
            {
                KetQuaTruyVan ketQua = _chiTietMonHoc_BUS.XoaChiTietMonHoc( new ChiTietMonHoc_DTO { ID = id } );
                MessageBox.Show( ketQua.LoiNhan );
            }
            else
            {
                MessageBox.Show( "Vui lòng nhập đầy đủ dữ liệu" );
            }
        }

        private void BtnLamMoi_Click ( object sender, System.EventArgs e )
        {
            DgvDuLieu.DataSource = _chiTietMonHoc_BUS.TimChiTietMonHocTheoMonHoc( new ChiTietMonHoc_DTO { ID_MonHoc = _monHoc_DTO.ID } ).DuLieu.Tables[ 0 ];
            TxtKienThuc.Clear();
            TxtID.Clear();
        }

        private void BtnThoat_Click ( object sender, System.EventArgs e )
        {
            QuanLyMonHoc_Admin_GUI chuyenForm = new QuanLyMonHoc_Admin_GUI();
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }

        private void DgvDuLieu_CellClick ( object sender, DataGridViewCellEventArgs e )
        {
            int i = e.RowIndex;
            if ( i >= 0 && Int32.TryParse( DgvDuLieu[ 0, i ].Value.ToString(), out int id ) )
            {
                TxtID.Text = id.ToString();
                TxtKienThuc.Text = DgvDuLieu[ 1, i ].Value.ToString();
            }
        }

        private void QuanLyChiTietMonHoc_Admin_GUI_Load ( object sender, EventArgs e )
        {
            DgvDuLieu.DataSource = _chiTietMonHoc_BUS.TimChiTietMonHocTheoMonHoc( new ChiTietMonHoc_DTO { ID_MonHoc = _monHoc_DTO.ID } ).DuLieu.Tables[ 0 ];
        }
    }
}
