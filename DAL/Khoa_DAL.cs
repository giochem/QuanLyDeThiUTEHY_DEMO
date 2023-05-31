using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class Khoa_DAL : KetNoiDuLieu
    {
        string _truyVan;
        public KetQuaTruyVan TimToanBoKhoa ( )
        {
            _truyVan = "SELECT * FROM Khoa";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            return ThucHienTruyVan( yeuCau, "Khoa" );
        }

        public KetQuaTruyVan ThemKhoa ( Khoa_DTO khoa_DTO )
        {
            _truyVan = "INSERT INTO Khoa " +
             "VALUES(@TenKhoa,@DienThoai,@DiaDiem)";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@TenKhoa", khoa_DTO.TenKhoa ) );
            yeuCau.Parameters.Add( new SqlParameter( "@DienThoai", khoa_DTO.DienThoai ) );
            yeuCau.Parameters.Add( new SqlParameter( "@DiaDiem", khoa_DTO.DiaDiem ) );
            return ThucHienTruyVan( yeuCau, "Khoa" );
        }
        public KetQuaTruyVan SuaKhoa ( Khoa_DTO khoa_DTO )
        {
            _truyVan = "UPDATE Khoa SET" +
                " TenKhoa=@TenKhoa,DienThoai=@DienThoai,DiaDiem=@DiaDiem" +
                " WHERE ID=@ID";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@TenKhoa", khoa_DTO.TenKhoa ) );
            yeuCau.Parameters.Add( new SqlParameter( "@DienThoai", khoa_DTO.DienThoai ) );
            yeuCau.Parameters.Add( new SqlParameter( "@DiaDiem", khoa_DTO.DiaDiem ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", khoa_DTO.ID ) );
            return ThucHienTruyVan( yeuCau, "Khoa" );
        }
        public KetQuaTruyVan XoaKhoa ( Khoa_DTO khoa_DTO )
        {
            _truyVan = "DELETE FROM Khoa WHERE ID=@ID";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", khoa_DTO.ID ) );
            return ThucHienTruyVan( yeuCau, "Khoa" );
        }
    }
}
