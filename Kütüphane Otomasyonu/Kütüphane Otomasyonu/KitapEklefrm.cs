using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kütüphane_Otomasyonu
{
    public partial class KitapEklefrm : Form
    {
        public KitapEklefrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J56TKVJ;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void KitapEklefrm_Load(object sender, EventArgs e)
        {

        }

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kitapEkle(barcodeNo,bookName,AUTHOR,PUBLISHER,numberOfPage,TYPE,numberOfStock,shelfNumber,DESCRIPTION,dateOfRegistration) values (@barcodeNo,@bookName,@AUTHOR,@PUBLISHER,@numberOfPage,@TYPE,@numberOfStock,@shelfNumber,@DESCRIPTION,@dateOfRegistration)", baglanti);


            komut.Parameters.AddWithValue("@barcodeNo", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@bookName", txtKitapAdı.Text);
            komut.Parameters.AddWithValue("@AUTHOR", txtYazar.Text);
            komut.Parameters.AddWithValue("@PUBLISHER", txtYayınevi.Text);
            komut.Parameters.AddWithValue("@numberOfPage", txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@TYPE", comboTür.Text);
            komut.Parameters.AddWithValue("@numberOfStock", txtStokSayisi.Text);
            komut.Parameters.AddWithValue("@shelfNumber", txtRafNo.Text);
            komut.Parameters.AddWithValue("@DESCRIPTION", txtAciklama.Text);
            komut.Parameters.AddWithValue("@dateOfRegistration", DateTime.Now.ToShortDateString());

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap kayıt işlemi tamamlandı.");


            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                       item.Text = "";
                    
                }
            }

            this.Close();
        }
    }
    }

