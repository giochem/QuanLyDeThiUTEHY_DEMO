using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class ChiTietDeThi_DAL : KetNoiDuLieu
    {
        string _truyVan;
        public KetQuaTruyVan TimChiTietDeThiTheoDeThi ( ChiTietDeThi_DTO chiTietDeThi_DTO )
        {
            _truyVan = "SELECT * FROM ChiTietDeThi WHERE ID_DeThi=@ID_DeThi";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_DeThi", chiTietDeThi_DTO.ID_DeThi ) );
            return ThucHienTruyVan( yeuCau, "ChiTietDeThi" );
        }

        public KetQuaTruyVan ThemChiTietDeThiTheoCauHoi ( DeThi_DTO deThi_DTO )
        {
            _truyVan = "insert into ChiTietDeThi(ID_DeThi,ID_CauHoi) select top 10 @ID_DeThi,ID from CauHoi order by newid()";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@SoCauHoi", deThi_DTO.SoCauHoi ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_DeThi", deThi_DTO.ID ) );
            return ThucHienTruyVan( yeuCau, "ChiTietDeThi" );
        }
        //public KetQuaTruyVan SuaChiTietDeThi ( ChiTietDeThi_DTO chiTietDeThi_DTO )
        //{
        //    _truyVan = "UPDATE ChiTietDeThi SET" +
        //        " ID_DeThi=@ID_DeThi,ID_CauHoi=@ID_CauHoi,STT=@STT" +
        //        " WHERE ID=@ID";

        //    SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
        //    yeuCau.Parameters.Add( new SqlParameter( "@ID_DeThi", chiTietDeThi_DTO.ID_DeThi ) );
        //    yeuCau.Parameters.Add( new SqlParameter( "@ID_CauHoi", chiTietDeThi_DTO.ID_CauHoi ) );
        //    yeuCau.Parameters.Add( new SqlParameter( "@STT", chiTietDeThi_DTO.STT ) );
        //    yeuCau.Parameters.Add( new SqlParameter( "@ID", chiTietDeThi_DTO.ID ) );
        //    return ThucHienTruyVan( yeuCau, "ChiTietDeThi" );
        //}
        //public KetQuaTruyVan XoaChiTietDeThi ( ChiTietDeThi_DTO chiTietDeThi_DTO )
        //{
        //    _truyVan = "DELETE FROM ChiTietDeThi" +
        //        " WHERE ID=@ID";

        //    SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
        //    yeuCau.Parameters.Add( new SqlParameter( "@ID", chiTietDeThi_DTO.ID ) );
        //    return ThucHienTruyVan( yeuCau, "ChiTietDeThi" );
        //}
    }
}
