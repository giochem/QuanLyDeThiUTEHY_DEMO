using DAL;
using DTO;
using System;

namespace BUS
{
    public class ChiTietMonHoc_BUS
    {
        KetQuaTruyVan _ketQuaTruyVan = new KetQuaTruyVan();
        readonly ChiTietMonHoc_DAL _chiTietMonHoc_DAL = new ChiTietMonHoc_DAL();

        public KetQuaTruyVan TimChiTietMonHocTheoMonHoc ( ChiTietMonHoc_DTO chiTietMonHoc_DTO )
        {
            try
            {
                _ketQuaTruyVan = _chiTietMonHoc_DAL.TimChiTietMonHocTheoMonHoc( chiTietMonHoc_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm chi tiết môn học theo môn học thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan TimChiTietMonHocTheoKienThuc ( ChiTietMonHoc_DTO chiTietMonHoc_DTO )
        {
            try
            {
                _ketQuaTruyVan = _chiTietMonHoc_DAL.TimChiTietMonHocTheoKienThuc( chiTietMonHoc_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm chi tiết môn học theo kiến thức thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan TimChiTietMonHoc ( ChiTietMonHoc_DTO chiTietMonHoc_DTO )
        {
            try
            {
                _ketQuaTruyVan = _chiTietMonHoc_DAL.TimChiTietMonHoc( chiTietMonHoc_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm chi tiết môn học thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan ThemChiTietMonHoc ( ChiTietMonHoc_DTO chiTietMonHoc_DTO )
        {
            try
            {
                KetQuaTruyVan timKiem = _chiTietMonHoc_DAL.TimChiTietMonHocTheoKienThuc( chiTietMonHoc_DTO );
                if ( timKiem.DuLieu.Tables[ 0 ].Rows.Count >= 1 )
                {
                    _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 1 ).ThemLoiNhan( "Kiến thức của môn học đã tồn tại" );
                    return _ketQuaTruyVan;
                }
                _ketQuaTruyVan = _chiTietMonHoc_DAL.ThemChiTietMonHoc( chiTietMonHoc_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Thêm chi tiết môn học thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan SuaChiTietMonHoc ( ChiTietMonHoc_DTO chiTietMonHoc_DTO )
        {
            try
            {
                _ = _chiTietMonHoc_DAL.SuaChiTietMonHoc( chiTietMonHoc_DTO );

                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Cập nhật chi tiết môn học thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan XoaChiTietMonHoc ( ChiTietMonHoc_DTO chiTietMonHoc_DTO )
        {
            try
            {
                _ = _chiTietMonHoc_DAL.XoaChiTietMonHoc( chiTietMonHoc_DTO );

                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Xóa chi tiết môn học thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
    }
}
