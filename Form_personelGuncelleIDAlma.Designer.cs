namespace otobus_otomasyon_linq
{
    partial class Form_personelGuncelleIDAlma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_personelGuncelleIDAlma));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_calisan_ID = new System.Windows.Forms.TextBox();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button_iptal = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_durum = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çalışan Numarasını Girin";
            // 
            // textBox_calisan_ID
            // 
            this.textBox_calisan_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_calisan_ID.Location = new System.Drawing.Point(194, 30);
            this.textBox_calisan_ID.Name = "textBox_calisan_ID";
            this.textBox_calisan_ID.Size = new System.Drawing.Size(156, 22);
            this.textBox_calisan_ID.TabIndex = 1;
            // 
            // button_kaydet
            // 
            this.button_kaydet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("button_kaydet.Image")));
            this.button_kaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kaydet.Location = new System.Drawing.Point(275, 69);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(75, 35);
            this.button_kaydet.TabIndex = 2;
            this.button_kaydet.Text = "Bul";
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
            this.button_iptal.Location = new System.Drawing.Point(194, 69);
            this.button_iptal.Name = "button_iptal";
            this.button_iptal.Size = new System.Drawing.Size(75, 35);
            this.button_iptal.TabIndex = 3;
            this.button_iptal.Text = "İptal";
            this.button_iptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_iptal.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_durum});
            this.statusStrip1.Location = new System.Drawing.Point(0, 163);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(462, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_durum
            // 
            this.toolStripStatusLabel_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripStatusLabel_durum.Name = "toolStripStatusLabel_durum";
            this.toolStripStatusLabel_durum.Size = new System.Drawing.Size(0, 17);
            // 
            // Form_personelGuncelleIDAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(462, 185);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_iptal);
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.textBox_calisan_ID);
            this.Controls.Add(this.label1);
            this.Name = "Form_personelGuncelleIDAlma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Güncelle Numara Alma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_personelGuncelleIDAlma_FormClosing);
            this.Load += new System.EventHandler(this.Form_personelGuncelleIDAlma_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_calisan_ID;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button button_iptal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_durum;
    }
}