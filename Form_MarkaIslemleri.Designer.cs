namespace otobus_otomasyon_linq
{
    partial class Form_MarkaIslemleri
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
            this.groupBox_yeni_marka = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_marka_ekleme = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_ekle = new System.Windows.Forms.Button();
            this.textBox_markaAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_markalar = new System.Windows.Forms.DataGridView();
            this.groupBox_guncelle_sil = new System.Windows.Forms.GroupBox();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_marka_guncelle_sil = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_sil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_markanin_adi = new System.Windows.Forms.TextBox();
            this.label_markaKodu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_yeni_marka.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_markalar)).BeginInit();
            this.groupBox_guncelle_sil.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_yeni_marka
            // 
            this.groupBox_yeni_marka.Controls.Add(this.statusStrip1);
            this.groupBox_yeni_marka.Controls.Add(this.button_ekle);
            this.groupBox_yeni_marka.Controls.Add(this.textBox_markaAdi);
            this.groupBox_yeni_marka.Controls.Add(this.label1);
            this.groupBox_yeni_marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_yeni_marka.Location = new System.Drawing.Point(392, 12);
            this.groupBox_yeni_marka.Name = "groupBox_yeni_marka";
            this.groupBox_yeni_marka.Size = new System.Drawing.Size(310, 126);
            this.groupBox_yeni_marka.TabIndex = 1;
            this.groupBox_yeni_marka.TabStop = false;
            this.groupBox_yeni_marka.Text = "Yeni Marka Ekle";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_marka_ekleme});
            this.statusStrip1.Location = new System.Drawing.Point(3, 101);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(304, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_marka_ekleme
            // 
            this.toolStripStatusLabel_marka_ekleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel_marka_ekleme.Name = "toolStripStatusLabel_marka_ekleme";
            this.toolStripStatusLabel_marka_ekleme.Size = new System.Drawing.Size(0, 17);
            // 
            // button_ekle
            // 
            this.button_ekle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ekle.Image = global::otobus_otomasyon_linq.Properties.Resources.add_20x20;
            this.button_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ekle.Location = new System.Drawing.Point(167, 51);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(85, 31);
            this.button_ekle.TabIndex = 2;
            this.button_ekle.Text = "Ekle";
            this.button_ekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ekle.UseVisualStyleBackColor = false;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // textBox_markaAdi
            // 
            this.textBox_markaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_markaAdi.Location = new System.Drawing.Point(113, 25);
            this.textBox_markaAdi.Name = "textBox_markaAdi";
            this.textBox_markaAdi.Size = new System.Drawing.Size(128, 22);
            this.textBox_markaAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka Adı";
            // 
            // dataGridView_markalar
            // 
            this.dataGridView_markalar.AllowUserToAddRows = false;
            this.dataGridView_markalar.AllowUserToDeleteRows = false;
            this.dataGridView_markalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_markalar.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView_markalar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_markalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_markalar.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_markalar.Name = "dataGridView_markalar";
            this.dataGridView_markalar.ReadOnly = true;
            this.dataGridView_markalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_markalar.Size = new System.Drawing.Size(351, 338);
            this.dataGridView_markalar.TabIndex = 2;
            this.dataGridView_markalar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_markalar_CellMouseClick);
            // 
            // groupBox_guncelle_sil
            // 
            this.groupBox_guncelle_sil.Controls.Add(this.button_guncelle);
            this.groupBox_guncelle_sil.Controls.Add(this.statusStrip2);
            this.groupBox_guncelle_sil.Controls.Add(this.button_sil);
            this.groupBox_guncelle_sil.Controls.Add(this.label3);
            this.groupBox_guncelle_sil.Controls.Add(this.textBox_markanin_adi);
            this.groupBox_guncelle_sil.Controls.Add(this.label_markaKodu);
            this.groupBox_guncelle_sil.Controls.Add(this.label2);
            this.groupBox_guncelle_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_guncelle_sil.Location = new System.Drawing.Point(395, 145);
            this.groupBox_guncelle_sil.Name = "groupBox_guncelle_sil";
            this.groupBox_guncelle_sil.Size = new System.Drawing.Size(304, 152);
            this.groupBox_guncelle_sil.TabIndex = 3;
            this.groupBox_guncelle_sil.TabStop = false;
            this.groupBox_guncelle_sil.Text = "Güncelle Sil";
            // 
            // button_guncelle
            // 
            this.button_guncelle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_guncelle.Image = global::otobus_otomasyon_linq.Properties.Resources.accept_20x20;
            this.button_guncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guncelle.Location = new System.Drawing.Point(185, 73);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(94, 35);
            this.button_guncelle.TabIndex = 8;
            this.button_guncelle.Text = "Güncelle";
            this.button_guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_guncelle.UseVisualStyleBackColor = false;
            this.button_guncelle.Click += new System.EventHandler(this.button_guncelle_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_marka_guncelle_sil});
            this.statusStrip2.Location = new System.Drawing.Point(3, 127);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(298, 22);
            this.statusStrip2.TabIndex = 7;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel_marka_guncelle_sil
            // 
            this.toolStripStatusLabel_marka_guncelle_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel_marka_guncelle_sil.Name = "toolStripStatusLabel_marka_guncelle_sil";
            this.toolStripStatusLabel_marka_guncelle_sil.Size = new System.Drawing.Size(0, 17);
            // 
            // button_sil
            // 
            this.button_sil.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sil.Image = global::otobus_otomasyon_linq.Properties.Resources._71;
            this.button_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sil.Location = new System.Drawing.Point(110, 73);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(69, 35);
            this.button_sil.TabIndex = 5;
            this.button_sil.Text = "Sil";
            this.button_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_sil.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Markanın Adı";
            // 
            // textBox_markanin_adi
            // 
            this.textBox_markanin_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_markanin_adi.Location = new System.Drawing.Point(110, 47);
            this.textBox_markanin_adi.Name = "textBox_markanin_adi";
            this.textBox_markanin_adi.Size = new System.Drawing.Size(100, 22);
            this.textBox_markanin_adi.TabIndex = 2;
            // 
            // label_markaKodu
            // 
            this.label_markaKodu.AutoSize = true;
            this.label_markaKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_markaKodu.Location = new System.Drawing.Point(80, 27);
            this.label_markaKodu.Name = "label_markaKodu";
            this.label_markaKodu.Size = new System.Drawing.Size(0, 16);
            this.label_markaKodu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marka Kodu:";
            // 
            // Form_MarkaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(733, 362);
            this.Controls.Add(this.groupBox_guncelle_sil);
            this.Controls.Add(this.dataGridView_markalar);
            this.Controls.Add(this.groupBox_yeni_marka);
            this.Name = "Form_MarkaIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marka İşlemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_MarkaIslemleri_FormClosing);
            this.Load += new System.EventHandler(this.Form_MarkaIslemleri_Load);
            this.groupBox_yeni_marka.ResumeLayout(false);
            this.groupBox_yeni_marka.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_markalar)).EndInit();
            this.groupBox_guncelle_sil.ResumeLayout(false);
            this.groupBox_guncelle_sil.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_yeni_marka;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_marka_ekleme;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.TextBox textBox_markaAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_markalar;
        private System.Windows.Forms.GroupBox groupBox_guncelle_sil;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_markanin_adi;
        private System.Windows.Forms.Label label_markaKodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_marka_guncelle_sil;
        private System.Windows.Forms.Button button_guncelle;

    }
}