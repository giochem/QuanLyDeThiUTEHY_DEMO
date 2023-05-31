using DAL;
using DTO;
using System;

namespace BUS
{
    public class MonHoc_BUS
    {
        KetQuaTruyVan _ketQuaTruyVan = new KetQuaTruyVan();
        readonly MonHoc_DAL _monHoc_DAL = new MonHoc_DAL();
        public KetQuaTruyVan TimToanBoMonHoc ( )
        {
            try
            {
                _ketQuaTruyVan = _monHoc_DAL.TimToanBoMonHoc();
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm toàn bộ môn học thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan TimMonHocTheoTen ( MonHoc_DTO monHoc_DTO )
        {
            try
            {
                _ketQuaTruyVan = _monHoc_DAL.TimMonHocTheoTenGanDung( monHoc_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm môn học theo tên thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan TimMonHoc ( MonHoc_DTO monHoc_DTO )
        {
            try
            {
                _ketQuaTruyVan = _monHoc_DAL.TimMonHoc( monHoc_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm môn học thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan ThemMonHoc ( MonHoc_DTO monHoc_DTO )
        {
            try
            {
                KetQuaTruyVan timKiem = _monHoc_DAL.TimMonHocTheoTen( monHoc_DTO );
                if ( timKiem.DuLieu.Tables[ 0 ].Rows.Count >= 1 )
                {
                    _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 1 ).ThemLoiNhan( "Tên môn học đã tồn tại" );
                    return _ketQuaTruyVan;
                }
                _ketQuaTruyVan = _monHoc_DAL.ThemMonHoc( monHoc_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Thêm môn học thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan SuaMonHoc ( MonHoc_DTO monHoc_DTO )
        {
            try
            {
                _ = _monHoc_DAL.SuaMonHoc( monHoc_DTO );

                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Cập nhật môn học thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan XoaMonHoc ( MonHoc_DTO monHoc_DTO )
        {
            try
            {
                _ = _monHoc_DAL.XoaMonHoc( monHoc_DTO );

                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Xóa môn học thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
    }
}
