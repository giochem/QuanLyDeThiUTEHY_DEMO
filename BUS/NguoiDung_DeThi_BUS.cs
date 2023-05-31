using DAL;
using DTO;
using System;

namespace BUS
{
    public class NguoiDung_DeThi_BUS
    {
        KetQuaTruyVan _ketQuaTruyVan = new KetQuaTruyVan();
        readonly NguoiDung_DeThi_DAL _nguoiDung_DeThi_DAL = new NguoiDung_DeThi_DAL();

        public KetQuaTruyVan ThongKeDiemThiTheoMonHoc ( MonHoc_DTO monHoc_DTO )
        {
            try
            {
                _ketQuaTruyVan = _nguoiDung_DeThi_DAL.ThongKeDiemThiTheoMonHoc( monHoc_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Thống kê điểm thi theo môn học thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan TimNguoiDung_DeThiTheoNguoiDungVaDeThi ( NguoiDung_DeThi_DTO nguoiDung_DeThi_DTO )
        {
            try
            {
                _ketQuaTruyVan = _nguoiDung_DeThi_DAL.TimNguoiDung_DeThiTheoNguoiDungDeThi( nguoiDung_DeThi_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Tìm kiếm người dùng làm đề thi theo người dùng và đề thi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan ThemNguoiDung_DeThi ( NguoiDung_DeThi_DTO nguoiDung_DeThi_DTO )
        {
            try
            {
                KetQuaTruyVan timKiem = _nguoiDung_DeThi_DAL.TimNguoiDung_DeThiTheoNguoiDungDeThi( nguoiDung_DeThi_DTO );
                if ( timKiem.DuLieu.Tables[ 0 ].Rows.Count >= 1 )
                {
                    _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 1 ).ThemLoiNhan( "Người dùng làm đề thi đã tồn tại" );
                    return _ketQuaTruyVan;
                }
                _nguoiDung_DeThi_DAL.ThemNguoiDung_DeThi( nguoiDung_DeThi_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Thêm người dùng làm đề thi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan NopDeThi ( NguoiDung_DeThi_DTO nguoiDungDeThi_DTO )
        {
            try
            {
                _nguoiDung_DeThi_DAL.NopDeThi( nguoiDungDeThi_DTO );

                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Nộp đề thi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan SuaNguoiDung_DeThi ( NguoiDung_DeThi_DTO nguoiDung_DeThi_DTO )
        {
            try
            {
                _nguoiDung_DeThi_DAL.SuaNguoiDung_DeThi( nguoiDung_DeThi_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Sửa người dùng làm đề thi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
        public KetQuaTruyVan XoaNguoiDung_DeThi ( NguoiDung_DeThi_DTO nguoiDung_DeThi_DTO )
        {
            try
            {
                _nguoiDung_DeThi_DAL.XoaNguoiDung_DeThi( nguoiDung_DeThi_DTO );
                _ketQuaTruyVan.ThemThanhCong( true ).ThemMaPhanHoi( 0 ).ThemLoiNhan( "Xóa người dùng làm đề thi thành công" );
            }
            catch ( Exception e )
            {
                _ketQuaTruyVan.ThemThanhCong( false ).ThemMaPhanHoi( 2 ).ThemLoiNhan( e.Message );
            }
            return _ketQuaTruyVan;
        }
    }
}
