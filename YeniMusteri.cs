using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Otel_Uygulaması
{
    public partial class YeniMusteri : Form
    {
        public YeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ONUR;Initial Catalog=Otel Uygulaması;Integrated Security=True");



            


          private void btnOda101_Click(object sender, EventArgs e)        
        {
            TxtOda.Text = "101";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda101(Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void btnOda102_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102(Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void btnOda103_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda103(Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void btnOda104_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "104";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda104(Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void btnOda105_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "105";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105(Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void btnOda106_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "106";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda106(Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void btnOda107_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "107";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda107(Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void btnOda108_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "108";
            baglanti.Open();
          
            SqlCommand komut = new SqlCommand("insert into Oda108(Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void btnOda109_Click(object sender, EventArgs e)
        {
            TxtOda.Text = "109";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda109(Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void btnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli odalar boş odaları gösterir");
        }
        private void btnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli butonlar dolu odaları gösteririr");

        }
        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime KucukTarih = Convert.ToDateTime(dtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dtpCikisTarihi.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;
            label11.Text = Sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text) * 100;
            txtUcret.Text = ucret.ToString();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (txtAdi.Text == "" || txtSoyadi.Text=="" || MskTxtTelefon.Text=="" || TxtMail.Text=="" || TxtTc.Text=="" )
            {
                MessageBox.Show("Boş alanları doldurunuz");
            }
            else
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into MusteriEkle(Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('"
                    + txtAdi.Text + "','" + txtSoyadi.Text + "','" + comboBox1.Text + "','" + MskTxtTelefon.Text + "','" + TxtMail.Text + "','" + TxtTc.Text + "','"
                    + TxtOda.Text + "','" + txtUcret.Text + "','" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "', '" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", baglanti);
                
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri kaydı yapıldı");
            }
           

           
        }
        
        private void YeniMusteri_Load(object sender, EventArgs e)
        {
            //Oda 101  de boşluk doluluk kontrolleri
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                btnOda101.Text = "Dolu";
            }
            baglanti.Close();
            if (btnOda101.Text != "101")            //101 nolu oda doluysa seçilemesin ve rengi kırmızı olsun
            {
                btnOda101.Enabled = false;
                btnOda101.BackColor = Color.Red;
            }

            //Oda 102  de boşluk doluluk kontrolleri
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglanti);       //veritabanından 102 nolu odaya eriştik
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                btnOda102.Text = "Dolu";
            }
           
            if (btnOda102.Text != "102")    //102 nolu oda doluysa seçilemesin ve rengi kırmızı olsun
            {
                btnOda102.Enabled = false;
                btnOda102.BackColor = Color.Red;
            }
            baglanti.Close();
            //Oda 103  de boşluk doluluk kontrolleri
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                btnOda103.Text = "Dolu";
            }
            
            if (btnOda103.Text != "103")
            {
                btnOda103.Enabled = false;
                btnOda103.BackColor = Color.Red;
            }
            baglanti.Close();
            //Oda 104  de boşluk doluluk kontrolleri
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                btnOda104.Text = "Dolu";
            }
            baglanti.Close();
            if (btnOda104.Text != "104")
            {
                btnOda104.Enabled = false;
                btnOda104.BackColor = Color.Red;
            }

            //Oda 105  de boşluk doluluk kontrolleri
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                btnOda105.Text = "Dolu";
            }
            baglanti.Close();
            if (btnOda105.Text != "105")
            {
                btnOda105.Enabled = false;
                btnOda105.BackColor = Color.Red;
            }


            //Oda 106  de boşluk doluluk kontrolleri
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                btnOda106.Text = "Dolu";
            }
            baglanti.Close();
            if (btnOda106.Text != "106")
            {
                btnOda106.Enabled = false;
                btnOda106.BackColor = Color.Red;
            }

            //Oda 107  de boşluk doluluk kontrolleri
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                btnOda107.Text = "Dolu";
            }
            baglanti.Close();
            if (btnOda107.Text != "107")
            {
                btnOda107.Enabled = false;
                btnOda107.BackColor = Color.Red;
            }

            //Oda 108  de boşluk doluluk kontrolleri
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                btnOda108.Text = "Dolu";
            }
            baglanti.Close();
            if (btnOda108.Text != "108")
            {
                btnOda108.Enabled = false;
                btnOda108.BackColor = Color.Red;
            }

            //Oda 109  de boşluk doluluk kontrolleri
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
               
                btnOda109.Text = "Dolu";
            }
            baglanti.Close();
            if (btnOda109.Text != "109")
            {
                btnOda109.Enabled = false;
                btnOda109.BackColor = Color.Red;
            }
        }
        
        private void txtAdi_TextChanged(object sender, EventArgs e)
        {
        }

        private void TxtTc_KeyPress(object sender, KeyPressEventArgs e)
        {

                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void MskTxtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
    
}
//Data Source=ONUR;Initial Catalog="Otel Uygulaması";Integrated Security=True