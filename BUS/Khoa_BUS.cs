using DAL;
using DTO;
using System;

namespace BUS
{
    public class Khoa_BUS
    {
        KetQuaTruyVan _ketQuaTruyVan = new KetQuaTruyVan();
        readonly Khoa_DAL _khoa_DAL = new Khoa_DAL();
        public KetQuaTruyVan TimToanBoKhoa ( )
        {
            try
            {
                _ketQuaTruyVan = _khoa_DAL.TimToanBoKhoa();
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm toàn bộ khoa thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan ThemKhoa ( Khoa_DTO khoa_DTO )
        {
            try
            {
                _ketQuaTruyVan = _khoa_DAL.ThemKhoa( khoa_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Thêm khoa thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan SuaKhoa ( Khoa_DTO khoa_DTO )
        {
            try
            {
                _ketQuaTruyVan = _khoa_DAL.SuaKhoa( khoa_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Sửa khoa thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan XoaKhoa ( Khoa_DTO khoa_DTO )
        {
            try
            {
                _ketQuaTruyVan = _khoa_DAL.XoaKhoa( khoa_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Xóa khoa thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
    }
}
