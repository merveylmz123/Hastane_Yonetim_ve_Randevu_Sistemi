namespace Hastane_Yonetim_ve_Randevu_Sistemi
{
    partial class FrmBransPaneli
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
            this.BtnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TxtBrans = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGuncelle.Location = new System.Drawing.Point(138, 234);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(149, 44);
            this.BtnGuncelle.TabIndex = 72;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSil.Location = new System.Drawing.Point(138, 184);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(149, 44);
            this.BtnSil.TabIndex = 71;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(323, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 226);
            this.dataGridView1.TabIndex = 70;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
//            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEkle.Location = new System.Drawing.Point(138, 130);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(149, 44);
            this.BtnEkle.TabIndex = 69;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtBrans
            // 
            this.TxtBrans.Location = new System.Drawing.Point(126, 88);
            this.TxtBrans.Name = "TxtBrans";
            this.TxtBrans.Size = new System.Drawing.Size(179, 26);
            this.TxtBrans.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Branş Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 62;
            this.label5.Text = "Branş id:";
            // 
            // Txtid
            // 
            this.Txtid.Enabled = false;
            this.Txtid.Location = new System.Drawing.Point(126, 56);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(179, 26);
            this.Txtid.TabIndex = 61;
            // 
            // FrmBransPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(853, 321);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtBrans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txtid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmBransPaneli";
            this.Text = "Branş Paneli";
            this.Load += new System.EventHandler(this.FrmBransPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox TxtBrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txtid;
    }
}