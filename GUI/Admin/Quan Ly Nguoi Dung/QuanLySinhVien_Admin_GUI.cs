using BUS;
using DTO;
using DTO.OneToOne;
using System;
using System.Data;
using System.Windows.Forms;
namespace GUI.Admin.QuanLyNguoiDung
{
    public partial class QuanLySinhVien_Admin_GUI : Form
    {
        NguoiDung_BUS _nguoiDung_BUS = new NguoiDung_BUS();
        Khoa_BUS _khoa_BUS = new Khoa_BUS();
        Lop_BUS _lop_BUS = new Lop_BUS();
        public QuanLySinhVien_Admin_GUI ( )
        {
            InitializeComponent();
        }

        private void BtnThoat_Click ( object sender, EventArgs e )
        {
            ChucNangQuanLyNguoiDung_Admin_GUI chuyenForm = new ChucNangQuanLyNguoiDung_Admin_GUI();
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }
        private bool KiemTraNhap ( )
        {
            if ( TxtTaiKhoan.Text == "" || TxtMatKhau.Text == "" || TxtEmail.Text == "" || CbbKhoa.Text == "" || CbbLop.Text == "" )
            {
                return false;
            }
            return true;
        }
        private void QuanLySinhVien_Admin_GUI_Load ( object sender, EventArgs e )
        {
            if ( _nguoiDung_BUS.TimToanBoSinhVien().DuLieu != null )
            {

                DgvDuLieu.DataSource = _nguoiDung_BUS.TimToanBoSinhVien().DuLieu.Tables[ 0 ];
            }
            if ( _khoa_BUS.TimToanBoKhoa().DuLieu != null )
            {

                CbbKhoa.DataSource = _khoa_BUS.TimToanBoKhoa().DuLieu.Tables[ 0 ];
                CbbKhoa.DisplayMember = "TenKhoa";
            }
        }

        private void CbbKhoa_SelectedIndexChanged ( object sender, EventArgs e )
        {
            DataRowView cot = (DataRowView) CbbKhoa.Items[ CbbKhoa.SelectedIndex ];
            int id_Khoa = (int) cot.Row[ "ID" ];
            CbbLop.DataSource = _lop_BUS.TimLopTheoKhoa( new Lop_DTO() { ID_Khoa = id_Khoa } ).DuLieu.Tables[ 0 ];
            CbbLop.DisplayMember = "TenLop";
        }

        private void BtnThem_Click ( object sender, EventArgs e )
        {
            if ( KiemTraNhap() && CbbLop.SelectedIndex >= 0 )
            {
                DataRowView cot = (DataRowView) CbbLop.Items[ CbbLop.SelectedIndex ];
                int id_Lop = (int) cot.Row[ "ID" ];
                KetQuaTruyVan ketQua = _nguoiDung_BUS.ThemSinhVien(
                    new NguoiDung_DTO { TaiKhoan = TxtTaiKhoan.Text, MatKhau = TxtMatKhau.Text, Email = TxtEmail.Text },
                    new SinhVien_DTO { ID_Lop = id_Lop } );
                MessageBox.Show( ketQua.LoiNhan );
            }
            else
            {
                MessageBox.Show( "Vui lòng nhập đầy đủ dữ liệu" );
            }
        }
        private void BtnSua_Click ( object sender, EventArgs e )
        {
            if ( KiemTraNhap() && Int32.TryParse( TxtID.Text, out int id ) )
            {
                DataRowView cot = (DataRowView) CbbLop.Items[ CbbLop.SelectedIndex ];
                int id_Lop = (int) cot.Row[ "ID" ];

                KetQuaTruyVan ketQua = _nguoiDung_BUS.SuaSinhVien(
                    new NguoiDung_DTO { ID = id, TaiKhoan = TxtTaiKhoan.Text, MatKhau = TxtMatKhau.Text, VaiTro = "SinhVien", Email = TxtEmail.Text },
                    new SinhVien_DTO { ID_NguoiDung = id, ID_Lop = id_Lop } );
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
                DataRowView cot = (DataRowView) CbbLop.Items[ CbbLop.SelectedIndex ];
                int id_Lop = (int) cot.Row[ "ID" ];

                KetQuaTruyVan ketQua = _nguoiDung_BUS.XoaSinhVien(
                    new NguoiDung_DTO { ID = id },
                    new SinhVien_DTO { ID_NguoiDung = id } );
                MessageBox.Show( ketQua.LoiNhan );
            }
            else
            {
                MessageBox.Show( "Vui lòng nhập đầy đủ dữ liệu" );
            }
        }

        private void BtnLamMoi_Click ( object sender, EventArgs e )
        {
            if ( _nguoiDung_BUS.TimToanBoSinhVien().DuLieu != null )
            {
                DgvDuLieu.DataSource = _nguoiDung_BUS.TimToanBoSinhVien().DuLieu.Tables[ 0 ];
            }
            TxtID.Clear();
            TxtTaiKhoan.Clear();
            TxtMatKhau.Clear();
            TxtEmail.Clear();
        }

        private void DgvDuLieu_CellClick ( object sender, DataGridViewCellEventArgs e )
        {
            int i = e.RowIndex;
            if ( i >= 0 && Int32.TryParse( DgvDuLieu[ 0, i ].Value.ToString(), out int id ) )
            {

                TxtID.Text = id.ToString();
                TxtTaiKhoan.Text = DgvDuLieu[ 1, i ].Value.ToString();
                TxtMatKhau.Text = DgvDuLieu[ 2, i ].Value.ToString();
                TxtEmail.Text = DgvDuLieu[ 4, i ].Value.ToString();
                CbbLop.Text = DgvDuLieu[ 5, i ].Value.ToString();
                CbbKhoa.Text = DgvDuLieu[ 6, i ].Value.ToString();
            }
        }

        private void BtnThoat_Click_1 ( object sender, EventArgs e )
        {
            ChucNangQuanLyNguoiDung_Admin_GUI chuyenForm = new ChucNangQuanLyNguoiDung_Admin_GUI();
            Hide();
            chuyenForm.ShowDialog();
            Close();
        }
    }
}
