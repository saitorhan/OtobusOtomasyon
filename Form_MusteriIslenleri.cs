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
    public partial class Form_MusteriIslenleri : Form
    {
        private VeriTabaniIslemleriDataContext ctx;
        public static bool form_acik_mi;
        public Form_MusteriIslenleri()
        {
            InitializeComponent();
        }

        private void Form_MusteriIslenleri_Load(object sender, EventArgs e)
        {
            form_acik_mi = true;
            ctx = new VeriTabaniIslemleriDataContext();
        }

        private void Form_MusteriIslenleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_acik_mi = false;
        }

        private void button__ara_Click(object sender, EventArgs e)
        {
            Musteriler musteri = null;
            try
            {
                int musteriID = Convert.ToInt32(textBox_ID.Text);
                musteri = ctx.Musterilers.Where(m => m.ID == musteriID).Select(m => m).Single();
                Form_musteriKayitAl musteriKaydi = new Form_musteriKayitAl(musteri);
                foreach (Form item in this.MdiParent.MdiChildren)
                {
                    if (item.Text==musteriKaydi.Text)
                    {
                        item.Close();
                        musteriKaydi.MdiParent = this.MdiParent;
                        musteriKaydi.Show();
                        this.Close();
                        return;
                    }
                }

                musteriKaydi.MdiParent = this.MdiParent;
                musteriKaydi.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                Form_ana_ekran.HataKaydi(ex);
                toolStripStatusLabel_bilgi.Text="Aranan müşteri bulunamadı";
            }
        }
    }
}