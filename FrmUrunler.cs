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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ONUR;Initial Catalog=Otel Uygulaması;Integrated Security=True");
        private void veriler()
        {
            Listviewitem.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Alinan", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Temel_Gıda"].ToString();
                ekle.SubItems.Add(oku["İçecek"].ToString());
                ekle.SubItems.Add(oku["Atıştırmalık"].ToString());

                Listviewitem.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
           
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Alinan(Temel_Gıda,İçecek,Atıştırmalık) values ('" + txtgidalar.Text + "','" + txtiçecek.Text + "','" + txtatistirmalik.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
           
        }

        private void Listviewitem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            veriler();
        }
    }
}
