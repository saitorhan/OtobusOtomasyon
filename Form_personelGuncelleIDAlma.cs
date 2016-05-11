using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace otobus_otomasyon_linq
{
    public partial class Form_personelGuncelleIDAlma : Form
    {
        public static bool form_acik_mi = false;
        VeriTabaniIslemleriDataContext db;
        public Form_personelGuncelleIDAlma()
        {
            InitializeComponent();
        }

        private void Form_personelGuncelleIDAlma_Load(object sender, EventArgs e)
        {
            form_acik_mi = true;
            db = new VeriTabaniIslemleriDataContext();
        }

        private void Form_personelGuncelleIDAlma_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_acik_mi = false;
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            foreach (Char item in textBox_calisan_ID.Text)
            {
                if (!Char.IsDigit(item))
                {
                    toolStripStatusLabel_durum.Text = "Numara sadece rakamlardan oluşabilir.";
                    return;
                }
            }

            int guncellenecekID = Convert.ToInt32(textBox_calisan_ID.Text);
            Calisanlar calisan = null;
            try
            {
                calisan = db.Calisanlars.Where(s => s.ID == guncellenecekID).Select(s => s).First();
            }
            catch (Exception ex)
            {
                Form_ana_ekran.HataKaydi(ex);
                toolStripStatusLabel_durum.Text = "Çalışan bulunamadı.";
                return;
            }
            Form_personel_guncelle_ekle frm_guncelle = new Form_personel_guncelle_ekle(calisan);
            frm_guncelle.Text = "Personel Güncelle";
            if (Form_personel_guncelle_ekle.form_acik_mi)
            {
                foreach (Form item in this.MdiParent.MdiChildren)
                {
                    if (item.Text==frm_guncelle.Text)
                    {
                        MessageBox.Show("Lütfen açık olan güncelleme penceresini kapatıp tekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        item.BringToFront();
                        return;
                    }
                }
            }

            frm_guncelle.MdiParent = this.MdiParent;
            frm_guncelle.Show();
            this.Close();
        }
    }
}
