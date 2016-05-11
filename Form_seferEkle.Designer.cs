namespace otobus_otomasyon_linq
{
    partial class Form_seferEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_seferEkle));
            this.comboBox_otobus = new System.Windows.Forms.ComboBox();
            this.comboBox_sofor = new System.Windows.Forms.ComboBox();
            this.comboBox_muavin = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_varisZamanGun = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_kalkisZamanGun = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_kalkisZamansaat = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_varisZamansaat = new System.Windows.Forms.DateTimePicker();
            this.textBox_tahminiSure = new System.Windows.Forms.TextBox();
            this.textBox_bilettutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_guzergah = new System.Windows.Forms.ComboBox();
            this.textBox_kalkis = new System.Windows.Forms.TextBox();
            this.textBox_varis = new System.Windows.Forms.TextBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_kayitdurum = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_otobus
            // 
            this.comboBox_otobus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_otobus.FormattingEnabled = true;
            this.comboBox_otobus.Location = new System.Drawing.Point(180, 126);
            this.comboBox_otobus.Name = "comboBox_otobus";
            this.comboBox_otobus.Size = new System.Drawing.Size(142, 24);
            this.comboBox_otobus.TabIndex = 2;
            // 
            // comboBox_sofor
            // 
            this.comboBox_sofor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_sofor.FormattingEnabled = true;
            this.comboBox_sofor.Location = new System.Drawing.Point(180, 153);
            this.comboBox_sofor.Name = "comboBox_sofor";
            this.comboBox_sofor.Size = new System.Drawing.Size(142, 24);
            this.comboBox_sofor.TabIndex = 3;
            // 
            // comboBox_muavin
            // 
            this.comboBox_muavin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_muavin.FormattingEnabled = true;
            this.comboBox_muavin.Location = new System.Drawing.Point(180, 180);
            this.comboBox_muavin.Name = "comboBox_muavin";
            this.comboBox_muavin.Size = new System.Drawing.Size(142, 24);
            this.comboBox_muavin.TabIndex = 4;
            // 
            // dateTimePicker_varisZamanGun
            // 
            this.dateTimePicker_varisZamanGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_varisZamanGun.Location = new System.Drawing.Point(180, 233);
            this.dateTimePicker_varisZamanGun.Name = "dateTimePicker_varisZamanGun";
            this.dateTimePicker_varisZamanGun.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_varisZamanGun.TabIndex = 6;
            this.dateTimePicker_varisZamanGun.ValueChanged += new System.EventHandler(this.dateTimePicker_kalkisZamanGun_ValueChanged);
            // 
            // dateTimePicker_kalkisZamanGun
            // 
            this.dateTimePicker_kalkisZamanGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_kalkisZamanGun.Location = new System.Drawing.Point(180, 207);
            this.dateTimePicker_kalkisZamanGun.Name = "dateTimePicker_kalkisZamanGun";
            this.dateTimePicker_kalkisZamanGun.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_kalkisZamanGun.TabIndex = 5;
            this.dateTimePicker_kalkisZamanGun.Value = new System.DateTime(2013, 8, 26, 10, 3, 40, 0);
            this.dateTimePicker_kalkisZamanGun.ValueChanged += new System.EventHandler(this.dateTimePicker_kalkisZamanGun_ValueChanged);
            // 
            // dateTimePicker_kalkisZamansaat
            // 
            this.dateTimePicker_kalkisZamansaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_kalkisZamansaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_kalkisZamansaat.Location = new System.Drawing.Point(386, 207);
            this.dateTimePicker_kalkisZamansaat.Name = "dateTimePicker_kalkisZamansaat";
            this.dateTimePicker_kalkisZamansaat.Size = new System.Drawing.Size(92, 22);
            this.dateTimePicker_kalkisZamansaat.TabIndex = 7;
            this.dateTimePicker_kalkisZamansaat.ValueChanged += new System.EventHandler(this.dateTimePicker_kalkisZamanGun_ValueChanged);
            // 
            // dateTimePicker_varisZamansaat
            // 
            this.dateTimePicker_varisZamansaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker_varisZamansaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_varisZamansaat.Location = new System.Drawing.Point(386, 233);
            this.dateTimePicker_varisZamansaat.Name = "dateTimePicker_varisZamansaat";
            this.dateTimePicker_varisZamansaat.Size = new System.Drawing.Size(92, 22);
            this.dateTimePicker_varisZamansaat.TabIndex = 8;
            this.dateTimePicker_varisZamansaat.ValueChanged += new System.EventHandler(this.dateTimePicker_kalkisZamanGun_ValueChanged);
            // 
            // textBox_tahminiSure
            // 
            this.textBox_tahminiSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_tahminiSure.Location = new System.Drawing.Point(180, 259);
            this.textBox_tahminiSure.Name = "textBox_tahminiSure";
            this.textBox_tahminiSure.ReadOnly = true;
            this.textBox_tahminiSure.Size = new System.Drawing.Size(100, 22);
            this.textBox_tahminiSure.TabIndex = 9;
            // 
            // textBox_bilettutar
            // 
            this.textBox_bilettutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_bilettutar.Location = new System.Drawing.Point(180, 285);
            this.textBox_bilettutar.Name = "textBox_bilettutar";
            this.textBox_bilettutar.Size = new System.Drawing.Size(100, 22);
            this.textBox_bilettutar.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kalkış Şehri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(69, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Varış Şehri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(69, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Otobüs";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(69, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Şoför";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(69, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Muavin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(69, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kalkış Zamanı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(69, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Varış Zamanı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(69, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tahmini Süre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(69, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tutar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(69, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Güzergah";
            // 
            // comboBox_guzergah
            // 
            this.comboBox_guzergah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_guzergah.FormattingEnabled = true;
            this.comboBox_guzergah.Location = new System.Drawing.Point(180, 45);
            this.comboBox_guzergah.Name = "comboBox_guzergah";
            this.comboBox_guzergah.Size = new System.Drawing.Size(200, 24);
            this.comboBox_guzergah.TabIndex = 21;
            this.comboBox_guzergah.SelectedIndexChanged += new System.EventHandler(this.comboBox_guzergah_SelectedIndexChanged);
            // 
            // textBox_kalkis
            // 
            this.textBox_kalkis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_kalkis.Location = new System.Drawing.Point(180, 72);
            this.textBox_kalkis.Name = "textBox_kalkis";
            this.textBox_kalkis.ReadOnly = true;
            this.textBox_kalkis.Size = new System.Drawing.Size(142, 22);
            this.textBox_kalkis.TabIndex = 22;
            // 
            // textBox_varis
            // 
            this.textBox_varis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_varis.Location = new System.Drawing.Point(180, 100);
            this.textBox_varis.Name = "textBox_varis";
            this.textBox_varis.ReadOnly = true;
            this.textBox_varis.Size = new System.Drawing.Size(142, 22);
            this.textBox_varis.TabIndex = 23;
            // 
            // button_kaydet
            // 
            this.button_kaydet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_kaydet.Image")));
            this.button_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kaydet.Location = new System.Drawing.Point(370, 345);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(108, 41);
            this.button_kaydet.TabIndex = 24;
            this.button_kaydet.Text = "  Kaydet";
            this.button_kaydet.UseVisualStyleBackColor = false;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_kayitdurum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 454);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(739, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_kayitdurum
            // 
            this.toolStripStatusLabel_kayitdurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel_kayitdurum.Name = "toolStripStatusLabel_kayitdurum";
            this.toolStripStatusLabel_kayitdurum.Size = new System.Drawing.Size(0, 17);
            // 
            // Form_seferEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(739, 476);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.textBox_varis);
            this.Controls.Add(this.textBox_kalkis);
            this.Controls.Add(this.comboBox_guzergah);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_bilettutar);
            this.Controls.Add(this.textBox_tahminiSure);
            this.Controls.Add(this.dateTimePicker_varisZamansaat);
            this.Controls.Add(this.dateTimePicker_kalkisZamansaat);
            this.Controls.Add(this.dateTimePicker_varisZamanGun);
            this.Controls.Add(this.dateTimePicker_kalkisZamanGun);
            this.Controls.Add(this.comboBox_muavin);
            this.Controls.Add(this.comboBox_sofor);
            this.Controls.Add(this.comboBox_otobus);
            this.Name = "Form_seferEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sefer Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_seferEkle_FormClosing);
            this.Load += new System.EventHandler(this.Form_seferEkle_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_otobus;
        private System.Windows.Forms.ComboBox comboBox_sofor;
        private System.Windows.Forms.ComboBox comboBox_muavin;
        private System.Windows.Forms.DateTimePicker dateTimePicker_varisZamanGun;
        private System.Windows.Forms.DateTimePicker dateTimePicker_kalkisZamanGun;
        private System.Windows.Forms.DateTimePicker dateTimePicker_kalkisZamansaat;
        private System.Windows.Forms.DateTimePicker dateTimePicker_varisZamansaat;
        private System.Windows.Forms.TextBox textBox_tahminiSure;
        private System.Windows.Forms.TextBox textBox_bilettutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_guzergah;
        private System.Windows.Forms.TextBox textBox_kalkis;
        private System.Windows.Forms.TextBox textBox_varis;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_kayitdurum;
    }
}