using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Otel_Uygulaması
{
    public partial class frmgelirgider : Form
    {
        public frmgelirgider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ONUR;Initial Catalog=Otel Uygulaması;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            lblpersonelmaas.Text = (personel * 3000).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(labelkasa.Text) - (Convert.ToInt32(lblpersonelmaas.Text) + Convert.ToInt32(lblalınanurun1.Text) + Convert.ToInt32(lblalınanurun2.Text) + Convert.ToInt32(lblalınanurun3.Text));
            labelsonuc.Text = sonuc.ToString();

        }

        private void frmgelirgider_Load(object sender, EventArgs e)
        {
            //Kasadaki tutar
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                labelkasa.Text = oku["toplam"].ToString();

            }
            baglanti.Close();
            
            
            //Gıdaların giderleri
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(Temel_Gıda) as toplam1 from Urunler", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblalınanurun1.Text = oku2["toplam1"].ToString();

            }
            baglanti.Close();
            
            
            //İçeceklerin giderleri
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(İçecek) as toplam2 from Urunler", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblalınanurun2.Text = oku3["toplam2"].ToString();

            }
            baglanti.Close();

            //Atıştırmalık giderleri
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Atıştırmalık) as toplam3 from Urunler", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblalınanurun3.Text = oku4["toplam3"].ToString();

            }
            baglanti.Close();






            
        }
    }
}
