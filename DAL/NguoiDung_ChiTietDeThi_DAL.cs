using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class NguoiDung_ChiTietDeThi_DAL : KetNoiDuLieu
    {
        string _truyVan;
        public KetQuaTruyVan TimNguoiDung_ChiTietDeThiTheoNguoiDung_DeThi ( NguoiDung_ChiTietDeThi_DTO nguoiDung_ChiTietDeThi_DTO )
        {
            _truyVan = "SELECT * FROM NguoiDung_ChiTietDeThi " +
             "WHERE ID_NguoiDung_DeThi=@ID_NguoiDung_DeThi";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_NguoiDung_DeThi", nguoiDung_ChiTietDeThi_DTO.ID_NguoiDung_DeThi ) );
            return ThucHienTruyVan( yeuCau, "NguoiDung_ChiTietDeThi" );
        }
        public KetQuaTruyVan TimNguoiDung_ChiTietDeThiTheoNguoiDung_DeThiVaChiTietDeThi ( NguoiDung_ChiTietDeThi_DTO nguoiDung_ChiTietDeThi_DTO )
        {
            _truyVan = "SELECT * FROM NguoiDung_ChiTietDeThi " +
             "WHERE ID_NguoiDung_DeThi=@ID_NguoiDung_DeThi AND ID_ChiTietDeThi=@ID_ChiTietDeThi";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_NguoiDung_DeThi", nguoiDung_ChiTietDeThi_DTO.ID_NguoiDung_DeThi ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_ChiTietDeThi", nguoiDung_ChiTietDeThi_DTO.ID_ChiTietDeThi ) );
            return ThucHienTruyVan( yeuCau, "NguoiDung_ChiTietDeThi" );
        }
        public KetQuaTruyVan ThemNguoiDung_ChiTietDeThi ( NguoiDung_ChiTietDeThi_DTO nguoiDung_ChiTietDeThi_DTO )
        {
            _truyVan = "INSERT INTO NguoiDung_ChiTietDeThi " +
             "VALUES(@ID_NguoiDung_DeThi,@ID_ChiTietDeThi,@CauTraLoi)";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_NguoiDung_DeThi", nguoiDung_ChiTietDeThi_DTO.ID_NguoiDung_DeThi ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_ChiTietDeThi", nguoiDung_ChiTietDeThi_DTO.ID_ChiTietDeThi ) );
            yeuCau.Parameters.Add( new SqlParameter( "@CauTraLoi", nguoiDung_ChiTietDeThi_DTO.CauTraLoi ) );
            return ThucHienTruyVan( yeuCau, "NguoiDung_ChiTietDeThi" );
        }
        public KetQuaTruyVan SuaNguoiDung_ChiTietDeThi ( NguoiDung_ChiTietDeThi_DTO nguoiDung_ChiTietDeThi_DTO )
        {
            _truyVan = "UPDATE NguoiDung_ChiTietDeThi SET" +
                " ID_NguoiDung_DeThi=@ID_NguoiDung_DeThi,ID_ChiTietDeThi=@ID_ChiTietDeThi,CauTraLoi=@CauTraLoi" +
                " WHERE ID=@ID";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_NguoiDung_DeThi", nguoiDung_ChiTietDeThi_DTO.ID_NguoiDung_DeThi ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_ChiTietDeThi", nguoiDung_ChiTietDeThi_DTO.ID_ChiTietDeThi ) );
            yeuCau.Parameters.Add( new SqlParameter( "@CauTraLoi", nguoiDung_ChiTietDeThi_DTO.CauTraLoi ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", nguoiDung_ChiTietDeThi_DTO.ID_NguoiDung_DeThi ) );
            return ThucHienTruyVan( yeuCau, "NguoiDung_ChiTietDeThi" );
        }
        public KetQuaTruyVan XoaNguoiDung_DeThi ( NguoiDung_ChiTietDeThi_DTO nguoiDung_ChiTietDeThi_DTO )
        {
            _truyVan = "DELETE FROM NguoiDung_ChiTietDeThi WHERE ID=@ID";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", nguoiDung_ChiTietDeThi_DTO.ID_NguoiDung_DeThi ) );

            return ThucHienTruyVan( yeuCau, "NguoiDung_ChiTietDeThi" );
        }
    }
}
