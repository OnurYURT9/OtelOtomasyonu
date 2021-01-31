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
    public partial class Satislar : Form
    {
        public Satislar()
        {
            InitializeComponent();
        }

        private void Satislar_Load(object sender, EventArgs e)
        {

        }

        private void button1_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxoda101_KeyPress(object sender, KeyPressEventArgs e)
        {          
          e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);           
        }

        private void textBoxoda102_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBoxoda103_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxoda104_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBoxoda105_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxoda106_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBoxoda107_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBoxoda108_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void textBoxoda109_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ONUR;Initial Catalog=Otel Uygulaması;Integrated Security=True");
        // Oda 101 su ve çay servisleri
        private void button10_Click(object sender, EventArgs e) //oda101 su servisi
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select fiyatı from Satislar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                int su101;
                su101 = Convert.ToInt32(textBoxoda101.Text);
                int oku2;
                oku2 = Convert.ToInt32(oku);
                int sonuc = su101 * oku2;
                lbl101.Text = sonuc.ToString();
            }



            baglanti.Close();

        }

        private void button19_Click(object sender, EventArgs e) //oda101 çay servisi
        {
            baglanti.Open();
           
            baglanti.Close();
        }
    }
}
