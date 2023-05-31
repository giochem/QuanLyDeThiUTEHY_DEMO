using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class NguoiDung_DAL : KetNoiDuLieu
    {
        string _truyVan;
        public KetQuaTruyVan TimNguoiDungTheoTaiKhoan ( NguoiDung_DTO nguoiDung_DTO )
        {
            _truyVan = "SELECT * FROM NguoiDung WHERE TaiKhoan=@TaiKhoan";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@TaiKhoan", nguoiDung_DTO.TaiKhoan ) );
            return ThucHienTruyVan( yeuCau, "NguoiDung" );
        }
        public KetQuaTruyVan TimToanBoSinhVien ( )
        {
            _truyVan = "SELECT NguoiDung.*, Lop.TenLop,Khoa.TenKhoa FROM NguoiDung " +
                "INNER JOIN SinhVien ON NguoiDung.ID = SinhVien.ID_NguoiDung " +
                "INNER JOIN Lop ON Lop.ID = SinhVien.ID_Lop " +
                "INNER JOIN Khoa ON Lop.ID_Khoa = Khoa.ID";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            return ThucHienTruyVan( yeuCau, "NguoiDung" );
        }
        public KetQuaTruyVan TimNguoiDungTheoVaiTro ( NguoiDung_DTO nguoiDung_DTO )
        {
            _truyVan = "SELECT * FROM NguoiDung WHERE VaiTro=@VaiTro";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@VaiTro", nguoiDung_DTO.VaiTro ) );
            return ThucHienTruyVan( yeuCau, "NguoiDung" );
        }
        public KetQuaTruyVan ThemNguoiDung ( NguoiDung_DTO nguoiDung_DTO )
        {
            _truyVan = "INSERT INTO NguoiDung OUTPUT Inserted.* " +
             "VALUES(@TaiKhoan,@MatKhau,@VaiTro,@Email)";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@TaiKhoan", nguoiDung_DTO.TaiKhoan ) );
            yeuCau.Parameters.Add( new SqlParameter( "@MatKhau", nguoiDung_DTO.MatKhau ) );
            yeuCau.Parameters.Add( new SqlParameter( "@VaiTro", nguoiDung_DTO.VaiTro ) );
            yeuCau.Parameters.Add( new SqlParameter( "@Email", nguoiDung_DTO.Email ) );
            return ThucHienTruyVan( yeuCau, "NguoiDung" );
        }
        public KetQuaTruyVan SuaNguoiDung ( NguoiDung_DTO nguoiDung_DTO )
        {
            _truyVan = "UPDATE NguoiDung SET" +
                " TaiKhoan=@TaiKhoan,MatKhau=@MatKhau,VaiTro=@VaiTro,Email=@Email" +
                " WHERE ID=@ID";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@TaiKhoan", nguoiDung_DTO.TaiKhoan ) );
            yeuCau.Parameters.Add( new SqlParameter( "@MatKhau", nguoiDung_DTO.MatKhau ) );
            yeuCau.Parameters.Add( new SqlParameter( "@VaiTro", nguoiDung_DTO.VaiTro ) );
            yeuCau.Parameters.Add( new SqlParameter( "@Email", nguoiDung_DTO.Email ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", nguoiDung_DTO.ID ) );


            return ThucHienTruyVan( yeuCau, "NguoiDung" );
        }
        public KetQuaTruyVan XoaNguoiDung ( NguoiDung_DTO nguoiDung_DTO )
        {
            _truyVan = "DELETE FROM NguoiDung WHERE ID=@ID";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", nguoiDung_DTO.ID ) );

            return ThucHienTruyVan( yeuCau, "NguoiDung" );
        }
    }
}
