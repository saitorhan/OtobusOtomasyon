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
    public partial class Form_personel_detay : Form
    {
        public Form_personel_detay()
        {
            InitializeComponent();
        }

        public static bool form_acik_mi = false;
        VeriTabaniIslemleriDataContext ctx;

        private void Form_personel_detay_Load(object sender, EventArgs e)
        {
            ctx = new VeriTabaniIslemleriDataContext();
            form_acik_mi = true;

            var sehirler = ctx.Sehirlers.OrderBy(s=>s.SehirAd).Select(s => s);
            comboBox_sehir.DataSource = sehirler;
        }

        private void Form_personel_detay_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_acik_mi = false;
        }

        private void comboBox_sehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sehirID = (comboBox_sehir.SelectedItem as Sehirler).ID;

            var subeler = ctx.Subelers.Where(s => s.SehirID == sehirID).OrderBy(s => s.SubeAd).Select(s => s);
            comboBox_sube.DataSource = subeler;
        }

        private void comboBox_sube_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sube_id = (comboBox_sube.SelectedItem as Subeler).ID;
            var calisanlar = from calisan in ctx.Calisanlars
                             join sube in ctx.Subelers on calisan.SubeID equals sube.ID
                             join calisanTip in ctx.CalisanTipleris on calisan.CalisanTipID equals calisanTip.ID
                             where calisan.SubeID==sube_id
                             select new {
                                            calisan.ID,
                                            calisan.Ad,
                                            calisan.Soyad,
                                            calisan.Telefon,
                                            calisan.Email,
                                            sube.SubeAd,
                                            calisan.KullaniciAd,
                                            calisma_pozisyonu = calisanTip.TipAd,
                                            calisan.EvAdres
                                        };
            if (calisanlar != null)
            {
                dataGridView_calisanlar_listesi.DataSource = calisanlar;
            }
        }

        private void dataGridView_calisanlar_listesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView_calisanlar_listesi.Rows[e.RowIndex].Selected = true;
            int id = Convert.ToInt32(dataGridView_calisanlar_listesi.SelectedRows[0].Cells[0].Value);

            Form_personel_guncelle_ekle personel_guncelle = new Form_personel_guncelle_ekle();
            if (Form_personel_guncelle_ekle.form_acik_mi)
            {
                if (Form_personel_guncelle_ekle.ID > 0)
                {
                    MessageBox.Show("Aynı anda birden fazla güncelleme ekranı açılamaz.");
                    return;
                }
            }

            Form_personel_guncelle_ekle.ID = id;
            Form_personel_guncelle_ekle.sehir = comboBox_sehir.SelectedItem as Sehirler;
            Form_personel_guncelle_ekle.sube = comboBox_sube.SelectedItem as Subeler;
            Form_personel_guncelle_ekle.calisma_tip = dataGridView_calisanlar_listesi.SelectedRows[0].Cells[7].Value.ToString();
            personel_guncelle.MdiParent = this.MdiParent;
            personel_guncelle.Show();
        }


    }
}
