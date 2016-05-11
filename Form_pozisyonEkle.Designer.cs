namespace otobus_otomasyon_linq
{
    partial class Form_pozisyonEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_pozisyonEkle));
            this.listBox_pozisyonlar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl_pozisyonIslemleri = new System.Windows.Forms.TabControl();
            this.tabPage_PozisyınGuncelle = new System.Windows.Forms.TabPage();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_iptal = new System.Windows.Forms.Button();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.textBox_pozisyonYeniAd = new System.Windows.Forms.TextBox();
            this.label_pozisyonEskiAd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage_pozisyonEkle = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_pozisyon_adi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_bilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl_pozisyonIslemleri.SuspendLayout();
            this.tabPage_PozisyınGuncelle.SuspendLayout();
            this.tabPage_pozisyonEkle.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_pozisyonlar
            // 
            this.listBox_pozisyonlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox_pozisyonlar.FormattingEnabled = true;
            this.listBox_pozisyonlar.ItemHeight = 16;
            this.listBox_pozisyonlar.Location = new System.Drawing.Point(12, 25);
            this.listBox_pozisyonlar.Name = "listBox_pozisyonlar";
            this.listBox_pozisyonlar.Size = new System.Drawing.Size(248, 340);
            this.listBox_pozisyonlar.Sorted = true;
            this.listBox_pozisyonlar.TabIndex = 0;
            this.listBox_pozisyonlar.SelectedIndexChanged += new System.EventHandler(this.listBox_pozisyonlar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pozisyonlar";
            // 
            // tabControl_pozisyonIslemleri
            // 
            this.tabControl_pozisyonIslemleri.Controls.Add(this.tabPage_PozisyınGuncelle);
            this.tabControl_pozisyonIslemleri.Controls.Add(this.tabPage_pozisyonEkle);
            this.tabControl_pozisyonIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl_pozisyonIslemleri.Location = new System.Drawing.Point(312, 25);
            this.tabControl_pozisyonIslemleri.Name = "tabControl_pozisyonIslemleri";
            this.tabControl_pozisyonIslemleri.SelectedIndex = 0;
            this.tabControl_pozisyonIslemleri.Size = new System.Drawing.Size(407, 222);
            this.tabControl_pozisyonIslemleri.TabIndex = 2;
            // 
            // tabPage_PozisyınGuncelle
            // 
            this.tabPage_PozisyınGuncelle.Controls.Add(this.button_sil);
            this.tabPage_PozisyınGuncelle.Controls.Add(this.button_iptal);
            this.tabPage_PozisyınGuncelle.Controls.Add(this.button_guncelle);
            this.tabPage_PozisyınGuncelle.Controls.Add(this.textBox_pozisyonYeniAd);
            this.tabPage_PozisyınGuncelle.Controls.Add(this.label_pozisyonEskiAd);
            this.tabPage_PozisyınGuncelle.Controls.Add(this.label3);
            this.tabPage_PozisyınGuncelle.Controls.Add(this.label2);
            this.tabPage_PozisyınGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage_PozisyınGuncelle.Location = new System.Drawing.Point(4, 25);
            this.tabPage_PozisyınGuncelle.Name = "tabPage_PozisyınGuncelle";
            this.tabPage_PozisyınGuncelle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_PozisyınGuncelle.Size = new System.Drawing.Size(399, 193);
            this.tabPage_PozisyınGuncelle.TabIndex = 0;
            this.tabPage_PozisyınGuncelle.Text = "Seçili Pozisyonu Güncelle";
            this.tabPage_PozisyınGuncelle.UseVisualStyleBackColor = true;
            // 
            // button_sil
            // 
            this.button_sil.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sil.Image = ((System.Drawing.Image)(resources.GetObject("button_sil.Image")));
            this.button_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sil.Location = new System.Drawing.Point(144, 110);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(124, 31);
            this.button_sil.TabIndex = 6;
            this.button_sil.Text = "Pozisyon Sil";
            this.button_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_sil.UseVisualStyleBackColor = false;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button_iptal
            // 
            this.button_iptal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_iptal.Image = global::otobus_otomasyon_linq.Properties.Resources.remove_20x20;
            this.button_iptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_iptal.Location = new System.Drawing.Point(144, 147);
            this.button_iptal.Name = "button_iptal";
            this.button_iptal.Size = new System.Drawing.Size(124, 26);
            this.button_iptal.TabIndex = 5;
            this.button_iptal.Text = "İptal";
            this.button_iptal.UseVisualStyleBackColor = false;
            this.button_iptal.Click += new System.EventHandler(this.button_iptal_Click);
            // 
            // button_guncelle
            // 
            this.button_guncelle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("button_guncelle.Image")));
            this.button_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guncelle.Location = new System.Drawing.Point(144, 72);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(124, 32);
            this.button_guncelle.TabIndex = 4;
            this.button_guncelle.Text = "Güncelle";
            this.button_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_guncelle.UseVisualStyleBackColor = false;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // textBox_pozisyonYeniAd
            // 
            this.textBox_pozisyonYeniAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_pozisyonYeniAd.Location = new System.Drawing.Point(88, 44);
            this.textBox_pozisyonYeniAd.Name = "textBox_pozisyonYeniAd";
            this.textBox_pozisyonYeniAd.Size = new System.Drawing.Size(201, 22);
            this.textBox_pozisyonYeniAd.TabIndex = 3;
            // 
            // label_pozisyonEskiAd
            // 
            this.label_pozisyonEskiAd.AutoSize = true;
            this.label_pozisyonEskiAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_pozisyonEskiAd.Location = new System.Drawing.Point(85, 13);
            this.label_pozisyonEskiAd.Name = "label_pozisyonEskiAd";
            this.label_pozisyonEskiAd.Size = new System.Drawing.Size(0, 16);
            this.label_pozisyonEskiAd.TabIndex = 2;
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
            // tabPage_pozisyonEkle
            // 
            this.tabPage_pozisyonEkle.Controls.Add(this.button1);
            this.tabPage_pozisyonEkle.Controls.Add(this.textBox_pozisyon_adi);
            this.tabPage_pozisyonEkle.Controls.Add(this.label4);
            this.tabPage_pozisyonEkle.Controls.Add(this.button_kaydet);
            this.tabPage_pozisyonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage_pozisyonEkle.Location = new System.Drawing.Point(4, 25);
            this.tabPage_pozisyonEkle.Name = "tabPage_pozisyonEkle";
            this.tabPage_pozisyonEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_pozisyonEkle.Size = new System.Drawing.Size(399, 193);
            this.tabPage_pozisyonEkle.TabIndex = 1;
            this.tabPage_pozisyonEkle.Text = "Pozisyon Ekle";
            this.tabPage_pozisyonEkle.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(113, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_pozisyon_adi
            // 
            this.textBox_pozisyon_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_pozisyon_adi.Location = new System.Drawing.Point(109, 14);
            this.textBox_pozisyon_adi.Name = "textBox_pozisyon_adi";
            this.textBox_pozisyon_adi.Size = new System.Drawing.Size(172, 22);
            this.textBox_pozisyon_adi.TabIndex = 7;
            this.textBox_pozisyon_adi.TextChanged += new System.EventHandler(this.textBox_pozisyon_adi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pozisyon Adı";
            // 
            // button_kaydet
            // 
            this.button_kaydet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_kaydet.Image")));
            this.button_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kaydet.Location = new System.Drawing.Point(194, 40);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(101, 45);
            this.button_kaydet.TabIndex = 8;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kaydet.UseVisualStyleBackColor = false;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_bilgi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(803, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_bilgi
            // 
            this.toolStripStatusLabel_bilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel_bilgi.Name = "toolStripStatusLabel_bilgi";
            this.toolStripStatusLabel_bilgi.Size = new System.Drawing.Size(0, 17);
            // 
            // Form_pozisyonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 422);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl_pozisyonIslemleri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_pozisyonlar);
            this.Name = "Form_pozisyonEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pozisyon Eke";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_pozisyonEkle_FormClosing);
            this.Load += new System.EventHandler(this.Form_pozisyonEkle_Load);
            this.tabControl_pozisyonIslemleri.ResumeLayout(false);
            this.tabPage_PozisyınGuncelle.ResumeLayout(false);
            this.tabPage_PozisyınGuncelle.PerformLayout();
            this.tabPage_pozisyonEkle.ResumeLayout(false);
            this.tabPage_pozisyonEkle.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_pozisyonlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl_pozisyonIslemleri;
        private System.Windows.Forms.TabPage tabPage_PozisyınGuncelle;
        private System.Windows.Forms.Button button_iptal;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.TextBox textBox_pozisyonYeniAd;
        private System.Windows.Forms.Label label_pozisyonEskiAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage_pozisyonEkle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_bilgi;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.TextBox textBox_pozisyon_adi;
        private System.Windows.Forms.Label label4;
    }
}