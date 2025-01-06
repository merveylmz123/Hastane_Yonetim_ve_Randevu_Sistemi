using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Yonetim_ve_Randevu_Sistemi
{
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar(HastaAd, HastaSoyad, HastaTC, HastaTelefon, HastaCinsiyet, HastaSifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTC.Text);
            komut.Parameters.AddWithValue("@p4", MskTelefon.Text);
            komut.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }
    }
}
