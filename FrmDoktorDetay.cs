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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        public string TCnumara;
        sqlbaglanti bgl = new sqlbaglanti();
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
           LblTC.Text = TCnumara;

            SqlCommand komut = new SqlCommand("Select DoktorAd, DoktorSoyad From Tbl_Doktorlar Where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Duyurular", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;   

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Randevular Where RandevuDoktor='" + LblAdSoyad.Text +"'", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void BtnBilgiDüzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle fr = new FrmDoktorBilgiDuzenle();
            fr.TCnumara = LblTC.Text;
            fr.Show();
        }
    }
}
