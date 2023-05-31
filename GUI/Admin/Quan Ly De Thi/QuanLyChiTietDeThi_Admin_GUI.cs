using BUS;
using DTO;
using System.Windows.Forms;

namespace GUI.Admin
{
    public partial class QuanLyChiTietDeThi_Admin_GUI : Form
    {
        ChiTietDeThi_BUS _chiTietDeThi_BUS = new ChiTietDeThi_BUS();
        DeThi_DTO _deThi_DTO = new DeThi_DTO();
        public QuanLyChiTietDeThi_Admin_GUI ( DeThi_DTO deThi_DTO )
        {
            InitializeComponent();
            _deThi_DTO = deThi_DTO;
        }

        private void QuanLyChiTietDeThi_Admin_GUI_Load ( object sender, System.EventArgs e )
        {
            DgvDuLieu.DataSource = _chiTietDeThi_BUS.TimToanBoChiTietDeThiTheoDeThi( new ChiTietDeThi_DTO { ID_DeThi = _deThi_DTO.ID } ).DuLieu.Tables[ 0 ];
        }

        private void BtnThoat_Click ( object sender, System.EventArgs e )
        {
            QuanLyDeThi_Admin_GUI chuyenForm = new QuanLyDeThi_Admin_GUI();
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }
    }
}
