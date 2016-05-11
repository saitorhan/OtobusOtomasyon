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
    public partial class Form_GuzergahEkle : Form
    {
        public static bool form_acik_mi;
        VeriTabaniIslemleriDataContext ctx;
        public Form_GuzergahEkle()
        {
            InitializeComponent();
        }
   
        private void Form_GuzergahEkle_Load(object sender, EventArgs e)
        {
            ctx = new VeriTabaniIslemleriDataContext();
            var sehirler = ctx.Sehirlers.OrderBy(s => s.SehirAd).Select(s => s);
            comboBox_baslamaSehir.DataSource = sehirler;
            var sehirler2 = ctx.Sehirlers.OrderBy(s => s.SehirAd).Select(s => s);
            comboBox_varisSehir.DataSource = sehirler2;
            var sehirler3 = ctx.Sehirlers.OrderBy(s => s.SehirAd).Select(s => s);
            comboBox_sehir1.DataSource = sehirler3;
            form_acik_mi = true;
        }

        private void Form_GuzergahEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_acik_mi = false;
        }

        private void button_iptal_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kayıt iptal edilecek! Onaylıyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result==DialogResult.Yes)
            {
                this.Close();
            }
        }
        int guzergahID;
        private void button_ekle_Click(object sender, EventArgs e)
        {
            Guzergah guzergah = new Guzergah();
            guzergah.Tanim = textBox_guzergahIsmi.Text;
            guzergah.kalkis_sehir = (comboBox_baslamaSehir.SelectedItem as Sehirler).ID;
            guzergah.varis_sehir = (comboBox_varisSehir.SelectedItem as Sehirler).ID;
            try
            {
                ctx.Guzergahs.InsertOnSubmit(guzergah);
                ctx.SubmitChanges();
                toolStripStatusLabel_kayit.Text = "Kayıt başarılı.\nGüzergah üzeri şehir seçiniz.";
                groupBox_GuzergahSehirleri.Enabled = true;
                panel_guzergahEkle.Enabled = false;
                guzergahID = ctx.Guzergahs.Where(g => g.Tanim.CompareTo(guzergah.Tanim) == 0).Select(g => g.ID).First();
            }
            catch (Exception ex)
            {
                Form_ana_ekran.HataKaydi(ex);
                toolStripStatusLabel_kayit.Text = "Kayıt başarısız.";
            }
        }

        int label_y = 40;
        private void button_GuzergahaSehirEkle_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = "Şehir " + ((label_y - 40) / 27 + 2);
            label.Location = new Point(6, label_y + 3);
            label.Size = new System.Drawing.Size(40, 13);
            label.AutoSize = true;
            groupBox_GuzergahSehirleri.Controls.Add(label);

            ComboBox combobox = new ComboBox();
            var sehirler = ctx.Sehirlers.OrderBy(s => s.SehirAd).Select(s => s);
            combobox.DataSource = sehirler;
            combobox.Location = new Point(65, label_y);
            combobox.Size = comboBox_sehir1.Size;
            groupBox_GuzergahSehirleri.Controls.Add(combobox);
            label_y += 27;
        }

        private void comboBox_varisSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string birincisehir = (comboBox_baslamaSehir.SelectedItem as Sehirler).SehirAd;
                string ikincisehir = (comboBox_varisSehir.SelectedItem as Sehirler).SehirAd;

                textBox_guzergahIsmi.Text = birincisehir + " - " + ikincisehir;
            }
            catch { }
        }

        private void comboBox_baslamaSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string birincisehir = (comboBox_baslamaSehir.SelectedItem as Sehirler).SehirAd;
                string ikincisehir = (comboBox_varisSehir.SelectedItem as Sehirler).SehirAd;

                textBox_guzergahIsmi.Text = birincisehir + " - " + ikincisehir;
            }
            catch { }
        }

        private void button_sehirleriKaydet_Click(object sender, EventArgs e)
        {
            bool basari = false;
            foreach (var item in groupBox_GuzergahSehirleri.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox combo = item as ComboBox;
                    GuzergahItem guzergahItem = new GuzergahItem();
                    guzergahItem.SeferID = guzergahID;
                    guzergahItem.GececegiIlID = (combo.SelectedItem as Sehirler).ID;
                    ctx.GuzergahItems.InsertOnSubmit(guzergahItem);
                    try
                    {
                        ctx.SubmitChanges();
                        basari = true;
                    }
                    catch (Exception ex)
                    {
                        Form_ana_ekran.HataKaydi(ex);
                        basari = false;
                    }
                }
            }
            if(basari)
                toolStripStatusLabel_itemKayit.Text = "Kayıtlar başarılı";
            else
                toolStripStatusLabel_itemKayit.Text = "Kayıtlar başarısız";
            panel_guzergahEkle.Enabled = true;
            groupBox_GuzergahSehirleri.Enabled = false;
        }

        private void comboBox_sehir1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
