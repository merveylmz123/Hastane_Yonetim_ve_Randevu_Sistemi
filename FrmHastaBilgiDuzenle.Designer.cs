namespace Hastane_Yonetim_ve_Randevu_Sistemi
{
    partial class FrmHastaBilgiDuzenle
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
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.CmbBrans = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(170, 174);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(163, 28);
            this.CmbCinsiyet.TabIndex = 5;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(170, 210);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(163, 26);
            this.TxtSifre.TabIndex = 6;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(170, 79);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(163, 26);
            this.TxtSoyad.TabIndex = 2;
            // 
            // CmbBrans
            // 
            this.CmbBrans.AutoSize = true;
            this.CmbBrans.Location = new System.Drawing.Point(96, 180);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(68, 20);
            this.CmbBrans.TabIndex = 28;
            this.CmbBrans.Text = "Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(170, 47);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(163, 26);
            this.TxtAd.TabIndex = 1;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(170, 111);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(163, 26);
            this.MskTC.TabIndex = 3;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "TC Kimlik No:";
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(170, 143);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(163, 26);
            this.MskTelefon.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(98, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Telefon:";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(170, 246);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(163, 34);
            this.BtnGuncelle.TabIndex = 36;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // FrmHastaBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(474, 339);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.CmbBrans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaBilgiDuzenle";
            this.Text = "Bilgi Düzenle";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label CmbBrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnGuncelle;
    }
}