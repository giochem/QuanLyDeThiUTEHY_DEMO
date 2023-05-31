using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class DeThi_DAL : KetNoiDuLieu
    {
        string _truyVan;
        public KetQuaTruyVan TimToanBoDeThi ( )
        {
            _truyVan = "SELECT * FROM DeThi";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            return ThucHienTruyVan( yeuCau, "DeThi" );
        }
        public KetQuaTruyVan TimDeThiTheoMonHoc ( DeThi_DTO deThi_DTO )
        {
            _truyVan = "SELECT top 1 * FROM DeThi WHERE ID_MonHoc=@ID_MonHoc AND NgayBatDau <=GETDATE() AND GETDATE()<= NgayKetThuc order by newid()";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_MonHoc", deThi_DTO.ID_MonHoc ) );
            return ThucHienTruyVan( yeuCau, "DeThi" );
        }
        public KetQuaTruyVan TimDeThiTheoTieuDe ( DeThi_DTO deThi_DTO )
        {
            _truyVan = "SELECT * FROM DeThi WHERE TieuDe=@TieuDe";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@TieuDe", deThi_DTO.TieuDe ) );
            return ThucHienTruyVan( yeuCau, "DeThi" );
        }
        public KetQuaTruyVan TimDeThi ( DeThi_DTO deThi_DTO )
        {
            _truyVan = "SELECT * FROM DeThi where ID=@ID";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", deThi_DTO.ID ) );
            return ThucHienTruyVan( yeuCau, "DeThi" );
        }
        public KetQuaTruyVan ThemDeThi ( DeThi_DTO deThi_DTO )
        {
            _truyVan = "INSERT INTO DeThi" +
             " VALUES(@ID_MonHoc,@TieuDe,@SoCauHoi,@ThoiGian,@SoCauToiThieu,@NgayBatDau,@NgayKetThuc)";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_MonHoc", deThi_DTO.ID_MonHoc ) );
            yeuCau.Parameters.Add( new SqlParameter( "@TieuDe", deThi_DTO.TieuDe ) );
            yeuCau.Parameters.Add( new SqlParameter( "@SoCauHoi", deThi_DTO.SoCauHoi ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ThoiGian", deThi_DTO.ThoiGian ) );

            yeuCau.Parameters.Add( new SqlParameter( "@SoCauToiThieu", deThi_DTO.SoCauToiThieu ) );
            yeuCau.Parameters.Add( new SqlParameter( "@NgayBatDau", deThi_DTO.NgayBatDau ) );
            yeuCau.Parameters.Add( new SqlParameter( "@NgayKetThuc", deThi_DTO.NgayKetThuc ) );
            return ThucHienTruyVan( yeuCau, "DeThi" );
        }

        public KetQuaTruyVan SuaDeThi ( DeThi_DTO deThi_DTO )
        {
            _truyVan = "UPDATE DeThi SET" +
                " ID_MonHoc=@ID_MonHoc,TieuDe=@TieuDe,SoCauHoi=@SoCauHoi,ThoiGian=@ThoiGian,SoCauToiThieu=@SoCauToiThieu,NgayBatDau=@NgayBatDau,NgayKetThuc=@NgayKetThuc" +
                " WHERE ID=@ID";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_MonHoc", deThi_DTO.ID_MonHoc ) );
            yeuCau.Parameters.Add( new SqlParameter( "@TieuDe", deThi_DTO.TieuDe ) );
            yeuCau.Parameters.Add( new SqlParameter( "@SoCauHoi", deThi_DTO.SoCauHoi ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ThoiGian", deThi_DTO.ThoiGian ) );
            yeuCau.Parameters.Add( new SqlParameter( "@SoCauToiThieu", deThi_DTO.SoCauToiThieu ) );
            yeuCau.Parameters.Add( new SqlParameter( "@NgayBatDau", deThi_DTO.NgayBatDau.ToString( "s" ) ) );
            yeuCau.Parameters.Add( new SqlParameter( "@NgayKetThuc", deThi_DTO.NgayKetThuc.ToString( "s" ) ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", deThi_DTO.ID ) );
            return ThucHienTruyVan( yeuCau, "DeThi" );
        }
        public KetQuaTruyVan XoaDeThi ( DeThi_DTO deThi_DTO )
        {
            _truyVan = "DELETE FROM DeThi WHERE ID=@ID";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", deThi_DTO.ID ) );

            return ThucHienTruyVan( yeuCau, "DeThi" );
        }
    }
}
