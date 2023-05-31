using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.Admin
{
    public partial class ThongKeDiemThi_GUI : Form
    {
        readonly NguoiDung_DeThi_BUS _nguoiDung_DeThi_BUS = new NguoiDung_DeThi_BUS();
        readonly MonHoc_BUS _monHoc_BUS = new MonHoc_BUS();

        public ThongKeDiemThi_GUI ( )
        {
            InitializeComponent();
        }

        private void ThongKeDiemThi_GUI_Load ( object sender, EventArgs e )
        {
            CbbMonHoc.DataSource = _monHoc_BUS.TimToanBoMonHoc().DuLieu.Tables[ 0 ];
            CbbMonHoc.DisplayMember = "Ten";
            DataRowView cotMonHoc = (DataRowView) CbbMonHoc.Items[ CbbMonHoc.SelectedIndex ];
            int id_MonHoc = (int) cotMonHoc.Row[ "ID" ];

            KetQuaTruyVan ketQua = _nguoiDung_DeThi_BUS.ThongKeDiemThiTheoMonHoc( new MonHoc_DTO { ID = id_MonHoc } );
            foreach ( var series in Chart.Series )
            {
                series.Points.Clear();
            }
            foreach ( DataRow cot in ketQua.DuLieu.Tables[ 0 ].Rows )
            {
                Chart.Series[ "Chart" ].Points.AddXY( ((int) cot[ "DiemThi" ]).ToString(), (int) cot[ "SoLuong" ] );
            }
        }

        private void BtnThoat_Click ( object sender, EventArgs e )
        {
            BaoCaoThongKe_Admin_GUI chuyenForm = new BaoCaoThongKe_Admin_GUI();
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }

        private void CbbMonHoc_SelectedIndexChanged ( object sender, EventArgs e )
        {
            DataRowView cotMonHoc = (DataRowView) CbbMonHoc.Items[ CbbMonHoc.SelectedIndex ];
            int id_MonHoc = (int) cotMonHoc.Row[ "ID" ];

            KetQuaTruyVan ketQua = _nguoiDung_DeThi_BUS.ThongKeDiemThiTheoMonHoc( new MonHoc_DTO { ID = id_MonHoc } );
            foreach ( var series in Chart.Series )
            {
                series.Points.Clear();
            }
            foreach ( DataRow cot in ketQua.DuLieu.Tables[ 0 ].Rows )
            {
                Chart.Series[ "Chart" ].Points.AddXY( ((int) cot[ "DiemThi" ]).ToString(), (int) cot[ "SoLuong" ] );
            }
        }
    }
}
