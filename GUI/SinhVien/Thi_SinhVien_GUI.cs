using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI.SinhVien
{
    public partial class Thi_SinhVien_GUI : Form
    {
        readonly MonHoc_BUS _monHoc_BUS = new MonHoc_BUS();
        readonly DeThi_BUS _deThi_BUS = new DeThi_BUS();
        readonly NguoiDung_DeThi_BUS _nguoiDung_DeThi_BUS = new NguoiDung_DeThi_BUS();
        readonly NguoiDung_DTO _nguoiDung_DTO = new NguoiDung_DTO();
        public Thi_SinhVien_GUI ( NguoiDung_DTO nguoiDung_DTO )
        {
            InitializeComponent();
            _nguoiDung_DTO = nguoiDung_DTO;
        }

        private void BtnThoat_Click ( object sender, EventArgs e )
        {
            TrangChuNguoiDung_GUI chuyenForm = new TrangChuNguoiDung_GUI( _nguoiDung_DTO );
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }

        private void BtnBatDau_Click ( object sender, EventArgs e )
        {
            DataRowView cot = (DataRowView) CbbMonHoc.Items[ CbbMonHoc.SelectedIndex ];
            int id_MonHoc = (int) cot.Row[ "ID" ];
            KetQuaTruyVan ketQua = _deThi_BUS.TimDeThiTheoMonHoc( new DeThi_DTO { ID_MonHoc = id_MonHoc } );
            if ( ketQua.DuLieu.Tables[ 0 ].Rows.Count > 0 )
            {

                int id_DeThi = (int) ketQua.DuLieu.Tables[ 0 ].Rows[ 0 ][ "ID" ];

                KetQuaTruyVan deThi = _nguoiDung_DeThi_BUS.ThemNguoiDung_DeThi(
                    new NguoiDung_DeThi_DTO
                    {
                        ID_DeThi = id_DeThi,
                        ID_NguoiDung = _nguoiDung_DTO.ID,
                        BatDau = DateTime.Now,
                        KetThuc = DateTime.Now
                    } );
                if ( deThi.ThanhCong )
                {
                    KetQuaTruyVan timNguoiDungLamDeThi = _nguoiDung_DeThi_BUS.TimNguoiDung_DeThiTheoNguoiDungVaDeThi( new NguoiDung_DeThi_DTO { ID_DeThi = id_DeThi, ID_NguoiDung = _nguoiDung_DTO.ID } );
                    int id = (int) timNguoiDungLamDeThi.DuLieu.Tables[ 0 ].Rows[ 0 ][ "ID" ];
                    DeThi_SinhVien_GUI chuyenForm = new DeThi_SinhVien_GUI( new NguoiDung_DeThi_DTO { ID = id, ID_DeThi = id_DeThi, ID_NguoiDung = _nguoiDung_DTO.ID } );
                    Hide();
                    chuyenForm.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show( "Bạn đã làm đề thi này" );
                }
            }
        }

        private void Thi_SinhVien_GUI_Load ( object sender, EventArgs e )
        {
            CbbMonHoc.DataSource = _monHoc_BUS.TimToanBoMonHoc().DuLieu.Tables[ 0 ];
            CbbMonHoc.DisplayMember = "Ten";
        }

        private void CbbMonHoc_SelectedIndexChanged ( object sender, EventArgs e )
        {
            DataRowView cot = (DataRowView) CbbMonHoc.Items[ CbbMonHoc.SelectedIndex ];
            int id_MonHoc = (int) cot.Row[ "ID" ];
            KetQuaTruyVan ketQua = _deThi_BUS.TimDeThiTheoMonHoc( new DeThi_DTO { ID_MonHoc = id_MonHoc } );
            if ( (int) ketQua.DuLieu.Tables[ 0 ].Rows.Count > 0 )
            {
                LblDeThi.Text = "đề thi: " + (string) ketQua.DuLieu.Tables[ 0 ].Rows[ 0 ][ "TieuDe" ];
                LblSoCauHoi.Text = "số câu hỏi:" + ((int) ketQua.DuLieu.Tables[ 0 ].Rows[ 0 ][ "SoCauHoi" ]).ToString();
                LblThoiGian.Text = "thời gian:" + ((int) ketQua.DuLieu.Tables[ 0 ].Rows[ 0 ][ "ThoiGian" ]).ToString() + " phút";
            }
            else
            {
                MessageBox.Show( "Không tồn tại đề thi" );

            }
        }
    }
}
