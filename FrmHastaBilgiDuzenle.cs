using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Yonetim_ve_Randevu_Sistemi
{
    public partial class FrmHastaBilgiDuzenle : Form
    {
        public FrmHastaBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string TCnumara;
        sqlbaglanti bgl = new sqlbaglanti();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCnumara;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                MskTelefon.Text = dr[4].ToString();
                TxtSifre.Text = dr[5].ToString();
                CmbCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1, HastaSoyad=@p2,HastaTelefon=@p3, HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", TxtAd.Text);
            komutguncelle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@p3", MskTelefon.Text);
            komutguncelle.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komutguncelle.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
            komutguncelle.Parameters.AddWithValue("@p6", MskTC.Text);
            komutguncelle.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
        }
    }
}
