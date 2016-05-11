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
    public partial class Form_ana_ekran : Form
    {

        public static int calisan_id = 0;
        public static string calisan_ad = "";
        public static string calisan_soyad = "";
        public static int sube_id = 0;
        public static string sube_ad = "";
        public static int sube_il_id = 0;
        public Form_ana_ekran()
        {
            InitializeComponent();
        }

        private void Form_ana_ekran_Load(object sender, EventArgs e)
        {
            KullaniciGirisEkrani();
        }

        public static void HataKaydi(Exception ex)
        {
            VeriTabaniIslemleriDataContext ctx = new VeriTabaniIslemleriDataContext();
            Hatalar hata = new Hatalar();
            hata.Numara = ex.HelpLink;
            hata.Mesaj = ex.Message;
            hata.zaman = DateTime.Now;
            hata.Prosedur = ex.Source;
            try
            {
                ctx.Hatalars.InsertOnSubmit(hata);
                ctx.SubmitChanges();
            }
            catch (Exception)
            {
                
            }
        }

        public void MenuyuKontrolEt(bool durum)
        {
            menuStrip_menu.Enabled = durum;
        }

        private void KullaniciGirisEkrani()
        {
            Form_kullanici_girisi kullanici = new Form_kullanici_girisi();
            kullanici.MdiParent = this;
            kullanici.Show();
        }

        private void Form_ana_ekran_TextChanged(object sender, EventArgs e)
        {
            if (calisan_id > 0)
            {
                menuStrip_menu.Enabled = true;
            }
            else
            {
                menuStrip_menu.Enabled = false;
            }
        }

        private void cikisyapToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Çıkış yapılacak onaylıyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (secim==DialogResult.No)
            {
                return;
            }
            Form_ana_ekran.calisan_id = 0;
            sube_id = 0;
            calisan_ad = "";
            calisan_soyad = "";
            sube_ad = "";
            this.Text = "Otobüs Bilet Otomasyon Sitemi";
            foreach (Form item in this.MdiChildren)
            {
                item.Close();
            }

            KullaniciGirisEkrani();
        }

        private void subeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_subeEkle kullanici = new form_subeEkle();
            if (form_subeEkle.form_acik_mi)
            {
                FormuOneGetir(kullanici);
                return;
            }
            kullanici.MdiParent = this;
            kullanici.Show();
        }

        void FormuOneGetir(Form oneGelecekForm)
        {
             foreach (Form item in this.MdiChildren)
                {
                    if (oneGelecekForm.Text==item.Text)
                    {
                        item.BringToFront();
                    }
                }
        }

        private void subeDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_SubeDetay sube_datay = new form_SubeDetay();
            if (form_SubeDetay.form_acik_mi)
            {
                FormuOneGetir(sube_datay);
                return;
            }
            sube_datay.MdiParent = this;
            sube_datay.Show();
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_personel_guncelle_ekle personel_ekle = new Form_personel_guncelle_ekle();
            if (Form_personel_guncelle_ekle.form_acik_mi)
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (personel_ekle.Text==item.Text)
                    {
                        FormuOneGetir(personel_ekle);
                        return;
                    }
                }
            }
            personel_ekle.MdiParent = this;
            personel_ekle.Show();
        }

        private void personelDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_personel_detay personel_detay = new Form_personel_detay();
            if(Form_personel_detay.form_acik_mi)
                foreach (var item in this.MdiChildren)
                {
                    if (item.Text == personel_detay.Text)
                    {
                        item.BringToFront();
                        return;
                    }
                }
            personel_detay.MdiParent = this;
            personel_detay.Show();
        }

        private void personelGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_personelGuncelleIDAlma frm_IDAl = new Form_personelGuncelleIDAlma();
            if (Form_personelGuncelleIDAlma.form_acik_mi)
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (item.Text==frm_IDAl.Text)
                    {
                        item.BringToFront();
                        return;
                    }
                }
            }

            frm_IDAl.MdiParent = this;
            frm_IDAl.Show();
        }


        private void otobüsEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_otobusEkle otobus_ekle = new Form_otobusEkle();
            if (Form_otobusEkle.form_acik_mi)
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (item.Text==otobus_ekle.Text)
                    {
                        item.BringToFront();
                        return;
                    }
                }
            }

            otobus_ekle.MdiParent = this;
            otobus_ekle.Show();
        }

        private void otobüsDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_otobusDetay otobus_detay = new Form_otobusDetay();
            if (Form_otobusDetay.form_acik_mi)
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (item.Text==otobus_detay.Text)
                    {
                        item.BringToFront();
                        return;
                    }
                }
            }
            otobus_detay.MdiParent = this;
            otobus_detay.Show();
        }

        private void guzergahEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_GuzergahEkle guzergahEkle = new Form_GuzergahEkle();
            if (Form_GuzergahEkle.form_acik_mi)
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (guzergahEkle.Text == item.Text)
                    {
                        item.BringToFront();
                    }
                }
            }
            guzergahEkle.MdiParent = this;
            guzergahEkle.Show();
        }

        private void güzergahDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_GuzergahDetay guzergahDetay = new Form_GuzergahDetay();
            if (Form_GuzergahDetay.form_acik_mi)
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (guzergahDetay.Text == item.Text)
                    {
                        item.BringToFront();
                    }
                }
            }
            guzergahDetay.MdiParent = this;
            guzergahDetay.Show();
        }

        private void biletSatisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_biletSatis biletSatis = new Form_biletSatis();
            if (Form_biletSatis.form_acik_mi)
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (item.Text==biletSatis.Text)
                    {
                        item.BringToFront();
                        return;
                    }
                }
            }
            biletSatis.MdiParent = this;
            biletSatis.Show();
        }

        private void seferEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_seferEkle seferEkle = new Form_seferEkle();
            if (Form_seferEkle.form_acikMi)
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (item.Text==seferEkle.Text)
                    {
                        item.BringToFront();
                        return;
                    }
                }
            }
            seferEkle.MdiParent = this;
            seferEkle.Show();
        }

        private void biletSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_BiletSil bilet_sil = new Form_BiletSil();

            if (Form_BiletSil.form_acik_mi)
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (item.Text == bilet_sil.Text)
                    {
                        item.BringToFront();
                        return;
                    }
                }
            }

            bilet_sil.MdiParent = this;
            bilet_sil.Show();
        }

        private void pozisyonEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_pozisyonEkle pozisyon_islemeleri = new Form_pozisyonEkle(1);
            if (Form_pozisyonEkle.form_acik_mi)
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (item.Text==pozisyon_islemeleri.Text)
                    {
                        item.BringToFront();
                        return;
                    }
                }
            }

            pozisyon_islemeleri.MdiParent = this;
            pozisyon_islemeleri.Show();
        }

        private void pozisyonGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_pozisyonEkle pozisyon_islemeleri = new Form_pozisyonEkle();
            if (Form_pozisyonEkle.form_acik_mi)
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (item.Text == pozisyon_islemeleri.Text)
                    {
                        item.BringToFront();
                        return;
                    }
                }
            }

            pozisyon_islemeleri.MdiParent = this;
            pozisyon_islemeleri.Show();
        }

        private void seferDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_SeferDetay sefer_detay = new Form_SeferDetay();
            if (Form_pozisyonEkle.form_acik_mi)
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (item.Text == sefer_detay.Text)
                    {
                        item.BringToFront();
                        return;
                    }
                }
            }

            sefer_detay.MdiParent = this;
            sefer_detay.Show();
        }

        private void markaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_MarkaIslemleri marka_islemleri = new Form_MarkaIslemleri();
            if (Form_MarkaIslemleri.form_acik)
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (item.Text == marka_islemleri.Text)
                    {
                        item.BringToFront();
                        return;
                    }
                }
            }
            marka_islemleri.MdiParent = this;
            marka_islemleri.Show();
        }

        private void masrafCesitiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_MasrafTipIslemler masrafTip_islemleri = new Form_MasrafTipIslemler(1);
            if (Form_MasrafTipIslemler.form_acik_mi)
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (item.Text == masrafTip_islemleri.Text)
                    {
                        item.BringToFront();
                        return;
                    }
                }
            }
            masrafTip_islemleri.MdiParent = this;
            masrafTip_islemleri.Show();
        }

        private void masrafCesitiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_MasrafTipIslemler masrafTip_islemleri = new Form_MasrafTipIslemler();
            if (Form_MasrafTipIslemler.form_acik_mi)
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (item.Text == masrafTip_islemleri.Text)
                    {
                        item.BringToFront();
                        return;
                    }
                }
            }
            masrafTip_islemleri.MdiParent = this;
            masrafTip_islemleri.Show();
        }

        private void musteriKayitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_musteriKayitAl musteri_kaydet = new Form_musteriKayitAl();
            if (Form_musteriKayitAl.form_acik_mi)
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (item.Text==musteri_kaydet.Text)
                    {
                        item.BringToFront();
                        return;
                    }
                }
            }

            musteri_kaydet.MdiParent = this;
            musteri_kaydet.Show();
        }

        private void otobusSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_otobusDetay otobus_detay = new Form_otobusDetay();
            if (Form_otobusDetay.form_acik_mi)
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (item.Text == otobus_detay.Text)
                    {
                        item.BringToFront();
                        return;
                    }
                }
            }
            otobus_detay.MdiParent = this;
            otobus_detay.Show();
        }

        private void harcamaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_masrafIslemleri masraf_detay = new Form_masrafIslemleri();
            if (Form_masrafIslemleri.form_acik_mi)
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (item.Text == masraf_detay.Text)
                    {
                        item.BringToFront();
                        return;
                    }
                }
            }
            masraf_detay.MdiParent = this;
            masraf_detay.Show();
        }

        private void seferBazliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaporBiletler biletlersefer = new RaporBiletler();
            biletlersefer.ShowPreview();
        }

        private void musteriKaydiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_MusteriIslenleri musterIslemleri = new Form_MusteriIslenleri();
            if (Form_MusteriIslenleri.form_acik_mi)
            {
                foreach (Form item in this.MdiChildren)
                {
                    if (item.Text==musterIslemleri.Text)
                    {
                        item.BringToFront();
                        return;
                    }
                }
            }
            musterIslemleri.MdiParent = this;
            musterIslemleri.Show();
        }

        private void kayitliMusterilerListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RaporMusteriler rapor = new RaporMusteriler();
            rapor.ShowPreview();
        }

        private void tarihBazliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RaporTarihBazli tarigBazli = new RaporTarihBazli();
            tarigBazli.ShowPreview();
        }

    }
}
