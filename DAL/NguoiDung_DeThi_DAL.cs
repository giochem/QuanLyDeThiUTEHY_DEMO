using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class NguoiDung_DeThi_DAL : KetNoiDuLieu
    {
        string _truyVan;
        public KetQuaTruyVan ThongKeDiemThiTheoMonHoc ( MonHoc_DTO monHoc_DTO )
        {
            _truyVan = "select DiemThi, Count(DiemThi) as SoLuong from NguoiDung_DeThi a " +
                "inner join DeThi b on a.ID_DeThi=b.ID " +
                "inner join MonHoc c on b.ID_MonHoc=c.ID " +
                "where c.ID = @ID " +
                "GROUP BY a.DiemThi ORDER BY DiemThi ASC";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", monHoc_DTO.ID ) );
            return ThucHienTruyVan( yeuCau, "NguoiDung_DeThi" );
        }
        public KetQuaTruyVan TimNguoiDung_DeThiTheoNguoiDungDeThi ( NguoiDung_DeThi_DTO nguoiDung_DeThi_DTO )
        {
            _truyVan = "SELECT * FROM NguoiDung_DeThi WHERE ID_NguoiDung=@ID_NguoiDung AND ID_DeThi=@ID_DeThi";
            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_NguoiDung", nguoiDung_DeThi_DTO.ID_NguoiDung ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_DeThi", nguoiDung_DeThi_DTO.ID_DeThi ) );
            return ThucHienTruyVan( yeuCau, "NguoiDung_DeThi" );
        }
        public KetQuaTruyVan ThemNguoiDung_DeThi ( NguoiDung_DeThi_DTO nguoiDung_DeThi_DTO )
        {
            _truyVan = "INSERT INTO NguoiDung_DeThi " +
             "VALUES(@ID_NguoiDung,@ID_DeThi,@DiemThi,@BatDau,@KetThuc)";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_NguoiDung", nguoiDung_DeThi_DTO.ID_NguoiDung ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_DeThi", nguoiDung_DeThi_DTO.ID_DeThi ) );
            yeuCau.Parameters.Add( new SqlParameter( "@DiemThi", nguoiDung_DeThi_DTO.DiemThi ) );
            yeuCau.Parameters.Add( new SqlParameter( "@BatDau", nguoiDung_DeThi_DTO.BatDau ) );
            yeuCau.Parameters.Add( new SqlParameter( "@KetThuc", nguoiDung_DeThi_DTO.KetThuc ) );
            return ThucHienTruyVan( yeuCau, "NguoiDung_DeThi" );
        }
        public KetQuaTruyVan NopDeThi ( NguoiDung_DeThi_DTO nguoiDungDeThi_DTO )
        {
            _truyVan = "update NguoiDung_DeThi set KetThuc=@KetThuc,DiemThi = " +
                "(select soCauDung = COUNT(DapAnDung) from NguoiDung_DeThi a " +
                "inner join NguoiDung_ChiTietDeThi b on a.ID = b.ID_NguoiDung_DeThi " +
                "inner join ChiTietDeThi c on c.ID = b.ID_ChiTietDeThi " +
                "inner join CauHoi d on d.ID = c.ID_CauHoi " +
                "inner join DapAn e on e.ID_CauHoi = d.ID " +
                "WHERE a.ID = @ID AND b.CauTraLoi = e.STT AND e.DapAnDung = 1) WHERE ID = @ID";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@KetThuc", nguoiDungDeThi_DTO.KetThuc ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", nguoiDungDeThi_DTO.ID ) );
            return ThucHienTruyVan( yeuCau, "NguoiDung_DeThi" );
        }
        public KetQuaTruyVan SuaNguoiDung_DeThi ( NguoiDung_DeThi_DTO nguoiDung_DeThi_DTO )
        {
            _truyVan = "UPDATE NguoiDung_DeThi SET" +
                " ID_NguoiDung=@ID_NguoiDung,ID_DeThi=@ID_DeThi,DiemThi=@DiemThi,BatDau=@BatDau,KetThuc=@KetThuc" +
                " WHERE ID=@ID";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_NguoiDung", nguoiDung_DeThi_DTO.ID_DeThi ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ID_DeThi", nguoiDung_DeThi_DTO.ID_DeThi ) );
            yeuCau.Parameters.Add( new SqlParameter( "@DiemThi", nguoiDung_DeThi_DTO.DiemThi ) );
            yeuCau.Parameters.Add( new SqlParameter( "@BatDau", nguoiDung_DeThi_DTO.BatDau ) );
            yeuCau.Parameters.Add( new SqlParameter( "@KetThuc", nguoiDung_DeThi_DTO.KetThuc ) );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", nguoiDung_DeThi_DTO.ID ) );
            return ThucHienTruyVan( yeuCau, "NguoiDung_DeThi" );
        }
        public KetQuaTruyVan XoaNguoiDung_DeThi ( NguoiDung_DeThi_DTO nguoiDung_DeThi_DTO )
        {
            _truyVan = "DELETE FROM NguoiDung_DeThi WHERE ID=@ID";

            SqlCommand yeuCau = new SqlCommand( _truyVan, KetNoiDuLieu.KET_NOI );
            yeuCau.Parameters.Add( new SqlParameter( "@ID", nguoiDung_DeThi_DTO.ID ) );

            return ThucHienTruyVan( yeuCau, "NguoiDung_DeThi" );
        }
    }
}
