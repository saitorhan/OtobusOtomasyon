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
    public partial class Form_otobusEkle : Form
    {
        public Form_otobusEkle()
        {
            InitializeComponent();
        }

        public static bool form_acik_mi = false;
        VeriTabaniIslemleriDataContext ctx;

        private void Form_otobusEkle_Load(object sender, EventArgs e)
        {
            form_acik_mi = true;
            ctx = new VeriTabaniIslemleriDataContext();

            var markalar = ctx.Markalars.Select(m => m);
            comboBox_marka.DataSource = markalar;
        }

        private void Form_otobusEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_acik_mi = false;
        }

        private void textBox_plaka_Leave(object sender, EventArgs e)
        {
            textBox_plaka.Text = textBox_plaka.Text.Trim().ToUpper();
            if (textBox_plaka.Text.Length==0)
            {
                textBox_plaka.BackColor = Color.Red;
            }
            else
            {
                textBox_plaka.BackColor = Color.White;
            }
        }

        private void textBox_koltuk_sayisi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(textBox_koltuk_sayisi.Text);
                if (textBox_koltuk_sayisi.Text.Length==2)
                {
                    comboBox_marka.Focus();
                }
                textBox_koltuk_sayisi.BackColor = Color.White;
            }
            catch (Exception)
            {
                textBox_koltuk_sayisi.BackColor = Color.Red;
            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (textBox_plaka.BackColor==Color.Red)
            {
                toolStripStatusLabel_kayit_durum.Text = "Eksik alanları kontrol ediniz.";
                return;
            }
            if (textBox_koltuk_sayisi.Text.Length==0)
            {
                textBox_koltuk_sayisi.BackColor = Color.Red;
                toolStripStatusLabel_kayit_durum.Text = "Eksik alanları kontrol ediniz.";
                return;
            }

            Otobusler otobus = new Otobusler();
            otobus.Plaka = textBox_plaka.Text;
            otobus.KoltukSayisi = Convert.ToByte(textBox_koltuk_sayisi.Text);
            otobus.MarkaID = (comboBox_marka.SelectedItem as Markalar).ID;
            otobus.AktifMi = checkBox_aktifMi.Checked;
            try
            {
                ctx.Otobuslers.InsertOnSubmit(otobus);
                ctx.SubmitChanges();
                toolStripStatusLabel_kayit_durum.Text = "Yeni otobüs başarı ile eklendi.";
                textBox_plaka.Text = "";
                textBox_koltuk_sayisi.Text = "";
                textBox_koltuk_sayisi.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                Form_ana_ekran.HataKaydi(ex);
                toolStripStatusLabel_kayit_durum.Text = "Ekleme başarısız.";
            }
        }

        private void button_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
