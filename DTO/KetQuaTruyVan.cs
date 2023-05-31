using System.Data;

namespace DTO
{
    public class KetQuaTruyVan : IKetQuaTruyVan
    {
        public KetQuaTruyVan ( ) { }
        public KetQuaTruyVan ( bool thanhCong, int maPhanHoi, string loiNhan, DataSet duLieu )
        {
            ThanhCong = thanhCong;
            MaPhanHoi = maPhanHoi;
            LoiNhan = loiNhan;
            DuLieu = duLieu;
        }
        public bool ThanhCong { get; set; }
        public int MaPhanHoi { get; set; }
        public string LoiNhan { get; set; }
        public DataSet DuLieu { get; set; }

        public KetQuaTruyVan ThemThanhCong ( bool thanhCong )
        {
            ThanhCong = thanhCong;
            return this;
        }
        public KetQuaTruyVan ThemMaPhanHoi ( int maPhanHoi )
        {
            MaPhanHoi = maPhanHoi;
            return this;
        }

        public KetQuaTruyVan ThemLoiNhan ( string loiNhan )
        {
            LoiNhan = loiNhan;
            return this;
        }

        public KetQuaTruyVan ThemDuLieu ( DataSet duLieu )
        {
            DuLieu = duLieu;
            return this;
        }
    }
}
