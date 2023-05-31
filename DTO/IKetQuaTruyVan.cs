using System.Data;

namespace DTO
{
    interface IKetQuaTruyVan
    {
        KetQuaTruyVan ThemMaPhanHoi ( int maPhanHoi );
        KetQuaTruyVan ThemThanhCong ( bool thanhCong );
        KetQuaTruyVan ThemLoiNhan ( string loiNhan );
        KetQuaTruyVan ThemDuLieu ( DataSet duLieu );
    }
}
