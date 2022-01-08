using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class emanetKitapVerfrm : Form
    {
        public emanetKitapVerfrm()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J56TKVJ;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        private void grpKitapBilgileri_Enter(object sender, EventArgs e)
        {

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }


        private void sepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from TBLSepet", baglanti);
            adtr.Fill(daset, "TBLSepet");
            dataGridView1.DataSource = daset.Tables["TBLSepet"];
            baglanti.Close();


        }

        private void kitapSayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(bookCount) from TBLSepet", baglanti);
            lblKitapSayi.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();



        }

        private void emanetKitapVerfrm_Load(object sender, EventArgs e)
        {
            sepetListele();
            kitapSayisi();
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLSepet(barcodenNo,bookName,AUTHOR,PUBLISHER,numberOfPage,bookCount,alısTarihi,teslimTarihi) values (@barcodenNo,@bookName,@AUTHOR,@PUBLISHER,@numberOfPage,@bookCount,@alısTarihi,@teslimTarihi)", baglanti);

            komut.Parameters.AddWithValue("@barcodeNo", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@bookName", txtKitapAdı.Text);
            komut.Parameters.AddWithValue("@AUTHOR", txtYazar.Text);
            komut.Parameters.AddWithValue("@PUBLISHER", txtYayınevi.Text);
            komut.Parameters.AddWithValue("@numberOfPage", txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@bookCount", int.Parse(txtKitapSayisi.Text));
            komut.Parameters.AddWithValue("@alısTarihi", daTimPicAlis.Text);
            komut.Parameters.AddWithValue("@teslimTarihi", daTimPicTeslim.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap(lar) sepete eklendi.", "Ekleme işlemi");
            daset.Tables["TBLSepet"].Clear();
            sepetListele();

            lblKitapSayi.Text = "";
            kitapSayisi();

            foreach (Control item in grpKitapBilgileri.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtKitapSayisi)
                    {
                        item.Text = " ";
                    }
                }

            }





        }

        private void txtTCAra_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select from uyeEkle where TC like'" + txtTCAra.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {
                txtAdSoyad.Text = read["nameSurname"].ToString();
                
                txtYas.Text = read["AGE"].ToString();
                txtTelefon.Text = read["TELEPHONE"].ToString();
               
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(bookCount) from TBLEmanetKitap ", baglanti);
            lblKitapSayi.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();

            if (txtTCAra.Text == "")
            {
                foreach (Control item in grpUyeBilgileri.Controls)
                {
                    item.Text = "";
                   
                }
            }


    }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kitapEkle where BarkodNo like'"+txtBarkodNo.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while(read.Read())
            {
                txtKitapAdı.Text = read["bookName"].ToString();
                txtYazar.Text = read["AUTHOR"].ToString();
                txtYayınevi.Text = read["PUBLISHER"].ToString();
                txtSayfaSayisi.Text = read["numberOfPage"].ToString();
            
            }
            baglanti.Close();
            foreach (Control item in grpKitapBilgileri.Controls)
            {

                if(item is TextBox)
                {
                    if (item != txtKitapSayisi)
                    {
                        item.Text = "";

                    }
                }

            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from TBLSepet where barcodeNo= '"+dataGridView1.CurrentRow.Cells["barcodeNo"].Value.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Silme işlemi tamamlandı", "Silme işlemi");
            daset.Tables["TBLSepet"].Clear();
            sepetListele();

            lblKitapSayi.Text = "";
            kitapSayisi();

        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (lblKitapSayi.Text != "")
            {

                if (lblKayıtlıKitapAdi.Text == " " && int.Parse(lblKitapSayi.Text) <= 3 || lblKayıtlıKitapAdi.Text != "" && int.Parse(lblKayıtlıKitapAdi.Text) + int.Parse(lblKitapSayi.Text) <= 3)
                {

                    if (true) 
                    
                    {

                        lblKitapSayi.Text = "";
                        kitapSayisi();

                        //komut Satırları


                    }

                }
                else
                {
                    MessageBox.Show("Emanet kitap sayisi 3'ten fazla olamaz.", "Uyarı");

                }
            }


            else
            {
                MessageBox.Show("Önce sepete kitap ekleyiniz.", "Uyarı");

            }
           



        }
    } 
}
