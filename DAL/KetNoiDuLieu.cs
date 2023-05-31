using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class KetNoiDuLieu
    {
        public readonly static SqlConnection KET_NOI = new SqlConnection( @"Data Source=GIOCHEM;Initial Catalog=QuanLyDeThiUTEHY_DEMO;Integrated Security=True" );
        readonly KetQuaTruyVan _ketQuaTruyVan = new KetQuaTruyVan();
        protected KetQuaTruyVan ThucHienTruyVan ( SqlCommand truyVan, string tenBang )
        {

            SqlDataAdapter da = new SqlDataAdapter( truyVan );
            DataTable bangDuLieu = new DataTable( tenBang );
            da.Fill( bangDuLieu );

            DataSet dataSet = new DataSet();
            dataSet.Tables.Add( bangDuLieu );
            _ketQuaTruyVan.DuLieu = dataSet;
            return _ketQuaTruyVan;
        }
    }
}
