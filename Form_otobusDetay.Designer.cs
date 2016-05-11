namespace otobus_otomasyon_linq
{
    partial class Form_otobusDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_otobusDetay));
            this.comboBox_marka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_otobusler = new System.Windows.Forms.DataGridView();
            this.comboBox_aktiflik_durumu = new System.Windows.Forms.ComboBox();
            this.button_butun_otobusler = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_guncelleme_durum = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.checkBox_aktifMi = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_marka = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_koltukSayisi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_plaka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_otobusID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_otobusler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_marka
            // 
            this.comboBox_marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_marka.FormattingEnabled = true;
            this.comboBox_marka.Location = new System.Drawing.Point(76, 6);
            this.comboBox_marka.Name = "comboBox_marka";
            this.comboBox_marka.Size = new System.Drawing.Size(133, 24);
            this.comboBox_marka.TabIndex = 0;
            this.comboBox_marka.SelectedIndexChanged += new System.EventHandler(this.comboBox_marka_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka";
            // 
            // dataGridView_otobusler
            // 
            this.dataGridView_otobusler.AllowUserToAddRows = false;
            this.dataGridView_otobusler.AllowUserToDeleteRows = false;
            this.dataGridView_otobusler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_otobusler.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView_otobusler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_otobusler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_otobusler.Location = new System.Drawing.Point(12, 33);
            this.dataGridView_otobusler.Name = "dataGridView_otobusler";
            this.dataGridView_otobusler.ReadOnly = true;
            this.dataGridView_otobusler.Size = new System.Drawing.Size(641, 297);
            this.dataGridView_otobusler.TabIndex = 2;
            this.dataGridView_otobusler.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_otobusler_CellMouseClick);
            // 
            // comboBox_aktiflik_durumu
            // 
            this.comboBox_aktiflik_durumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_aktiflik_durumu.FormattingEnabled = true;
            this.comboBox_aktiflik_durumu.Items.AddRange(new object[] {
            "Aktif",
            "Pasif",
            "Hepsi"});
            this.comboBox_aktiflik_durumu.Location = new System.Drawing.Point(215, 6);
            this.comboBox_aktiflik_durumu.Name = "comboBox_aktiflik_durumu";
            this.comboBox_aktiflik_durumu.Size = new System.Drawing.Size(133, 24);
            this.comboBox_aktiflik_durumu.TabIndex = 3;
            this.comboBox_aktiflik_durumu.Text = "Otobüs Durumu";
            this.comboBox_aktiflik_durumu.SelectedIndexChanged += new System.EventHandler(this.comboBox_marka_SelectedIndexChanged);
            // 
            // button_butun_otobusler
            // 
            this.button_butun_otobusler.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_butun_otobusler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_butun_otobusler.Location = new System.Drawing.Point(364, 4);
            this.button_butun_otobusler.Name = "button_butun_otobusler";
            this.button_butun_otobusler.Size = new System.Drawing.Size(127, 26);
            this.button_butun_otobusler.TabIndex = 4;
            this.button_butun_otobusler.Text = "Bütün Otobüsler";
            this.button_butun_otobusler.UseVisualStyleBackColor = false;
            this.button_butun_otobusler.Click += new System.EventHandler(this.button_butun_otobusler_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.statusStrip1);
            this.groupBox1.Controls.Add(this.button_guncelle);
            this.groupBox1.Controls.Add(this.checkBox_aktifMi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label_marka);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label_koltukSayisi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_plaka);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_otobusID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 208);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Otobüs Güncelleme Paneli";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_guncelleme_durum});
            this.statusStrip1.Location = new System.Drawing.Point(3, 183);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(600, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_guncelleme_durum
            // 
            this.toolStripStatusLabel_guncelleme_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel_guncelleme_durum.Name = "toolStripStatusLabel_guncelleme_durum";
            this.toolStripStatusLabel_guncelleme_durum.Size = new System.Drawing.Size(0, 17);
            // 
            // button_guncelle
            // 
            this.button_guncelle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_guncelle.Enabled = false;
            this.button_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("button_guncelle.Image")));
            this.button_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guncelle.Location = new System.Drawing.Point(194, 143);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(95, 37);
            this.button_guncelle.TabIndex = 10;
            this.button_guncelle.Text = "Güncelle";
            this.button_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_guncelle.UseVisualStyleBackColor = false;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // checkBox_aktifMi
            // 
            this.checkBox_aktifMi.AutoSize = true;
            this.checkBox_aktifMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_aktifMi.Location = new System.Drawing.Point(149, 117);
            this.checkBox_aktifMi.Name = "checkBox_aktifMi";
            this.checkBox_aktifMi.Size = new System.Drawing.Size(96, 20);
            this.checkBox_aktifMi.TabIndex = 9;
            this.checkBox_aktifMi.Text = "Evet / Hayır";
            this.checkBox_aktifMi.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Aktif Mi:";
            // 
            // label_marka
            // 
            this.label_marka.AutoSize = true;
            this.label_marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_marka.Location = new System.Drawing.Point(146, 98);
            this.label_marka.Name = "label_marka";
            this.label_marka.Size = new System.Drawing.Size(0, 16);
            this.label_marka.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Otobüsün Markası:";
            // 
            // label_koltukSayisi
            // 
            this.label_koltukSayisi.AutoSize = true;
            this.label_koltukSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_koltukSayisi.Location = new System.Drawing.Point(146, 74);
            this.label_koltukSayisi.Name = "label_koltukSayisi";
            this.label_koltukSayisi.Size = new System.Drawing.Size(0, 16);
            this.label_koltukSayisi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Koltuk Sayısı:";
            // 
            // textBox_plaka
            // 
            this.textBox_plaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_plaka.Location = new System.Drawing.Point(149, 46);
            this.textBox_plaka.Name = "textBox_plaka";
            this.textBox_plaka.Size = new System.Drawing.Size(121, 22);
            this.textBox_plaka.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Otobüsün Plakası:";
            // 
            // label_otobusID
            // 
            this.label_otobusID.AutoSize = true;
            this.label_otobusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_otobusID.Location = new System.Drawing.Point(146, 26);
            this.label_otobusID.Name = "label_otobusID";
            this.label_otobusID.Size = new System.Drawing.Size(0, 16);
            this.label_otobusID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Otobüs Kodu:";
            // 
            // Form_otobusDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(703, 556);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_butun_otobusler);
            this.Controls.Add(this.comboBox_aktiflik_durumu);
            this.Controls.Add(this.dataGridView_otobusler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_marka);
            this.Name = "Form_otobusDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otobüs Detay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_otobusDetay_FormClosing);
            this.Load += new System.EventHandler(this.Form_otobusDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_otobusler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_marka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_otobusler;
        private System.Windows.Forms.ComboBox comboBox_aktiflik_durumu;
        private System.Windows.Forms.Button button_butun_otobusler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.CheckBox checkBox_aktifMi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_marka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_koltukSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_plaka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_otobusID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_guncelleme_durum;
    }
}