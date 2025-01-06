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
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void temizle()
        {
            TxtBrans.Text = "";
            Txtid.Text = "";
        }
        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komutEkle = new SqlCommand("insert into Tbl_Branslar(BransAd) values (@p1)", bgl.baglanti());
            komutEkle.Parameters.AddWithValue("@p1", TxtBrans.Text);

            komutEkle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtBrans.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("Delete From Tbl_Branslar where Bransid=@p1", bgl.baglanti());
            komutSil.Parameters.AddWithValue("@p1", Txtid.Text);
            komutSil.ExecuteNonQuery();
            MessageBox.Show("Branş Silindi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            bgl.baglanti().Close();
            listele();
            temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Branslar Set BransAd=@p1 where Bransid=@p2", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@p1", TxtBrans.Text);
            komutguncelle.Parameters.AddWithValue("@p2", Txtid.Text);
            komutguncelle.ExecuteNonQuery();
            MessageBox.Show("Branş Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            listele();
            temizle();
        }

    }
}
