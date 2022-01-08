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
    public partial class uyeListelemefrm : Form
    {
        public uyeListelemefrm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        // ARAMA İŞLEMİ
        DataSet daset = new DataSet(); // KAYITLARI GEÇİCİ OLARAK TUTACAĞIMIZ TABLO.
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["uyeEkle"].Clear();

            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(" select * from uyeEkle where TC like '"+txtAra.Text+ "'",baglanti);
            adtr.Fill(daset,"uyeEkle");
            gridListe.DataSource = daset.Tables["uyeEkle"];

            baglanti.Close();

        }

        private void gridListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTC.Text = gridListe.CurrentRow.Cells["TC"].Value.ToString();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J56TKVJ;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" select * from uyeEkle where TC like '"+txtTC.Text+ "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {

                txtAdSoyad.Text = read["nameSurname"].ToString();
                txtYas.Text = read["AGE"].ToString();
                comboCinsiyet.Text = read["GENDER"].ToString();
                txtTel.Text = read["TELEPHONE"].ToString();
                txtAdres.Text = read["ADDRESS"].ToString();
                txtEmail.Text = read["EMAIL"].ToString();
                txtOkunanSayi.Text = read["readingCount"].ToString();

            }

            baglanti.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        //SİLME İŞLEMİ
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek istedeğinize emin misiniz ?","Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {

            baglanti.Open();
            SqlCommand komut = new SqlCommand(" delete from uyeEkle where TC=@TC", baglanti);
            komut.Parameters.AddWithValue("@TC",gridListe.CurrentRow.Cells["TC"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();


            MessageBox.Show("Silme işlemi gerçekleşti");
            daset.Tables["uyeEkle"].Clear();
            uyeListele();

            foreach (Control item in Controls)
            {
                if(item is TextBox)
                {
                    item.Text = " ";

                }
            }
            }
        }

        // LİSTELEME İŞLEMİ
        private void uyeListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from uyeEkle", baglanti);
            adtr.Fill(daset, "uyeEkle");
            gridListe.DataSource = daset.Tables["uyeEkle"];

            baglanti.Close();


;        }

        private void uyeListelemefrm_Load(object sender, EventArgs e)
        {
            uyeListele();
        }


        // GÜNCELLEME İŞLEMİ
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" Update uyeEkle set nameSurname=@nameSurname, AGE=@AGE, GENDER=@GENDER, TELEPHONE=@TELEPHONE,ADDRESS=@ADDRESS, EMAIL=@EMAIL, readingCount=@readingCount where TC=@TC", baglanti);
            
            komut.Parameters.AddWithValue("@TC", txtTC.Text);     
            komut.Parameters.AddWithValue("@nameSurname", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@AGE", txtYas.Text);
            komut.Parameters.AddWithValue("@GENDER", comboCinsiyet.Text);
            komut.Parameters.AddWithValue("@TELEPHONE", txtTel.Text);
            komut.Parameters.AddWithValue("@ADDRESS", txtAdres.Text);
            komut.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
            komut.Parameters.AddWithValue("@readingCount", int.Parse(txtOkunanSayi.Text));

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleşti.");

            daset.Tables["uyeEkle"].Clear();
            uyeListele();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = " ";

                }
            }

        }
    }
}
