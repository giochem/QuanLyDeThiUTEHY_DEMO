using DAL;
using DTO;
using System;

namespace BUS
{
    public class DeThi_BUS
    {
        KetQuaTruyVan _ketQuaTruyVan = new KetQuaTruyVan();
        readonly DeThi_DAL _deThi_DAL = new DeThi_DAL();
        readonly ChiTietDeThi_DAL _chiTietDeThi_DAL = new ChiTietDeThi_DAL();
        public KetQuaTruyVan TimToanBoDeThi ( )
        {
            try
            {
                _ketQuaTruyVan = _deThi_DAL.TimToanBoDeThi();
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm toàn bộ đề thi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan TimDeThiTheoMonHoc ( DeThi_DTO deThi_DTO )
        {
            try
            {
                _ketQuaTruyVan = _deThi_DAL.TimDeThiTheoMonHoc( deThi_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm đề thi thoe môn học thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan TimDeThi ( DeThi_DTO deThi_DTO )
        {
            try
            {
                _ketQuaTruyVan = _deThi_DAL.TimDeThi( deThi_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm đề thi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan ThemDeThi ( DeThi_DTO deThi_DTO )
        {
            try
            {
                KetQuaTruyVan timKiem = _deThi_DAL.TimDeThiTheoTieuDe( deThi_DTO );
                if ( timKiem.DuLieu.Tables[ 0 ].Rows.Count >= 1 )
                {
                    _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 1 ).ThemLoiNhan( "Tên đề thi đã tồn tại" );
                    return _ketQuaTruyVan;
                }
                _ketQuaTruyVan = _deThi_DAL.ThemDeThi( deThi_DTO );
                KetQuaTruyVan deThi = _deThi_DAL.TimDeThiTheoTieuDe( deThi_DTO );
                deThi_DTO.ID = (int) deThi.DuLieu.Tables[ 0 ].Rows[ 0 ][ "ID" ];
                _chiTietDeThi_DAL.ThemChiTietDeThiTheoCauHoi( deThi_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Thêm đề thi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan SuaDeThi ( DeThi_DTO deThi_DTO )
        {
            try
            {
                _deThi_DAL.SuaDeThi( deThi_DTO );

                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Cập nhật đề thi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan XoaDeThi ( DeThi_DTO deThi_DTO )
        {
            try
            {
                _deThi_DAL.XoaDeThi( deThi_DTO );

                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Xóa đề thi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
    }
}
