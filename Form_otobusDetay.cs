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
    public partial class Form_otobusDetay : Form
    {
        public Form_otobusDetay()
        {
            InitializeComponent();
        }

        public static bool form_acik_mi = false;
        VeriTabaniIslemleriDataContext ctx;
        private void Form_otobusDetay_Load(object sender, EventArgs e)
        {
            form_acik_mi = true;
            ctx = new VeriTabaniIslemleriDataContext();
            var markalar = ctx.Markalars.Select(m => m);
            comboBox_marka.DataSource = markalar;

            var otobusler = from otobus in ctx.Otobuslers
                            join marka in ctx.Markalars on otobus.MarkaID equals marka.ID
                            select new
                            {
                                otobus.ID,
                                otobus.Plaka,
                                otobus.KoltukSayisi,
                                marka.MarkaAd,
                                otobus.AktifMi
                            };
            dataGridView_otobusler.DataSource = otobusler;
        }

        private void Form_otobusDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_acik_mi = false;
        }

        private void comboBox_marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            int markaID = (comboBox_marka.SelectedItem as Markalar).ID;

            if (comboBox_aktiflik_durumu.SelectedIndex < 0 || comboBox_aktiflik_durumu.SelectedIndex == 2)
            {
                var otobusler = from otobus in ctx.Otobuslers
                            join marka in ctx.Markalars on otobus.MarkaID equals marka.ID
                            where otobus.MarkaID==markaID
                            select new
                            {
                                otobus.ID,
                                otobus.Plaka,
                                otobus.KoltukSayisi,
                                marka.MarkaAd,
                                otobus.AktifMi
                            };
            dataGridView_otobusler.DataSource = otobusler;
            }

            else if (comboBox_aktiflik_durumu.SelectedIndex == 0)
            {
                var otobusler = from otobus in ctx.Otobuslers
                                join marka in ctx.Markalars on otobus.MarkaID equals marka.ID
                                where otobus.MarkaID == markaID
                                where otobus.AktifMi == true
                                select new
                                {
                                    otobus.ID,
                                    otobus.Plaka,
                                    otobus.KoltukSayisi,
                                    marka.MarkaAd,
                                    otobus.AktifMi
                                };
                dataGridView_otobusler.DataSource = otobusler;
            }

            else if (comboBox_aktiflik_durumu.SelectedIndex == 1)
            {
                var otobusler = from otobus in ctx.Otobuslers
                                join marka in ctx.Markalars on otobus.MarkaID equals marka.ID
                                where otobus.MarkaID == markaID
                                where otobus.AktifMi == false
                                select new
                                {
                                    otobus.ID,
                                    otobus.Plaka,
                                    otobus.KoltukSayisi,
                                    marka.MarkaAd,
                                    otobus.AktifMi
                                };
                dataGridView_otobusler.DataSource = otobusler;
            }
        }

        private void button_butun_otobusler_Click(object sender, EventArgs e)
        {
            var otobusler = from otobus in ctx.Otobuslers
                            join marka in ctx.Markalars on otobus.MarkaID equals marka.ID
                            select new
                            {
                                otobus.ID,
                                otobus.Plaka,
                                otobus.KoltukSayisi,
                                marka.MarkaAd,
                                otobus.AktifMi
                            };
            dataGridView_otobusler.DataSource = otobusler;
        }

        Otobusler otobus = null;
        private void dataGridView_otobusler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                button_guncelle.Enabled = false;
                return;
            }
            button_guncelle.Enabled = true;
            int otobus_id = Convert.ToInt32(dataGridView_otobusler.Rows[e.RowIndex].Cells[0].Value);
            otobus = ctx.Otobuslers.Where(o => o.ID == otobus_id).Select(o => o).First();
            label_otobusID.Text = otobus_id.ToString();
            textBox_plaka.Text = otobus.Plaka;
            label_koltukSayisi.Text = otobus.KoltukSayisi.ToString();
            label_marka.Text = ctx.Markalars.Where(m => m.ID == otobus.MarkaID).Select(m => m.MarkaAd).First();
            checkBox_aktifMi.Checked = otobus.AktifMi;
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            textBox_plaka.Text = textBox_plaka.Text.Trim().ToUpper();
            if (textBox_plaka.Text.Length == 0)
            {
                textBox_plaka.BackColor = Color.Red;
                toolStripStatusLabel_guncelleme_durum.Text = "Eksik bilgileri kontrol ediniz.";
                return;
            }

            otobus.Plaka = textBox_plaka.Text;
            otobus.AktifMi = checkBox_aktifMi.Checked;
            try
            {
                ctx.SubmitChanges();
                toolStripStatusLabel_guncelleme_durum.Text = "Güncelleme başarılı.";
                label_otobusID.Text = "";
                textBox_plaka.Text = "";
                label_koltukSayisi.Text = "";
                label_marka.Text = "";
                button_guncelle.Enabled = false;
                button_butun_otobusler_Click(null, null);
            }
            catch (Exception ex)
            {
                Form_ana_ekran.HataKaydi(ex);
                toolStripStatusLabel_guncelleme_durum.Text = "Güncelleme başarısız oldu";
            }
        }
    }
}
