namespace otobus_otomasyon_linq
{
    partial class Form_masrafIslemleri
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
            this.groupBox_butunMasraflar = new System.Windows.Forms.GroupBox();
            this.dataGridView_masraflar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_calisan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_seferID = new System.Windows.Forms.TextBox();
            this.label_otobus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_masraf = new System.Windows.Forms.ComboBox();
            this.textBox_tutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_bilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_kayitlimasrafIslemleri = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_kayitliTutar = new System.Windows.Forms.TextBox();
            this.comboBox_kayitliMasraf = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_kayitli_calisan = new System.Windows.Forms.ComboBox();
            this.button_iptal = new System.Windows.Forms.Button();
            this.button_ara = new System.Windows.Forms.Button();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.groupBox_butunMasraflar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_masraflar)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox_kayitlimasrafIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_butunMasraflar
            // 
            this.groupBox_butunMasraflar.Controls.Add(this.dataGridView_masraflar);
            this.groupBox_butunMasraflar.Location = new System.Drawing.Point(476, 15);
            this.groupBox_butunMasraflar.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_butunMasraflar.Name = "groupBox_butunMasraflar";
            this.groupBox_butunMasraflar.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_butunMasraflar.Size = new System.Drawing.Size(564, 542);
            this.groupBox_butunMasraflar.TabIndex = 0;
            this.groupBox_butunMasraflar.TabStop = false;
            this.groupBox_butunMasraflar.Text = "Masraflar";
            // 
            // dataGridView_masraflar
            // 
            this.dataGridView_masraflar.AllowUserToAddRows = false;
            this.dataGridView_masraflar.AllowUserToDeleteRows = false;
            this.dataGridView_masraflar.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView_masraflar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_masraflar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_masraflar.Location = new System.Drawing.Point(4, 19);
            this.dataGridView_masraflar.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_masraflar.Name = "dataGridView_masraflar";
            this.dataGridView_masraflar.ReadOnly = true;
            this.dataGridView_masraflar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_masraflar.Size = new System.Drawing.Size(556, 519);
            this.dataGridView_masraflar.TabIndex = 0;
            this.dataGridView_masraflar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_masraflar_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sefer Numarası";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Otobüs";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox_calisan
            // 
            this.comboBox_calisan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_calisan.FormattingEnabled = true;
            this.comboBox_calisan.Location = new System.Drawing.Point(227, 85);
            this.comboBox_calisan.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_calisan.Name = "comboBox_calisan";
            this.comboBox_calisan.Size = new System.Drawing.Size(235, 24);
            this.comboBox_calisan.TabIndex = 3;
            this.comboBox_calisan.SelectedIndexChanged += new System.EventHandler(this.comboBox_calisan_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Masrafı Yapan Çalışan";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_seferID
            // 
            this.textBox_seferID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_seferID.Location = new System.Drawing.Point(227, 31);
            this.textBox_seferID.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_seferID.Name = "textBox_seferID";
            this.textBox_seferID.Size = new System.Drawing.Size(132, 22);
            this.textBox_seferID.TabIndex = 5;
            this.textBox_seferID.TextChanged += new System.EventHandler(this.textBox_seferID_TextChanged);
            // 
            // label_otobus
            // 
            this.label_otobus.AutoSize = true;
            this.label_otobus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_otobus.Location = new System.Drawing.Point(223, 59);
            this.label_otobus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_otobus.Name = "label_otobus";
            this.label_otobus.Size = new System.Drawing.Size(0, 16);
            this.label_otobus.TabIndex = 6;
            this.label_otobus.Click += new System.EventHandler(this.label_otobus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yapılan Masraf";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox_masraf
            // 
            this.comboBox_masraf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_masraf.FormattingEnabled = true;
            this.comboBox_masraf.Location = new System.Drawing.Point(227, 118);
            this.comboBox_masraf.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_masraf.Name = "comboBox_masraf";
            this.comboBox_masraf.Size = new System.Drawing.Size(235, 24);
            this.comboBox_masraf.TabIndex = 8;
            this.comboBox_masraf.SelectedIndexChanged += new System.EventHandler(this.comboBox_masraf_SelectedIndexChanged);
            // 
            // textBox_tutar
            // 
            this.textBox_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_tutar.Location = new System.Drawing.Point(227, 151);
            this.textBox_tutar.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_tutar.Name = "textBox_tutar";
            this.textBox_tutar.Size = new System.Drawing.Size(132, 22);
            this.textBox_tutar.TabIndex = 9;
            this.textBox_tutar.TextChanged += new System.EventHandler(this.textBox_tutar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(16, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tutar";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_bilgi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1056, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel_bilgi
            // 
            this.toolStripStatusLabel_bilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel_bilgi.Name = "toolStripStatusLabel_bilgi";
            this.toolStripStatusLabel_bilgi.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusLabel_bilgi.Click += new System.EventHandler(this.toolStripStatusLabel_bilgi_Click);
            // 
            // groupBox_kayitlimasrafIslemleri
            // 
            this.groupBox_kayitlimasrafIslemleri.Controls.Add(this.label9);
            this.groupBox_kayitlimasrafIslemleri.Controls.Add(this.button_sil);
            this.groupBox_kayitlimasrafIslemleri.Controls.Add(this.button_guncelle);
            this.groupBox_kayitlimasrafIslemleri.Controls.Add(this.label6);
            this.groupBox_kayitlimasrafIslemleri.Controls.Add(this.textBox_kayitliTutar);
            this.groupBox_kayitlimasrafIslemleri.Controls.Add(this.comboBox_kayitliMasraf);
            this.groupBox_kayitlimasrafIslemleri.Controls.Add(this.label7);
            this.groupBox_kayitlimasrafIslemleri.Controls.Add(this.label8);
            this.groupBox_kayitlimasrafIslemleri.Controls.Add(this.comboBox_kayitli_calisan);
            this.groupBox_kayitlimasrafIslemleri.Location = new System.Drawing.Point(20, 263);
            this.groupBox_kayitlimasrafIslemleri.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_kayitlimasrafIslemleri.Name = "groupBox_kayitlimasrafIslemleri";
            this.groupBox_kayitlimasrafIslemleri.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_kayitlimasrafIslemleri.Size = new System.Drawing.Size(443, 293);
            this.groupBox_kayitlimasrafIslemleri.TabIndex = 14;
            this.groupBox_kayitlimasrafIslemleri.TabStop = false;
            this.groupBox_kayitlimasrafIslemleri.Text = "Kayıtlı Masraf İşlemleri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(8, 219);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 17;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button_sil
            // 
            this.button_sil.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sil.Image = global::otobus_otomasyon_linq.Properties.Resources._71;
            this.button_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sil.Location = new System.Drawing.Point(210, 160);
            this.button_sil.Margin = new System.Windows.Forms.Padding(4);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(91, 36);
            this.button_sil.TabIndex = 16;
            this.button_sil.Text = "Sil";
            this.button_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_sil.UseVisualStyleBackColor = false;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // button_guncelle
            // 
            this.button_guncelle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_guncelle.Image = global::otobus_otomasyon_linq.Properties.Resources.accept_20x20;
            this.button_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guncelle.Location = new System.Drawing.Point(309, 160);
            this.button_guncelle.Margin = new System.Windows.Forms.Padding(4);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(100, 36);
            this.button_guncelle.TabIndex = 16;
            this.button_guncelle.Text = "Güncelle";
            this.button_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_guncelle.UseVisualStyleBackColor = false;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tutar";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox_kayitliTutar
            // 
            this.textBox_kayitliTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_kayitliTutar.Location = new System.Drawing.Point(212, 107);
            this.textBox_kayitliTutar.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_kayitliTutar.Name = "textBox_kayitliTutar";
            this.textBox_kayitliTutar.Size = new System.Drawing.Size(93, 22);
            this.textBox_kayitliTutar.TabIndex = 15;
            this.textBox_kayitliTutar.TextChanged += new System.EventHandler(this.textBox_kayitliTutar_TextChanged);
            // 
            // comboBox_kayitliMasraf
            // 
            this.comboBox_kayitliMasraf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_kayitliMasraf.FormattingEnabled = true;
            this.comboBox_kayitliMasraf.Location = new System.Drawing.Point(212, 74);
            this.comboBox_kayitliMasraf.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_kayitliMasraf.Name = "comboBox_kayitliMasraf";
            this.comboBox_kayitliMasraf.Size = new System.Drawing.Size(196, 24);
            this.comboBox_kayitliMasraf.TabIndex = 14;
            this.comboBox_kayitliMasraf.SelectedIndexChanged += new System.EventHandler(this.comboBox_kayitliMasraf_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(8, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Yapılan Masraf";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(8, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Masrafı Yapan Çalışan";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboBox_kayitli_calisan
            // 
            this.comboBox_kayitli_calisan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_kayitli_calisan.FormattingEnabled = true;
            this.comboBox_kayitli_calisan.Location = new System.Drawing.Point(212, 41);
            this.comboBox_kayitli_calisan.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_kayitli_calisan.Name = "comboBox_kayitli_calisan";
            this.comboBox_kayitli_calisan.Size = new System.Drawing.Size(196, 24);
            this.comboBox_kayitli_calisan.TabIndex = 11;
            this.comboBox_kayitli_calisan.SelectedIndexChanged += new System.EventHandler(this.comboBox_kayitli_calisan_SelectedIndexChanged);
            // 
            // button_iptal
            // 
            this.button_iptal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_iptal.Image = global::otobus_otomasyon_linq.Properties.Resources.remove_20x20;
            this.button_iptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_iptal.Location = new System.Drawing.Point(238, 194);
            this.button_iptal.Margin = new System.Windows.Forms.Padding(4);
            this.button_iptal.Name = "button_iptal";
            this.button_iptal.Size = new System.Drawing.Size(94, 37);
            this.button_iptal.TabIndex = 15;
            this.button_iptal.Text = "İptal";
            this.button_iptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_iptal.UseVisualStyleBackColor = false;
            this.button_iptal.Click += new System.EventHandler(this.button_iptal_Click);
            // 
            // button_ara
            // 
            this.button_ara.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ara.Image = global::otobus_otomasyon_linq.Properties.Resources.search_16x16;
            this.button_ara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ara.Location = new System.Drawing.Point(368, 30);
            this.button_ara.Margin = new System.Windows.Forms.Padding(4);
            this.button_ara.Name = "button_ara";
            this.button_ara.Size = new System.Drawing.Size(75, 28);
            this.button_ara.TabIndex = 12;
            this.button_ara.Text = "Ara";
            this.button_ara.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ara.UseVisualStyleBackColor = false;
            this.button_ara.Click += new System.EventHandler(this.button_ara_Click);
            // 
            // button_kaydet
            // 
            this.button_kaydet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kaydet.Image = global::otobus_otomasyon_linq.Properties.Resources._5;
            this.button_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kaydet.Location = new System.Drawing.Point(340, 194);
            this.button_kaydet.Margin = new System.Windows.Forms.Padding(4);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(103, 37);
            this.button_kaydet.TabIndex = 11;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_kaydet.UseVisualStyleBackColor = false;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // Form_masrafIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1056, 602);
            this.Controls.Add(this.button_iptal);
            this.Controls.Add(this.groupBox_kayitlimasrafIslemleri);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_ara);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_tutar);
            this.Controls.Add(this.comboBox_masraf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_otobus);
            this.Controls.Add(this.textBox_seferID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_calisan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_butunMasraflar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_masrafIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masraf İşlemleri";
            this.Load += new System.EventHandler(this.Form_masrafIslemleri_Load);
            this.groupBox_butunMasraflar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_masraflar)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox_kayitlimasrafIslemleri.ResumeLayout(false);
            this.groupBox_kayitlimasrafIslemleri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_butunMasraflar;
        private System.Windows.Forms.DataGridView dataGridView_masraflar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_calisan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_seferID;
        private System.Windows.Forms.Label label_otobus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_masraf;
        private System.Windows.Forms.TextBox textBox_tutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button button_ara;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_bilgi;
        private System.Windows.Forms.GroupBox groupBox_kayitlimasrafIslemleri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_kayitliTutar;
        private System.Windows.Forms.ComboBox comboBox_kayitliMasraf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_kayitli_calisan;
        private System.Windows.Forms.Button button_iptal;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.Label label9;
    }
}