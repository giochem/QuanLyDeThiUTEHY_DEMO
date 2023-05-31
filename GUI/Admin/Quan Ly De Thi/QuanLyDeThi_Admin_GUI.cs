using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI.Admin
{
    public partial class QuanLyDeThi_Admin_GUI : Form
    {
        readonly DeThi_BUS _deThi_BUS = new DeThi_BUS();
        readonly MonHoc_BUS _monHoc_BUS = new MonHoc_BUS();
        public QuanLyDeThi_Admin_GUI ( )
        {
            InitializeComponent();
        }

        private void BtnThoat_Click ( object sender, EventArgs e )
        {
            TrangChu_Admin_GUI chuyenForm = new TrangChu_Admin_GUI();
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }
        private bool KiemTraNhap ( )
        {
            if ( CbbMonHoc.Text == "" || TxtTieuDe.Text == "" || TxtSoCauHoi.Text == "" || TxtSoCauToiThieu.Text == "" )
            {
                return false;
            }
            if ( CbbThoiGian.Text == "" || TxtNgayBatDau.Text == "" || TxtNgayKetThuc.Text == "" )
            {
                return false;
            }
            return true;
        }
        private void BtnThem_Click ( object sender, EventArgs e )
        {
            if ( KiemTraNhap() &&
                Int32.TryParse( TxtSoCauHoi.Text, out int soCauHoi ) &&
                Int32.TryParse( TxtSoCauToiThieu.Text, out int soCauToiThieu ) &&
                Int32.TryParse( CbbThoiGian.Text, out int thoiGian ) &&
                DateTime.TryParse( TxtNgayKetThuc.Text, out DateTime ngayKetThuc ) &&
                DateTime.TryParse( TxtNgayBatDau.Text, out DateTime ngayBatDau ) )
            {
                DataRowView cot = (DataRowView) CbbMonHoc.Items[ CbbMonHoc.SelectedIndex ];
                int id_MonHoc = (int) cot.Row[ "ID" ];
                KetQuaTruyVan ketQua = _deThi_BUS.ThemDeThi(
                    new DeThi_DTO
                    {
                        ID_MonHoc = id_MonHoc,
                        TieuDe = TxtTieuDe.Text,
                        SoCauHoi = soCauHoi,
                        SoCauToiThieu = soCauToiThieu,
                        ThoiGian = thoiGian,
                        NgayBatDau = ngayBatDau,
                        NgayKetThuc = ngayKetThuc
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
            if ( KiemTraNhap() &&
                Int32.TryParse( TxtID.Text, out int id ) &&
                Int32.TryParse( TxtSoCauHoi.Text, out int soCauHoi ) &&
                Int32.TryParse( TxtSoCauToiThieu.Text, out int soCauToiThieu ) &&
                Int32.TryParse( CbbThoiGian.Text, out int thoiGian ) &&
                DateTime.TryParse( TxtNgayKetThuc.Text, out DateTime ngayKetThuc ) &&
                DateTime.TryParse( TxtNgayBatDau.Text, out DateTime ngayBatDau ) )
            {
                DataRowView cot = (DataRowView) CbbMonHoc.Items[ CbbMonHoc.SelectedIndex ];
                int id_MonHoc = (int) cot.Row[ "ID" ];
                KetQuaTruyVan ketQua = _deThi_BUS.SuaDeThi(
                    new DeThi_DTO
                    {
                        ID = id,
                        ID_MonHoc = id_MonHoc,
                        TieuDe = TxtTieuDe.Text,
                        SoCauHoi = soCauHoi,
                        SoCauToiThieu = soCauToiThieu,
                        ThoiGian = thoiGian,
                        NgayBatDau = ngayBatDau,
                        NgayKetThuc = ngayKetThuc
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
            if ( Int32.TryParse( TxtID.Text, out int id ) )
            {
                KetQuaTruyVan ketQua = _deThi_BUS.XoaDeThi(
                    new DeThi_DTO
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

        private void BtnLamMoi_Click ( object sender, EventArgs e )
        {
            DgvDuLieu.DataSource = _deThi_BUS.TimToanBoDeThi().DuLieu.Tables[ 0 ];
            TxtID.Clear();
            TxtTieuDe.Clear();
            TxtSoCauToiThieu.Clear();
            TxtNgayKetThuc.Clear();
            TxtNgayBatDau.Clear();
        }

        private void BtnChiTietDeThi_Click ( object sender, EventArgs e )
        {
            if ( Int32.TryParse( TxtID.Text, out int id ) )
            {
                DataRowView cot = (DataRowView) CbbMonHoc.Items[ CbbMonHoc.SelectedIndex ];
                int id_MonHoc = (int) cot.Row[ "ID" ];
                QuanLyChiTietDeThi_Admin_GUI chuyenForm = new QuanLyChiTietDeThi_Admin_GUI( new DeThi_DTO { ID = id } );
                Hide();
                chuyenForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show( "Vui lòng chọn đề thi" );
            }
        }

        private void DgvDuLieu_CellClick ( object sender, DataGridViewCellEventArgs e )
        {
            int i = e.RowIndex;
            if ( i >= 0 && Int32.TryParse( DgvDuLieu[ 0, i ].Value.ToString(), out int id )
                && Int32.TryParse( DgvDuLieu[ 1, i ].Value.ToString(), out int id_MonHoc ) )
            {
                TxtID.Text = id.ToString();
                KetQuaTruyVan ketQua = _monHoc_BUS.TimMonHoc( new MonHoc_DTO { ID = id_MonHoc } );
                CbbMonHoc.Text = (string) ketQua.DuLieu.Tables[ 0 ].Rows[ 0 ][ "Ten" ];
                TxtTieuDe.Text = DgvDuLieu[ 2, i ].Value.ToString();
                TxtSoCauHoi.Text = DgvDuLieu[ 3, i ].Value.ToString();
                CbbThoiGian.Text = DgvDuLieu[ 4, i ].Value.ToString();
                TxtSoCauToiThieu.Text = DgvDuLieu[ 5, i ].Value.ToString();
                TxtNgayBatDau.Text = DgvDuLieu[ 6, i ].Value.ToString();
                TxtNgayKetThuc.Text = DgvDuLieu[ 7, i ].Value.ToString();
            }
        }

        private void QuanLyDeThi_Admin_GUI_Load ( object sender, EventArgs e )
        {
            if ( _deThi_BUS.TimToanBoDeThi().DuLieu != null )
            {
                DgvDuLieu.DataSource = _deThi_BUS.TimToanBoDeThi().DuLieu.Tables[ 0 ];

            }
            if ( _monHoc_BUS.TimToanBoMonHoc().DuLieu != null )
            {

                CbbMonHoc.DataSource = _monHoc_BUS.TimToanBoMonHoc().DuLieu.Tables[ 0 ];
                CbbMonHoc.DisplayMember = "Ten";
            }
        }

        private void McThoiGianThi_DateChanged ( object sender, DateRangeEventArgs e )
        {
            TxtNgayBatDau.Text = McThoiGianThi.SelectionStart.ToShortDateString();
            TxtNgayKetThuc.Text = McThoiGianThi.SelectionEnd.ToShortDateString();
        }
    }
}
