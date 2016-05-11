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
    public partial class Form_MarkaIslemleri : Form
    {
        public static bool form_acik = false;
        VeriTabaniIslemleriDataContext ctx;
        public Form_MarkaIslemleri()
        {
            InitializeComponent();
        }

        private void Form_MarkaIslemleri_Load(object sender, EventArgs e)
        {
            form_acik = true;
            MarkalariCek();
        }

        private void Form_MarkaIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_acik = false;
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            textBox_markaAdi.Text = textBox_markaAdi.Text.Trim().ToUpper();
            if (textBox_markaAdi.Text.Length == 0)
            {
                toolStripStatusLabel_marka_ekleme.Text = "Marka adı girmediniz.";
                return;
            }

            try
            {
                Markalar marka = new Markalar();
                marka.MarkaAd = textBox_markaAdi.Text;
                ctx.Markalars.InsertOnSubmit(marka);
                ctx.SubmitChanges();
                toolStripStatusLabel_marka_ekleme.Text = "Kayıt başarı ile eklendi.";
                textBox_markaAdi.Text = "";
                MarkalariCek();
            }
            catch (Exception ex)
            {
                Form_ana_ekran.HataKaydi(ex);
                toolStripStatusLabel_marka_ekleme.Text = "Kayıt eklenirken bir hata ile karşılaşıldı.";
            }
        }

        private void MarkalariCek()
        {
            ctx = new VeriTabaniIslemleriDataContext();
            var markalar = ctx.Markalars.Select(m => m);
            dataGridView_markalar.DataSource = markalar;
            dataGridView_markalar.Columns[0].HeaderText = "Kod";
            dataGridView_markalar.Columns[1].HeaderText = "Marka Adı";
        }

        private void dataGridView_markalar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView_markalar.Rows[e.RowIndex].Selected = true;
            label_markaKodu.Text = dataGridView_markalar.SelectedRows[0].Cells[0].Value.ToString();
            textBox_markanin_adi.Text = dataGridView_markalar.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button_guncelle_Click(object sender, EventArgs e)
        {
            int markaID = Convert.ToInt32(label_markaKodu.Text);
            Markalar marka = ctx.Markalars.Where(m => m.ID == markaID).Select(m => m).First();
            textBox_markanin_adi.Text = textBox_markanin_adi.Text.Trim().ToUpper();
            if (textBox_markanin_adi.Text.Length == 0)
            {
                toolStripStatusLabel_marka_guncelle_sil.Text = "Marka adını yazmadınız.";
                return;
            }
            marka.MarkaAd = textBox_markanin_adi.Text;
            try
            {
                ctx.SubmitChanges();
                toolStripStatusLabel_marka_guncelle_sil.Text = "Marka adı başarı ile güncellendi.";
                MarkalariCek();
            }
            catch (Exception ex)
            {
                Form_ana_ekran.HataKaydi(ex);
                toolStripStatusLabel_marka_guncelle_sil.Text = "Marka adı güncelleme başarısız.";
            }
        }
    }
}
