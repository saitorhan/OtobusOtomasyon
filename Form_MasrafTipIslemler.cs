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
    public partial class Form_MasrafTipIslemler : Form
    {
        public Form_MasrafTipIslemler()
        {
            InitializeComponent();
        }

        public Form_MasrafTipIslemler(int secim)
        {
            InitializeComponent();
            tabControl_masrafTipIslemleri.SelectedTab = tabPage_MasrafCesidiEkle;
        }

        public static bool form_acik_mi;
        VeriTabaniIslemleriDataContext ctx;
        private void Form_MasrafTipIslemler_Load(object sender, EventArgs e)
        {
            form_acik_mi = true;
            ctx = new VeriTabaniIslemleriDataContext();
            MasrafTipleriniCek();
        }

        private void MasrafTipleriniCek()
        {
            IEnumerable<MasrafTipleri> masrafTipleri = ctx.MasrafTipleris.Select(m => m);
            listBox_masrafCesitleri.DataSource = masrafTipleri;
        }

        private void Form_MasrafTipIslemler_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_acik_mi = false;
        }

        private void listBox_masrafCesitleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_masrafCesitleri.SelectedIndex > -1)
                label_masrafEskiAd.Text = (listBox_masrafCesitleri.SelectedItem as MasrafTipleri).MasrafAd;
        }

        private void button_iptal_Click(object sender, EventArgs e)
        {
            textBox_MasrafYeniAd.Text = "";
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            textBox_MasrafYeniAd.Text = textBox_MasrafYeniAd.Text.Trim().ToUpper();
            if (IsimDoğrula(textBox_MasrafYeniAd.Text))
            {
                int masrafTipID = (listBox_masrafCesitleri.SelectedItem as MasrafTipleri).ID;
                MasrafTipleri masrafTip = ctx.MasrafTipleris.Where(ct => ct.ID == masrafTipID).Select(ct => ct).Single();
                masrafTip.MasrafAd = textBox_MasrafYeniAd.Text;
                DialogResult result = MessageBox.Show("Masraf Tipi güncellenecek. Onaylamak için " + DialogResult.Yes.ToString() + " butonuna basın.", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ctx.SubmitChanges();
                        toolStripStatusLabel_bilgi.Text = "Güncelleme işlemi başarı ile gerçekleşti.";
                        MasrafTipleriniCek();
                        textBox_MasrafYeniAd.Text = "";
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
            DialogResult result = MessageBox.Show("Masraf Çeşiti silinecek. Onaylamak için " + DialogResult.Yes.ToString() + " butonuna basın.", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                int masrafTipID = (listBox_masrafCesitleri.SelectedItem as MasrafTipleri).ID;
                MasrafTipleri masrafTip = ctx.MasrafTipleris.Where(ct => ct.ID == masrafTipID).Select(ct => ct).Single();
                ctx.MasrafTipleris.DeleteOnSubmit(masrafTip);
                try
                {
                    ctx.SubmitChanges();
                    toolStripStatusLabel_bilgi.Text = "Pozisyon başarı ile silindi.";
                    MasrafTipleriniCek();
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
            textBox_MasrafAdi_adi.Text = textBox_MasrafAdi_adi.Text.Trim().ToUpper();
            if (IsimDoğrula(textBox_MasrafAdi_adi.Text))
            {
                MasrafTipleri masrafTip = new MasrafTipleri();
                masrafTip.MasrafAd = textBox_MasrafAdi_adi.Text;
                try
                {
                    ctx.MasrafTipleris.InsertOnSubmit(masrafTip);
                    ctx.SubmitChanges();
                    toolStripStatusLabel_bilgi.Text = "Masraf Çeşiti başarı ile eklendi.";
                    MasrafTipleriniCek();
                    textBox_MasrafAdi_adi.Text = "";
                }
                catch (Exception ex)
                {
                    Form_ana_ekran.HataKaydi(ex);
                    toolStripStatusLabel_bilgi.Text = "Masraf Çeşiti eklenirken hata oluştu.";
                }
            }
            else
            {
                toolStripStatusLabel_bilgi.Text = "Lütfen ismi kontrol ediniz.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_MasrafAdi_adi.Text = "";
            tabControl_masrafTipIslemleri.SelectedTab = tabPage_MasrafGuncelle;
        }
    }
}
