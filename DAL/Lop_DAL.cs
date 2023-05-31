using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class Lop_DAL : KetNoiDuLieu
    {
        string _truyVan;
        public KetQuaTruyVan TimLopTheoKhoa ( Lop_DTO lop_DTO )
        {
            _truyVan = "SELECT * FROM Lop WHERE ID_Khoa=@ID_Khoa";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_Khoa", lop_DTO.ID_Khoa ) );
            return ThucHienTruyVan( yeuCau, "Lop" );
        }

        public KetQuaTruyVan ThemLop ( Lop_DTO lop_DTO )
        {
            _truyVan = "INSERT INTO Lop VALUES(@ID_Khoa,@TenLop,@HeDaoTao,@NamNhapHoc)";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_Khoa", lop_DTO.ID_Khoa ) );
            yeuCau.Parameters.Add( new SqlParameter( "@TenLop", lop_DTO.TenLop ) );
            yeuCau.Parameters.Add( new SqlParameter( "@HeDaoTao", lop_DTO.HeDaoTao ) );
            yeuCau.Parameters.Add( new SqlParameter( "@NamNhapHoc", lop_DTO.NamNhapHoc ) );
            return ThucHienTruyVan( yeuCau, "Lop" );
        }
        public KetQuaTruyVan SuaLop ( Lop_DTO lop_DTO )
        {
            _truyVan = "UPDATE Lop SET" +
                " ID_Khoa=@ID_Khoa,TenLop=@TenLop,HeDaoTao=@HeDaoTao,NamNhapHoc=@NamNhapHoc" +
                " WHERE ID=@ID";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_Khoa", lop_DTO.ID_Khoa ) );
            yeuCau.Parameters.Add( new SqlParameter( "@TenLop", lop_DTO.TenLop ) );
            yeuCau.Parameters.Add( new SqlParameter( "@HeDaoTao", lop_DTO.HeDaoTao ) );
            yeuCau.Parameters.Add( new SqlParameter( "@NamNhapHoc", lop_DTO.NamNhapHoc ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", lop_DTO.ID ) );
            return ThucHienTruyVan( yeuCau, "Lop" );
        }
        public KetQuaTruyVan XoaLop ( Lop_DTO lop_DTO )
        {
            _truyVan = "DELETE FROM Lop WHERE ID=@ID";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", lop_DTO.ID ) );
            return ThucHienTruyVan( yeuCau, "Lop" );
        }
    }
}
