namespace otobus_otomasyon_linq
{
    partial class Form_GuzergahEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GuzergahEkle));
            this.panel_guzergahEkle = new System.Windows.Forms.Panel();
            this.statusStrip_kayit = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_kayit = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox_guzergahIsmi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_iptal = new System.Windows.Forms.Button();
            this.button_ekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_varisSehir = new System.Windows.Forms.ComboBox();
            this.comboBox_baslamaSehir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_sehir1 = new System.Windows.Forms.ComboBox();
            this.groupBox_GuzergahSehirleri = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_itemKayit = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_sehirleriKaydet = new System.Windows.Forms.Button();
            this.button_GuzergahaSehirEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_guzergahEkle.SuspendLayout();
            this.statusStrip_kayit.SuspendLayout();
            this.groupBox_GuzergahSehirleri.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_guzergahEkle
            // 
            this.panel_guzergahEkle.Controls.Add(this.statusStrip_kayit);
            this.panel_guzergahEkle.Controls.Add(this.textBox_guzergahIsmi);
            this.panel_guzergahEkle.Controls.Add(this.label4);
            this.panel_guzergahEkle.Controls.Add(this.button_iptal);
            this.panel_guzergahEkle.Controls.Add(this.button_ekle);
            this.panel_guzergahEkle.Controls.Add(this.label2);
            this.panel_guzergahEkle.Controls.Add(this.comboBox_varisSehir);
            this.panel_guzergahEkle.Controls.Add(this.comboBox_baslamaSehir);
            this.panel_guzergahEkle.Controls.Add(this.label1);
            this.panel_guzergahEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel_guzergahEkle.Location = new System.Drawing.Point(12, 12);
            this.panel_guzergahEkle.Name = "panel_guzergahEkle";
            this.panel_guzergahEkle.Size = new System.Drawing.Size(292, 507);
            this.panel_guzergahEkle.TabIndex = 0;
            // 
            // statusStrip_kayit
            // 
            this.statusStrip_kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip_kayit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_kayit});
            this.statusStrip_kayit.Location = new System.Drawing.Point(0, 485);
            this.statusStrip_kayit.Name = "statusStrip_kayit";
            this.statusStrip_kayit.Size = new System.Drawing.Size(292, 22);
            this.statusStrip_kayit.TabIndex = 8;
            this.statusStrip_kayit.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_kayit
            // 
            this.toolStripStatusLabel_kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel_kayit.Name = "toolStripStatusLabel_kayit";
            this.toolStripStatusLabel_kayit.Size = new System.Drawing.Size(0, 17);
            // 
            // textBox_guzergahIsmi
            // 
            this.textBox_guzergahIsmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_guzergahIsmi.Location = new System.Drawing.Point(6, 89);
            this.textBox_guzergahIsmi.Name = "textBox_guzergahIsmi";
            this.textBox_guzergahIsmi.Size = new System.Drawing.Size(236, 22);
            this.textBox_guzergahIsmi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Güzergah İsmi";
            // 
            // button_iptal
            // 
            this.button_iptal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_iptal.Image = global::otobus_otomasyon_linq.Properties.Resources.remove_20x20;
            this.button_iptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_iptal.Location = new System.Drawing.Point(69, 114);
            this.button_iptal.Name = "button_iptal";
            this.button_iptal.Size = new System.Drawing.Size(83, 33);
            this.button_iptal.TabIndex = 5;
            this.button_iptal.Text = "İptal";
            this.button_iptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_iptal.UseVisualStyleBackColor = false;
            this.button_iptal.Click += new System.EventHandler(this.button_iptal_Click);
            // 
            // button_ekle
            // 
            this.button_ekle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ekle.Image = ((System.Drawing.Image)(resources.GetObject("button_ekle.Image")));
            this.button_ekle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ekle.Location = new System.Drawing.Point(158, 114);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(105, 33);
            this.button_ekle.TabIndex = 4;
            this.button_ekle.Text = "Kaydet";
            this.button_ekle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ekle.UseVisualStyleBackColor = false;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Varış Şehri";
            // 
            // comboBox_varisSehir
            // 
            this.comboBox_varisSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_varisSehir.FormattingEnabled = true;
            this.comboBox_varisSehir.Location = new System.Drawing.Point(134, 33);
            this.comboBox_varisSehir.Name = "comboBox_varisSehir";
            this.comboBox_varisSehir.Size = new System.Drawing.Size(144, 24);
            this.comboBox_varisSehir.TabIndex = 2;
            this.comboBox_varisSehir.SelectedIndexChanged += new System.EventHandler(this.comboBox_varisSehir_SelectedIndexChanged);
            // 
            // comboBox_baslamaSehir
            // 
            this.comboBox_baslamaSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_baslamaSehir.FormattingEnabled = true;
            this.comboBox_baslamaSehir.Location = new System.Drawing.Point(134, 6);
            this.comboBox_baslamaSehir.Name = "comboBox_baslamaSehir";
            this.comboBox_baslamaSehir.Size = new System.Drawing.Size(144, 24);
            this.comboBox_baslamaSehir.TabIndex = 1;
            this.comboBox_baslamaSehir.SelectedIndexChanged += new System.EventHandler(this.comboBox_baslamaSehir_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Şehri";
            // 
            // comboBox_sehir1
            // 
            this.comboBox_sehir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_sehir1.FormattingEnabled = true;
            this.comboBox_sehir1.Location = new System.Drawing.Point(95, 13);
            this.comboBox_sehir1.Name = "comboBox_sehir1";
            this.comboBox_sehir1.Size = new System.Drawing.Size(160, 24);
            this.comboBox_sehir1.TabIndex = 7;
            this.comboBox_sehir1.SelectedIndexChanged += new System.EventHandler(this.comboBox_sehir1_SelectedIndexChanged);
            // 
            // groupBox_GuzergahSehirleri
            // 
            this.groupBox_GuzergahSehirleri.Controls.Add(this.statusStrip1);
            this.groupBox_GuzergahSehirleri.Controls.Add(this.panel1);
            this.groupBox_GuzergahSehirleri.Controls.Add(this.comboBox_sehir1);
            this.groupBox_GuzergahSehirleri.Controls.Add(this.label3);
            this.groupBox_GuzergahSehirleri.Enabled = false;
            this.groupBox_GuzergahSehirleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_GuzergahSehirleri.Location = new System.Drawing.Point(310, 12);
            this.groupBox_GuzergahSehirleri.Name = "groupBox_GuzergahSehirleri";
            this.groupBox_GuzergahSehirleri.Size = new System.Drawing.Size(525, 507);
            this.groupBox_GuzergahSehirleri.TabIndex = 1;
            this.groupBox_GuzergahSehirleri.TabStop = false;
            this.groupBox_GuzergahSehirleri.Text = "Güzergah Şehirleri";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_itemKayit});
            this.statusStrip1.Location = new System.Drawing.Point(3, 482);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(519, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_itemKayit
            // 
            this.toolStripStatusLabel_itemKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel_itemKayit.Name = "toolStripStatusLabel_itemKayit";
            this.toolStripStatusLabel_itemKayit.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_sehirleriKaydet);
            this.panel1.Controls.Add(this.button_GuzergahaSehirEkle);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(261, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 44);
            this.panel1.TabIndex = 8;
            // 
            // button_sehirleriKaydet
            // 
            this.button_sehirleriKaydet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_sehirleriKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sehirleriKaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_sehirleriKaydet.Image")));
            this.button_sehirleriKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sehirleriKaydet.Location = new System.Drawing.Point(134, 0);
            this.button_sehirleriKaydet.Name = "button_sehirleriKaydet";
            this.button_sehirleriKaydet.Size = new System.Drawing.Size(111, 36);
            this.button_sehirleriKaydet.TabIndex = 10;
            this.button_sehirleriKaydet.Text = "Kaydet";
            this.button_sehirleriKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_sehirleriKaydet.UseVisualStyleBackColor = false;
            this.button_sehirleriKaydet.Click += new System.EventHandler(this.button_sehirleriKaydet_Click);
            // 
            // button_GuzergahaSehirEkle
            // 
            this.button_GuzergahaSehirEkle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_GuzergahaSehirEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_GuzergahaSehirEkle.Image = global::otobus_otomasyon_linq.Properties.Resources.add_20x20;
            this.button_GuzergahaSehirEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_GuzergahaSehirEkle.Location = new System.Drawing.Point(3, 0);
            this.button_GuzergahaSehirEkle.Name = "button_GuzergahaSehirEkle";
            this.button_GuzergahaSehirEkle.Size = new System.Drawing.Size(125, 36);
            this.button_GuzergahaSehirEkle.TabIndex = 9;
            this.button_GuzergahaSehirEkle.Text = "Güzergaha Şehir Ekle";
            this.button_GuzergahaSehirEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_GuzergahaSehirEkle.UseVisualStyleBackColor = false;
            this.button_GuzergahaSehirEkle.Click += new System.EventHandler(this.button_GuzergahaSehirEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şehir 1";
            // 
            // Form_GuzergahEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(847, 531);
            this.Controls.Add(this.groupBox_GuzergahSehirleri);
            this.Controls.Add(this.panel_guzergahEkle);
            this.Name = "Form_GuzergahEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güzergah Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_GuzergahEkle_FormClosing);
            this.Load += new System.EventHandler(this.Form_GuzergahEkle_Load);
            this.panel_guzergahEkle.ResumeLayout(false);
            this.panel_guzergahEkle.PerformLayout();
            this.statusStrip_kayit.ResumeLayout(false);
            this.statusStrip_kayit.PerformLayout();
            this.groupBox_GuzergahSehirleri.ResumeLayout(false);
            this.groupBox_GuzergahSehirleri.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_guzergahEkle;
        private System.Windows.Forms.Button button_iptal;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_varisSehir;
        private System.Windows.Forms.ComboBox comboBox_baslamaSehir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_sehir1;
        private System.Windows.Forms.GroupBox groupBox_GuzergahSehirleri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_sehirleriKaydet;
        private System.Windows.Forms.Button button_GuzergahaSehirEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_guzergahIsmi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip_kayit;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_kayit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_itemKayit;
    }
}