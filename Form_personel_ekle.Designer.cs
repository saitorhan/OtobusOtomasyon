namespace otobus_otomasyon_linq
{
    partial class Form_personel_guncelle_ekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_personel_guncelle_ekle));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_sehir = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_sube = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ad = new System.Windows.Forms.TextBox();
            this.textBox_soyad = new System.Windows.Forms.TextBox();
            this.textBox_telefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ev_adres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_kullanici_ad = new System.Windows.Forms.TextBox();
            this.textBox_sifre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_sifre_tekrar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBox_yonetici_mi = new System.Windows.Forms.CheckBox();
            this.comboBox_calisan_tipi = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button_iptal = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_kayit_durum = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şehir";
            // 
            // comboBox_sehir
            // 
            this.comboBox_sehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_sehir.FormattingEnabled = true;
            this.comboBox_sehir.Location = new System.Drawing.Point(116, 6);
            this.comboBox_sehir.Name = "comboBox_sehir";
            this.comboBox_sehir.Size = new System.Drawing.Size(178, 24);
            this.comboBox_sehir.TabIndex = 1;
            this.comboBox_sehir.Text = "Şehir Seçiniz";
            this.comboBox_sehir.SelectedIndexChanged += new System.EventHandler(this.comboBox_sehir_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şube";
            // 
            // comboBox_sube
            // 
            this.comboBox_sube.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_sube.FormattingEnabled = true;
            this.comboBox_sube.Location = new System.Drawing.Point(116, 31);
            this.comboBox_sube.Name = "comboBox_sube";
            this.comboBox_sube.Size = new System.Drawing.Size(178, 24);
            this.comboBox_sube.TabIndex = 3;
            this.comboBox_sube.Text = "Şube Seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ad";
            // 
            // textBox_ad
            // 
            this.textBox_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_ad.Location = new System.Drawing.Point(116, 57);
            this.textBox_ad.MaxLength = 50;
            this.textBox_ad.Name = "textBox_ad";
            this.textBox_ad.Size = new System.Drawing.Size(178, 22);
            this.textBox_ad.TabIndex = 5;
            this.textBox_ad.Leave += new System.EventHandler(this.textBoxSadeceHarf);
            // 
            // textBox_soyad
            // 
            this.textBox_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_soyad.Location = new System.Drawing.Point(116, 83);
            this.textBox_soyad.MaxLength = 50;
            this.textBox_soyad.Name = "textBox_soyad";
            this.textBox_soyad.Size = new System.Drawing.Size(178, 22);
            this.textBox_soyad.TabIndex = 6;
            this.textBox_soyad.Leave += new System.EventHandler(this.textBoxSadeceHarf);
            // 
            // textBox_telefon
            // 
            this.textBox_telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_telefon.Location = new System.Drawing.Point(116, 109);
            this.textBox_telefon.MaxLength = 10;
            this.textBox_telefon.Name = "textBox_telefon";
            this.textBox_telefon.Size = new System.Drawing.Size(178, 22);
            this.textBox_telefon.TabIndex = 7;
            this.textBox_telefon.TextChanged += new System.EventHandler(this.textBox_telefon_TextChanged);
            this.textBox_telefon.Leave += new System.EventHandler(this.textBox_telefon_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefon";
            // 
            // textBox_mail
            // 
            this.textBox_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_mail.Location = new System.Drawing.Point(116, 135);
            this.textBox_mail.MaxLength = 60;
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(178, 22);
            this.textBox_mail.TabIndex = 10;
            this.textBox_mail.Leave += new System.EventHandler(this.textBox_mail_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "E-mail";
            // 
            // textBox_ev_adres
            // 
            this.textBox_ev_adres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_ev_adres.Location = new System.Drawing.Point(116, 161);
            this.textBox_ev_adres.Multiline = true;
            this.textBox_ev_adres.Name = "textBox_ev_adres";
            this.textBox_ev_adres.Size = new System.Drawing.Size(178, 77);
            this.textBox_ev_adres.TabIndex = 12;
            this.textBox_ev_adres.Leave += new System.EventHandler(this.textBox_ev_adres_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ev Adres";
            // 
            // textBox_kullanici_ad
            // 
            this.textBox_kullanici_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_kullanici_ad.Location = new System.Drawing.Point(116, 244);
            this.textBox_kullanici_ad.MaxLength = 20;
            this.textBox_kullanici_ad.Name = "textBox_kullanici_ad";
            this.textBox_kullanici_ad.Size = new System.Drawing.Size(178, 22);
            this.textBox_kullanici_ad.TabIndex = 14;
            this.textBox_kullanici_ad.Leave += new System.EventHandler(this.textBox_kullanici_ad_Leave);
            // 
            // textBox_sifre
            // 
            this.textBox_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_sifre.Location = new System.Drawing.Point(116, 270);
            this.textBox_sifre.MaxLength = 20;
            this.textBox_sifre.Name = "textBox_sifre";
            this.textBox_sifre.Size = new System.Drawing.Size(178, 22);
            this.textBox_sifre.TabIndex = 15;
            this.textBox_sifre.UseSystemPasswordChar = true;
            this.textBox_sifre.Leave += new System.EventHandler(this.textBox_kullanici_ad_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Kullanıcı Ad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Şifre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(12, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Şifre Tekrar";
            // 
            // textBox_sifre_tekrar
            // 
            this.textBox_sifre_tekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_sifre_tekrar.Location = new System.Drawing.Point(116, 296);
            this.textBox_sifre_tekrar.MaxLength = 20;
            this.textBox_sifre_tekrar.Name = "textBox_sifre_tekrar";
            this.textBox_sifre_tekrar.Size = new System.Drawing.Size(178, 22);
            this.textBox_sifre_tekrar.TabIndex = 19;
            this.textBox_sifre_tekrar.UseSystemPasswordChar = true;
            this.textBox_sifre_tekrar.Leave += new System.EventHandler(this.textBox_kullanici_ad_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(12, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Yönetici";
            // 
            // checkBox_yonetici_mi
            // 
            this.checkBox_yonetici_mi.AutoSize = true;
            this.checkBox_yonetici_mi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_yonetici_mi.Location = new System.Drawing.Point(116, 322);
            this.checkBox_yonetici_mi.Name = "checkBox_yonetici_mi";
            this.checkBox_yonetici_mi.Size = new System.Drawing.Size(96, 20);
            this.checkBox_yonetici_mi.TabIndex = 22;
            this.checkBox_yonetici_mi.Text = "Hayır / Evet";
            this.checkBox_yonetici_mi.UseVisualStyleBackColor = true;
            // 
            // comboBox_calisan_tipi
            // 
            this.comboBox_calisan_tipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_calisan_tipi.FormattingEnabled = true;
            this.comboBox_calisan_tipi.Location = new System.Drawing.Point(116, 345);
            this.comboBox_calisan_tipi.Name = "comboBox_calisan_tipi";
            this.comboBox_calisan_tipi.Size = new System.Drawing.Size(178, 24);
            this.comboBox_calisan_tipi.TabIndex = 23;
            this.comboBox_calisan_tipi.Text = "Konum Seçiniz";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(12, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Çalışma Konum";
            // 
            // button_kaydet
            // 
            this.button_kaydet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_kaydet.Image")));
            this.button_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kaydet.Location = new System.Drawing.Point(186, 375);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(108, 36);
            this.button_kaydet.TabIndex = 25;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kaydet.UseVisualStyleBackColor = false;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // button_iptal
            // 
            this.button_iptal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_iptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_iptal.Image = ((System.Drawing.Image)(resources.GetObject("button_iptal.Image")));
            this.button_iptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_iptal.Location = new System.Drawing.Point(102, 375);
            this.button_iptal.Name = "button_iptal";
            this.button_iptal.Size = new System.Drawing.Size(78, 36);
            this.button_iptal.TabIndex = 26;
            this.button_iptal.Text = "İptal";
            this.button_iptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_iptal.UseVisualStyleBackColor = false;
            this.button_iptal.Click += new System.EventHandler(this.button_iptal_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_kayit_durum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 433);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(626, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_kayit_durum
            // 
            this.toolStripStatusLabel_kayit_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel_kayit_durum.Name = "toolStripStatusLabel_kayit_durum";
            this.toolStripStatusLabel_kayit_durum.Size = new System.Drawing.Size(0, 17);
            // 
            // Form_personel_guncelle_ekle
            // 
            this.AcceptButton = this.button_kaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.button_iptal;
            this.ClientSize = new System.Drawing.Size(626, 455);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_iptal);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox_calisan_tipi);
            this.Controls.Add(this.checkBox_yonetici_mi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_sifre_tekrar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_sifre);
            this.Controls.Add(this.textBox_kullanici_ad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_ev_adres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_telefon);
            this.Controls.Add(this.textBox_soyad);
            this.Controls.Add(this.textBox_ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_sube);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_sehir);
            this.Controls.Add(this.label1);
            this.Name = "Form_personel_guncelle_ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_personel_ekle_FormClosing);
            this.Load += new System.EventHandler(this.Form_personel_ekle_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_sehir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_sube;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ad;
        private System.Windows.Forms.TextBox textBox_soyad;
        private System.Windows.Forms.TextBox textBox_telefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ev_adres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_kullanici_ad;
        private System.Windows.Forms.TextBox textBox_sifre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_sifre_tekrar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox_yonetici_mi;
        private System.Windows.Forms.ComboBox comboBox_calisan_tipi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button button_iptal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_kayit_durum;
    }
}