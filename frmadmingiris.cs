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
    public partial class frmadmingiris : Form
    {
        public frmadmingiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ONUR;Initial Catalog=Otel Uygulaması;Integrated Security=True");

        private void btngiris_Click(object sender, EventArgs e)
        {
            //veri tabanında yer alan kullanıcı adı:adminotel       şifre:12345
            if (txtkullaniciadi.Text == "" || txtsifre.Text == "")
            {
                MessageBox.Show("Lütfen texboxları boş geçmeyin");
            } 
            else
            {
                 try
            {
                baglanti.Open();
                string sql = "select * from AdminGiris where Kullanici=@Kullaniciadi AND Sifre=@Sifre";     //admin panelindeki şifre ve kullanıcı adımızı veri tabanından çekiyorum. 
                SqlParameter prm1 = new SqlParameter("Kullaniciadi", txtkullaniciadi.Text.Trim());          //kullanici adını alıyorum
                SqlParameter prm2 = new SqlParameter("Sifre", txtsifre.Text.Trim());                        //şifreyi çekiyorum.
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
               
                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    Anaform fr = new Anaform();
                    fr.Show();
                    this.Hide(); // gizleme
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş");
            }
            }
           
        }
    }
}
