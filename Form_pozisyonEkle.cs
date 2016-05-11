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
    public partial class Form_pozisyonEkle : Form
    {
        public static bool form_acik_mi;
        VeriTabaniIslemleriDataContext ctx;
        public Form_pozisyonEkle()
        {
            InitializeComponent();
        }

        public Form_pozisyonEkle(int secim)
        {
            InitializeComponent();
            tabControl_pozisyonIslemleri.SelectedTab = tabPage_pozisyonEkle;
        }

        private void Form_pozisyonEkle_Load(object sender, EventArgs e)
        {
            form_acik_mi = true;
            ctx = new VeriTabaniIslemleriDataContext();
            PozisyonlariCek();
        }

        private void PozisyonlariCek()
        {
            IEnumerable<CalisanTipleri> pozisyonlar = ctx.CalisanTipleris.OrderBy(ct=>ct.TipAd).Select(ct => ct);
            listBox_pozisyonlar.DataSource = pozisyonlar;
        }

        private void Form_pozisyonEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_acik_mi = false;
        }

        private void listBox_pozisyonlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox_pozisyonlar.SelectedIndex > -1)
                label_pozisyonEskiAd.Text = (listBox_pozisyonlar.SelectedItem as CalisanTipleri).TipAd;
        }

        private void button_iptal_Click(object sender, EventArgs e)
        {
            textBox_pozisyonYeniAd.Text = "";
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            textBox_pozisyonYeniAd.Text = textBox_pozisyonYeniAd.Text.Trim().ToUpper();
            if (IsimDoğrula(textBox_pozisyonYeniAd.Text))
            {
                int calisanTipID = (listBox_pozisyonlar.SelectedItem as CalisanTipleri).ID;
                CalisanTipleri calisan = ctx.CalisanTipleris.Where(ct => ct.ID == calisanTipID).Select(ct => ct).Single();
                calisan.TipAd = textBox_pozisyonYeniAd.Text;
                DialogResult result = MessageBox.Show("Pozisyon güncellenecek. Onaylamak için " + DialogResult.Yes.ToString() + " butonuna basın.", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result==DialogResult.Yes)
                {
                    try
                    {
                        ctx.SubmitChanges();
                        toolStripStatusLabel_bilgi.Text = "Güncelleme işlemi başarı ile gerçekleşti.";
                        PozisyonlariCek();
                        textBox_pozisyonYeniAd.Text = "";
                    }
                    catch (Exception ex)
                    {
                        Form_ana_ekran.HataKaydi(ex);
                        toolStripStatusLabel_bilgi.Text = "Güncelleme işlemi başarısız oldu.";
                    }
                }
            }
            else
            {
                toolStripStatusLabel_bilgi.Text = "Lütfen ismi kontrol ediniz.";
            }
        }

        private bool IsimDoğrula(string isim)
        {
            if (isim.Length == 0)
            {
                return false;
            }
            foreach (char item in isim)
            {
                if (!Char.IsLetter(item) && !Char.IsWhiteSpace(item))
                {
                    return false;
                }
            }
            return true;
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Pozisyon silinecek. Onaylamak için " + DialogResult.Yes.ToString() + " butonuna basın.", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result==DialogResult.Yes)
            {
                int calisanTipID = (listBox_pozisyonlar.SelectedItem as CalisanTipleri).ID;
                CalisanTipleri calisan = ctx.CalisanTipleris.Where(ct => ct.ID == calisanTipID).Select(ct => ct).Single();
                ctx.CalisanTipleris.DeleteOnSubmit(calisan);
                try
                {
                    ctx.SubmitChanges();
                toolStripStatusLabel_bilgi.Text = "Pozisyon başarı ile silindi.";
                PozisyonlariCek();
                }
                catch (Exception ex)
                {
                    Form_ana_ekran.HataKaydi(ex);
                    toolStripStatusLabel_bilgi.Text = "Pozisyon silinirken hata oluştu.";
                }
            }
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            textBox_pozisyon_adi.Text = textBox_pozisyon_adi.Text.Trim().ToUpper();
            if (IsimDoğrula(textBox_pozisyon_adi.Text))
            {
                CalisanTipleri calisanTip = new CalisanTipleri();
                calisanTip.TipAd = textBox_pozisyon_adi.Text;
                try
                {
                    ctx.CalisanTipleris.InsertOnSubmit(calisanTip);
                    ctx.SubmitChanges();
                    toolStripStatusLabel_bilgi.Text = "Pozisyon başarı ile eklendi.";
                    textBox_pozisyon_adi.Text = "";
                    PozisyonlariCek();
                }
                catch (Exception ex)
                {
                    Form_ana_ekran.HataKaydi(ex);
                    toolStripStatusLabel_bilgi.Text = "Pozisyon eklenirken hata oluştu.";
                }
            }
            else
            {
                toolStripStatusLabel_bilgi.Text = "Lütfen ismi kontrol ediniz.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_pozisyon_adi.Text = "";
            tabControl_pozisyonIslemleri.SelectedTab = tabPage_PozisyınGuncelle;
        }

        private void textBox_pozisyon_adi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
