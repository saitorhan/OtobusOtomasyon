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
    public partial class Form_SeferDetay : Form
    {
        public Form_SeferDetay()
        {
            InitializeComponent();
        }

        public static bool form_acik_mi;
        VeriTabaniIslemleriDataContext ctx;
        private void Form_SeferDetay_Load(object sender, EventArgs e)
        {
            form_acik_mi = true;
            ctx = new VeriTabaniIslemleriDataContext();
            IEnumerable<Guzergah> guzergahlar = ctx.Guzergahs.Select(g => g);
            comboBox_guzergahlar.DataSource = guzergahlar;
        }

        private void comboBox_guzergahlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int guzergahID = (comboBox_guzergahlar.SelectedItem as Guzergah).ID;
            IEnumerable<Seferler> seferler = ctx.Seferlers.Where(s => s.guzergahID == guzergahID).Select(s => s);
            listBox_seferler.DataSource = seferler;
            if (seferler.Count(s => s.ID > 0) == 0)
            {
                label_seferNo.Text = "";
                label_kSehir.Text = "";
                label_vSehir.Text = "";
                label_otobus.Text = "";
                label_muavin.Text = "";
                label_sofor.Text = "";
                label_kZaman.Text = "";
                label_vZaman.Text = "";
                label_sure.Text = "";
                label_ucret.Text = "";
            }
        }

        int seferID;
        private void listBox_seferler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_seferler.SelectedIndex > -1)
            {
                try
                {
                    Seferler sefer = listBox_seferler.SelectedItem as Seferler;
                    label_seferNo.Text = sefer.ID.ToString();
                    label_kSehir.Text = sefer.Sehirler.SehirAd;
                    label_vSehir.Text = sefer.Sehirler1.SehirAd;
                    label_otobus.Text = sefer.Otobusler.ToString();
                    label_muavin.Text = sefer.Calisanlar.ToString();
                    label_sofor.Text = sefer.Calisanlar1.ToString();
                    label_kZaman.Text = sefer.KalkisZamani.ToString("dd MMMM yyyy HH:mm");
                    DateTime varisZamani = Convert.ToDateTime(sefer.VarisZamani);
                    label_vZaman.Text = varisZamani.ToString("dd MMMM yyyy HH:mm");
                    label_sure.Text = sefer.TahminiSure;
                    label_ucret.Text = sefer.BiletTutar.ToString(".##");
                    seferID = sefer.ID;
                }
                catch (Exception)
                {
                    
                }
                
            }
        }

        private void Form_SeferDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_acik_mi = false;
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sefer silinecek. Onaylamak için " + DialogResult.Yes.ToString() + " butonuna basın.", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                Seferler sefer = ctx.Seferlers.Where(s => s.ID == seferID).Select(s => s).Single();
                IEnumerable<Biletler> biletler = ctx.Biletlers.Where(b => b.SeferID == seferID).Select(b => b);
                IEnumerable<DoluKoltuklar> doluKoltuklar = ctx.DoluKoltuklars.Where(d => d.SeferID == seferID).Select(d => d);
                IEnumerable<OtobusMasraflari> masraflar = ctx.OtobusMasraflaris.Where(ms => ms.SeferID == seferID).Select(ms => ms);

                ctx.OtobusMasraflaris.DeleteAllOnSubmit(masraflar);
                ctx.DoluKoltuklars.DeleteAllOnSubmit(doluKoltuklar);
                ctx.Biletlers.DeleteAllOnSubmit(biletler);
                ctx.Seferlers.DeleteOnSubmit(sefer);
                try
                {
                    ctx.SubmitChanges();
                    toolStripStatusLabel_bilgi.Text = "Sefer başarı ile silindi.";
                    IEnumerable<Guzergah> guzergahlar = ctx.Guzergahs.Select(g => g);
                    comboBox_guzergahlar.DataSource = guzergahlar;
                }
                catch (Exception ex)
                {
                    Form_ana_ekran.HataKaydi(ex);
                    toolStripStatusLabel_bilgi.Text = "Sefer silinirken hata oluştu.";
                }
            }
        }

        private void listBox_seferler_DataSourceChanged(object sender, EventArgs e)
        {

        }
    }
}
