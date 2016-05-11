using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using otobus_otomasyon_linq.Properties;

namespace otobus_otomasyon_linq
{
    public partial class Form_biletSatis : Form
    {
        public Form_biletSatis()
        {
            InitializeComponent();
        }

        VeriTabaniIslemleriDataContext ctx;
        public static bool form_acik_mi;
        private void button_yolcuyuSorgula_Click(object sender, EventArgs e)
        {
            try
            {
                yolcuID = Convert.ToInt32(textBox_yolcuID.Text);
                Musteriler musteri = ctx.Musterilers.Where(m => m.ID == yolcuID).Select(m => m).First();
                textBox_yolcuAd.Text = musteri.Ad;
                textBox_yolcuSoyad.Text = musteri.Soyad;
                comboBox_cinsiyet.SelectedIndex = Convert.ToInt32(musteri.Cinsiyet);
            }
            catch (Exception ex)
            {
                Form_ana_ekran.HataKaydi(ex);
                toolStripStatusLabel_islemstatu.Text = "Arama sırasında bir hata ile karşılaşıldı.";
            }
        }

        private void Form_biletSatis_Load(object sender, EventArgs e)
        {
            form_acik_mi = true;

            //Koltuk İsimlerini yaz
           
            ctx = new VeriTabaniIslemleriDataContext();

            IEnumerable<Guzergah> guzergahlar = from g in ctx.Guzergahs
                                                let i = from gi in ctx.GuzergahItems
                                                        where gi.GececegiIlID == Form_ana_ekran.sube_il_id
                                                        select gi.SeferID
                                                where i.Contains(g.ID)
                                                orderby g.Tanim
                                                select g;
            comboBox_guzergah.DataSource = guzergahlar;
        }



        /// <summary>
        /// Sefer seçildikten sonra sisteme kayıtlı o sefere ait koltuklar çekilip bir listeye alınır. daha sonra otobüse ait bütün koltuk numaraları bu liste üzerinden sorgulanır. eğer koltuk numarası listede varsa satışı yapılmış anlamı taşır ve pasif hale getirlir.
        /// </summary>
        private void comboBox_sefer_SelectedIndexChanged(object sender, EventArgs e)
        {

            ucret = Convert.ToDouble((comboBox_sefer.SelectedItem as Seferler).BiletTutar);
            comboBox_koltukNo.Items.Clear();
            seferID = (comboBox_sefer.SelectedItem as Seferler).ID;
            textBox_ucret.Text = "";
            //textBox_ucret.Text = (comboBox_sefer.SelectedItem as Seferler).BiletTutar.ToString();

            DoluKoltuklar koltuk = new DoluKoltuklar();
            koltuk.BinisSehirID = Form_ana_ekran.sube_il_id;
            koltuk.SeferID = seferID;

            int OtobusID = (comboBox_sefer.SelectedItem as Seferler).OtobusID;
            int koltukSayisi = ctx.Otobuslers.Where(o => o.ID == OtobusID).Select(o => o.KoltukSayisi).First();
            IEnumerable<int> doluKoltuk = from d in ctx.DoluKoltuklars
                                          where d.BinisSehirID == koltuk.BinisSehirID &&
                                                d.SeferID == koltuk.SeferID
                                          select d.KoltukID;


            List<int> doluKoltuklar = doluKoltuk.ToList();

            //bilet sorgu düzelt
            for (int i = 1; i <= koltukSayisi; i++)
            {
                if (!doluKoltuklar.Contains(i))
                {
                    comboBox_koltukNo.Items.Add(i);
                    string button = "_" + i;
                    panel_koltuklar.Controls[button].BackColor = Color.Green;
                    panel_koltuklar.Controls[button].Enabled = true;
                }
                else
                {
                    bool cinsiyet = ctx.Biletlers.Where(b => (b.KultukNo == i && b.SeferID == koltuk.SeferID)).Select(c => c.YolcuCinsiyet).First();
                    string button = "_" + i;
                    panel_koltuklar.Controls[button].Enabled = false;
                    if (cinsiyet )
                    {
                        panel_koltuklar.Controls[button].BackColor = Color.Pink;
                    }
                    else
                    {
                        panel_koltuklar.Controls[button].BackColor = Color.Blue;
                    }
                }
                        
            }
        }

        DataTable dt_binis_sehirleri = new DataTable();
        DataTable dt_inis_sehirleri = new DataTable();
        private int yolcuID;
        private int guzergahID;
        private int binisSehri_item;
        private int inisSehri_item;
        private int seferID;
        private double ucret;
        private void comboBox_guzergah_SelectedIndexChanged(object sender, EventArgs e)
        {
            guzergahID = (comboBox_guzergah.SelectedItem as Guzergah).ID;
            IEnumerable<Seferler> seferler = ctx.Seferlers.Where(s => s.guzergahID == guzergahID).OrderBy(s=>s.KalkisZamani).Select(s => s);
            comboBox_sefer.DataSource = seferler;

          
            var binis_s = from sehir in ctx.Sehirlers
                          join guzergahitem in ctx.GuzergahItems on sehir.ID equals guzergahitem.GececegiIlID
                          where guzergahitem.SeferID == guzergahID && sehir.ID==Form_ana_ekran.sube_il_id
                          orderby sehir.SehirAd
                          select new
                          {
                              sehir.SehirAd,
                              guzergahitem.ID,
                              guzergahitem.GececegiIlID,
                          };
            if (dt_binis_sehirleri.Columns.Count ==0 )
            {
                dt_binis_sehirleri.Columns.Add("sehirID");
                dt_binis_sehirleri.Columns.Add("sehirAd");
                dt_binis_sehirleri.Columns.Add("ID");
            }
            dt_binis_sehirleri.Rows.Clear();
            int b_guzergahid = 0;
            foreach (var item in binis_s)
            {
                dt_binis_sehirleri.Rows.Add(item.GececegiIlID, item.SehirAd, item.ID);
                b_guzergahid = item.ID;
            }

            comboBox_binisSehir.DataSource = dt_binis_sehirleri;
            comboBox_binisSehir.DisplayMember = "sehirAd";

            var inis_s = from sehir in ctx.Sehirlers
                          join guzergahitem in ctx.GuzergahItems on sehir.ID equals guzergahitem.GececegiIlID
                          where guzergahitem.SeferID == guzergahID && guzergahitem.ID > b_guzergahid
                          orderby sehir.SehirAd
                          select new
                          {
                              sehir.SehirAd,
                              guzergahitem.ID,
                              guzergahitem.GececegiIlID,
                          };

            if (dt_inis_sehirleri.Columns.Count == 0)
            {
                dt_inis_sehirleri.Columns.Add("sehirID");
                dt_inis_sehirleri.Columns.Add("sehirAd");
                dt_inis_sehirleri.Columns.Add("ID");
            }

            dt_inis_sehirleri.Rows.Clear();
            foreach (var item in inis_s)
            {
                dt_inis_sehirleri.Rows.Add(item.GececegiIlID, item.SehirAd, item.ID);

            }

            comboBox_inisSehir.DataSource = dt_inis_sehirleri;
            comboBox_inisSehir.DisplayMember = "sehirAd";
        }

        private void comboBox_binisSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox_binisSehir.SelectedIndex;
            if(index >= 0)
            binisSehri_item = Convert.ToInt32(dt_binis_sehirleri.Rows[index].ItemArray[2]);
        }

        private void comboBox_inisSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox_inisSehir.SelectedIndex;
            if(index >= 0)
            inisSehri_item = Convert.ToInt32(dt_inis_sehirleri.Rows[index].ItemArray[2]);
            int toplam_sehir = ctx.GuzergahItems.Where(g => g.SeferID == guzergahID).Count(g => g.ID > 0) - 1;
            int gececegi_sehr = ctx.GuzergahItems.Where(g => g.ID >= binisSehri_item && g.ID < inisSehri_item).Count(g => g.ID > 0);
            double biletucret = ((double)gececegi_sehr / toplam_sehir) * ucret;
            textBox_ucret.Text = biletucret.ToString();
        }

        private void button_satisYap_Click(object sender, EventArgs e)
        {
            Biletler bilet = new Biletler();
            int binisSehirID =Convert.ToInt32(dt_binis_sehirleri.Rows[comboBox_binisSehir.SelectedIndex].ItemArray[0]);
            bilet.BinisSehirID = binisSehirID;
            int inisSehirID = Convert.ToInt32(dt_inis_sehirleri.Rows[comboBox_inisSehir.SelectedIndex].ItemArray[0]);
            bilet.InisSehirID = inisSehirID;
            try
            {
                bilet.YolcuID = Convert.ToInt32(textBox_yolcuID.Text.Trim());
            }
            catch (Exception) { }

            bilet.SeferID = (comboBox_sefer.SelectedItem as Seferler).ID;
            bilet.SatisMiRezarvasyonMu = radioButton_satis.Checked;
            int koltukNo = Convert.ToInt32(comboBox_koltukNo.SelectedItem);
            bilet.KultukNo = Convert.ToByte(koltukNo);
            bilet.YolcuCinsiyet = Convert.ToBoolean(comboBox_cinsiyet.SelectedIndex);
            bilet.YolcuAd = textBox_yolcuAd.Text.Trim().ToUpper();
            bilet.YolcuSoyad = textBox_yolcuSoyad.Text.Trim().ToUpper();
            bilet.SatisTip = radioButton_nakit.Checked;
            decimal ucret = Convert.ToDecimal(textBox_ucret.Text);
            bilet.Ucret = ucret;
            bilet.IslemZaman = DateTime.Now;
            bilet.IslemYapanPersonelID = Form_ana_ekran.calisan_id;
            try
            {
                ctx.Biletlers.InsertOnSubmit(bilet);
                ctx.SubmitChanges();

                int sonBiletID = ctx.Biletlers.Where(b => (b.SeferID == bilet.SeferID && b.KultukNo == bilet.KultukNo)).Select(b => b.ID).First();

                int inis = Convert.ToInt32(dt_inis_sehirleri.Rows[comboBox_inisSehir.SelectedIndex].ItemArray[2]);
                int binis = Convert.ToInt32(dt_binis_sehirleri.Rows[comboBox_binisSehir.SelectedIndex].ItemArray[2]);

                for (int i = binis; i < inis; i++)
                {
                    DoluKoltuklar doldur = new DoluKoltuklar();
                    int sehirID = ctx.GuzergahItems.Where(g => g.ID == i).Select(g => g.GececegiIlID).First();
                    doldur.BinisSehirID = ctx.Subelers.Where(s => s.SehirID == sehirID).Select(s => s.SehirID).First();
                    doldur.SeferID = seferID;
                    doldur.KoltukID = koltukNo;
                    doldur.BiletNo = sonBiletID;
                    ctx.DoluKoltuklars.InsertOnSubmit(doldur);
                    ctx.SubmitChanges();
                }

                toolStripStatusLabel_islemstatu.Text = "Bilet satışı yapıldı";
            }
            catch (Exception ex)
            {
                Form_ana_ekran.HataKaydi(ex);
                toolStripStatusLabel_islemstatu.Text = "Bilet satışı başarısız";
            }

            //Boş dolu koltuklar yeniden düzenleniyor
            comboBox_sefer_SelectedIndexChanged(null, null);
        }

        private void _1_Click(object sender, EventArgs e)
        {
            Button tiklananButon = sender as Button;
            string tiklanan = tiklananButon.Text;
            foreach (var item in comboBox_koltukNo.Items)
            {
                if (item.ToString() == tiklanan)
                {
                    comboBox_koltukNo.SelectedItem = item;
                    return;
                }
            }
        }

       
    }
}
