using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class DapAn_DAL : KetNoiDuLieu
    {
        string _truyVan;
        public KetQuaTruyVan TimDapAnTheoCauHoi ( DapAn_DTO dapAn_DTO )
        {
            _truyVan = "SELECT * FROM DapAn WHERE ID_CauHoi=@ID_CauHoi";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_CauHoi", dapAn_DTO.ID_CauHoi ) );
            return ThucHienTruyVan( yeuCau, "DapAn" );
        }
        public KetQuaTruyVan ThemDapAn ( DapAn_DTO dapAn_DTO )
        {
            _truyVan = "INSERT INTO DapAn(ID_CauHoi,STT,NoiDung,DapAnDung) VALUES(@ID_CauHoi,@STT,@NoiDung,@DapAnDung)";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_CauHoi", dapAn_DTO.ID_CauHoi ) );
            yeuCau.Parameters.Add( new SqlParameter( "@STT", dapAn_DTO.STT ) );
            yeuCau.Parameters.Add( new SqlParameter( "@NoiDung", dapAn_DTO.NoiDung ) );
            yeuCau.Parameters.Add( new SqlParameter( "@DapAnDung", dapAn_DTO.DapAnDung ) );
            return ThucHienTruyVan( yeuCau, "DapAn" );
        }
        public KetQuaTruyVan SuaDapAn ( DapAn_DTO dapAn_DTO )
        {
            _truyVan = "UPDATE DapAn SET" +
                " NoiDung=@NoiDung,DapAnDung=@DapAnDung" +
                " WHERE ID_CauHoi=@ID_CauHoi AND STT=@STT";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@NoiDung", dapAn_DTO.NoiDung ) );
            yeuCau.Parameters.Add( new SqlParameter( "@DapAnDung", dapAn_DTO.DapAnDung ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_CauHoi", dapAn_DTO.ID_CauHoi ) );
            yeuCau.Parameters.Add( new SqlParameter( "@STT", dapAn_DTO.STT ) );
            return ThucHienTruyVan( yeuCau, "DapAn" );
        }
        //public KetQuaTruyVan XoaDapAn ( DapAn_DTO dapAn_DTO )
        //{
        //    _truyVan = "DELETE FROM DapAn WHERE ID=@ID";

        //    SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
        //    yeuCau.Parameters.Add( new SqlParameter( "@ID", dapAn_DTO.ID ) );

        //    return ThucHienTruyVan( yeuCau, "DapAn" );
        //}
    }
}
