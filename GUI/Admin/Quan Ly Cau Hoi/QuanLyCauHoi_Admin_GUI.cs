using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GUI.Admin
{
    public partial class QuanLyCauHoi_Admin_GUI : Form
    {
        CauHoi_BUS _cauHoi_BUS = new CauHoi_BUS();
        DapAn_BUS _dapAn_BUS = new DapAn_BUS();
        MonHoc_BUS _monHoc_BUS = new MonHoc_BUS();
        ChiTietMonHoc_BUS _chiTietMonHoc_BUS = new ChiTietMonHoc_BUS();

        public QuanLyCauHoi_Admin_GUI ( )
        {
            InitializeComponent();
        }

        private void DgvDuLieu_CellClick ( object sender, DataGridViewCellEventArgs e )
        {
            int i = e.RowIndex;
            if ( i >= 0 && Int32.TryParse( DgvDuLieu[ 0, i ].Value.ToString(), out int id ) )
            {

                TxtID.Text = id.ToString();
                TxtTieuDe.Text = DgvDuLieu[ 2, i ].Value.ToString();
                CbbDoKho.Text = DgvDuLieu[ 3, i ].Value.ToString();
                TxtGiaiThich.Text = DgvDuLieu[ 4, i ].Value.ToString();
                TxtNoiDung.Text = DgvDuLieu[ 5, i ].Value.ToString();

                // dap an
                DataTable dapAn = _dapAn_BUS.TimDapAnTheoCauHoi( new DapAn_DTO { ID_CauHoi = id } ).DuLieu.Tables[ 0 ];
                TxtDapAn1.Text = (string) dapAn.Rows[ 0 ][ "NoiDung" ];
                TxtDapAn2.Text = (string) dapAn.Rows[ 1 ][ "NoiDung" ];
                TxtDapAn3.Text = (string) dapAn.Rows[ 2 ][ "NoiDung" ];
                TxtDapAn4.Text = (string) dapAn.Rows[ 3 ][ "NoiDung" ];
                // dap an dung
                if ( (bool) dapAn.Rows[ 0 ][ "DapAnDung" ] )
                {
                    Rdb1.Checked = true;
                }
                else if ( (bool) dapAn.Rows[ 1 ][ "DapAnDung" ] )
                {
                    Rdb2.Checked = true;
                }
                else if ( (bool) dapAn.Rows[ 2 ][ "DapAnDung" ] )
                {
                    Rdb3.Checked = true;
                }
                else
                {
                    Rdb4.Checked = true;
                }
                // mon hoc

            }
        }
        private void QuanLyCauHoi_Admin_GUI_Load ( object sender, System.EventArgs e )
        {
            DgvDuLieu.DataSource = _cauHoi_BUS.TimToanBoCauHoi().DuLieu.Tables[ 0 ];
            CbbMonHoc.DataSource = _monHoc_BUS.TimToanBoMonHoc().DuLieu.Tables[ 0 ];
            CbbMonHoc.DisplayMember = "Ten";
        }
        private bool KiemTraNhap ( )
        {
            if ( CbbMonHoc.Text == "" || CbbKienThuc.Text == "" || TxtTieuDe.Text == "" || TxtGiaiThich.Text == "" || CbbDoKho.Text == "" || TxtNoiDung.Text == "" )
            {
                return false;
            }
            if ( TxtDapAn1.Text == "" || TxtDapAn2.Text == "" || TxtDapAn3.Text == "" || TxtDapAn4.Text == "" )
            {
                return false;
            }
            if ( !Rdb1.Checked && !Rdb2.Checked && !Rdb3.Checked && !Rdb4.Checked )
            {
                return false;
            }
            return true;
        }

        private void BtnThem_Click ( object sender, System.EventArgs e )
        {
            if ( KiemTraNhap() )
            {
                DataRowView cot = (DataRowView) CbbKienThuc.Items[ CbbKienThuc.SelectedIndex ];
                int id_ChiTietMonHoc = (int) cot.Row[ "ID" ];

                List<DapAn_DTO> dapAns = new List<DapAn_DTO>
                {
                    new DapAn_DTO { STT = 1, NoiDung = TxtDapAn1.Text, DapAnDung = Rdb1.Checked },
                    new DapAn_DTO { STT = 2, NoiDung = TxtDapAn2.Text, DapAnDung = Rdb2.Checked },
                    new DapAn_DTO { STT = 3, NoiDung = TxtDapAn3.Text, DapAnDung = Rdb3.Checked },
                    new DapAn_DTO { STT = 4, NoiDung = TxtDapAn4.Text, DapAnDung = Rdb4.Checked }
                };

                KetQuaTruyVan ketQua = _cauHoi_BUS.ThemCauHoi(
                    new CauHoi_DTO { TieuDe = TxtTieuDe.Text, GiaiThich = TxtGiaiThich.Text, NoiDung = TxtNoiDung.Text, DoKho = CbbDoKho.Text, ID_ChiTietMonHoc = id_ChiTietMonHoc },
                    dapAns );
                MessageBox.Show( ketQua.LoiNhan );
            }
            else
            {
                MessageBox.Show( "Vui lòng nhập đầy đủ dữ liệu" );
            }
        }

        private void BtnSua_Click ( object sender, System.EventArgs e )
        {
            if ( KiemTraNhap() && Int32.TryParse( TxtID.Text, out int id ) )
            {
                DataRowView cot = (DataRowView) CbbKienThuc.Items[ CbbKienThuc.SelectedIndex ];
                int id_ChiTietMonHoc = (int) cot.Row[ "ID" ];

                List<DapAn_DTO> dapAns = new List<DapAn_DTO>
                {
                    new DapAn_DTO { STT = 1, NoiDung = TxtDapAn1.Text, DapAnDung = Rdb1.Checked },
                    new DapAn_DTO { STT = 2, NoiDung = TxtDapAn2.Text, DapAnDung = Rdb2.Checked },
                    new DapAn_DTO { STT = 3, NoiDung = TxtDapAn3.Text, DapAnDung = Rdb3.Checked },
                    new DapAn_DTO { STT = 4, NoiDung = TxtDapAn4.Text, DapAnDung = Rdb4.Checked }
                };

                KetQuaTruyVan ketQua = _cauHoi_BUS.SuaCauHoi(
                    new CauHoi_DTO { ID = id, TieuDe = TxtTieuDe.Text, GiaiThich = TxtGiaiThich.Text, NoiDung = TxtNoiDung.Text, DoKho = CbbDoKho.Text, ID_ChiTietMonHoc = id_ChiTietMonHoc },
                    dapAns );
                MessageBox.Show( ketQua.LoiNhan );
            }
            else
            {
                MessageBox.Show( "Vui lòng nhập đầy đủ dữ liệu" );
            }
        }

        private void BtnXoa_Click ( object sender, System.EventArgs e )
        {
            if ( Int32.TryParse( TxtID.Text, out int id ) )
            {

                KetQuaTruyVan ketQua = _cauHoi_BUS.XoaCauHoi( new CauHoi_DTO { ID = id } );
                MessageBox.Show( ketQua.LoiNhan );
            }
            else
            {
                MessageBox.Show( "Vui lòng chọn câu hỏi" );
            }
        }

        private void BtnLamMoi_Click ( object sender, System.EventArgs e )
        {
            DgvDuLieu.DataSource = _cauHoi_BUS.TimToanBoCauHoi().DuLieu.Tables[ 0 ];
            TxtID.Clear();
            TxtTieuDe.Clear();
            TxtGiaiThich.Clear();
            TxtNoiDung.Clear();

            TxtDapAn1.Clear();
            TxtDapAn2.Clear();
            TxtDapAn3.Clear();
            TxtDapAn4.Clear();
            Rdb1.Checked = false; Rdb2.Checked = false;
            Rdb3.Checked = false; Rdb4.Checked = false;

        }
        private void BtnThoat_Click ( object sender, System.EventArgs e )
        {
            TrangChu_Admin_GUI chuyenForm = new TrangChu_Admin_GUI();
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }

        private void CbbMonHoc_SelectedIndexChanged ( object sender, System.EventArgs e )
        {
            DataRowView cot = (DataRowView) CbbMonHoc.Items[ CbbMonHoc.SelectedIndex ];
            int id_MonHoc = (int) cot.Row[ "ID" ];
            CbbKienThuc.DataSource = _chiTietMonHoc_BUS.TimChiTietMonHocTheoMonHoc( new ChiTietMonHoc_DTO { ID_MonHoc = id_MonHoc } ).DuLieu.Tables[ 0 ];
            CbbKienThuc.DisplayMember = "KienThuc";
        }

        private void BtnTimKiem_Click ( object sender, EventArgs e )
        {

        }
    }
}
