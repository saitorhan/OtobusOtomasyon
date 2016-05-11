namespace otobus_otomasyon_linq
{
    partial class form_SubeDetay
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_sehirler = new System.Windows.Forms.ComboBox();
            this.dataGridView_subeler = new System.Windows.Forms.DataGridView();
            this.panel_sube_detaylari = new System.Windows.Forms.Panel();
            this.panel_guncelleme = new System.Windows.Forms.Panel();
            this.label_sube_kodu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.betterSplitButton_sube_islemleri = new ComponentOwl.BetterSplitButton.BetterSplitButton();
            this.contextMenuStrip_sube_islemleri = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.subeyiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subeyiGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_subeAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_subeSehir = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_grid_yenile = new System.Windows.Forms.Button();
            this.button_sube_ekleme = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_guncelle_iptal = new System.Windows.Forms.Button();
            this.button_guncelle_kayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_subeler)).BeginInit();
            this.panel_sube_detaylari.SuspendLayout();
            this.panel_guncelleme.SuspendLayout();
            this.contextMenuStrip_sube_islemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şubeleri listelenecek şehir:";
            // 
            // comboBox_sehirler
            // 
            this.comboBox_sehirler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_sehirler.FormattingEnabled = true;
            this.comboBox_sehirler.Location = new System.Drawing.Point(187, 6);
            this.comboBox_sehirler.Name = "comboBox_sehirler";
            this.comboBox_sehirler.Size = new System.Drawing.Size(121, 24);
            this.comboBox_sehirler.TabIndex = 1;
            this.comboBox_sehirler.Text = "Şehir Seçiniz";
            this.comboBox_sehirler.SelectedIndexChanged += new System.EventHandler(this.comboBox_sehirler_SelectedIndexChanged);
            // 
            // dataGridView_subeler
            // 
            this.dataGridView_subeler.AllowUserToAddRows = false;
            this.dataGridView_subeler.AllowUserToDeleteRows = false;
            this.dataGridView_subeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_subeler.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView_subeler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_subeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_subeler.Location = new System.Drawing.Point(15, 33);
            this.dataGridView_subeler.Name = "dataGridView_subeler";
            this.dataGridView_subeler.ReadOnly = true;
            this.dataGridView_subeler.Size = new System.Drawing.Size(558, 396);
            this.dataGridView_subeler.TabIndex = 2;
            this.dataGridView_subeler.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_subeler_CellMouseClick);
            // 
            // panel_sube_detaylari
            // 
            this.panel_sube_detaylari.Controls.Add(this.panel_guncelleme);
            this.panel_sube_detaylari.Controls.Add(this.label_sube_kodu);
            this.panel_sube_detaylari.Controls.Add(this.label4);
            this.panel_sube_detaylari.Controls.Add(this.betterSplitButton_sube_islemleri);
            this.panel_sube_detaylari.Controls.Add(this.textBox_subeAd);
            this.panel_sube_detaylari.Controls.Add(this.label3);
            this.panel_sube_detaylari.Controls.Add(this.label_subeSehir);
            this.panel_sube_detaylari.Controls.Add(this.label2);
            this.panel_sube_detaylari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel_sube_detaylari.Location = new System.Drawing.Point(579, 33);
            this.panel_sube_detaylari.Name = "panel_sube_detaylari";
            this.panel_sube_detaylari.Size = new System.Drawing.Size(253, 396);
            this.panel_sube_detaylari.TabIndex = 3;
            this.panel_sube_detaylari.Visible = false;
            // 
            // panel_guncelleme
            // 
            this.panel_guncelleme.Controls.Add(this.button_guncelle_iptal);
            this.panel_guncelleme.Controls.Add(this.button_guncelle_kayit);
            this.panel_guncelleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel_guncelleme.Location = new System.Drawing.Point(53, 102);
            this.panel_guncelleme.Name = "panel_guncelleme";
            this.panel_guncelleme.Size = new System.Drawing.Size(195, 47);
            this.panel_guncelleme.TabIndex = 9;
            this.panel_guncelleme.Visible = false;
            // 
            // label_sube_kodu
            // 
            this.label_sube_kodu.AutoSize = true;
            this.label_sube_kodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sube_kodu.Location = new System.Drawing.Point(72, 3);
            this.label_sube_kodu.Name = "label_sube_kodu";
            this.label_sube_kodu.Size = new System.Drawing.Size(0, 16);
            this.label_sube_kodu.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Şube Kodu:";
            // 
            // betterSplitButton_sube_islemleri
            // 
            this.betterSplitButton_sube_islemleri.ContextMenuStrip = this.contextMenuStrip_sube_islemleri;
            this.betterSplitButton_sube_islemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.betterSplitButton_sube_islemleri.Location = new System.Drawing.Point(75, 73);
            this.betterSplitButton_sube_islemleri.Name = "betterSplitButton_sube_islemleri";
            this.betterSplitButton_sube_islemleri.Size = new System.Drawing.Size(161, 23);
            this.betterSplitButton_sube_islemleri.TabIndex = 4;
            this.betterSplitButton_sube_islemleri.Text = "Seçili Şube İşlemleri";
            // 
            // contextMenuStrip_sube_islemleri
            // 
            this.contextMenuStrip_sube_islemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.contextMenuStrip_sube_islemleri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subeyiSilToolStripMenuItem,
            this.subeyiGuncelleToolStripMenuItem});
            this.contextMenuStrip_sube_islemleri.Name = "contextMenuStrip_sube_islemleri";
            this.contextMenuStrip_sube_islemleri.Size = new System.Drawing.Size(191, 48);
            // 
            // subeyiSilToolStripMenuItem
            // 
            this.subeyiSilToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subeyiSilToolStripMenuItem.Name = "subeyiSilToolStripMenuItem";
            this.subeyiSilToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.subeyiSilToolStripMenuItem.Text = "Şubeyi Sil";
            this.subeyiSilToolStripMenuItem.Click += new System.EventHandler(this.subeyiSilToolStripMenuItem_Click);
            // 
            // subeyiGuncelleToolStripMenuItem
            // 
            this.subeyiGuncelleToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.subeyiGuncelleToolStripMenuItem.Name = "subeyiGuncelleToolStripMenuItem";
            this.subeyiGuncelleToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.subeyiGuncelleToolStripMenuItem.Text = "Şube Adını Değiştir";
            this.subeyiGuncelleToolStripMenuItem.Click += new System.EventHandler(this.subeyiGuncelleToolStripMenuItem_Click);
            // 
            // textBox_subeAd
            // 
            this.textBox_subeAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_subeAd.Location = new System.Drawing.Point(75, 47);
            this.textBox_subeAd.Name = "textBox_subeAd";
            this.textBox_subeAd.ReadOnly = true;
            this.textBox_subeAd.Size = new System.Drawing.Size(161, 22);
            this.textBox_subeAd.TabIndex = 3;
            this.textBox_subeAd.Leave += new System.EventHandler(this.textBox_subeAd_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şube Adı:";
            // 
            // label_subeSehir
            // 
            this.label_subeSehir.AutoSize = true;
            this.label_subeSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_subeSehir.Location = new System.Drawing.Point(66, 26);
            this.label_subeSehir.Name = "label_subeSehir";
            this.label_subeSehir.Size = new System.Drawing.Size(0, 16);
            this.label_subeSehir.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şehir:";
            // 
            // button_grid_yenile
            // 
            this.button_grid_yenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_grid_yenile.Location = new System.Drawing.Point(314, 4);
            this.button_grid_yenile.Name = "button_grid_yenile";
            this.button_grid_yenile.Size = new System.Drawing.Size(106, 23);
            this.button_grid_yenile.TabIndex = 7;
            this.button_grid_yenile.Text = "Listeyi Yenile";
            this.button_grid_yenile.UseVisualStyleBackColor = true;
            this.button_grid_yenile.Click += new System.EventHandler(this.button_grid_yenile_Click);
            // 
            // button_sube_ekleme
            // 
            this.button_sube_ekleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sube_ekleme.Location = new System.Drawing.Point(519, 4);
            this.button_sube_ekleme.Name = "button_sube_ekleme";
            this.button_sube_ekleme.Size = new System.Drawing.Size(105, 23);
            this.button_sube_ekleme.TabIndex = 8;
            this.button_sube_ekleme.Text = "Yeni Şube Ekle";
            this.button_sube_ekleme.UseVisualStyleBackColor = true;
            this.button_sube_ekleme.Visible = false;
            this.button_sube_ekleme.Click += new System.EventHandler(this.button_sube_ekleme_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(426, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Bütün Şubeler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_guncelle_iptal
            // 
            this.button_guncelle_iptal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_guncelle_iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_guncelle_iptal.Image = global::otobus_otomasyon_linq.Properties.Resources.remove_20x20;
            this.button_guncelle_iptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guncelle_iptal.Location = new System.Drawing.Point(16, 3);
            this.button_guncelle_iptal.Name = "button_guncelle_iptal";
            this.button_guncelle_iptal.Size = new System.Drawing.Size(69, 32);
            this.button_guncelle_iptal.TabIndex = 8;
            this.button_guncelle_iptal.Text = "İptal";
            this.button_guncelle_iptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_guncelle_iptal.UseVisualStyleBackColor = false;
            this.button_guncelle_iptal.Click += new System.EventHandler(this.button_guncelle_iptal_Click);
            // 
            // button_guncelle_kayit
            // 
            this.button_guncelle_kayit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_guncelle_kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_guncelle_kayit.Image = global::otobus_otomasyon_linq.Properties.Resources._52;
            this.button_guncelle_kayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_guncelle_kayit.Location = new System.Drawing.Point(91, 3);
            this.button_guncelle_kayit.Name = "button_guncelle_kayit";
            this.button_guncelle_kayit.Size = new System.Drawing.Size(92, 32);
            this.button_guncelle_kayit.TabIndex = 7;
            this.button_guncelle_kayit.Text = "Kaydet";
            this.button_guncelle_kayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_guncelle_kayit.UseVisualStyleBackColor = false;
            this.button_guncelle_kayit.Click += new System.EventHandler(this.button_guncelle_kayit_Click);
            // 
            // form_SubeDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(839, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_sube_ekleme);
            this.Controls.Add(this.button_grid_yenile);
            this.Controls.Add(this.panel_sube_detaylari);
            this.Controls.Add(this.dataGridView_subeler);
            this.Controls.Add(this.comboBox_sehirler);
            this.Controls.Add(this.label1);
            this.Name = "form_SubeDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şube Detay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_SubeDetay_FormClosing);
            this.Load += new System.EventHandler(this.form_SubeDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_subeler)).EndInit();
            this.panel_sube_detaylari.ResumeLayout(false);
            this.panel_sube_detaylari.PerformLayout();
            this.panel_guncelleme.ResumeLayout(false);
            this.contextMenuStrip_sube_islemleri.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_sehirler;
        private System.Windows.Forms.DataGridView dataGridView_subeler;
        private System.Windows.Forms.Panel panel_sube_detaylari;
        private ComponentOwl.BetterSplitButton.BetterSplitButton betterSplitButton_sube_islemleri;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_sube_islemleri;
        private System.Windows.Forms.ToolStripMenuItem subeyiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subeyiGuncelleToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_subeAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_subeSehir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_sube_kodu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_grid_yenile;
        private System.Windows.Forms.Panel panel_guncelleme;
        private System.Windows.Forms.Button button_guncelle_iptal;
        private System.Windows.Forms.Button button_guncelle_kayit;
        private System.Windows.Forms.Button button_sube_ekleme;
        private System.Windows.Forms.Button button1;
    }
}