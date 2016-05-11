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
    public partial class Form_seferEkle : Form
    {
        public static bool form_acikMi;
        VeriTabaniIslemleriDataContext ctx;
        public Form_seferEkle()
        {
            InitializeComponent();
        }

        private void Form_seferEkle_Load(object sender, EventArgs e)
        {
            form_acikMi = true;
            ctx=new VeriTabaniIslemleriDataContext();
            IEnumerable<Guzergah> guzergahlar = ctx.Guzergahs.OrderBy(g=>g.Tanim).Select(g => g);
            comboBox_guzergah.DataSource = guzergahlar;

            IEnumerable<Otobusler> otobusler = ctx.Otobuslers.Where(o=>o.AktifMi).OrderBy(o=>o.Plaka).Select(o => o);
            comboBox_otobus.DataSource = otobusler;

            IEnumerable<Calisanlar> soforler = from calisan in ctx.Calisanlars
                                               where calisan.CalisanTipID == 1002
                                               orderby calisan.Ad, calisan.Soyad
                                               select calisan;

            comboBox_sofor.DataSource = soforler;

            IEnumerable<Calisanlar> muavinler= from muavin in ctx.Calisanlars
                                               where muavin.CalisanTipID == 1003
                                               orderby muavin.Ad, muavin.Soyad
                                               select muavin;

            comboBox_muavin.DataSource = muavinler;

            dateTimePicker_kalkisZamanGun.MinDate = DateTime.Today;
            dateTimePicker_varisZamanGun.MinDate = DateTime.Today;
        }

        private void Form_seferEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_acikMi = false;
        }

        private void comboBox_guzergah_SelectedIndexChanged(object sender, EventArgs e)
        {
            int kalkis = (comboBox_guzergah.SelectedItem as Guzergah).kalkis_sehir;
            int varis = (comboBox_guzergah.SelectedItem as Guzergah).varis_sehir;
            string kalkisSehir = ctx.Sehirlers.Where(s => s.ID == kalkis).Select(s => s.SehirAd).First();
            string varisSehir = ctx.Sehirlers.Where(s => s.ID == varis).Select(s => s.SehirAd).First();
            textBox_kalkis.Text = kalkisSehir;
            textBox_varis.Text = varisSehir;
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            DateTime kalkisZamani = new DateTime(dateTimePicker_kalkisZamanGun.Value.Year,
                                                 dateTimePicker_kalkisZamanGun.Value.Month,
                                                 dateTimePicker_kalkisZamanGun.Value.Day,
                                                 dateTimePicker_kalkisZamansaat.Value.Hour,
                                                 dateTimePicker_kalkisZamansaat.Value.Minute, 0);
            DateTime varisZamani = new DateTime(dateTimePicker_varisZamanGun.Value.Year,
                                                dateTimePicker_varisZamanGun.Value.Month,
                                                dateTimePicker_varisZamanGun.Value.Day,
                                                dateTimePicker_varisZamansaat.Value.Hour,
                                                dateTimePicker_varisZamansaat.Value.Minute, 0);

            TimeSpan fark = varisZamani.Subtract(kalkisZamani);

            if (fark.TotalMinutes <= 0)
            {
                toolStripStatusLabel_kayitdurum.Text = "Varış zamanı kalkış zamanından büyük olmak zorunda";
                return;
            }

            textBox_tahminiSure.Text = fark.ToString();
            double ucret = 0;
            try
            {
                ucret = double.Parse(textBox_bilettutar.Text);
            }
            catch (Exception)
            {
                toolStripStatusLabel_kayitdurum.Text = "Ücret bloğunu kontrol ediniz.";
            }

            toolStripStatusLabel_kayitdurum.Text = "";

            Seferler sefer = new Seferler();
            sefer.KalkisSehirID = (comboBox_guzergah.SelectedItem as Guzergah).kalkis_sehir;
            sefer.VarisSehirID = (comboBox_guzergah.SelectedItem as Guzergah).varis_sehir;
            sefer.OtobusID = (comboBox_otobus.SelectedItem as Otobusler).ID;
            sefer.MuavinID = (comboBox_muavin.SelectedItem as Calisanlar).ID;
            sefer.SoforID = (comboBox_sofor.SelectedItem as Calisanlar).ID;
            sefer.KalkisZamani = kalkisZamani;
            sefer.VarisZamani = varisZamani;
            sefer.TahminiSure = textBox_tahminiSure.Text;
            sefer.BiletTutar = Convert.ToDecimal(ucret);
            sefer.guzergahID = (comboBox_guzergah.SelectedItem as Guzergah).ID;

            ctx.Seferlers.InsertOnSubmit(sefer);
            try
            {
                ctx.SubmitChanges();
                toolStripStatusLabel_kayitdurum.Text = "Kayıt başarılı";
            }
            catch (Exception ex)
            {
                Form_ana_ekran.HataKaydi(ex);
                toolStripStatusLabel_kayitdurum.Text = "Kayıt başarısız.";
            }
        }

        private void dateTimePicker_kalkisZamanGun_ValueChanged(object sender, EventArgs e)
        {
            DateTime kalkisZamani = new DateTime(dateTimePicker_kalkisZamanGun.Value.Year,
                                                 dateTimePicker_kalkisZamanGun.Value.Month,
                                                 dateTimePicker_kalkisZamanGun.Value.Day,
                                                 dateTimePicker_kalkisZamansaat.Value.Hour,
                                                 dateTimePicker_kalkisZamansaat.Value.Minute, 0);
            DateTime varisZamani = new DateTime(dateTimePicker_varisZamanGun.Value.Year,
                                                dateTimePicker_varisZamanGun.Value.Month,
                                                dateTimePicker_varisZamanGun.Value.Day,
                                                dateTimePicker_varisZamansaat.Value.Hour,
                                                dateTimePicker_varisZamansaat.Value.Minute, 0);

            TimeSpan fark = varisZamani.Subtract(kalkisZamani);
            if (fark.TotalMinutes <= 0)
            {
                toolStripStatusLabel_kayitdurum.Text = "Varış zamanı kalkış zamanından büyük olmak zorunda";
                return;
            }
        }
    }
}
