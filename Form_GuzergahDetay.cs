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
    public partial class Form_GuzergahDetay : Form
    {
        public static bool form_acik_mi;
        private VeriTabaniIslemleriDataContext ctx;
        public Form_GuzergahDetay()
        {
            InitializeComponent();
        }

        private void Form_GuzergahDetay_Load(object sender, EventArgs e)
        {
            form_acik_mi = true;
            ctx = new VeriTabaniIslemleriDataContext();
            GuzergahlariCek();
        }

        void GuzergahlariCek()
        {
            IEnumerable<Guzergah> guzergahlar = ctx.Guzergahs.Select(g => g);
            dataGridView_butun_guzergahlar.DataSource = guzergahlar;
            dataGridView_butun_guzergahlar.Columns[2].Visible =
                dataGridView_butun_guzergahlar.Columns[3].Visible =
                dataGridView_butun_guzergahlar.Columns[4].Visible =
                dataGridView_butun_guzergahlar.Columns[5].Visible = false;
        }

        private void Form_GuzergahDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_acik_mi = false;
        }

        int GuzergahID;
        private void dataGridView_butun_guzergahlar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            listView_secilenGuzergahSehirler.Items.Clear();
            GuzergahID = Convert.ToInt32(dataGridView_butun_guzergahlar.SelectedRows[0].Cells[0].Value);
            IEnumerable<string> GuzergahSehirler = from guzergahitem in ctx.GuzergahItems
                                   join sehir in ctx.Sehirlers on guzergahitem.GececegiIlID equals sehir.ID
                                   where guzergahitem.SeferID == GuzergahID
                                   select sehir.SehirAd;
            foreach (string item in GuzergahSehirler)
            {
                listView_secilenGuzergahSehirler.Items.Add(item);
            }
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Güzergah silinecek. Onaylamak için " + DialogResult.Yes.ToString() + " butonuna basın.", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                Guzergah guzergah = ctx.Guzergahs.Where(g => g.ID == GuzergahID).Select(g => g).Single();
                ctx.Guzergahs.DeleteOnSubmit(guzergah);

                IEnumerable<GuzergahItem> GuzergahItems = ctx.GuzergahItems.Where(gi => gi.SeferID == GuzergahID).Select(gi => gi);
                ctx.GuzergahItems.DeleteAllOnSubmit(GuzergahItems);

                IEnumerable<Seferler> seferler = ctx.Seferlers.Where(s => s.guzergahID == GuzergahID).Select(s => s);
                ctx.Seferlers.DeleteAllOnSubmit(seferler);

                foreach (Seferler item in seferler)
                {
                    IEnumerable<Biletler> biletler = ctx.Biletlers.Where(b=>b.SeferID==item.ID).Select(b=>b);
                    ctx.Biletlers.DeleteAllOnSubmit(biletler);

                    IEnumerable<DoluKoltuklar> doluKoltuklar = ctx.DoluKoltuklars.Where(d => d.SeferID == item.ID).Select(d => d);
                    ctx.DoluKoltuklars.DeleteAllOnSubmit(doluKoltuklar);
                }
                try
                {
                    ctx.SubmitChanges();
                    toolStripStatusLabel_bilgi.Text = "Güzergah başarı ile silindi.";
                    GuzergahlariCek();
                }
                catch (Exception ex)
                {
                    Form_ana_ekran.HataKaydi(ex);
                    toolStripStatusLabel_bilgi.Text = "Güzergah silinirken hata oluştu.";
                }
            }
        }

        private void dataGridView_butun_guzergahlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
