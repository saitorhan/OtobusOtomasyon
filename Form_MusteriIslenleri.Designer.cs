namespace otobus_otomasyon_linq
{
    partial class Form_MusteriIslenleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MusteriIslenleri));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_bilgi = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.button__ara = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_bilgi});
            this.statusStrip1.Location = new System.Drawing.Point(0, 104);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(446, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_bilgi
            // 
            this.toolStripStatusLabel_bilgi.Name = "toolStripStatusLabel_bilgi";
            this.toolStripStatusLabel_bilgi.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Numarası:";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(140, 28);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID.TabIndex = 2;
            // 
            // button__ara
            // 
            this.button__ara.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button__ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button__ara.Image = ((System.Drawing.Image)(resources.GetObject("button__ara.Image")));
            this.button__ara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button__ara.Location = new System.Drawing.Point(246, 20);
            this.button__ara.Name = "button__ara";
            this.button__ara.Size = new System.Drawing.Size(80, 35);
            this.button__ara.TabIndex = 23;
            this.button__ara.Text = "Ara";
            this.button__ara.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button__ara.UseVisualStyleBackColor = false;
            this.button__ara.Click += new System.EventHandler(this.button__ara_Click);
            // 
            // Form_MusteriIslenleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(446, 126);
            this.Controls.Add(this.button__ara);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form_MusteriIslenleri";
            this.Text = "Müşteri İşlemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_MusteriIslenleri_FormClosing);
            this.Load += new System.EventHandler(this.Form_MusteriIslenleri_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_bilgi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Button button__ara;
    }
}