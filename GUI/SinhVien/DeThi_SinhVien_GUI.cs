using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GUI.SinhVien
{
    public partial class DeThi_SinhVien_GUI : Form
    {
        readonly NguoiDung_DeThi_DTO _nguoiDung_DeThi_DTO = new NguoiDung_DeThi_DTO();
        readonly DeThi_BUS _deThi_BUS = new DeThi_BUS();
        readonly ChiTietDeThi_BUS _chiTietDeThi_BUS = new ChiTietDeThi_BUS();
        readonly NguoiDung_DeThi_BUS _nguoiDung_DeThi_BUS = new NguoiDung_DeThi_BUS();
        readonly NguoiDung_ChiTietDeThi_BUS _nguoiDung_ChiTietDeThi_BUS = new NguoiDung_ChiTietDeThi_BUS();
        readonly DapAn_BUS _dapAn_BUS = new DapAn_BUS();
        readonly CauHoi_BUS _cauHoi_BUS = new CauHoi_BUS();
        readonly List<NguoiDung_ChiTietDeThi_DTO> _chiTietDeThi = new List<NguoiDung_ChiTietDeThi_DTO>();
        int totalSeconds;
        public DeThi_SinhVien_GUI ( NguoiDung_DeThi_DTO nguoiDung_DeThi_DTO )
        {
            InitializeComponent();
            _nguoiDung_DeThi_DTO = nguoiDung_DeThi_DTO;
            totalSeconds = (int) _deThi_BUS.TimDeThi( new DeThi_DTO { ID = nguoiDung_DeThi_DTO.ID_DeThi } ).DuLieu.Tables[ 0 ].Rows[ 0 ][ "ThoiGian" ] * 60;
            LblTimer.Text = (totalSeconds / 60).ToString();
            LblPhut.Text = (totalSeconds - (totalSeconds / 60) * 60).ToString();
            this.Timer.Enabled = true;
        }

        private void DeThi_SinhVien_GUI_Load ( object sender, System.EventArgs e )
        {
            KetQuaTruyVan ketQua = _chiTietDeThi_BUS.TimToanBoChiTietDeThiTheoDeThi( new ChiTietDeThi_DTO { ID_DeThi = _nguoiDung_DeThi_DTO.ID_DeThi } );
            foreach ( DataRow row in ketQua.DuLieu.Tables[ 0 ].Rows )
            {
                int id_ChiTietDeThi = (int) row[ "ID" ];
                _chiTietDeThi.Add( new NguoiDung_ChiTietDeThi_DTO { ID_NguoiDung_DeThi = _nguoiDung_DeThi_DTO.ID, ID_ChiTietDeThi = id_ChiTietDeThi } );
            }
            ClbCauHoi.DataSource = ketQua.DuLieu.Tables[ 0 ];
            ClbCauHoi.DisplayMember = "STT";
        }
        private void LamMoi ( )
        {
            Rdb1.Checked = false;
            Rdb2.Checked = false;
            Rdb3.Checked = false;
            Rdb4.Checked = false;
        }
        private void ClbCauHoi_SelectedIndexChanged ( object sender, System.EventArgs e )
        {
            LamMoi();
            DataRowView cot = (DataRowView) ClbCauHoi.Items[ ClbCauHoi.SelectedIndex ];
            KetQuaTruyVan ketQua = _cauHoi_BUS.TimCauHoi( new CauHoi_DTO { ID = (int) cot.Row[ "ID_CauHoi" ] } );
            LblCauHoi.Text = (string) ketQua.DuLieu.Tables[ 0 ].Rows[ 0 ][ "NoiDung" ];
            KetQuaTruyVan dapAns = _dapAn_BUS.TimDapAnTheoCauHoi( new DapAn_DTO
            {
                ID_CauHoi = (int) ketQua.DuLieu.Tables[ 0 ].Rows[ 0 ][ "ID" ]
            } );
            Rdb1.Text = (string) dapAns.DuLieu.Tables[ 0 ].Rows[ 0 ][ "NoiDung" ];
            Rdb2.Text = (string) dapAns.DuLieu.Tables[ 0 ].Rows[ 1 ][ "NoiDung" ];
            Rdb3.Text = (string) dapAns.DuLieu.Tables[ 0 ].Rows[ 2 ][ "NoiDung" ];
            Rdb4.Text = (string) dapAns.DuLieu.Tables[ 0 ].Rows[ 3 ][ "NoiDung" ];

            // nguoi dung chon dap an
            if ( _chiTietDeThi[ ClbCauHoi.SelectedIndex ].CauTraLoi == 1 )
            {
                Rdb1.Checked = true;
            }
            if ( _chiTietDeThi[ ClbCauHoi.SelectedIndex ].CauTraLoi == 2 )
            {
                Rdb2.Checked = true;
            }
            if ( _chiTietDeThi[ ClbCauHoi.SelectedIndex ].CauTraLoi == 3 )
            {
                Rdb3.Checked = true;
            }
            if ( _chiTietDeThi[ ClbCauHoi.SelectedIndex ].CauTraLoi == 4 )
            {
                Rdb4.Checked = true;
            }
        }

        private void Rdb1_CheckedChanged ( object sender, System.EventArgs e )
        {
            if ( Rdb1.Checked )
            {
                _chiTietDeThi[ ClbCauHoi.SelectedIndex ].CauTraLoi = 1;
                ClbCauHoi.SetItemChecked( ClbCauHoi.SelectedIndex, true );
            }
        }

        private void Rdb2_CheckedChanged ( object sender, System.EventArgs e )
        {
            if ( Rdb2.Checked )
            {
                _chiTietDeThi[ ClbCauHoi.SelectedIndex ].CauTraLoi = 2;
                ClbCauHoi.SetItemChecked( ClbCauHoi.SelectedIndex, true );
            }
        }

        private void Rdb3_CheckedChanged ( object sender, System.EventArgs e )
        {
            if ( Rdb3.Checked )
            {
                _chiTietDeThi[ ClbCauHoi.SelectedIndex ].CauTraLoi = 3;
                ClbCauHoi.SetItemChecked( ClbCauHoi.SelectedIndex, true );
            }
        }

        private void Rdb4_CheckedChanged ( object sender, System.EventArgs e )
        {
            if ( Rdb4.Checked )
            {
                _chiTietDeThi[ ClbCauHoi.SelectedIndex ].CauTraLoi = 4;
                ClbCauHoi.SetItemChecked( ClbCauHoi.SelectedIndex, true );
            }
        }
        private void BtnNopBai_Click ( object sender, System.EventArgs e )
        {
            DialogResult dialogResult = MessageBox.Show( "Bạn chắc chắn muốn nộp bài ?", "question", MessageBoxButtons.YesNo );
            if ( dialogResult == DialogResult.Yes )
            {
                foreach ( NguoiDung_ChiTietDeThi_DTO cau in _chiTietDeThi )
                {
                    _nguoiDung_ChiTietDeThi_BUS.ThemNguoiDung_ChiTietDeThi( cau );
                }
                KetQuaTruyVan ketQua = _nguoiDung_DeThi_BUS.NopDeThi( new NguoiDung_DeThi_DTO { ID = _nguoiDung_DeThi_DTO.ID, KetThuc = DateTime.Now } );
                DiemThi_SinhVien_GUI chuyenForm = new DiemThi_SinhVien_GUI( _nguoiDung_DeThi_DTO );
                Hide();
                chuyenForm.ShowDialog();
                Close();
            }
        }

        private void Timer_Tick ( object sender, EventArgs e )
        {
            if ( totalSeconds > 0 )
            {
                totalSeconds--;
                LblTimer.Text = (totalSeconds / 60).ToString();
                LblPhut.Text = (totalSeconds - (totalSeconds / 60) * 60).ToString();
            }
            else
            {
                MessageBox.Show( "Time out" );
                Timer.Stop();
                foreach ( NguoiDung_ChiTietDeThi_DTO cau in _chiTietDeThi )
                {
                    _nguoiDung_ChiTietDeThi_BUS.ThemNguoiDung_ChiTietDeThi( cau );
                }
                KetQuaTruyVan ketQua = _nguoiDung_DeThi_BUS.NopDeThi( new NguoiDung_DeThi_DTO { ID = _nguoiDung_DeThi_DTO.ID, KetThuc = DateTime.Now } );
                DiemThi_SinhVien_GUI chuyenForm = new DiemThi_SinhVien_GUI( _nguoiDung_DeThi_DTO );
                Hide();
                chuyenForm.ShowDialog();
                Close();
            }
        }
    }
}
