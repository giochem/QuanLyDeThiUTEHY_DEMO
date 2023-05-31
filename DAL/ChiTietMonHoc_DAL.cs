using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class ChiTietMonHoc_DAL : KetNoiDuLieu
    {
        string _truyVan;
        public KetQuaTruyVan TimToanBoChiTietMonHoc ( )
        {
            _truyVan = "SELECT * FROM ChiTietMonHoc";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            return ThucHienTruyVan( yeuCau, "ChiTietMonHoc" );
        }

        public KetQuaTruyVan TimChiTietMonHocTheoMonHoc ( ChiTietMonHoc_DTO chiTietMonHoc_DTO )
        {
            _truyVan = "SELECT * FROM ChiTietMonHoc WHERE ID_MonHoc=@ID_MonHoc";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_MonHoc", chiTietMonHoc_DTO.ID_MonHoc ) );
            return ThucHienTruyVan( yeuCau, "ChiTietMonHoc" );
        }
        public KetQuaTruyVan TimChiTietMonHocTheoKienThuc ( ChiTietMonHoc_DTO chiTietMonHoc_DTO )
        {
            _truyVan = "SELECT * FROM ChiTietMonHoc WHERE KienThuc=@KienThuc";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@KienThuc", chiTietMonHoc_DTO.KienThuc ) );
            return ThucHienTruyVan( yeuCau, "ChiTietMonHoc" );
        }
        public KetQuaTruyVan TimChiTietMonHoc ( ChiTietMonHoc_DTO chiTietMonHoc_DTO )
        {
            _truyVan = "SELECT * FROM ChiTietMonHoc WHERE ID=@ID";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", chiTietMonHoc_DTO.ID ) );
            return ThucHienTruyVan( yeuCau, "ChiTietMonHoc" );
        }
        public KetQuaTruyVan ThemChiTietMonHoc ( ChiTietMonHoc_DTO chiTietMonHoc_DTO )
        {
            _truyVan = "INSERT INTO ChiTietMonHoc VALUES(@ID_MonHoc,@KienThuc)";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_MonHoc", chiTietMonHoc_DTO.ID_MonHoc ) );
            yeuCau.Parameters.Add( new SqlParameter( "@KienThuc", chiTietMonHoc_DTO.KienThuc ) );
            return ThucHienTruyVan( yeuCau, "ChiTietMonHoc" );
        }
        public KetQuaTruyVan SuaChiTietMonHoc ( ChiTietMonHoc_DTO chiTietMonHoc_DTO )
        {
            _truyVan = "UPDATE ChiTietMonHoc SET" +
                " ID_MonHoc=@ID_MonHoc,KienThuc=@KienThuc" +
                " WHERE ID=@ID";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_MonHoc", chiTietMonHoc_DTO.ID_MonHoc ) );
            yeuCau.Parameters.Add( new SqlParameter( "@KienThuc", chiTietMonHoc_DTO.KienThuc ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", chiTietMonHoc_DTO.ID ) );
            return ThucHienTruyVan( yeuCau, "ChiTietMonHoc" );
        }
        public KetQuaTruyVan XoaChiTietMonHoc ( ChiTietMonHoc_DTO chiTietMonHoc_DTO )
        {
            _truyVan = "DELETE FROM ChiTietMonHoc WHERE ID=@ID";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", chiTietMonHoc_DTO.ID ) );

            return ThucHienTruyVan( yeuCau, "ChiTietMonHoc" );
        }
    }
}
