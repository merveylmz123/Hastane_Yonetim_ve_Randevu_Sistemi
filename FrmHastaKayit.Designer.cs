namespace Hastane_Yonetim_ve_Randevu_Sistemi
{
    partial class FrmHastaKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(203, 61);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(173, 26);
            this.TxtAd.TabIndex = 1;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(203, 125);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(173, 26);
            this.mskTC.TabIndex = 3;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cinsiyet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefon:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(203, 93);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(173, 26);
            this.txtSoyad.TabIndex = 2;
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(203, 159);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(173, 26);
            this.MskTelefon.TabIndex = 4;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(203, 224);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(173, 26);
            this.TxtSifre.TabIndex = 6;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(203, 191);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(173, 28);
            this.cmbCinsiyet.TabIndex = 5;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(230, 256);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(124, 36);
            this.BtnKaydet.TabIndex = 21;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            // 
            // FrmHastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(537, 338);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Button BtnKaydet;
    }
}