using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Hastane_Yonetim_ve_Randevu_Sistemi
{
    public partial class FrmDoktorKayit : Form
    {
        public FrmDoktorKayit()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        void temizle()
        {
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            CmbBrans.Text = "";
            MskTC.Text = "";
            TxtSifre.Text = "";
            TxtAd.Focus();
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Doktorlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            listele();
            SqlCommand komut = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbBrans.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into Tbl_Doktorlar(DoktorAd, DoktorSoyad, DoktorBrans, DoktorTC, DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komut2.Parameters.AddWithValue("@p4", MskTC.Text);
            komut2.Parameters.AddWithValue("@p5", TxtSifre.Text);

            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Kaydı Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("Delete From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komutSil.Parameters.AddWithValue("@p1", MskTC.Text);
            komutSil.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            listele();
            temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Doktorlar Set DoktorAd=@p1, DoktorSoyad=@p2, DoktorBrans=@p3, DoktorSifre=@p4 where DoktorTC=@p5", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", TxtAd.Text);
            komutguncelle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komutguncelle.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komutguncelle.Parameters.AddWithValue("@p5", MskTC.Text);
            komutguncelle.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            listele();
            temizle();
        }
    }
}
