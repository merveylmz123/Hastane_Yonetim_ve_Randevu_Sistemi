using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Yonetim_ve_Randevu_Sistemi
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string TCnumara;
        sqlbaglanti bgl = new sqlbaglanti();
        void listele()
        {
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("select *  from Tbl_Randevular", bgl.baglanti());
            da3.Fill(dt3);
            dataGridView3.DataSource = dt3;
        }
        void temizle()
        {
            Txtid.Text = "";
            MskTarih.Text = "";
            MskSaat.Text = "";
            CmbBrans.Text = "";
            CmbDoktor.Text = "";
        }
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TCnumara;
            SqlCommand komut1 = new SqlCommand("Select SekreterAd,SekreterSoyad From Tbl_Sekreter Where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblAdSoyad.Text = dr1[0] + " " + dr1[1];
            }
            bgl.baglanti().Close();

            listele();

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select BransAd from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (DoktorAd + ' ' + DoktorSoyad) as 'Doktor Adı Soyadı', DoktorBrans from Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            SqlCommand komut2 = new SqlCommand("select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat, RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", MskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", MskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@p4", CmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Kayıt İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select DoktorAd, DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TxtDuyuru.Text = "";
        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorKayit fr = new FrmDoktorKayit();
            fr.Show();
        }

        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBransPaneli fr = new FrmBransPaneli();
            fr.Show();
        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView3.SelectedCells[0].RowIndex;

            Txtid.Text = dataGridView3.Rows[secilen].Cells[0].Value.ToString();
            MskTarih.Text = dataGridView3.Rows[secilen].Cells[1].Value.ToString();
            MskSaat.Text = dataGridView3.Rows[secilen].Cells[2].Value.ToString();
            CmbBrans.Text = dataGridView3.Rows[secilen].Cells[3].Value.ToString();
            CmbDoktor.Text = dataGridView3.Rows[secilen].Cells[4].Value.ToString();
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Randevular Set RandevuTarih=@p1,RandevuSaat=@p2, RandevuBrans=@p3, RandevuDoktor=@p4 where Randevuid=@p5", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", MskTarih.Text);
            komutguncelle.Parameters.AddWithValue("@p2", MskSaat.Text);
            komutguncelle.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komutguncelle.Parameters.AddWithValue("@p4", CmbDoktor.Text);
            komutguncelle.Parameters.AddWithValue("@p5", Txtid.Text);
            komutguncelle.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            listele();
            temizle();
        }
    }
}
