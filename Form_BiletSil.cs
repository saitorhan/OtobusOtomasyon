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
    public partial class Form_BiletSil : Form
    {
        public static bool form_acik_mi;
        VeriTabaniIslemleriDataContext ctx;
        public Form_BiletSil()
        {
            InitializeComponent();
        }

        private void Form_BiletSil_Load(object sender, EventArgs e)
        {
            form_acik_mi = true;
            ctx = new VeriTabaniIslemleriDataContext();
        }

        private void Form_BiletSil_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_acik_mi = false;
        }

        Biletler bilet = null;
        private void button_bilet_bul_Click(object sender, EventArgs e)
        {
            try
            {
                int biletID = Convert.ToInt32(textBox_biletNumarasi.Text);
                bilet = ctx.Biletlers.Where(b => b.ID == biletID).Select(b => b).Single();
                Seferler sefer = ctx.Seferlers.Where(s => s.ID == bilet.SeferID).Select(s => s).Single();
                label_sefer.Text = sefer.ToString();
                label_zaman.Text = bilet.IslemZaman.ToLongDateString();
                label_koltuk.Text = bilet.KultukNo.ToString();
                label_ad.Text = bilet.YolcuAd;
                label_soyad.Text = bilet.YolcuSoyad;
                if (bilet.SatisTip)
                {
                    label_satis_tip.Text = "Nakit";
                }
                else
                {
                    label_satis_tip.Text = "Kredi Kartı";
                }
                label_ucret.Text=bilet.Ucret.ToString(".##");
                label_inis.Text = ctx.Sehirlers.Where(s => s.ID == bilet.InisSehirID).Select(s => s.SehirAd).Single();
                label_binis.Text = ctx.Sehirlers.Where(s => s.ID == bilet.BinisSehirID).Select(s => s.SehirAd).Single();
            }
            catch (Exception ex)
            {
                Form_ana_ekran.HataKaydi(ex);
                toolStripStatusLabel_biletBilgi.Text = "Bilet bulunamadı";
            }
        }

        /// <summary>
        /// Bilet silinirken biletle ilişkili diğer kayıtlarda silinmektedir.
        /// </summary>
        private void button_biletSil_Click(object sender, EventArgs e)
        {
            if (bilet==null)
            {
                toolStripStatusLabel_biletBilgi.Text = "Bilet bilgisi eksik";
                return;
            }
            DialogResult result = MessageBox.Show("Bilet silinecek, onaylamak için " + DialogResult.Yes.ToString() + " butonuna tıklayınız.", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                ctx.Biletlers.DeleteOnSubmit(bilet);
                IEnumerable<DoluKoltuklar> doluKOltuklar = ctx.DoluKoltuklars.Where(d => d.BiletNo == bilet.ID).Select(d => d);
                ctx.DoluKoltuklars.DeleteAllOnSubmit(doluKOltuklar);
                ctx.SubmitChanges();
                toolStripStatusLabel_biletBilgi.Text = "Bilet Başarı ile silindi.";
                bilet = null;

                label_sefer.Text = "";
                label_zaman.Text = "";
                label_koltuk.Text = "";
                label_ad.Text = "";
                label_soyad.Text = "";
                label_satis_tip.Text = "";
                label_inis.Text = "";
                label_binis.Text = "";
                label_ucret.Text = "";
            }
        }

        private void groupBox_biletBilgileri_Enter(object sender, EventArgs e)
        {

        }
    }
}
