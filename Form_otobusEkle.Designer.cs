namespace otobus_otomasyon_linq
{
    partial class Form_otobusEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_otobusEkle));
            this.textBox_plaka = new System.Windows.Forms.TextBox();
            this.textBox_koltuk_sayisi = new System.Windows.Forms.TextBox();
            this.comboBox_marka = new System.Windows.Forms.ComboBox();
            this.checkBox_aktifMi = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button_iptal = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_kayit_durum = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_plaka
            // 
            this.textBox_plaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_plaka.Location = new System.Drawing.Point(114, 97);
            this.textBox_plaka.Name = "textBox_plaka";
            this.textBox_plaka.Size = new System.Drawing.Size(164, 23);
            this.textBox_plaka.TabIndex = 0;
            this.textBox_plaka.Leave += new System.EventHandler(this.textBox_plaka_Leave);
            // 
            // textBox_koltuk_sayisi
            // 
            this.textBox_koltuk_sayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_koltuk_sayisi.Location = new System.Drawing.Point(114, 123);
            this.textBox_koltuk_sayisi.MaxLength = 2;
            this.textBox_koltuk_sayisi.Name = "textBox_koltuk_sayisi";
            this.textBox_koltuk_sayisi.Size = new System.Drawing.Size(164, 23);
            this.textBox_koltuk_sayisi.TabIndex = 1;
            this.textBox_koltuk_sayisi.TextChanged += new System.EventHandler(this.textBox_koltuk_sayisi_TextChanged);
            // 
            // comboBox_marka
            // 
            this.comboBox_marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_marka.FormattingEnabled = true;
            this.comboBox_marka.Location = new System.Drawing.Point(114, 150);
            this.comboBox_marka.Name = "comboBox_marka";
            this.comboBox_marka.Size = new System.Drawing.Size(164, 24);
            this.comboBox_marka.TabIndex = 2;
            // 
            // checkBox_aktifMi
            // 
            this.checkBox_aktifMi.AutoSize = true;
            this.checkBox_aktifMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_aktifMi.Location = new System.Drawing.Point(114, 177);
            this.checkBox_aktifMi.Name = "checkBox_aktifMi";
            this.checkBox_aktifMi.Size = new System.Drawing.Size(100, 21);
            this.checkBox_aktifMi.TabIndex = 3;
            this.checkBox_aktifMi.Text = "Evet / Hayır";
            this.checkBox_aktifMi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Koltuk Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Marka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Aktif Mi";
            // 
            // button_kaydet
            // 
            this.button_kaydet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_kaydet.Image")));
            this.button_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kaydet.Location = new System.Drawing.Point(187, 204);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(91, 32);
            this.button_kaydet.TabIndex = 8;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kaydet.UseVisualStyleBackColor = false;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // button_iptal
            // 
            this.button_iptal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_iptal.Image = ((System.Drawing.Image)(resources.GetObject("button_iptal.Image")));
            this.button_iptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_iptal.Location = new System.Drawing.Point(106, 204);
            this.button_iptal.Name = "button_iptal";
            this.button_iptal.Size = new System.Drawing.Size(75, 32);
            this.button_iptal.TabIndex = 9;
            this.button_iptal.Text = "İptal";
            this.button_iptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_iptal.UseVisualStyleBackColor = false;
            this.button_iptal.Click += new System.EventHandler(this.button_iptal_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_kayit_durum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 279);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(378, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_kayit_durum
            // 
            this.toolStripStatusLabel_kayit_durum.Name = "toolStripStatusLabel_kayit_durum";
            this.toolStripStatusLabel_kayit_durum.Size = new System.Drawing.Size(0, 17);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form_otobusEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(378, 301);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_iptal);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_aktifMi);
            this.Controls.Add(this.comboBox_marka);
            this.Controls.Add(this.textBox_koltuk_sayisi);
            this.Controls.Add(this.textBox_plaka);
            this.Name = "Form_otobusEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otobüs Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_otobusEkle_FormClosing);
            this.Load += new System.EventHandler(this.Form_otobusEkle_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_plaka;
        private System.Windows.Forms.TextBox textBox_koltuk_sayisi;
        private System.Windows.Forms.ComboBox comboBox_marka;
        private System.Windows.Forms.CheckBox checkBox_aktifMi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button button_iptal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_kayit_durum;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}