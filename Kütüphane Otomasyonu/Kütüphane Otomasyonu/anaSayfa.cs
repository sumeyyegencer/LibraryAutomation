using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUyeEkleme uyeEkle = new frmUyeEkleme();
            uyeEkle.ShowDialog();
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyeListelemefrm uyeListele = new uyeListelemefrm();
            uyeListele.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnKitapEkleme_Click(object sender, EventArgs e)
        {
            KitapEklefrm kitapEkle = new KitapEklefrm();
            kitapEkle.ShowDialog();

        }

        private void btnKitapListeleme_Click(object sender, EventArgs e)
        {
            kitapListelemefrm kitapListeleme = new kitapListelemefrm();
            kitapListeleme.ShowDialog();

        }

   
    }
}
