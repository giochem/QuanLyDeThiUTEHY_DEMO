using DTO;
using DTO.OneToOne;
using System.Data.SqlClient;

namespace DAL.OneToOne
{
    public class SinhVien_DAL : KetNoiDuLieu
    {
        string _truyVan;
        public KetQuaTruyVan ThemSinhVien ( SinhVien_DTO sinhVien_DTO )
        {
            _truyVan = "INSERT INTO SinhVien " +
             "VALUES(@ID_NguoiDung,@ID_Lop)";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@id_NguoiDung", sinhVien_DTO.ID_NguoiDung ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_Lop", sinhVien_DTO.ID_Lop ) );
            return ThucHienTruyVan( yeuCau, "SinhVien" );
        }
        public KetQuaTruyVan SuaSinhVien ( SinhVien_DTO sinhVien_DTO )
        {
            _truyVan = "UPDATE SinhVien SET" +
                " ID_Lop=@ID_Lop" +
                " WHERE ID_NguoiDung=@ID_NguoiDung";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_Lop", sinhVien_DTO.ID_Lop ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_NguoiDung", sinhVien_DTO.ID_NguoiDung ) );
            return ThucHienTruyVan( yeuCau, "SinhVien" );
        }
        public KetQuaTruyVan XoaSinhVien ( SinhVien_DTO sinhVien_DTO )
        {
            _truyVan = "DELETE FROM SinhVien " +
                " WHERE ID_NguoiDung=@ID_NguoiDung";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_NguoiDung", sinhVien_DTO.ID_NguoiDung ) );
            return ThucHienTruyVan( yeuCau, "SinhVien" );
        }
    }
}
