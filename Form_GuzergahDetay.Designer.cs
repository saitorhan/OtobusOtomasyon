namespace otobus_otomasyon_linq
{
    partial class Form_GuzergahDetay
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
            this.groupBox_butunGuzergahlar = new System.Windows.Forms.GroupBox();
            this.dataGridView_butun_guzergahlar = new System.Windows.Forms.DataGridView();
            this.listView_secilenGuzergahSehirler = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_bilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_sil = new System.Windows.Forms.Button();
            this.groupBox_butunGuzergahlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_butun_guzergahlar)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_butunGuzergahlar
            // 
            this.groupBox_butunGuzergahlar.Controls.Add(this.dataGridView_butun_guzergahlar);
            this.groupBox_butunGuzergahlar.Location = new System.Drawing.Point(12, 12);
            this.groupBox_butunGuzergahlar.Name = "groupBox_butunGuzergahlar";
            this.groupBox_butunGuzergahlar.Size = new System.Drawing.Size(395, 339);
            this.groupBox_butunGuzergahlar.TabIndex = 0;
            this.groupBox_butunGuzergahlar.TabStop = false;
            this.groupBox_butunGuzergahlar.Text = "Bütün Güzergahlar";
            // 
            // dataGridView_butun_guzergahlar
            // 
            this.dataGridView_butun_guzergahlar.AllowUserToAddRows = false;
            this.dataGridView_butun_guzergahlar.AllowUserToDeleteRows = false;
            this.dataGridView_butun_guzergahlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_butun_guzergahlar.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView_butun_guzergahlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_butun_guzergahlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_butun_guzergahlar.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_butun_guzergahlar.Name = "dataGridView_butun_guzergahlar";
            this.dataGridView_butun_guzergahlar.ReadOnly = true;
            this.dataGridView_butun_guzergahlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_butun_guzergahlar.Size = new System.Drawing.Size(389, 320);
            this.dataGridView_butun_guzergahlar.TabIndex = 0;
            this.dataGridView_butun_guzergahlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_butun_guzergahlar_CellContentClick);
            this.dataGridView_butun_guzergahlar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_butun_guzergahlar_CellMouseClick);
            // 
            // listView_secilenGuzergahSehirler
            // 
            this.listView_secilenGuzergahSehirler.FormattingEnabled = true;
            this.listView_secilenGuzergahSehirler.Location = new System.Drawing.Point(410, 22);
            this.listView_secilenGuzergahSehirler.Name = "listView_secilenGuzergahSehirler";
            this.listView_secilenGuzergahSehirler.Size = new System.Drawing.Size(202, 277);
            this.listView_secilenGuzergahSehirler.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_bilgi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(696, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_bilgi
            // 
            this.toolStripStatusLabel_bilgi.Name = "toolStripStatusLabel_bilgi";
            this.toolStripStatusLabel_bilgi.Size = new System.Drawing.Size(0, 17);
            // 
            // button_sil
            // 
            this.button_sil.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sil.Image = global::otobus_otomasyon_linq.Properties.Resources._71;
            this.button_sil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sil.Location = new System.Drawing.Point(413, 311);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(187, 40);
            this.button_sil.TabIndex = 2;
            this.button_sil.Text = "Seçili Güzergahı Sil";
            this.button_sil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_sil.UseVisualStyleBackColor = false;
            this.button_sil.Click += new System.EventHandler(this.button_sil_Click);
            // 
            // Form_GuzergahDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(696, 445);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_sil);
            this.Controls.Add(this.listView_secilenGuzergahSehirler);
            this.Controls.Add(this.groupBox_butunGuzergahlar);
            this.Name = "Form_GuzergahDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Güzergah Detay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_GuzergahDetay_FormClosing);
            this.Load += new System.EventHandler(this.Form_GuzergahDetay_Load);
            this.groupBox_butunGuzergahlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_butun_guzergahlar)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_butunGuzergahlar;
        private System.Windows.Forms.DataGridView dataGridView_butun_guzergahlar;
        private System.Windows.Forms.ListBox listView_secilenGuzergahSehirler;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_bilgi;
    }
}