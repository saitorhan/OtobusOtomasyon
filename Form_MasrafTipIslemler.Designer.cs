namespace otobus_otomasyon_linq
{
    partial class Form_MasrafTipIslemler
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
            this.tabControl_masrafTipIslemleri = new System.Windows.Forms.TabControl();
            this.tabPage_MasrafGuncelle = new System.Windows.Forms.TabPage();
            this.button_sil = new System.Windows.Forms.Button();
            this.textBox_MasrafYeniAd = new System.Windows.Forms.TextBox();
            this.label_masrafEskiAd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage_MasrafCesidiEkle = new System.Windows.Forms.TabPage();
            this.textBox_MasrafAdi_adi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_masrafCesitleri = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_bilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_iptal = new System.Windows.Forms.Button();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.tabControl_masrafTipIslemleri.SuspendLayout();
            this.tabPage_MasrafGuncelle.SuspendLayout();
            this.tabPage_MasrafCesidiEkle.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_masrafTipIslemleri
            // 
            this.tabControl_masrafTipIslemleri.Controls.Add(this.tabPage_MasrafGuncelle);
            this.tabControl_masrafTipIslemleri.Controls.Add(this.tabPage_MasrafCesidiEkle);
            this.tabControl_masrafTipIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl_masrafTipIslemleri.Location = new System.Drawing.Point(211, 39);
            this.tabControl_masrafTipIslemleri.Name = "tabControl_masrafTipIslemleri";
            this.tabControl_masrafTipIslemleri.SelectedIndex = 0;
            this.tabControl_masrafTipIslemleri.Size = new System.Drawing.Size(465, 263);
            this.tabControl_masrafTipIslemleri.TabIndex = 5;
            // 
            // tabPage_MasrafGuncelle
            // 
            this.tabPage_MasrafGuncelle.Controls.Add(this.button_sil);
            this.tabPage_MasrafGuncelle.Controls.Add(this.button_iptal);
            this.tabPage_MasrafGuncelle.Controls.Add(this.button_guncelle);
            this.tabPage_MasrafGuncelle.Controls.Add(this.textBox_MasrafYeniAd);
            this.tabPage_MasrafGuncelle.Controls.Add(this.label_masrafEskiAd);
            this.tabPage_MasrafGuncelle.Controls.Add(this.label3);
            this.tabPage_MasrafGuncelle.Controls.Add(this.label2);
            this.tabPage_MasrafGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage_MasrafGuncelle.Location = new System.Drawing.Point(4, 25);
            this.tabPage_MasrafGuncelle.Name = "tabPage_MasrafGuncelle";
            this.tabPage_MasrafGuncelle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_MasrafGuncelle.Size = new System.Drawing.Size(457, 234);
            this.tabPage_MasrafGuncelle.TabIndex = 0;
            this.tabPage_MasrafGuncelle.Text = "Masraf Çeşiti Güncelle";
            this.tabPage_MasrafGuncelle.UseVisualStyleBackColor = true;
            // 
            // button_sil
            // 
            this.button_sil.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sil.Location = new System.Drawing.Point(9, 70);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(111, 40);
            this.button_sil.TabIndex = 6;
            this.button_sil.Text = "Masraf Çesiti Sil";
            this.button_sil.UseVisualStyleBackColor = false;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // textBox_MasrafYeniAd
            // 
            this.textBox_MasrafYeniAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_MasrafYeniAd.Location = new System.Drawing.Point(88, 44);
            this.textBox_MasrafYeniAd.Name = "textBox_MasrafYeniAd";
            this.textBox_MasrafYeniAd.Size = new System.Drawing.Size(172, 22);
            this.textBox_MasrafYeniAd.TabIndex = 3;
            // 
            // label_masrafEskiAd
            // 
            this.label_masrafEskiAd.AutoSize = true;
            this.label_masrafEskiAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_masrafEskiAd.Location = new System.Drawing.Point(85, 13);
            this.label_masrafEskiAd.Name = "label_masrafEskiAd";
            this.label_masrafEskiAd.Size = new System.Drawing.Size(0, 16);
            this.label_masrafEskiAd.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yeni Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Eski Adı";
            // 
            // tabPage_MasrafCesidiEkle
            // 
            this.tabPage_MasrafCesidiEkle.Controls.Add(this.button1);
            this.tabPage_MasrafCesidiEkle.Controls.Add(this.button_kaydet);
            this.tabPage_MasrafCesidiEkle.Controls.Add(this.textBox_MasrafAdi_adi);
            this.tabPage_MasrafCesidiEkle.Controls.Add(this.label4);
            this.tabPage_MasrafCesidiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage_MasrafCesidiEkle.Location = new System.Drawing.Point(4, 25);
            this.tabPage_MasrafCesidiEkle.Name = "tabPage_MasrafCesidiEkle";
            this.tabPage_MasrafCesidiEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_MasrafCesidiEkle.Size = new System.Drawing.Size(457, 234);
            this.tabPage_MasrafCesidiEkle.TabIndex = 1;
            this.tabPage_MasrafCesidiEkle.Text = "Masraf Çeşiti Ekle";
            this.tabPage_MasrafCesidiEkle.UseVisualStyleBackColor = true;
            // 
            // textBox_MasrafAdi_adi
            // 
            this.textBox_MasrafAdi_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_MasrafAdi_adi.Location = new System.Drawing.Point(129, 14);
            this.textBox_MasrafAdi_adi.Name = "textBox_MasrafAdi_adi";
            this.textBox_MasrafAdi_adi.Size = new System.Drawing.Size(172, 22);
            this.textBox_MasrafAdi_adi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Masraf Çeşiti Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Masraf Çeşitleri";
            // 
            // listBox_masrafCesitleri
            // 
            this.listBox_masrafCesitleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox_masrafCesitleri.FormattingEnabled = true;
            this.listBox_masrafCesitleri.ItemHeight = 16;
            this.listBox_masrafCesitleri.Location = new System.Drawing.Point(12, 39);
            this.listBox_masrafCesitleri.Name = "listBox_masrafCesitleri";
            this.listBox_masrafCesitleri.Size = new System.Drawing.Size(193, 340);
            this.listBox_masrafCesitleri.Sorted = true;
            this.listBox_masrafCesitleri.TabIndex = 3;
            this.listBox_masrafCesitleri.SelectedIndexChanged += new System.EventHandler(this.listBox_masrafCesitleri_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_bilgi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(688, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_bilgi
            // 
            this.toolStripStatusLabel_bilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel_bilgi.Name = "toolStripStatusLabel_bilgi";
            this.toolStripStatusLabel_bilgi.Size = new System.Drawing.Size(0, 17);
            // 
            // button_iptal
            // 
            this.button_iptal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_iptal.Image = global::otobus_otomasyon_linq.Properties.Resources.remove_20x20;
            this.button_iptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_iptal.Location = new System.Drawing.Point(126, 71);
            this.button_iptal.Name = "button_iptal";
            this.button_iptal.Size = new System.Drawing.Size(84, 38);
            this.button_iptal.TabIndex = 5;
            this.button_iptal.Text = "İptal";
            this.button_iptal.UseVisualStyleBackColor = false;
            this.button_iptal.Click += new System.EventHandler(this.button_iptal_Click);
            // 
            // button_guncelle
            // 
            this.button_guncelle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_guncelle.Image = global::otobus_otomasyon_linq.Properties.Resources.accept_20x20;
            this.button_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guncelle.Location = new System.Drawing.Point(216, 72);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(93, 37);
            this.button_guncelle.TabIndex = 4;
            this.button_guncelle.Text = "Güncelle";
            this.button_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_guncelle.UseVisualStyleBackColor = false;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::otobus_otomasyon_linq.Properties.Resources.remove_20x20;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(122, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "İptal";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_kaydet
            // 
            this.button_kaydet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kaydet.Image = global::otobus_otomasyon_linq.Properties.Resources._55;
            this.button_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kaydet.Location = new System.Drawing.Point(203, 40);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(110, 36);
            this.button_kaydet.TabIndex = 8;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kaydet.UseVisualStyleBackColor = false;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // Form_MasrafTipIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(688, 463);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl_masrafTipIslemleri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_masrafCesitleri);
            this.Name = "Form_MasrafTipIslemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masraf Çeşitleri İşlemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_MasrafTipIslemler_FormClosing);
            this.Load += new System.EventHandler(this.Form_MasrafTipIslemler_Load);
            this.tabControl_masrafTipIslemleri.ResumeLayout(false);
            this.tabPage_MasrafGuncelle.ResumeLayout(false);
            this.tabPage_MasrafGuncelle.PerformLayout();
            this.tabPage_MasrafCesidiEkle.ResumeLayout(false);
            this.tabPage_MasrafCesidiEkle.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_masrafTipIslemleri;
        private System.Windows.Forms.TabPage tabPage_MasrafGuncelle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_iptal;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.TextBox textBox_MasrafYeniAd;
        private System.Windows.Forms.Label label_masrafEskiAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage_MasrafCesidiEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.TextBox textBox_MasrafAdi_adi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_masrafCesitleri;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_bilgi;
    }
}