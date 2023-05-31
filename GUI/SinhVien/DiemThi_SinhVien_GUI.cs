using BUS;
using DTO;
using GUI.Main;
using System.Windows.Forms;

namespace GUI.SinhVien
{
    public partial class DiemThi_SinhVien_GUI : Form
    {
        readonly NguoiDung_DeThi_BUS _nguoiDung_DeThi_BUS = new NguoiDung_DeThi_BUS();
        readonly NguoiDung_DeThi_DTO _nguoiDung_DeThi_DTO = new NguoiDung_DeThi_DTO();
        public DiemThi_SinhVien_GUI ( NguoiDung_DeThi_DTO nguoiDung_DeThi_DTO )
        {
            InitializeComponent();
            _nguoiDung_DeThi_DTO = nguoiDung_DeThi_DTO;
            KetQuaTruyVan ketQua = _nguoiDung_DeThi_BUS.TimNguoiDung_DeThiTheoNguoiDungVaDeThi( _nguoiDung_DeThi_DTO );
            LblDiem.Text = "Điểm : " + ketQua.DuLieu.Tables[ 0 ].Rows[ 0 ][ "DiemThi" ].ToString() + " / 10";
        }

        private void BtnThoat_Click ( object sender, System.EventArgs e )
        {
            DangNhap_GUI chuyenForm = new DangNhap_GUI();
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }
    }
}
