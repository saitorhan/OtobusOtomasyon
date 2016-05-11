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
    public partial class Form_musteriKayitAl : Form
    {
        public Form_musteriKayitAl()
        {
            InitializeComponent();
            FormuYapilandir();
            button_sil.Visible = false;
            button_guncelle.Visible = false;
            button_kaydet.Visible = true;
            button_iptal.Visible = true;
            Musteri = null;
        }

        public Form_musteriKayitAl(Musteriler musteri)
        {
            InitializeComponent();
            FormuYapilandir();
            this.Musteri = musteri;
            button_sil.Visible = true;
            button_kaydet.Visible = false;
            button_guncelle.Visible = true;
            button_iptal.Visible = true;
            textBox_ad.Text = Musteri.Ad;
            textBox_soyad.Text = Musteri.Soyad;
            textBox_email.Text = Musteri.Email;
            textBox_telefon.Text = Musteri.Telefon;
            int cinsiyet = Convert.ToInt32(Musteri.Cinsiyet);
            comboBox_cinsiyet.SelectedIndex = cinsiyet;
            dateTimePicker_dogumTarih.Value = Musteri.DogumTarih;
            textBox_adres.Text = Musteri.Adres;
            foreach (Sehirler item in comboBox_sehir.Items)
            {
                if (item.ID == Musteri.SehirID)
                {
                    comboBox_sehir.SelectedItem = item;
                    break;
                }
            }
            textBox_kartNumarasi.Text = Musteri.KartNumarasi;
            checkBox_kartTeslim.Checked = Musteri.KartTeslim;
        }

        public static bool form_acik_mi;
        VeriTabaniIslemleriDataContext ctx = new VeriTabaniIslemleriDataContext();

        bool ad = false,
            soyad = false,
            email = false,
            telefon = false,
            adres = false;
        private Musteriler Musteri = null;
        private void Form_musteriKayitAl_Load(object sender, EventArgs e)
        {
            form_acik_mi = true;
        }

        void FormuYapilandir()
        {
            string[] cinsiyet = { "Erkek", "Kadın" };
            comboBox_cinsiyet.DataSource = cinsiyet;
            comboBox_sehir.DataSource = ctx.Sehirlers.OrderBy(s=>s.SehirAd).Select(s => s);
            dateTimePicker_dogumTarih.MaxDate = DateTime.Today;
            DateTime simdi = DateTime.Now;
            textBox_kartNumarasi.Text = simdi.Year + "" + simdi.Month + "" + simdi.Day + "" + simdi.Minute + "" + simdi.Second + "" + simdi.Millisecond;

            textBox_ad.Text = "";
            textBox_soyad.Text = "";
            textBox_email.Text = "";
            textBox_telefon.Text = "";
            textBox_adres.Text = "";
            checkBox_kartTeslim.Checked = false;
        }

        private void textBox_ad_Leave(object sender, EventArgs e)
        {
            textBox_ad.Text = textBox_ad.Text.Trim().ToUpper();
            if (SadeceHarfMi(textBox_ad.Text))
            {
                SonucOlumlu(sender);
                ad = true;
            }
            else
            {
                SonucOlumsuz(sender);
                ad = false;
            }
        }

        void SonucOlumlu(object sender)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        void SonucOlumsuz(object sender)
        {
            ((TextBox)sender).BackColor = Color.Red;
        }

        bool SadeceHarfMi(string cumle)
        {
            if (cumle.Length == 0)
            {
                return false;
            }
            foreach (char item in cumle)
            {
                if (!Char.IsLetter(item) && !Char.IsWhiteSpace(item))
                {
                    return false;
                }
            }
            return true;
        }

        private void textBox_soyad_Leave(object sender, EventArgs e)
        {
            textBox_soyad.Text = textBox_soyad.Text.Trim().ToUpper();
            if (SadeceHarfMi(textBox_soyad.Text))
            {
                SonucOlumlu(sender);
                soyad = true;
            }
            else
            {
                SonucOlumsuz(sender);
                soyad = false;
            }
        }

        private void textBox_email_Leave(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex mail = new System.Text.RegularExpressions.Regex(@"^[\w\.=-]+@[\w\.-]+\.[\w]{2,3}$");
            if (mail.IsMatch(textBox_email.Text))
            {
                SonucOlumlu(sender);
                email = true;
            }
            else
            {
                SonucOlumsuz(sender);
                email = false;
            }
        }

        private void textBox_telefon_Leave(object sender, EventArgs e)
        {
            textBox_telefon.Text = textBox_telefon.Text.Trim();
            foreach (char item in textBox_telefon.Text)
            {
                if (!Char.IsDigit(item))
                {
                    SonucOlumsuz(sender);
                    telefon = false;
                    return;
                }
            }

            SonucOlumlu(sender);
            telefon = true;
        }

        private void textBox_telefon_TextChanged(object sender, EventArgs e)
        {
            foreach (char item in textBox_telefon.Text)
            {
                if (!Char.IsDigit(item))
                {
                    return;
                }
            }

            if (textBox_telefon.Text.Length == 10)
            {
                comboBox_cinsiyet.Focus();
            }
        }

        private void textBox_adres_Leave(object sender, EventArgs e)
        {
            textBox_adres.Text = textBox_adres.Text.Trim().ToUpper();
            if (textBox_adres.Text.Length != 0)
            {
                SonucOlumlu(sender);
                adres = true;
            }
            else
            {
                SonucOlumsuz(sender);
                adres = false;
            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (!(ad && soyad && email && telefon && adres))
            {
                toolStripStatusLabel_bilgi.Text = "İşaretli eksik bilgileri tamamlayınız.";
                return;
            }

            if (Musteri == null)
            {
                Musteriler musteri = new Musteriler();
                musteri.Ad = textBox_ad.Text;
                musteri.Soyad = textBox_soyad.Text;
                musteri.Email = textBox_email.Text;
                musteri.Telefon = textBox_telefon.Text;
                musteri.Cinsiyet = Convert.ToBoolean(comboBox_cinsiyet.SelectedIndex);
                musteri.DogumTarih = dateTimePicker_dogumTarih.Value;
                musteri.SehirID = (comboBox_sehir.SelectedItem as Sehirler).ID;
                musteri.Adres = textBox_adres.Text;
                musteri.KartNumarasi = textBox_kartNumarasi.Text;
                musteri.KartTeslim = checkBox_kartTeslim.Checked;
                musteri.MevcutPara = 0;
                ctx.Musterilers.InsertOnSubmit(musteri);

                try
                {
                    ctx.SubmitChanges();
                    toolStripStatusLabel_bilgi.Text = "Kayıt işlemi başarı ile tamamlanmıştır.";
                    FormuYapilandir();
                    return;
                }
                catch (Exception ex)
                {
                    Form_ana_ekran.HataKaydi(ex);
                    toolStripStatusLabel_bilgi.Text = "Kayıt işlemi hata ile karşılaştı.";
                    return;
                }
            }

            else
            {
                Musteri.Ad = textBox_ad.Text;
                Musteri.Soyad = textBox_soyad.Text;
                Musteri.Email = textBox_email.Text;
                Musteri.Telefon = textBox_telefon.Text;
                Musteri.Cinsiyet = Convert.ToBoolean(comboBox_cinsiyet.SelectedIndex);
                Musteri.DogumTarih = dateTimePicker_dogumTarih.Value;
                Musteri.SehirID = (comboBox_sehir.SelectedItem as Sehirler).ID;
                Musteri.Adres = textBox_adres.Text;
                Musteri.KartNumarasi = textBox_kartNumarasi.Text;
                Musteri.KartTeslim = checkBox_kartTeslim.Checked;

                try
                {
                    ctx.SubmitChanges();
                    toolStripStatusLabel_bilgi.Text = "Güncelleme işlemi başarı ile tamamlanmıştır.";
                    FormuYapilandir();
                    return;
                }
                catch (Exception ex)
                {
                    Form_ana_ekran.HataKaydi(ex);
                    toolStripStatusLabel_bilgi.Text = "Güncelleme işlemi hata ile karşılaştı.";
                    return;
                }
            }
            
            
        }

        private void button_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            try
            {
                ctx.Musterilers.DeleteOnSubmit(Musteri);
                ctx.SubmitChanges();
                MessageBox.Show("Silme işlemi başarı ile tamamlanmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            catch (Exception ex)
            {
                Form_ana_ekran.HataKaydi(ex);
                toolStripStatusLabel_bilgi.Text = "Silme işlemi hata ile karşılaştı.";
            }
        }
    }
}
