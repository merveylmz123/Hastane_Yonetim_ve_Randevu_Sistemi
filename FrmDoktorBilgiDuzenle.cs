using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Yonetim_ve_Randevu_Sistemi
{
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string TCnumara;
        sqlbaglanti bgl = new sqlbaglanti();
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCnumara;
            SqlCommand komut = new SqlCommand("select * From Tbl_Doktorlar Where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                CmbBrans.Text = dr[3].ToString();
                MskTC.Text = dr[4].ToString();
                TxtSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update Tbl_Doktorlar set DoktorAd=@p1, DoktorSoyad=@p2,DoktorBrans=@p3, DoktorSifre=@p4 where DoktorTC=@p5", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", TxtAd.Text);
            komutguncelle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komutguncelle.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komutguncelle.Parameters.AddWithValue("@p5", MskTC.Text);
            komutguncelle.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            bgl.baglanti().Close();
        }
    }
}
