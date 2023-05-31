using DAL;
using DTO;
using System;

namespace BUS
{
    public class ChiTietDeThi_BUS
    {
        KetQuaTruyVan _ketQuaTruyVan = new KetQuaTruyVan();
        readonly ChiTietDeThi_DAL _chiTietDeThi_DAL = new ChiTietDeThi_DAL();
        public KetQuaTruyVan TimToanBoChiTietDeThiTheoDeThi ( ChiTietDeThi_DTO chiTietDeThi_DTO )
        {
            try
            {
                _ketQuaTruyVan = _chiTietDeThi_DAL.TimChiTietDeThiTheoDeThi( chiTietDeThi_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm toàn bộ chi tiết đề thi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan ThemChiTietDeThi ( DeThi_DTO deThi_DTO )
        {
            try
            {
                _ketQuaTruyVan = _chiTietDeThi_DAL.ThemChiTietDeThiTheoCauHoi( deThi_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Thêm chi tiết đề thi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }

        //public KetQuaTruyVan SuaChiTietDeThi ( ChiTietDeThi_DTO chiTietDeThi_DTO )
        //{
        //    try
        //    {
        //        _chiTietDeThi_DAL.SuaChiTietDeThi( chiTietDeThi_DTO );

        //        _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Cập nhật chi tiết đề thi thành công" );
        //    }
        //    catch ( Exception e )
        //    {
        //        _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
        //    }
        //    return _ketQuaTruyVan;
        //}
        //public KetQuaTruyVan XoaChiTietDeThi ( ChiTietDeThi_DTO chiTietDeThi_DTO )
        //{
        //    try
        //    {
        //        _chiTietDeThi_DAL.XoaChiTietDeThi( chiTietDeThi_DTO );
        //        _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Xóa đề thi thành công" );
        //    }
        //    catch ( Exception e )
        //    {
        //        _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
        //    }
        //    return _ketQuaTruyVan;
        //}
    }
}
