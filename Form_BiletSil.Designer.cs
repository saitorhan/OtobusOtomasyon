namespace otobus_otomasyon_linq
{
    partial class Form_BiletSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BiletSil));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_biletNumarasi = new System.Windows.Forms.TextBox();
            this.button_bilet_bul = new System.Windows.Forms.Button();
            this.groupBox_biletBilgileri = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_inis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_binis = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label_ucret = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_satis_tip = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_soyad = new System.Windows.Forms.Label();
            this.label_zaman = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_koltuk = new System.Windows.Forms.Label();
            this.label_ad = new System.Windows.Forms.Label();
            this.label_sefer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_biletBilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_biletSil = new System.Windows.Forms.Button();
            this.groupBox_biletBilgileri.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilet Numarası:";
            // 
            // textBox_biletNumarasi
            // 
            this.textBox_biletNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_biletNumarasi.Location = new System.Drawing.Point(116, 22);
            this.textBox_biletNumarasi.Name = "textBox_biletNumarasi";
            this.textBox_biletNumarasi.Size = new System.Drawing.Size(100, 23);
            this.textBox_biletNumarasi.TabIndex = 1;
            // 
            // button_bilet_bul
            // 
            this.button_bilet_bul.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_bilet_bul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_bilet_bul.Image = ((System.Drawing.Image)(resources.GetObject("button_bilet_bul.Image")));
            this.button_bilet_bul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_bilet_bul.Location = new System.Drawing.Point(222, 20);
            this.button_bilet_bul.Name = "button_bilet_bul";
            this.button_bilet_bul.Size = new System.Drawing.Size(75, 24);
            this.button_bilet_bul.TabIndex = 2;
            this.button_bilet_bul.Text = "Ara";
            this.button_bilet_bul.UseVisualStyleBackColor = false;
            this.button_bilet_bul.Click += new System.EventHandler(this.button_bilet_bul_Click);
            // 
            // groupBox_biletBilgileri
            // 
            this.groupBox_biletBilgileri.Controls.Add(this.label3);
            this.groupBox_biletBilgileri.Controls.Add(this.label_inis);
            this.groupBox_biletBilgileri.Controls.Add(this.label5);
            this.groupBox_biletBilgileri.Controls.Add(this.label_binis);
            this.groupBox_biletBilgileri.Controls.Add(this.label16);
            this.groupBox_biletBilgileri.Controls.Add(this.label_ucret);
            this.groupBox_biletBilgileri.Controls.Add(this.label14);
            this.groupBox_biletBilgileri.Controls.Add(this.label_satis_tip);
            this.groupBox_biletBilgileri.Controls.Add(this.label12);
            this.groupBox_biletBilgileri.Controls.Add(this.label_soyad);
            this.groupBox_biletBilgileri.Controls.Add(this.label_zaman);
            this.groupBox_biletBilgileri.Controls.Add(this.label11);
            this.groupBox_biletBilgileri.Controls.Add(this.label8);
            this.groupBox_biletBilgileri.Controls.Add(this.label9);
            this.groupBox_biletBilgileri.Controls.Add(this.label_koltuk);
            this.groupBox_biletBilgileri.Controls.Add(this.label_ad);
            this.groupBox_biletBilgileri.Controls.Add(this.label_sefer);
            this.groupBox_biletBilgileri.Controls.Add(this.label2);
            this.groupBox_biletBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_biletBilgileri.Location = new System.Drawing.Point(16, 63);
            this.groupBox_biletBilgileri.Name = "groupBox_biletBilgileri";
            this.groupBox_biletBilgileri.Size = new System.Drawing.Size(389, 267);
            this.groupBox_biletBilgileri.TabIndex = 3;
            this.groupBox_biletBilgileri.TabStop = false;
            this.groupBox_biletBilgileri.Text = "Bilet Bilgileri";
            this.groupBox_biletBilgileri.Enter += new System.EventHandler(this.groupBox_biletBilgileri_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "İniş Şehri";
            // 
            // label_inis
            // 
            this.label_inis.AutoSize = true;
            this.label_inis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_inis.Location = new System.Drawing.Point(141, 221);
            this.label_inis.Name = "label_inis";
            this.label_inis.Size = new System.Drawing.Size(0, 16);
            this.label_inis.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Biniş Şehri";
            // 
            // label_binis
            // 
            this.label_binis.AutoSize = true;
            this.label_binis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_binis.Location = new System.Drawing.Point(141, 195);
            this.label_binis.Name = "label_binis";
            this.label_binis.Size = new System.Drawing.Size(0, 16);
            this.label_binis.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(6, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 16);
            this.label16.TabIndex = 15;
            this.label16.Text = "Ücret";
            // 
            // label_ucret
            // 
            this.label_ucret.AutoSize = true;
            this.label_ucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ucret.Location = new System.Drawing.Point(141, 172);
            this.label_ucret.Name = "label_ucret";
            this.label_ucret.Size = new System.Drawing.Size(0, 16);
            this.label_ucret.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(6, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 16);
            this.label14.TabIndex = 13;
            this.label14.Text = "Satış Tipi";
            // 
            // label_satis_tip
            // 
            this.label_satis_tip.AutoSize = true;
            this.label_satis_tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_satis_tip.Location = new System.Drawing.Point(141, 146);
            this.label_satis_tip.Name = "label_satis_tip";
            this.label_satis_tip.Size = new System.Drawing.Size(0, 16);
            this.label_satis_tip.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(6, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Yolcu Soyadı";
            // 
            // label_soyad
            // 
            this.label_soyad.AutoSize = true;
            this.label_soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_soyad.Location = new System.Drawing.Point(141, 123);
            this.label_soyad.Name = "label_soyad";
            this.label_soyad.Size = new System.Drawing.Size(0, 16);
            this.label_soyad.TabIndex = 10;
            // 
            // label_zaman
            // 
            this.label_zaman.AutoSize = true;
            this.label_zaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_zaman.Location = new System.Drawing.Point(141, 52);
            this.label_zaman.Name = "label_zaman";
            this.label_zaman.Size = new System.Drawing.Size(0, 16);
            this.label_zaman.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "İşlem Zamanı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Koltuk No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Yolcu Ad";
            // 
            // label_koltuk
            // 
            this.label_koltuk.AutoSize = true;
            this.label_koltuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_koltuk.Location = new System.Drawing.Point(141, 74);
            this.label_koltuk.Name = "label_koltuk";
            this.label_koltuk.Size = new System.Drawing.Size(0, 16);
            this.label_koltuk.TabIndex = 5;
            // 
            // label_ad
            // 
            this.label_ad.AutoSize = true;
            this.label_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ad.Location = new System.Drawing.Point(141, 97);
            this.label_ad.Name = "label_ad";
            this.label_ad.Size = new System.Drawing.Size(0, 16);
            this.label_ad.TabIndex = 3;
            // 
            // label_sefer
            // 
            this.label_sefer.AutoSize = true;
            this.label_sefer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sefer.Location = new System.Drawing.Point(141, 30);
            this.label_sefer.Name = "label_sefer";
            this.label_sefer.Size = new System.Drawing.Size(0, 16);
            this.label_sefer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bilet Sefer";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_biletBilgi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(630, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_biletBilgi
            // 
            this.toolStripStatusLabel_biletBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel_biletBilgi.Name = "toolStripStatusLabel_biletBilgi";
            this.toolStripStatusLabel_biletBilgi.Size = new System.Drawing.Size(0, 17);
            // 
            // button_biletSil
            // 
            this.button_biletSil.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_biletSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_biletSil.Image = ((System.Drawing.Image)(resources.GetObject("button_biletSil.Image")));
            this.button_biletSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_biletSil.Location = new System.Drawing.Point(330, 336);
            this.button_biletSil.Name = "button_biletSil";
            this.button_biletSil.Size = new System.Drawing.Size(75, 36);
            this.button_biletSil.TabIndex = 5;
            this.button_biletSil.Text = "Sil";
            this.button_biletSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_biletSil.UseVisualStyleBackColor = false;
            this.button_biletSil.Click += new System.EventHandler(this.button_biletSil_Click);
            // 
            // Form_BiletSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(630, 433);
            this.Controls.Add(this.button_biletSil);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox_biletBilgileri);
            this.Controls.Add(this.button_bilet_bul);
            this.Controls.Add(this.textBox_biletNumarasi);
            this.Controls.Add(this.label1);
            this.Name = "Form_BiletSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilet Sil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_BiletSil_FormClosing);
            this.Load += new System.EventHandler(this.Form_BiletSil_Load);
            this.groupBox_biletBilgileri.ResumeLayout(false);
            this.groupBox_biletBilgileri.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_biletNumarasi;
        private System.Windows.Forms.Button button_bilet_bul;
        private System.Windows.Forms.GroupBox groupBox_biletBilgileri;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_biletBilgi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label_ucret;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_satis_tip;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_soyad;
        private System.Windows.Forms.Label label_zaman;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_koltuk;
        private System.Windows.Forms.Label label_ad;
        private System.Windows.Forms.Label label_sefer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_biletSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_inis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_binis;
    }
}