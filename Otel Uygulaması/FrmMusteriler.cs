using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otel_Uygulaması
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ONUR;Initial Catalog=Otel Uygulaması;Integrated Security=True");
      
        private void verilerigoster()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["musteri_id"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            verilerigoster();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtTc.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOda.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi='" + txtAdi.Text + "' " +
                ",Soyadi='" + txtSoyadi.Text + "', Cinsiyet='" +comboBox1.Text+ "',Telefon='" + MskTxtTelefon.Text + "',Mail='" + TxtMail.Text + "'" +
                ",TC='" + TxtTc.Text + "',OdaNo='" + TxtOda.Text + "',Ucret='" + txtUcret.Text + "',GirisTarihi= '" + dtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi = '" + dtpCikisTarihi.Value.ToString("yyyy-MM-dd")+"' where musteri_id=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            listView1.Items.Clear();
            baglanti.Close();
            verilerigoster();
        }
        
        
        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle where musteri_id='"+listView1.SelectedItems[0].SubItems[0].Text+"'",baglanti);
            SqlCommand komut1 = new SqlCommand("delete from Oda101 where Adi='"+listView1.SelectedItems[0].SubItems[1].Text+"'",baglanti);
            SqlCommand komut2 = new SqlCommand("delete from Oda102 where Adi='" + listView1.SelectedItems[0].SubItems[1].Text + "'", baglanti);
            SqlCommand komut3 = new SqlCommand("delete from Oda103 where Adi='" + listView1.SelectedItems[0].SubItems[1].Text + "'", baglanti);
            SqlCommand komut4 = new SqlCommand("delete from Oda104 where Adi='" + listView1.SelectedItems[0].SubItems[1].Text + "'", baglanti);
            SqlCommand komut5 = new SqlCommand("delete from Oda105 where Adi='" + listView1.SelectedItems[0].SubItems[1].Text + "'", baglanti);
            SqlCommand komut6 = new SqlCommand("delete from Oda106 where Adi='" + listView1.SelectedItems[0].SubItems[1].Text + "'", baglanti);
            SqlCommand komut7 = new SqlCommand("delete from Oda107 where Adi='" + listView1.SelectedItems[0].SubItems[1].Text + "'", baglanti);
            SqlCommand komut8 = new SqlCommand("delete from Oda108 where Adi='" + listView1.SelectedItems[0].SubItems[1].Text + "'", baglanti);
            SqlCommand komut9 = new SqlCommand("delete from Oda109 where Adi='" + listView1.SelectedItems[0].SubItems[1].Text + "'", baglanti);

            komut.ExecuteNonQuery();
            komut1.ExecuteNonQuery();
            komut2.ExecuteNonQuery();
            komut3.ExecuteNonQuery();
            komut4.ExecuteNonQuery();
            komut5.ExecuteNonQuery();
            komut6.ExecuteNonQuery();
            komut7.ExecuteNonQuery();
            komut8.ExecuteNonQuery();
            komut9.ExecuteNonQuery();

            baglanti.Close();
            verilerigoster();

        }



        private void btnara_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            listView1.Items.Clear();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%"+textBoxisim.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["musteri_id"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
               

            }
            
            baglanti.Close();
        }
    }
}
//Data Source=ONUR;Initial Catalog="Otel Uygulaması";Integrated Security=True
