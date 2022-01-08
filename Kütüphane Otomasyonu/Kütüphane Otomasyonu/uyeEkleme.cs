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
    public partial class frmUyeEkleme : Form
    {
        public frmUyeEkleme()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUyeEkleme_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J56TKVJ;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();   //Tıklandığında bulunduğu sayfadan çıkılacak.
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into uyeEkle(TC,nameSurname,AGE,GENDER,TELEPHONE,ADDRESS,EMAIL,readingCount) values (@TC,@nameSurname,@AGE,@GENDER,@TELEPHONE,@ADDRESS,@EMAIL,@readingCount)", baglanti);


            komut.Parameters.AddWithValue("@TC", txtTC.Text);
            komut.Parameters.AddWithValue("@nameSurname", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@AGE", txtYas.Text);   
            komut.Parameters.AddWithValue("@GENDER", comboCinsiyet.Text);
            komut.Parameters.AddWithValue("@TELEPHONE", txtTel.Text);
            komut.Parameters.AddWithValue("@ADDRESS", txtAdres.Text);
            komut.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
            komut.Parameters.AddWithValue("@readingCount", txtOkunanSayi.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye kayıt işlemi yapıldı.");


            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtOkunanSayi)
                    {
                        item.Text = "";
                    }
                }
            }

            this.Close();
        }

        private void comboCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
           //string tc = txtTC.Text;



        }
    }
    }

