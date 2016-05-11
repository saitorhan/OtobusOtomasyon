namespace otobus_otomasyon_linq
{
    partial class form_subeEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_subeEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_sube_ad = new System.Windows.Forms.TextBox();
            this.comboBox_sube_sehir = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şube Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şubenin Bulunduğu İl:";
            // 
            // textBox_sube_ad
            // 
            this.textBox_sube_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_sube_ad.Location = new System.Drawing.Point(129, 34);
            this.textBox_sube_ad.Name = "textBox_sube_ad";
            this.textBox_sube_ad.Size = new System.Drawing.Size(109, 20);
            this.textBox_sube_ad.TabIndex = 2;
            this.textBox_sube_ad.Leave += new System.EventHandler(this.textBox_sube_ad_Leave);
            // 
            // comboBox_sube_sehir
            // 
            this.comboBox_sube_sehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_sube_sehir.FormattingEnabled = true;
            this.comboBox_sube_sehir.Location = new System.Drawing.Point(129, 6);
            this.comboBox_sube_sehir.Name = "comboBox_sube_sehir";
            this.comboBox_sube_sehir.Size = new System.Drawing.Size(109, 21);
            this.comboBox_sube_sehir.TabIndex = 3;
            this.comboBox_sube_sehir.Text = "Şehir Seç";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(131, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "     Şubeyi Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_subeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(347, 237);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_sube_sehir);
            this.Controls.Add(this.textBox_sube_ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form_subeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "          Şube Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_subeEkle_FormClosing);
            this.Load += new System.EventHandler(this.form_subeEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_sube_ad;
        private System.Windows.Forms.ComboBox comboBox_sube_sehir;
        private System.Windows.Forms.Button button1;
    }
}