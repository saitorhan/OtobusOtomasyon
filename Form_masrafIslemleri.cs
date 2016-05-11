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
    public partial class Form_masrafIslemleri : Form
    {
        public Form_masrafIslemleri()
        {
            InitializeComponent();
        }

        public static bool form_acik_mi;
        VeriTabaniIslemleriDataContext ctx;
        Seferler sefer;
        private void Form_masrafIslemleri_Load(object sender, EventArgs e)
        {
            form_acik_mi = true;
            ctx = new VeriTabaniIslemleriDataContext();
            comboBox_masraf.DataSource = ctx.MasrafTipleris.OrderBy(m => m.MasrafAd).Select(m => m);
            comboBox_kayitliMasraf.DataSource = ctx.MasrafTipleris.OrderBy(m => m.MasrafAd).Select(m => m);
            label9.Text = "Silmek veya güncellemek istediğiniz kaydı\n seçmek için tablodan tıklayınız";
        }

        private void button_ara_Click(object sender, EventArgs e)
        {
            try
            {
                int seferID = Convert.ToInt32(textBox_seferID.Text);
                sefer = ctx.Seferlers.Where(s => s.ID == seferID).Select(s => s).Single();
                label_otobus.Text = sefer.Otobusler.ToString();
                comboBox_calisan.DataSource = ctx.Calisanlars.Where(c => (c.ID == sefer.MuavinID || c.ID == sefer.SoforID)).Select(c => c);
                comboBox_kayitli_calisan.DataSource = ctx.Calisanlars.Where(c => (c.ID == sefer.MuavinID || c.ID == sefer.SoforID)).Select(c => c);
                SeciliSefereAitButunMasraflar(seferID);
            }
            catch (Exception ex)
            {
                Form_ana_ekran.HataKaydi(ex);
                toolStripStatusLabel_bilgi.Text = "Aradığınız sefer bilgisine ulaşılamadı. Lütfen kontrol ederek tekrar deneyiniz.";
            }
        }

        private void SeciliSefereAitButunMasraflar(int seferID)
        {
            var masraflar = from m in ctx.OtobusMasraflaris
                            where m.SeferID == seferID
                            orderby m.ID
                            select new
                            {
                                m.ID,
                                m.MasrafTipleri.MasrafAd,
                                m.Tutar,
                                m.PersonelID
                            };

            dataGridView_masraflar.DataSource = masraflar;
            dataGridView_masraflar.Columns[3].Visible = false;
            dataGridView_masraflar.Columns[0].HeaderText = "No";
            dataGridView_masraflar.Columns[1].HeaderText = "Masraf Tipi";
        }

        private void button_iptal_Click(object sender, EventArgs e)
        {
            textBox_seferID.Text = "";
            comboBox_calisan.DataSource = null;
            textBox_tutar.Text = "";
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                decimal tutar = Convert.ToDecimal(textBox_tutar.Text);
                OtobusMasraflari masraf = new OtobusMasraflari();
                masraf.OtobusId = sefer.OtobusID;
                masraf.MasrafTipID = (comboBox_masraf.SelectedItem as MasrafTipleri).ID;
                masraf.Tutar = tutar;
                masraf.PersonelID = (comboBox_calisan.SelectedItem as Calisanlar).ID;
                masraf.SeferID = sefer.ID;
                ctx.OtobusMasraflaris.InsertOnSubmit(masraf);
                ctx.SubmitChanges();

                toolStripStatusLabel_bilgi.Text = "Masraf kaydı başarı ile gerçekleşti";
                textBox_tutar.Text = "";

                SeciliSefereAitButunMasraflar(sefer.ID);
            }
            catch (Exception ex)
            {
                Form_ana_ekran.HataKaydi(ex);
                toolStripStatusLabel_bilgi.Text = "Masraf eklenirken bir hata ile karşılaşıldı.";
            }
        }


        OtobusMasraflari masraf_;
        private void dataGridView_masraflar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            dataGridView_masraflar.Rows[e.RowIndex].Selected = true;
            int masrafID = Convert.ToInt32(dataGridView_masraflar.SelectedRows[0].Cells[0].Value);
            masraf_ = ctx.OtobusMasraflaris.Where(m => m.ID == masrafID).Select(m => m).Single();
            foreach (Calisanlar item in comboBox_kayitli_calisan.Items)
            {
                if (item.ID == masraf_.PersonelID)
                {
                    comboBox_kayitli_calisan.SelectedItem = item;
                    break;
                }
            }

            foreach (MasrafTipleri item in comboBox_kayitliMasraf.Items)
            {
                if (item.ID == masraf_.MasrafTipID)
                {
                    comboBox_kayitliMasraf.SelectedItem = item;
                    break;
                }
            }

            textBox_kayitliTutar.Text = masraf_.Tutar.ToString();
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                decimal tutar = Convert.ToDecimal(textBox_kayitliTutar.Text);
                masraf_.MasrafTipID = (comboBox_kayitliMasraf.SelectedItem as MasrafTipleri).ID;
                masraf_.Tutar = tutar;
                masraf_.PersonelID = (comboBox_kayitli_calisan.SelectedItem as Calisanlar).ID;
                ctx.SubmitChanges();

                toolStripStatusLabel_bilgi.Text = "Masraf güncellemesi başarı ile gerçekleşti";
                textBox_tutar.Text = "";

                SeciliSefereAitButunMasraflar(sefer.ID);
            }
            catch (Exception ex)
            {
                Form_ana_ekran.HataKaydi(ex);
                toolStripStatusLabel_bilgi.Text = "Masraf güncellenirken bir hata ile karşılaşıldı.";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_calisan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_seferID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_otobus_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_masraf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_tutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel_bilgi_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button_sil_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox_kayitliTutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_kayitliMasraf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_kayitli_calisan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
