using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using otobus_otomasyon_linq.Properties;

namespace otobus_otomasyon_linq
{
    public partial class Form_kullanici_girisi : Form
    {
        static public bool acik_mi = false;

        public Form_kullanici_girisi()
        {
            InitializeComponent();
   
        }

        private void Form_kullanici_girisi_Load(object sender, EventArgs e)
        {
            acik_mi = true;
        }

        private void Form_kullanici_girisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            acik_mi = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici_adi = textBox_kullaniciAdi.Text;
            string sifre = textBox_sifre.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=BATMAN\SAIT;Initial Catalog=bilsam;Integrated Security=True");
            SqlCommand komut = new SqlCommand("SELECT C.ID, C.Ad, C.Soyad, S.ID, S.SubeAd, S.SehirID FROM Calisanlar C JOIN Subeler S ON C.SubeID = S.ID WHERE C.KullaniciAd = @Kullanici AND C.Sifre = @sifre", conn);
            komut.Parameters.AddWithValue("@Kullanici", kullanici_adi);
            komut.Parameters.AddWithValue("@sifre", sifre);
            conn.Open();
            SqlDataReader reader = komut.ExecuteReader();
            if (!reader.HasRows)
		    {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış girildi.\nLütfen kontrol ederek tekrar deneyiniz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (reader.Read())
            {
                Form_ana_ekran.calisan_id = reader.GetInt32(0);
                Form_ana_ekran.calisan_ad = reader.GetString(1);
                Form_ana_ekran.calisan_soyad = reader.GetString(2);
                Form_ana_ekran.sube_id = reader.GetInt32(3);
                Form_ana_ekran.sube_ad = reader.GetString(4);
                Form_ana_ekran.sube_il_id = reader.GetInt32(5);
                this.MdiParent.Text += " (" + Form_ana_ekran.sube_ad + ")";
                this.Close();
            }
            conn.Close();
        }

    }
}
