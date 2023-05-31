using DAL;
using DTO;
using System;

namespace BUS
{
    public class NguoiDung_ChiTietDeThi_BUS
    {
        KetQuaTruyVan _ketQuaTruyVan = new KetQuaTruyVan();

        readonly NguoiDung_ChiTietDeThi_DAL _nguoiDung_ChiTietDeThi_DAL = new NguoiDung_ChiTietDeThi_DAL();
        public KetQuaTruyVan TimNguoiDung_ChiTietDeThiTheoNguoiDung_DeThi ( NguoiDung_ChiTietDeThi_DTO nguoiDung_ChiTietDeThi_DTO )
        {
            try
            {
                _ketQuaTruyVan = _nguoiDung_ChiTietDeThi_DAL.TimNguoiDung_ChiTietDeThiTheoNguoiDung_DeThi( nguoiDung_ChiTietDeThi_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm người dùng làm chi tiết đề thi theo người dùng làm đề thi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan TimNguoiDung_ChiTietDeThiTheoNguoiDung_DeThiVaChiTietDeThi ( NguoiDung_ChiTietDeThi_DTO nguoiDung_ChiTietDeThi_DTO )
        {
            try
            {
                _ketQuaTruyVan = _nguoiDung_ChiTietDeThi_DAL.TimNguoiDung_ChiTietDeThiTheoNguoiDung_DeThiVaChiTietDeThi( nguoiDung_ChiTietDeThi_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm người dùng làm chi tiết đề thi theo người dùng làm đề thi và chi tiết đề thi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan ThemNguoiDung_ChiTietDeThi ( NguoiDung_ChiTietDeThi_DTO nguoiDung_ChiTietDeThi_DTO )
        {
            try
            {
                _ketQuaTruyVan = _nguoiDung_ChiTietDeThi_DAL.ThemNguoiDung_ChiTietDeThi( nguoiDung_ChiTietDeThi_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Thêm người dùng làm chi tiết đề thi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan SuaNguoiDung_ChiTietDeThi ( NguoiDung_ChiTietDeThi_DTO nguoiDung_ChiTietDeThi_DTO )
        {
            try
            {
                _ketQuaTruyVan = _nguoiDung_ChiTietDeThi_DAL.SuaNguoiDung_ChiTietDeThi( nguoiDung_ChiTietDeThi_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Sửa người dùng làm chi tiết đề thi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
    }
}
