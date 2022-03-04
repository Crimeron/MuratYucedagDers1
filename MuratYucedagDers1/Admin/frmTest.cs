using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuratYucedagDers1.Admin
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            int sayi,sonuc;
            sayi = Convert.ToInt32(textBox1.Text);
            sonuc = sayi * sayi;
            label1.Text = sonuc.ToString();
        }

        private void btnTekCift_Click(object sender, EventArgs e)
        {
            int sayi, sonuc;
            sayi =Convert.ToInt32(textBox1.Text);
            if(sayi%2 == 0)
            {
                label2.Text = "Çift";
            }
            else
            {
                label2.Text = "Tek";
            }
        }

        private void btnBasamak_Click(object sender, EventArgs e)
        {
        }

        private void btnBakteri_Click(object sender, EventArgs e)
        {
            int sayi, toplambakteri,i;
            sayi = 1;
            for (i = 0; i < 24; i++)
            {
                sayi += sayi;
            }
            label3.Text = sayi.ToString();
        }
    }
}
