using DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace BUS
{
    public class CauHoi_BUS
    {
        KetQuaTruyVan _ketQuaTruyVan = new KetQuaTruyVan();
        readonly CauHoi_DAL _cauHoi_DAL = new CauHoi_DAL();
        readonly DapAn_DAL _dapAn_DAL = new DapAn_DAL();
        public KetQuaTruyVan TimToanBoCauHoi ( )
        {
            try
            {
                _ketQuaTruyVan = _cauHoi_DAL.TimToanBoCauHoi();
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm toàn bộ câu hỏi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan TimCauHoiTheoMonHoc ( MonHoc_DTO monHoc_DTO )
        {
            try
            {
                _ketQuaTruyVan = _cauHoi_DAL.TimCauHoiTheoMonHoc( monHoc_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm câu hỏi theo môn học thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan TimCauHoiTheoChiTietDeThi ( ChiTietDeThi_DTO chiTietDeThi_DTO )
        {
            try
            {
                _ketQuaTruyVan = _cauHoi_DAL.TimCauHoiTheoChiTietDeThi( chiTietDeThi_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm câu hỏi theo chi tiết đề thi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan TimCauHoi ( CauHoi_DTO cauHoi_DTO )
        {
            try
            {
                _ketQuaTruyVan = _cauHoi_DAL.TimCauHoi( cauHoi_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm câu hỏi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan ThemCauHoi ( CauHoi_DTO cauHoi_DTO, List<DapAn_DTO> dapAn_DTOs )
        {
            try
            {
                KetQuaTruyVan timKiem = _cauHoi_DAL.TimCauHoiTheoTieuDe( cauHoi_DTO );
                if ( timKiem.DuLieu.Tables[ 0 ].Rows.Count >= 1 )
                {
                    _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 1 ).ThemLoiNhan( "Tên câu hỏi đã tồn tại" );
                    return _ketQuaTruyVan;
                }
                _ketQuaTruyVan = _cauHoi_DAL.ThemCauHoi( cauHoi_DTO );
                int id = (int) _ketQuaTruyVan.DuLieu.Tables[ 0 ].Rows[ 0 ][ "ID" ];

                dapAn_DTOs.ForEach( dapAn_DTO =>
                {
                    dapAn_DTO.ID_CauHoi = id;
                    _dapAn_DAL.ThemDapAn( dapAn_DTO );

                } );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Thêm câu hỏi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan SuaCauHoi ( CauHoi_DTO cauHoi_DTO, List<DapAn_DTO> dapAn_DTOs )
        {
            try
            {
                _cauHoi_DAL.SuaCauHoi( cauHoi_DTO );
                dapAn_DTOs.ForEach( dapAn_DTO =>
                {
                    dapAn_DTO.ID_CauHoi = cauHoi_DTO.ID;
                    _dapAn_DAL.SuaDapAn( dapAn_DTO );
                } );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Cập nhật câu hỏi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan XoaCauHoi ( CauHoi_DTO cauHoi_DTO )
        {
            try
            {
                _cauHoi_DAL.XoaCauHoi( cauHoi_DTO );

                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Xóa câu hỏi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
    }
}
