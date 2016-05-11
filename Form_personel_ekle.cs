using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace otobus_otomasyon_linq
{
    public partial class Form_personel_guncelle_ekle : Form
    {
        static public bool form_acik_mi = false;
        static public int ID = 0;
        static public Sehirler sehir;
        static public Subeler sube;
        static public string calisma_tip;
        public Form_personel_guncelle_ekle()
        {
            InitializeComponent();
        }

        VeriTabaniIslemleriDataContext db = new VeriTabaniIslemleriDataContext();
        Calisanlar guncellenecek_Calisan = null;

        public Form_personel_guncelle_ekle(Calisanlar Guncellenecek_Calisan)
        {
            InitializeComponent();
            guncellenecek_Calisan = Guncellenecek_Calisan;
            ID = guncellenecek_Calisan.ID;
        }
        /// <summary>
        /// Program ilk çalışmada veritabanından şehirleri ve çalışma pozisyonlarını çekerek ilgili comboboxlara atmaktadır. Bu yapılar için dictionary yapısı kullanılacaktır.
        /// Aynı şekilde çalışma pozisyonlarıda çekilmektedir.
        /// </summary>

        private void Form_personel_ekle_Load(object sender, EventArgs e)
        {
            form_acik_mi = true;
            var sehirler = from s in db.Sehirlers
                           orderby s.SehirAd
                           select s;
            comboBox_sehir.DataSource = sehirler;
            var calisma_konumlari = from c in db.CalisanTipleris
                                    orderby c.TipAd
                                    select c;
            comboBox_calisan_tipi.DataSource = calisma_konumlari;

            // gelen istek güncelleme isteği ise
            if (ID != 0 && guncellenecek_Calisan == null)
            {
                this.Text = "Personel Güncelle";
                Calisanlar calisan = db.Calisanlars.Where(c => c.ID == ID).Select(c => c).First();

                textBox_ad.Text = calisan.Ad;
                textBox_soyad.Text = calisan.Soyad;
                textBox_telefon.Text = calisan.Telefon;
                textBox_mail.Text = calisan.Email;
                textBox_ev_adres.Text = calisan.EvAdres;
                textBox_sifre.Text = calisan.Sifre;
                textBox_sifre_tekrar.Text = calisan.Sifre;
                checkBox_yonetici_mi.Checked = calisan.YoneticiMi;
                textBox_kullanici_ad.Text = calisan.KullaniciAd;
                if(sehir!=null)
                foreach (var item in sehirler)
                {
                    if (item.ID==sehir.ID)
                    {
                        comboBox_sehir.SelectedItem = item;
                    }
                }
                //şehir seçildikten sonra şube seçimi comboBox_sehir_selecteditem chanced olayında tanımlanır
                if(calisma_tip.Length > 0)
                foreach (var item in calisma_konumlari)
                {
                    if (item.TipAd==calisma_tip)
                    {
                        comboBox_calisan_tipi.SelectedItem = item;
                    }
                }
                button_kaydet.Text = "Güncelle";
            }
            // gelen isyek güncelleme isteği ise sonu
            // gelen istek ID aramalı güncelleme isteği ise
            if (guncellenecek_Calisan != null)
            {
                button_kaydet.Text = "Güncelle";
                textBox_ad.Text = guncellenecek_Calisan.Ad;
                textBox_soyad.Text = guncellenecek_Calisan.Soyad;
                textBox_telefon.Text = guncellenecek_Calisan.Telefon;
                textBox_mail.Text = guncellenecek_Calisan.Email;
                textBox_ev_adres.Text = guncellenecek_Calisan.EvAdres;
                textBox_sifre.Text = guncellenecek_Calisan.Sifre;
                textBox_sifre_tekrar.Text = guncellenecek_Calisan.Sifre;
                checkBox_yonetici_mi.Checked = guncellenecek_Calisan.YoneticiMi;
                textBox_kullanici_ad.Text = guncellenecek_Calisan.KullaniciAd;
                Sehirler calisaninSehri = db.Sehirlers.Where(s => s.ID == (db.Subelers.Where(sb => sb.ID == guncellenecek_Calisan.SubeID).Select(sb => sb.SehirID).First())).Select(s => s).First();
                if (calisaninSehri != null)
                {
                    foreach (var item in sehirler)
                    {
                        if (item.ID==calisaninSehri.ID)
                        {
                            comboBox_sehir.SelectedItem = item;
                        }
                    }
                }
            }

        }

        private void Form_personel_ekle_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_acik_mi = false;
            ID = 0;
            sehir = null;
            sube = null;
            calisma_tip = "";
        }

        /// <summary>
        /// Şehir seçildikten sonra şubeler tablosundan o ile ait şubeler seçilip ilgili comboboxa atılır
        /// </summary>

        private void comboBox_sehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            int deger = (comboBox_sehir.SelectedItem as Sehirler).ID;

            var subeler = from s in db.Subelers
                          where s.SehirID == deger
                          select s;

            int subesayisi = subeler.Count(s => s.ID > 0);
            if (subesayisi == 0)
            {
                DialogResult sonuc = MessageBox.Show(comboBox_sehir.SelectedValue + " şehrinde herhangi bir şube bulunmamaktadır. Yeni şube açmak için " + DialogResult.Yes.ToString() + " tuşuna basınız. Çıkmak için " + DialogResult.No.ToString() + " tuşuna basınız.", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (sonuc == DialogResult.Yes)
                {
                    if (ID > 0 && guncellenecek_Calisan == null)
                        form_subeEkle.id = deger;
                    form_subeEkle sube_ekle = new form_subeEkle();
                    if (form_subeEkle.form_acik_mi == true)
                        foreach (Form item in this.MdiParent.MdiChildren)
                        {
                            if (item.Text == sube_ekle.Text)
                            {
                                item.BringToFront();
                                return;
                            }
                        }
                    sube_ekle.MdiParent = this.MdiParent;
                    sube_ekle.Show();
                }
                else
                {   if(ID == 0)
                    this.Close();
                }
            }

            comboBox_sube.DataSource = subeler;
            // gelen istek guncelleme isteği ise
            if (sube != null)
            {
                foreach (var item in subeler)
                {
                    if (item.ID==sube.ID)
                    {
                        comboBox_sube.SelectedItem = item;
                    }
                }
            }

            // gelen istek ID aramalı güncelleme isteği ise

            if (guncellenecek_Calisan != null)
            {
                foreach (var item in subeler)
                {
                    if (item.ID == guncellenecek_Calisan.ID)
                    {
                        comboBox_sube.SelectedItem = item;
                    }
                }
            }
        }

        private void textBoxSadeceHarf(object sender, EventArgs e)
        {
            TextBox KontrolEdilecek = sender as TextBox;
            KontrolEdilecek.Text = KontrolEdilecek.Text.Trim().ToUpper();
            string cumle = KontrolEdilecek.Text;
            if (DogrulamaKontrolleri.SadeceHarfMi(cumle))
            {
                KontrolEdilecek.BackColor = Color.White;
            }
            else
            {
                KontrolEdilecek.BackColor = Color.Red;
            }
        }

        private void textBox_telefon_TextChanged(object sender, EventArgs e)
        {
            if (textBox_telefon.Text.Length == 10)
                textBox_mail.Focus();
        }

        private void textBox_telefon_Leave(object sender, EventArgs e)
        {
            textBox_telefon.Text = textBox_telefon.Text.Trim();
            if (textBox_telefon.Text.Length != 10)
            {
                textBox_telefon.BackColor = Color.Red;
                return;
            }
            foreach (char item in textBox_telefon.Text)
            {
                if (!Char.IsNumber(item))
                {
                    textBox_telefon.BackColor = Color.Red;
                    return;
                }
            }
            textBox_telefon.BackColor = Color.White;
        }

        private void textBox_mail_Leave(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex mail = new System.Text.RegularExpressions.Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (!mail.IsMatch(textBox_mail.Text))
            {
                textBox_mail.BackColor = Color.Red;
                return;
            }
            textBox_mail.BackColor = Color.White;
        }

        private void textBox_ev_adres_Leave(object sender, EventArgs e)
        {
            textBox_ev_adres.Text = textBox_ev_adres.Text.Trim();
            textBox_ev_adres.Text = textBox_ev_adres.Text.ToUpper();
            if (textBox_ev_adres.Text.Length == 0)
            {
                textBox_ev_adres.BackColor = Color.Red;
                return;
            }
            textBox_ev_adres.BackColor = Color.White;
        }

        private void textBox_kullanici_ad_Leave(object sender, EventArgs e)
        {
            textBox_kullanici_ad.Text = textBox_kullanici_ad.Text.Trim();
            if (textBox_kullanici_ad.Text.Length == 0)
            {
                textBox_kullanici_ad.BackColor = Color.Red;
                return;
            }
            textBox_kullanici_ad.BackColor = Color.White;
        }

        private void button_iptal_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıt işlemi iptal edilecek. Onaylıyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Kayıt işleminden önce bütün bilgilerin doğruluğu kontrol ediliyor. Bunun için fon rengi kırmızı olan textbox olmaması gerekiyor.
        /// </summary>
        private void button_kaydet_Click(object sender, EventArgs e)
        {
            if (textBox_sifre.Text.CompareTo(textBox_sifre_tekrar.Text) != 0)
            {
                toolStripStatusLabel_kayit_durum.Text = "Şifreler aynı değil.";
                return;
            }
            if (!ZorlayiciKayitlariSina())
            {
                toolStripStatusLabel_kayit_durum.Text = "Kırmızı ile boyanmış bilgiler eksik veya yanlış girilmiştir";
                return;
            }

            int subeid = (comboBox_sube.SelectedItem as Subeler).ID;
            int calismaPozisyonu = (comboBox_calisan_tipi.SelectedItem as CalisanTipleri).ID;
            if (ID > 0 && guncellenecek_Calisan == null)
            {
                Calisanlar calisan_update = db.Calisanlars.Where(c => c.ID == ID).Select(s => s).First();
                calisan_update.Ad = textBox_ad.Text;
                calisan_update.Soyad = textBox_soyad.Text;
                calisan_update.Telefon = textBox_telefon.Text;
                calisan_update.Email = textBox_mail.Text;
                calisan_update.EvAdres = textBox_ev_adres.Text;
                calisan_update.KullaniciAd = textBox_kullanici_ad.Text;
                calisan_update.Sifre = textBox_sifre.Text;
                calisan_update.YoneticiMi = checkBox_yonetici_mi.Checked;
                calisan_update.CalisanTipID = calismaPozisyonu;
                calisan_update.SubeID = subeid;

                try
                {
                    db.SubmitChanges();
                    MessageBox.Show(calisan_update.Ad + " " + calisan_update.Soyad + ", " + comboBox_sube.SelectedValue + " şubesinde güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    Form_ana_ekran.HataKaydi(ex);
                    toolStripStatusLabel_kayit_durum.Text = "Güncelleme başarısız. Bir hata ile karşılaşıldı.";
                }

                return;
            }

            Calisanlar calisan = new Calisanlar();
            calisan.Ad = textBox_ad.Text;
            calisan.Soyad = textBox_soyad.Text;
            calisan.Telefon = textBox_telefon.Text;
            calisan.Email = textBox_mail.Text;
            calisan.EvAdres = textBox_ev_adres.Text;
            calisan.KullaniciAd = textBox_kullanici_ad.Text;
            calisan.Sifre = textBox_sifre.Text;
            calisan.YoneticiMi = checkBox_yonetici_mi.Checked;
            calisan.CalisanTipID = calismaPozisyonu;
            calisan.SubeID = subeid;
            try
            {
                db.Calisanlars.InsertOnSubmit(calisan);
                db.SubmitChanges();
                MessageBox.Show(calisan.Ad + " " + calisan.Soyad + ", " + comboBox_sube.SelectedValue + " şubesine eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                toolStripStatusLabel_kayit_durum.Text = "Kayıt başarısız. Bir hata ile karşılaşıldı.";
            }
        }

        bool ZorlayiciKayitlariSina()
        {
            if (textBox_ad.BackColor == Color.Red)
            {
                return false;
            }
            if (textBox_soyad.BackColor == Color.Red)
            {
                return false;
            }
            if (textBox_telefon.BackColor == Color.Red)
            {
                return false;
            }
            if (textBox_mail.BackColor == Color.Red)
            {
                return false;
            }
            if (textBox_ev_adres.BackColor == Color.Red)
            {
                return false;
            }
            if (textBox_kullanici_ad.BackColor == Color.Red)
            {
                return false;
            }
            if (textBox_sifre.BackColor == Color.Red)
            {
                return false;
            }
            if (textBox_sifre_tekrar.BackColor == Color.Red)
            {
                return false;
            }
            return true;
        }

    }
}
