namespace Hastane_Yonetim_ve_Randevu_Sistemi
{
    partial class FrmDoktorBilgiDuzenle
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
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.CmbBrans = new System.Windows.Forms.ComboBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGuncelle.Location = new System.Drawing.Point(201, 214);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(190, 42);
            this.BtnGuncelle.TabIndex = 45;
            this.BtnGuncelle.Text = "Bilgi Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // CmbBrans
            // 
            this.CmbBrans.FormattingEnabled = true;
            this.CmbBrans.Location = new System.Drawing.Point(201, 146);
            this.CmbBrans.Name = "CmbBrans";
            this.CmbBrans.Size = new System.Drawing.Size(190, 28);
            this.CmbBrans.TabIndex = 44;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(201, 182);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(190, 26);
            this.TxtSifre.TabIndex = 43;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(201, 82);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(190, 26);
            this.TxtSoyad.TabIndex = 42;
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(140, 149);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(55, 20);
            this.lable1.TabIndex = 41;
            this.lable1.Text = "Branş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Ad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(201, 50);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(190, 26);
            this.TxtAd.TabIndex = 38;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(201, 114);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(190, 26);
            this.MskTC.TabIndex = 37;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "TC Kimlik No:";
            // 
            // FrmDoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(579, 317);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.CmbBrans);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorBilgiDuzenle";
            this.Text = "Doktor Bilgi Düzenle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.ComboBox CmbBrans;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}