using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Yonetim_ve_Randevu_Sistemi
{
    internal class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=;Initial Catalog=HastaneProjeVeritabani;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
