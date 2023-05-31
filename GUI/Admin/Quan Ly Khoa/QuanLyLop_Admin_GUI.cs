using BUS;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI.Admin.QuanLyLop
{
    public partial class QuanLyLop_Admin_GUI : Form
    {
        readonly Khoa_DTO _khoa_DTO = new Khoa_DTO();
        readonly Lop_BUS _lop_BUS = new Lop_BUS();
        public QuanLyLop_Admin_GUI ( Khoa_DTO khoa_DTO )
        {
            InitializeComponent();
            _khoa_DTO = khoa_DTO;
            TxtID_Khoa.Text = khoa_DTO.ID.ToString();
        }

        private void QuanLyLop_Admin_GUI_Load ( object sender, EventArgs e )
        {
            DgvDuLieu.DataSource = _lop_BUS.TimLopTheoKhoa( new Lop_DTO { ID_Khoa = _khoa_DTO.ID } ).DuLieu.Tables[ 0 ];
        }

        private void BtnLamMoi_Click ( object sender, EventArgs e )
        {
            DgvDuLieu.DataSource = _lop_BUS.TimLopTheoKhoa( new Lop_DTO { ID_Khoa = _khoa_DTO.ID } ).DuLieu.Tables[ 0 ];
            TxtID.Clear();
            TxtTenLop.Clear();
            TxtHeDaoTao.Clear();
            TxtNamNhapHoc.Clear();
        }

        private void DgvDuLieu_CellClick ( object sender, DataGridViewCellEventArgs e )
        {
            int i = e.RowIndex;
            if ( i >= 0 && Int32.TryParse( DgvDuLieu[ 0, i ].Value.ToString(), out int id ) )
            {
                TxtID.Text = id.ToString();
                TxtID_Khoa.Text = DgvDuLieu[ 1, i ].Value.ToString();
                TxtTenLop.Text = DgvDuLieu[ 2, i ].Value.ToString();
                TxtHeDaoTao.Text = DgvDuLieu[ 3, i ].Value.ToString();
                TxtNamNhapHoc.Text = DgvDuLieu[ 4, i ].Value.ToString();
            }
        }

        private void BtnTimKiem_Click ( object sender, EventArgs e )
        {

        }
        private bool KiemTraNhap ( )
        {
            if ( TxtTenLop.Text == "" || TxtHeDaoTao.Text == "" || TxtNamNhapHoc.Text == "" )
            {
                return false;
            }
            return true;
        }
        private void BtnThem_Click ( object sender, EventArgs e )
        {
            if ( KiemTraNhap() && Int32.TryParse( TxtNamNhapHoc.Text, out int namNhapHoc ) )
            {
                KetQuaTruyVan ketQua = _lop_BUS.ThemLop( new Lop_DTO
                {
                    ID_Khoa = _khoa_DTO.ID,
                    TenLop = TxtTenLop.Text,
                    HeDaoTao = TxtHeDaoTao.Text,
                    NamNhapHoc = namNhapHoc
                } );
                MessageBox.Show( ketQua.LoiNhan );
            }
            else
            {
                MessageBox.Show( "Vui lòng nhập đầy đủ dữ liệu" );
            }
        }

        private void BtnSua_Click ( object sender, EventArgs e )
        {
            if ( KiemTraNhap() && Int32.TryParse( TxtID.Text, out int id ) && Int32.TryParse( TxtNamNhapHoc.Text, out int namNhapHoc ) )
            {
                KetQuaTruyVan ketQua = _lop_BUS.ThemLop( new Lop_DTO
                {
                    ID = id,
                    ID_Khoa = _khoa_DTO.ID,
                    TenLop = TxtTenLop.Text,
                    HeDaoTao = TxtHeDaoTao.Text,
                    NamNhapHoc = namNhapHoc
                } );
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
                KetQuaTruyVan ketQua = _lop_BUS.ThemLop( new Lop_DTO
                {
                    ID = id,
                } );
                MessageBox.Show( ketQua.LoiNhan );
            }
            else
            {
                MessageBox.Show( "Vui lòng nhập đầy đủ dữ liệu" );
            }
        }

        private void BtnThoat_Click ( object sender, EventArgs e )
        {
            QuanLyKhoa_Admin_GUI chuyenForm = new QuanLyKhoa_Admin_GUI();
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }
    }
}
