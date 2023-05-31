using System;
using System.Windows.Forms;

namespace GUI.Admin
{
    public partial class BaoCaoThongKe_Admin_GUI : Form
    {
        public BaoCaoThongKe_Admin_GUI ( )
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

        private void BtnThongKe_Click ( object sender, EventArgs e )
        {
            ThongKeDiemThi_GUI chuyenForm = new ThongKeDiemThi_GUI();
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }
    }
}
