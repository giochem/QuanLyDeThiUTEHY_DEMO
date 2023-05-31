using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class CauHoi_DAL : KetNoiDuLieu
    {
        string _truyVan;
        public KetQuaTruyVan TimToanBoCauHoi ( )
        {
            _truyVan = "SELECT * FROM CauHoi";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            return ThucHienTruyVan( yeuCau, "CauHoi" );
        }
        public KetQuaTruyVan TimCauHoi ( CauHoi_DTO cauHoi_DTO )
        {
            _truyVan = "SELECT * FROM CauHoi WHERE ID=@ID";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", cauHoi_DTO.ID ) );
            return ThucHienTruyVan( yeuCau, "CauHoi" );
        }
        public KetQuaTruyVan TimCauHoiTheoMonHoc ( MonHoc_DTO monHoc_DTO )
        {
            _truyVan = "select a.ID,a.TieuDe from CauHoi a\r\nINNER JOIN ChiTietMonHoc b on a.ID_ChiTietMonHoc=b.ID\r\nINNER JOIN MonHoc c on c.ID = b.ID_MonHoc WHERE c.ID = @ID";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", monHoc_DTO.ID ) );
            return ThucHienTruyVan( yeuCau, "CauHoi" );
        }
        public KetQuaTruyVan TimCauHoiTheoKienThuc ( CauHoi_DTO cauHoi_DTO )
        {
            _truyVan = "SELECT * FROM CauHoi WHERE ID_ChiTietMonHoc = @ID_ChiTietMonHoc";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_ChiTietMonHoc", cauHoi_DTO.ID_ChiTietMonHoc ) );
            return ThucHienTruyVan( yeuCau, "CauHoi" );
        }
        public KetQuaTruyVan TimCauHoiTheoTieuDe ( CauHoi_DTO cauHoi_DTO )
        {
            _truyVan = "SELECT * FROM CauHoi WHERE TieuDe LIKE @TieuDe";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@TieuDe", "%" + cauHoi_DTO.TieuDe + "%" ) );
            return ThucHienTruyVan( yeuCau, "CauHoi" );
        }
        public KetQuaTruyVan TimCauHoiTheoChiTietDeThi ( ChiTietDeThi_DTO chiTietDeThi_DTO )
        {
            _truyVan = "SELECT a.* FROM CauHoi a inner join ChiTietDeThi b on a.ID = b.ID_CauHoi WHERE b.ID=@ID";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@TieuDe", chiTietDeThi_DTO.ID ) );
            return ThucHienTruyVan( yeuCau, "CauHoi" );
        }
        public KetQuaTruyVan ThemCauHoi ( CauHoi_DTO cauHoi_DTO )
        {
            _truyVan = "INSERT INTO CauHoi(ID_ChiTietMonHoc,TieuDe,DoKho,GiaiThich,NoiDung) OUTPUT INSERTED.* VALUES(@ID_ChiTietMonHoc,@TieuDe,@DoKho,@GiaiThich,@NoiDung)";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_ChiTietMonHoc", cauHoi_DTO.ID_ChiTietMonHoc ) );
            yeuCau.Parameters.Add( new SqlParameter( "@TieuDe", cauHoi_DTO.TieuDe ) );
            yeuCau.Parameters.Add( new SqlParameter( "@DoKho", cauHoi_DTO.DoKho ) );
            yeuCau.Parameters.Add( new SqlParameter( "@GiaiThich", cauHoi_DTO.GiaiThich ) );
            yeuCau.Parameters.Add( new SqlParameter( "@NoiDung", cauHoi_DTO.NoiDung ) );

            return ThucHienTruyVan( yeuCau, "CauHoi" );
        }
        public KetQuaTruyVan SuaCauHoi ( CauHoi_DTO cauHoi_DTO )
        {
            _truyVan = "UPDATE CauHoi SET" +
                " TieuDe=@TieuDe,DoKho=@DoKho,GiaiThich=@GiaiThich,NoiDung=@NoiDung" +
                " WHERE ID=@ID";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            //yeuCau.Parameters.Add( new SqlParameter( "@ID_ChiTietMonHoc", cauHoi_DTO.ID_ChiTietMonHoc ) );
            yeuCau.Parameters.Add( new SqlParameter( "@TieuDe", cauHoi_DTO.TieuDe ) );
            yeuCau.Parameters.Add( new SqlParameter( "@DoKho", cauHoi_DTO.DoKho ) );
            yeuCau.Parameters.Add( new SqlParameter( "@GiaiThich", cauHoi_DTO.GiaiThich ) );
            yeuCau.Parameters.Add( new SqlParameter( "@NoiDung", cauHoi_DTO.NoiDung ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", cauHoi_DTO.ID ) );

            return ThucHienTruyVan( yeuCau, "CauHoi" );
        }
        public KetQuaTruyVan XoaCauHoi ( CauHoi_DTO cauHoi_DTO )
        {
            _truyVan = "DELETE FROM CauHoi WHERE ID=@ID";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", cauHoi_DTO.ID ) );

            return ThucHienTruyVan( yeuCau, "CauHoi" );
        }
    }
}
