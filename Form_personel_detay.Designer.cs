namespace otobus_otomasyon_linq
{
    partial class Form_personel_detay
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
            this.comboBox_sehir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_sube = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_calisanlar_listesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_calisanlar_listesi)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_sehir
            // 
            this.comboBox_sehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_sehir.FormattingEnabled = true;
            this.comboBox_sehir.Location = new System.Drawing.Point(48, 12);
            this.comboBox_sehir.Name = "comboBox_sehir";
            this.comboBox_sehir.Size = new System.Drawing.Size(160, 24);
            this.comboBox_sehir.TabIndex = 1;
            this.comboBox_sehir.SelectedIndexChanged += new System.EventHandler(this.comboBox_sehir_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şehir";
            // 
            // comboBox_sube
            // 
            this.comboBox_sube.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_sube.FormattingEnabled = true;
            this.comboBox_sube.Location = new System.Drawing.Point(310, 12);
            this.comboBox_sube.Name = "comboBox_sube";
            this.comboBox_sube.Size = new System.Drawing.Size(160, 24);
            this.comboBox_sube.TabIndex = 3;
            this.comboBox_sube.SelectedIndexChanged += new System.EventHandler(this.comboBox_sube_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(263, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şube";
            // 
            // dataGridView_calisanlar_listesi
            // 
            this.dataGridView_calisanlar_listesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_calisanlar_listesi.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView_calisanlar_listesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_calisanlar_listesi.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView_calisanlar_listesi.Location = new System.Drawing.Point(4, 39);
            this.dataGridView_calisanlar_listesi.Name = "dataGridView_calisanlar_listesi";
            this.dataGridView_calisanlar_listesi.Size = new System.Drawing.Size(968, 444);
            this.dataGridView_calisanlar_listesi.TabIndex = 5;
            this.dataGridView_calisanlar_listesi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_calisanlar_listesi_CellMouseClick);
            // 
            // Form_personel_detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(978, 495);
            this.Controls.Add(this.dataGridView_calisanlar_listesi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_sube);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_sehir);
            this.Name = "Form_personel_detay";
            this.Text = "Personel Detayları";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_personel_detay_FormClosing);
            this.Load += new System.EventHandler(this.Form_personel_detay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_calisanlar_listesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_sube;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_sehir;
        private System.Windows.Forms.DataGridView dataGridView_calisanlar_listesi;
    }
}