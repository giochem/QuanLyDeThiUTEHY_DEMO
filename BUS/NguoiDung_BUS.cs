using DAL;
using DAL.OneToOne;
using DTO;
using DTO.OneToOne;
using System;
using System.Security.Cryptography;
using System.Text;

namespace BUS
{
    public class NguoiDung_BUS
    {
        KetQuaTruyVan _ketQuaTruyVan = new KetQuaTruyVan();
        readonly NguoiDung_DAL _nguoiDung_DAL = new NguoiDung_DAL();
        readonly SinhVien_DAL _sinhVien_DAL = new SinhVien_DAL();
        public KetQuaTruyVan TimToanBoAdmin ( )
        {
            try
            {
                _ketQuaTruyVan = _nguoiDung_DAL.TimNguoiDungTheoVaiTro( new NguoiDung_DTO { VaiTro = "admin" } );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm toàn bộ admin thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan TimToanBoSinhVien ( )
        {
            try
            {
                _ketQuaTruyVan = _nguoiDung_DAL.TimToanBoSinhVien();
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm toàn bộ sinh viên thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan DangNhap ( NguoiDung_DTO nguoiDung_DTO )
        {
            try
            {
                _ketQuaTruyVan = _nguoiDung_DAL.TimNguoiDungTheoTaiKhoan( nguoiDung_DTO );
                if ( _ketQuaTruyVan.DuLieu.Tables.Count != 1 || _ketQuaTruyVan.DuLieu.Tables[ 0 ].Rows.Count != 1 || nguoiDung_DTO.MatKhau != (string) _ketQuaTruyVan.DuLieu.Tables[ 0 ].Rows[ 0 ][ "MatKhau" ] )
                {
                    _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 1 ).ThemLoiNhan( "Tài khoản hoặc mật khẩu không chính xác" );
                    return _ketQuaTruyVan;
                }
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Đăng nhập thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan DangKy ( NguoiDung_DTO nguoiDung_DTO )
        {
            try
            {
                KetQuaTruyVan timKiem = _nguoiDung_DAL.TimNguoiDungTheoTaiKhoan( nguoiDung_DTO );
                if ( timKiem.DuLieu.Tables[ 0 ].Rows.Count >= 1 )
                {
                    _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 1 ).ThemLoiNhan( "Người dùng đã tồn tại" );
                    return _ketQuaTruyVan;
                }
                _ = _nguoiDung_DAL.ThemNguoiDung( nguoiDung_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Đăng ký thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan ThemSinhVien ( NguoiDung_DTO nguoiDung_DTO, SinhVien_DTO sinhVien_DTO )
        {
            try
            {
                KetQuaTruyVan timKiem = _nguoiDung_DAL.TimNguoiDungTheoTaiKhoan( nguoiDung_DTO );
                if ( timKiem.DuLieu.Tables[ 0 ].Rows.Count >= 1 )
                {
                    _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 1 ).ThemLoiNhan( "Người dùng đã tồn tại" );
                    return _ketQuaTruyVan;
                }
                nguoiDung_DTO.VaiTro = "SinhVien";
                _ketQuaTruyVan = _nguoiDung_DAL.ThemNguoiDung( nguoiDung_DTO );
                int id_NguoiDung = (int) _ketQuaTruyVan.DuLieu.Tables[ 0 ].Rows[ 0 ][ "ID" ];
                sinhVien_DTO.ID_NguoiDung = id_NguoiDung;
                _sinhVien_DAL.ThemSinhVien( sinhVien_DTO );

                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Thêm sinh viên thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan SuaNguoiDung ( NguoiDung_DTO nguoiDung_DTO )
        {
            try
            {
                _nguoiDung_DAL.SuaNguoiDung( nguoiDung_DTO );

                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Cập nhật người dùng thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan SuaSinhVien ( NguoiDung_DTO nguoiDung_DTO, SinhVien_DTO sinhVien_DTO )
        {
            try
            {
                _nguoiDung_DAL.SuaNguoiDung( nguoiDung_DTO );
                _sinhVien_DAL.SuaSinhVien( sinhVien_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Cập nhật người dùng thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan XoaNguoiDung ( NguoiDung_DTO nguoiDung_DTO )
        {
            try
            {
                _nguoiDung_DAL.XoaNguoiDung( nguoiDung_DTO );

                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Xóa người dùng thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan XoaSinhVien ( NguoiDung_DTO nguoiDung_DTO, SinhVien_DTO sinhVien_DTO )
        {
            try
            {
                _sinhVien_DAL.XoaSinhVien( sinhVien_DTO );
                _nguoiDung_DAL.XoaNguoiDung( nguoiDung_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Xoa sinh vien thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public string ChuyenChuoiSangSHA256 ( string chuoi )
        {
            using ( SHA256 sha256 = SHA256.Create() )
            {
                // Compute the hash of the given string
                byte[ ] bamChuoi = sha256.ComputeHash( Encoding.UTF8.GetBytes( chuoi ) );

                // Convert the byte array to string format
                return BitConverter.ToString( bamChuoi ).Replace( "-", "" );
            }
        }
    }
}
