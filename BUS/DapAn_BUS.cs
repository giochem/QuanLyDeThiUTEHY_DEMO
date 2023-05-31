using DAL;
using DTO;
using System;

namespace BUS
{
    public class DapAn_BUS
    {
        KetQuaTruyVan _ketQuaTruyVan = new KetQuaTruyVan();
        readonly DapAn_DAL _dapAn_DAL = new DapAn_DAL();

        public KetQuaTruyVan TimDapAnTheoCauHoi ( DapAn_DTO dapAn_DTO )
        {
            try
            {
                _ketQuaTruyVan = _dapAn_DAL.TimDapAnTheoCauHoi( dapAn_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm đáp án theo câu hỏi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
    }
}
