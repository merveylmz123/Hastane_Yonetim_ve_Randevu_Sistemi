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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string TCnumara;

        sqlbaglanti bgl = new sqlbaglanti();
        void temizle()
        {
            Txtid.Text = "";
            MskTarih.Text = "";
            MskSaat.Text = "";
            CmbBrans2.Text = "";
            CmbDoktor2.Text = "";
            MskTC.Text= "";
            CmbBrans.Text = "";
            CmbDoktor.Text = "";
        }
        void gecmisRandevuListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular Where HastaTC=" + TCnumara, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TCnumara;
            SqlCommand komut = new SqlCommand("Select HastaAd, HastaSoyad From Tbl_Hastalar Where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            gecmisRandevuListesi();

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
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

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular Where RandevuBrans= '" + CmbBrans.Text + "'" +" and RandevuDoktor='" + CmbDoktor.Text+"'" + " and RandevuDurum='" + false + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHastaBilgiDuzenle fr = new FrmHastaBilgiDuzenle();
            fr.TCnumara = LblTC.Text;
            fr.Show();
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;

            Txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            MskTarih.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            MskSaat.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            CmbBrans2.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            CmbDoktor2.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
            MskTC.Text = LblTC.Text;
        }
        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Randevular Set RandevuTarih=@p1,RandevuSaat=@p2, RandevuBrans=@p3, RandevuDoktor=@p4,RandevuDurum=@p5, HastaTC=@p6 where Randevuid=@p7", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", MskTarih.Text);
            komutguncelle.Parameters.AddWithValue("@p2", MskSaat.Text);
            komutguncelle.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komutguncelle.Parameters.AddWithValue("@p4", CmbDoktor.Text);
            komutguncelle.Parameters.AddWithValue("@p5", true);
            komutguncelle.Parameters.AddWithValue("@p6", MskTC.Text);
            komutguncelle.Parameters.AddWithValue("@p7", Txtid.Text);
            komutguncelle.ExecuteNonQuery();
            MessageBox.Show("Randevu Alma İşlemi Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            gecmisRandevuListesi();
            temizle();
        }

    }
}
