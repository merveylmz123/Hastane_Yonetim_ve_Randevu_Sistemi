﻿using System;
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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.TCnumara = MskTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
                MskTC.Text = "";
                TxtSifre.Text = "";
            }
            bgl.baglanti().Close();
        }
    }
}
