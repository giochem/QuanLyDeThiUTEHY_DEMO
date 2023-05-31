using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class MonHoc_DAL : KetNoiDuLieu
    {
        string _truyVan;
        public KetQuaTruyVan TimToanBoMonHoc ( )
        {
            _truyVan = "SELECT * FROM MonHoc";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            return ThucHienTruyVan( yeuCau, "MonHoc" );
        }
        public KetQuaTruyVan TimMonHoc ( MonHoc_DTO monHoc_DTO )
        {
            _truyVan = "SELECT * FROM MonHoc WHERE ID=@ID";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", monHoc_DTO.ID ) );
            return ThucHienTruyVan( yeuCau, "MonHoc" );
        }
        public KetQuaTruyVan TimMonHocTheoTenGanDung ( MonHoc_DTO monHoc_DTO )
        {
            _truyVan = "SELECT * FROM MonHoc WHERE Ten LIKE '%" + monHoc_DTO.Ten + "%'";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            //yeuCau.Parameters.Add( new SqlParameter( "@Ten", "%" + monHoc_DTO.Ten + "%" ) );
            return ThucHienTruyVan( yeuCau, "MonHoc" );
        }
        public KetQuaTruyVan TimMonHocTheoTen ( MonHoc_DTO monHoc_DTO )
        {
            _truyVan = "SELECT * FROM MonHoc WHERE Ten=@Ten";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@Ten", monHoc_DTO.Ten ) );
            return ThucHienTruyVan( yeuCau, "MonHoc" );
        }
        public KetQuaTruyVan ThemMonHoc ( MonHoc_DTO monHoc_DTO )
        {
            _truyVan = "INSERT INTO MonHoc " +
             "VALUES(@Ten)";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@Ten", monHoc_DTO.Ten ) );
            return ThucHienTruyVan( yeuCau, "MonHoc" );
        }
        public KetQuaTruyVan SuaMonHoc ( MonHoc_DTO monHoc_DTO )
        {
            _truyVan = "UPDATE MonHoc SET" +
                " Ten=@Ten" +
                " WHERE ID=@ID";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@Ten", monHoc_DTO.Ten ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", monHoc_DTO.ID ) );
            return ThucHienTruyVan( yeuCau, "MonHoc" );
        }
        public KetQuaTruyVan XoaMonHoc ( MonHoc_DTO monHoc_DTO )
        {
            _truyVan = "DELETE FROM MonHoc WHERE ID=@ID";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", monHoc_DTO.ID ) );

            return ThucHienTruyVan( yeuCau, "MonHoc" );
        }
    }
}
