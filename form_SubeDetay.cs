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
    public partial class form_SubeDetay : Form
    {
        public form_SubeDetay()
        {
            InitializeComponent();
        }

        public static bool form_acik_mi = false;
        List<int> liste_sehirler_id = new List<int>();


        /// <summary>
        /// Veritabanından şehirleri çeker ve sırayla hepsinin ID lerini şehirler listesine, adlarını da comcoboxa atar. Seçilen şehrin ID si combobox seçilen indekstir
        /// </summary>
        private void form_SubeDetay_Load(object sender, EventArgs e)
        {
            form_acik_mi = true;
            VeriTabaniIslemleriDataContext db = new VeriTabaniIslemleriDataContext();

            var sehirler = from s in db.Sehirlers
                           select s;
            foreach (Sehirler item in sehirler)
            {
                liste_sehirler_id.Add(item.ID);
                comboBox_sehirler.Items.Add(item.SehirAd);
            }
        }

        private void form_SubeDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_acik_mi = false;
        }

        private void comboBox_sehirler_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_sube_ekleme.Visible = true;
            panel_sube_detaylari.Visible = false;
            label_sube_kodu.Text = "";
            label_subeSehir.Text = "";
            textBox_subeAd.Text = "";
            VeriTabaniIslemleriDataContext db = new VeriTabaniIslemleriDataContext();

            var secilen_ildeki_subeler = from sehir in db.Sehirlers
                                         join sube in db.Subelers on sehir.ID equals sube.SehirID
                                         where sube.SehirID == liste_sehirler_id[comboBox_sehirler.SelectedIndex]
                                         select new
                                         {
                                            sube.ID, sube.SubeAd, sehir.SehirAd
                                         };
            dataGridView_subeler.DataSource = secilen_ildeki_subeler;
            dataGridView_subeler.Columns[0].HeaderText = "Şube Kodu";
            dataGridView_subeler.Columns[1].HeaderText = "Şube Adı";
            dataGridView_subeler.Columns[2].HeaderText = "Şube Şehir";
        }

        private void dataGridView_subeler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            panel_sube_detaylari.Visible = true;
            dataGridView_subeler.Rows[e.RowIndex].Selected = true;
            label_sube_kodu.Text = dataGridView_subeler.SelectedRows[0].Cells[0].Value.ToString();
            textBox_subeAd.Text = dataGridView_subeler.SelectedRows[0].Cells[1].Value.ToString();
            label_subeSehir.Text = dataGridView_subeler.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void subeyiSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show(textBox_subeAd.Text + " şubesi silinecek. Onaylıyor musunuz?", "Onay İstemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (secim != DialogResult.Yes)
            {
                return;
            }
            try
            {
                VeriTabaniIslemleriDataContext db = new VeriTabaniIslemleriDataContext();
                int sube_id = Convert.ToInt32(label_sube_kodu.Text);
                Subeler silinecekSube = db.Subelers.First(s => s.ID == sube_id);
                db.Subelers.DeleteOnSubmit(silinecekSube);
                db.SubmitChanges();
                MessageBox.Show(silinecekSube.SubeAd+ " şubesi başarı ile silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox_sehirler_SelectedIndexChanged(null, null);
            }
            catch (Exception ex)
            {
                Form_ana_ekran.HataKaydi(ex);
                MessageBox.Show("Kayıt silinirken bir hata ile karşılaşıldı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void button_grid_yenile_Click(object sender, EventArgs e)
        {
            comboBox_sehirler_SelectedIndexChanged(null, null);
        }

        private void subeyiGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button_grid_yenile.Enabled = false;
            dataGridView_subeler.Enabled = false;
            comboBox_sehirler.Enabled = false;
            panel_guncelleme.Visible = true;
            textBox_subeAd.ReadOnly = false;
            textBox_subeAd.Focus();
        }

        private void button_guncelle_iptal_Click(object sender, EventArgs e)
        {
            button_grid_yenile.Enabled = true;
            dataGridView_subeler.Enabled = true;
            comboBox_sehirler.Enabled = true;
            panel_guncelleme.Visible = false;
            textBox_subeAd.ReadOnly = true;
            textBox_subeAd.Text = dataGridView_subeler.SelectedRows[0].Cells[1].Value.ToString();
        }

        bool IsimHataliMi(string kontroledilecek)
        {
            foreach (char item in kontroledilecek)
            {
                if (Char.IsLetter(item) || Char.IsNumber(item))
                {
                    
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private void button_guncelle_kayit_Click(object sender, EventArgs e)
        {    
            string sube_ad = textBox_subeAd.Text;
            if (IsimHataliMi(sube_ad))
            {
                MessageBox.Show("Şube adı sadece harf veya rakam içerebilir.", "Yanlış bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (sube_ad.Length < 1)
            {
                MessageBox.Show("Şube adını girmediniz.", "Eksik bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            DialogResult secim = MessageBox.Show(dataGridView_subeler.SelectedRows[0].Cells[1].Value.ToString() + " şubesi "+sube_ad+" olarak güncellenecek. Onaylıyor musunuz?", "Onay İstemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (secim != DialogResult.Yes)
            {
                return;
            }

            try
            {
                VeriTabaniIslemleriDataContext db = new VeriTabaniIslemleriDataContext();
                int sube_id = Convert.ToInt32(label_sube_kodu.Text);
                Subeler guncellenecek_sube = db.Subelers.First(s => s.ID == sube_id);
                guncellenecek_sube.SubeAd = sube_ad;
                db.SubmitChanges();
                MessageBox.Show(dataGridView_subeler.SelectedRows[0].Cells[1].Value.ToString() + " şubesi " + sube_ad + " olarak güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                button_grid_yenile.Enabled = true;
                dataGridView_subeler.Enabled = true;
                comboBox_sehirler.Enabled = true;
                panel_guncelleme.Visible = false;
                textBox_subeAd.ReadOnly = true;
                button_grid_yenile_Click(null, null);
            }

            catch (Exception ex)
            {
                Form_ana_ekran.HataKaydi(ex);
                MessageBox.Show("Kayıt güncellenirken bir hata ile karşılaşıldı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_subeAd_Leave(object sender, EventArgs e)
        {
            textBox_subeAd.Text = textBox_subeAd.Text.Trim().ToUpper();
        }

        private void button_sube_ekleme_Click(object sender, EventArgs e)
        {
            form_subeEkle sube_ekle = new form_subeEkle();
            if(form_subeEkle.form_acik_mi)
            foreach (Form item in this.MdiParent.MdiChildren)
            {
                if (sube_ekle.Text==item.Text)
                {
                    item.BringToFront();
                    return;
                }
            }

            sube_ekle.MdiParent = this.MdiParent;
            sube_ekle.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VeriTabaniIslemleriDataContext db = new VeriTabaniIslemleriDataContext();
            var secilen_ildeki_subeler = from sehir in db.Sehirlers
                                         join sube in db.Subelers on sehir.ID equals sube.SehirID
                                         select new
                                         {
                                             sube.ID,
                                             sube.SubeAd,
                                             sehir.SehirAd
                                         };
            dataGridView_subeler.DataSource = secilen_ildeki_subeler;
            dataGridView_subeler.Columns[0].HeaderText = "Şube Kodu";
            dataGridView_subeler.Columns[1].HeaderText = "Şube Adı";
            dataGridView_subeler.Columns[2].HeaderText = "Şube Şehir";
        }
    }
}
