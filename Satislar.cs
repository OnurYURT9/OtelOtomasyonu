using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO: Bu kod satırı 'otel_UygulamasıDataSet.Satislar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.satislarTableAdapter.Fill(this.otel_UygulamasıDataSet.Satislar);

        }
    }
}
