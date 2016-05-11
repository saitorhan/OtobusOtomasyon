namespace otobus_otomasyon_linq
{
    partial class Form_SeferDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SeferDetay));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_guzergahlar = new System.Windows.Forms.ComboBox();
            this.listBox_seferler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_sil = new System.Windows.Forms.Button();
            this.groupBox_seferBilgileri = new System.Windows.Forms.GroupBox();
            this.label_kSehir = new System.Windows.Forms.Label();
            this.label_vSehir = new System.Windows.Forms.Label();
            this.label_sofor = new System.Windows.Forms.Label();
            this.label_ucret = new System.Windows.Forms.Label();
            this.label_otobus = new System.Windows.Forms.Label();
            this.label_kZaman = new System.Windows.Forms.Label();
            this.label_vZaman = new System.Windows.Forms.Label();
            this.label_muavin = new System.Windows.Forms.Label();
            this.label_sure = new System.Windows.Forms.Label();
            this.label_seferNo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_bilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_seferBilgileri.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Güzergah Seçiniz:";
            // 
            // comboBox_guzergahlar
            // 
            this.comboBox_guzergahlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_guzergahlar.FormattingEnabled = true;
            this.comboBox_guzergahlar.Location = new System.Drawing.Point(15, 44);
            this.comboBox_guzergahlar.Name = "comboBox_guzergahlar";
            this.comboBox_guzergahlar.Size = new System.Drawing.Size(204, 24);
            this.comboBox_guzergahlar.TabIndex = 1;
            this.comboBox_guzergahlar.SelectedIndexChanged += new System.EventHandler(this.comboBox_guzergahlar_SelectedIndexChanged);
            // 
            // listBox_seferler
            // 
            this.listBox_seferler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox_seferler.FormattingEnabled = true;
            this.listBox_seferler.ItemHeight = 16;
            this.listBox_seferler.Location = new System.Drawing.Point(15, 104);
            this.listBox_seferler.Name = "listBox_seferler";
            this.listBox_seferler.Size = new System.Drawing.Size(249, 276);
            this.listBox_seferler.TabIndex = 2;
            this.listBox_seferler.SelectedIndexChanged += new System.EventHandler(this.listBox_seferler_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seferler";
            // 
            // button_sil
            // 
            this.button_sil.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sil.Image = ((System.Drawing.Image)(resources.GetObject("button_sil.Image")));
            this.button_sil.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_sil.Location = new System.Drawing.Point(591, 400);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(164, 41);
            this.button_sil.TabIndex = 4;
            this.button_sil.Text = "       Seçili Seferi Sil";
            this.button_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_sil.UseVisualStyleBackColor = false;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // groupBox_seferBilgileri
            // 
            this.groupBox_seferBilgileri.Controls.Add(this.label_kSehir);
            this.groupBox_seferBilgileri.Controls.Add(this.label_vSehir);
            this.groupBox_seferBilgileri.Controls.Add(this.label_sofor);
            this.groupBox_seferBilgileri.Controls.Add(this.label_ucret);
            this.groupBox_seferBilgileri.Controls.Add(this.label_otobus);
            this.groupBox_seferBilgileri.Controls.Add(this.label_kZaman);
            this.groupBox_seferBilgileri.Controls.Add(this.label_vZaman);
            this.groupBox_seferBilgileri.Controls.Add(this.label_muavin);
            this.groupBox_seferBilgileri.Controls.Add(this.label_sure);
            this.groupBox_seferBilgileri.Controls.Add(this.label_seferNo);
            this.groupBox_seferBilgileri.Controls.Add(this.label12);
            this.groupBox_seferBilgileri.Controls.Add(this.label11);
            this.groupBox_seferBilgileri.Controls.Add(this.label10);
            this.groupBox_seferBilgileri.Controls.Add(this.label9);
            this.groupBox_seferBilgileri.Controls.Add(this.label8);
            this.groupBox_seferBilgileri.Controls.Add(this.label7);
            this.groupBox_seferBilgileri.Controls.Add(this.label6);
            this.groupBox_seferBilgileri.Controls.Add(this.label5);
            this.groupBox_seferBilgileri.Controls.Add(this.label4);
            this.groupBox_seferBilgileri.Controls.Add(this.label3);
            this.groupBox_seferBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox_seferBilgileri.Location = new System.Drawing.Point(283, 104);
            this.groupBox_seferBilgileri.Name = "groupBox_seferBilgileri";
            this.groupBox_seferBilgileri.Size = new System.Drawing.Size(472, 290);
            this.groupBox_seferBilgileri.TabIndex = 5;
            this.groupBox_seferBilgileri.TabStop = false;
            this.groupBox_seferBilgileri.Text = "Sefer Bilgileri";
            // 
            // label_kSehir
            // 
            this.label_kSehir.AutoSize = true;
            this.label_kSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kSehir.Location = new System.Drawing.Point(100, 58);
            this.label_kSehir.Name = "label_kSehir";
            this.label_kSehir.Size = new System.Drawing.Size(0, 16);
            this.label_kSehir.TabIndex = 19;
            // 
            // label_vSehir
            // 
            this.label_vSehir.AutoSize = true;
            this.label_vSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_vSehir.Location = new System.Drawing.Point(100, 85);
            this.label_vSehir.Name = "label_vSehir";
            this.label_vSehir.Size = new System.Drawing.Size(0, 16);
            this.label_vSehir.TabIndex = 18;
            // 
            // label_sofor
            // 
            this.label_sofor.AutoSize = true;
            this.label_sofor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sofor.Location = new System.Drawing.Point(100, 166);
            this.label_sofor.Name = "label_sofor";
            this.label_sofor.Size = new System.Drawing.Size(0, 16);
            this.label_sofor.TabIndex = 17;
            // 
            // label_ucret
            // 
            this.label_ucret.AutoSize = true;
            this.label_ucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ucret.Location = new System.Drawing.Point(100, 274);
            this.label_ucret.Name = "label_ucret";
            this.label_ucret.Size = new System.Drawing.Size(0, 16);
            this.label_ucret.TabIndex = 16;
            // 
            // label_otobus
            // 
            this.label_otobus.AutoSize = true;
            this.label_otobus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_otobus.Location = new System.Drawing.Point(100, 112);
            this.label_otobus.Name = "label_otobus";
            this.label_otobus.Size = new System.Drawing.Size(0, 16);
            this.label_otobus.TabIndex = 15;
            // 
            // label_kZaman
            // 
            this.label_kZaman.AutoSize = true;
            this.label_kZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kZaman.Location = new System.Drawing.Point(100, 193);
            this.label_kZaman.Name = "label_kZaman";
            this.label_kZaman.Size = new System.Drawing.Size(0, 16);
            this.label_kZaman.TabIndex = 14;
            // 
            // label_vZaman
            // 
            this.label_vZaman.AutoSize = true;
            this.label_vZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_vZaman.Location = new System.Drawing.Point(100, 220);
            this.label_vZaman.Name = "label_vZaman";
            this.label_vZaman.Size = new System.Drawing.Size(0, 16);
            this.label_vZaman.TabIndex = 13;
            // 
            // label_muavin
            // 
            this.label_muavin.AutoSize = true;
            this.label_muavin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_muavin.Location = new System.Drawing.Point(100, 139);
            this.label_muavin.Name = "label_muavin";
            this.label_muavin.Size = new System.Drawing.Size(0, 16);
            this.label_muavin.TabIndex = 12;
            // 
            // label_sure
            // 
            this.label_sure.AutoSize = true;
            this.label_sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_sure.Location = new System.Drawing.Point(100, 247);
            this.label_sure.Name = "label_sure";
            this.label_sure.Size = new System.Drawing.Size(0, 16);
            this.label_sure.TabIndex = 11;
            // 
            // label_seferNo
            // 
            this.label_seferNo.AutoSize = true;
            this.label_seferNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_seferNo.Location = new System.Drawing.Point(100, 31);
            this.label_seferNo.Name = "label_seferNo";
            this.label_seferNo.Size = new System.Drawing.Size(0, 16);
            this.label_seferNo.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(6, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "Kalkış Şehri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Varış Şehri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(6, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Şoför";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Bilet Tutar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Otobüs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kalkış Zamanı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Varış Zamanı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Muavin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tahmini Süre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sefer No";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_bilgi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(797, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_bilgi
            // 
            this.toolStripStatusLabel_bilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel_bilgi.Name = "toolStripStatusLabel_bilgi";
            this.toolStripStatusLabel_bilgi.Size = new System.Drawing.Size(0, 17);
            // 
            // Form_SeferDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 484);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox_seferBilgileri);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_seferler);
            this.Controls.Add(this.comboBox_guzergahlar);
            this.Controls.Add(this.label1);
            this.Name = "Form_SeferDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sefer Detay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SeferDetay_FormClosing);
            this.Load += new System.EventHandler(this.Form_SeferDetay_Load);
            this.groupBox_seferBilgileri.ResumeLayout(false);
            this.groupBox_seferBilgileri.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_guzergahlar;
        private System.Windows.Forms.ListBox listBox_seferler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.GroupBox groupBox_seferBilgileri;
        private System.Windows.Forms.Label label_kSehir;
        private System.Windows.Forms.Label label_vSehir;
        private System.Windows.Forms.Label label_sofor;
        private System.Windows.Forms.Label label_ucret;
        private System.Windows.Forms.Label label_otobus;
        private System.Windows.Forms.Label label_kZaman;
        private System.Windows.Forms.Label label_vZaman;
        private System.Windows.Forms.Label label_muavin;
        private System.Windows.Forms.Label label_sure;
        private System.Windows.Forms.Label label_seferNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_bilgi;
    }
}