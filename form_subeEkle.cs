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
    public partial class form_subeEkle : Form
    {
        public form_subeEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (VeriGirisKontrol())
                {
                    int secilen_sehir = (comboBox_sube_sehir.SelectedItem as Sehirler).ID;
                    string sube_ad = textBox_sube_ad.Text.Trim();

                    VeriTabaniIslemleriDataContext ctx = new VeriTabaniIslemleriDataContext();
                    Subeler sube = new Subeler();
                    sube.SubeAd = sube_ad;
                    sube.SehirID = secilen_sehir;

                    ctx.Subelers.InsertOnSubmit(sube);
                    ctx.SubmitChanges();
                    MessageBox.Show(comboBox_sube_sehir.SelectedItem + " şubesi eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Form_ana_ekran.HataKaydi(ex);
                MessageBox.Show(comboBox_sube_sehir.SelectedItem + " şubesi eklenirken bir oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private bool VeriGirisKontrol()
        {
            if (comboBox_sube_sehir.SelectedIndex < 0)
            {
                MessageBox.Show("Şehir seçiniz.", "Eksik giriş!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            if (textBox_sube_ad.Text.Trim().Length == 0)
            {
                MessageBox.Show("Şube adını giriniz.", "Eksik giriş!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            return true;
        }

        public static bool form_acik_mi = false;
        public static int id = 0;

        private void form_subeEkle_Load(object sender, EventArgs e)
        {
            form_acik_mi = true;
            VeriTabaniIslemleriDataContext ctx = new VeriTabaniIslemleriDataContext();

            var sehirler = from sehir in ctx.Sehirlers
                           orderby sehir.SehirAd
                           select sehir;
            comboBox_sube_sehir.DataSource = sehirler;
            if (id > 0)
            {
                foreach (var item in sehirler)
                {
                    if (item.ID==id)
                    {
                        comboBox_sube_sehir.SelectedItem = item;
                    }
                }
            }
        }

        private void form_subeEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_acik_mi = false;
            id = 0;
        }

        private void textBox_sube_ad_Leave(object sender, EventArgs e)
        {
            textBox_sube_ad.Text = textBox_sube_ad.Text.ToUpper();
        }

    }
}
