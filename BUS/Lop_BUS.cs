using DAL;
using DTO;
using System;

namespace BUS
{
    public class Lop_BUS
    {
        KetQuaTruyVan _ketQuaTruyVan = new KetQuaTruyVan();
        readonly Lop_DAL _khoa_DAL = new Lop_DAL();
        public KetQuaTruyVan TimLopTheoKhoa ( Lop_DTO lop_DTO )
        {
            try
            {
                _ketQuaTruyVan = _khoa_DAL.TimLopTheoKhoa( lop_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm lớp theo khoa thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan ThemLop ( Lop_DTO lop_DTO )
        {
            try
            {
                _ketQuaTruyVan = _khoa_DAL.ThemLop( lop_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Thêm lớp thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan SuaLop ( Lop_DTO lop_DTO )
        {
            try
            {
                _ketQuaTruyVan = _khoa_DAL.SuaLop( lop_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Sửa lớp thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan XoaLop ( Lop_DTO lop_DTO )
        {
            try
            {
                _ketQuaTruyVan = _khoa_DAL.SuaLop( lop_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Xóa lớp thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
    }
}
