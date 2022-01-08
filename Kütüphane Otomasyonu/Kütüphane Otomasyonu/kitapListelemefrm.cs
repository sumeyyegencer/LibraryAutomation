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
    public partial class kitapListelemefrm : Form
    {
        public kitapListelemefrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-J56TKVJ;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");


        DataSet daset = new DataSet();

        private void kitapListele()

        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from kitapEkle", baglanti);
            adtr.Fill(daset, "kitapEkle");
            KgridListe.DataSource = daset.Tables["kitapEkle"];

            baglanti.Close();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bu kaydı silmek istedeğinize emin misiniz ?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {

                baglanti.Open();
                SqlCommand komut = new SqlCommand(" delete from kitapEkle where barcodeNo=@barcodeNo", baglanti);
                komut.Parameters.AddWithValue("@barcodeNo", KgridListe.CurrentRow.Cells["barcodeNo"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Silme işlemi gerçekleşti");
                daset.Tables["uyeEkle"].Clear();
                kitapListele();
            }

        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update kitapEkle set bookName=@bookName,AUTHOR=@AUTHOR,PUBLISHER=@PUBLISHER,numberOfPage=@numberOfPage,TYPE=@TYPE,numberOfStock=@numberOfStock,shelfNumber=@shelfNumber,DESCRIPTION=@DESCRIPTION,dateOfRegistration=@dateOfRegistration where barcodeNo=@barcodeNo", baglanti);

            komut.Parameters.AddWithValue("@barcodeNo", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@bookName", txtKitapAdı.Text);
            komut.Parameters.AddWithValue("@AUTHOR", txtYazar.Text);
            komut.Parameters.AddWithValue("@PUBLISHER", txtYayınevi.Text);
            komut.Parameters.AddWithValue("@numberOfPage", txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@TYPE", comboTür.Text);
            komut.Parameters.AddWithValue("@numberOfStock", txtStokSayisi.Text);
            komut.Parameters.AddWithValue("@shelfNumber", txtRafNo.Text);
            komut.Parameters.AddWithValue("@DESCRIPTION", txtAciklama.Text);
           

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi gerçekleşti.");

            daset.Tables["kitapEkle"].Clear();
            kitapListele();

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = " ";

                }
            }

        }



        private void kitapListelemefrm_Load(object sender, EventArgs e)
        {
            kitapListele();
        }


        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["kitapEkle"].Clear();

            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(" select * from kitapEkle where TC like '%" + txtBarkodAra.Text + "%' ", baglanti);
            adtr.Fill(daset,"kitapEkle");
            KgridListe.DataSource = daset.Tables["kitapEkle"];

            baglanti.Close();

        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" select * from kitapEkle where TC like '" + txtBarkodAra.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read())
            {

                txtKitapAdı.Text = read["bookName"].ToString();
                txtYazar.Text = read["AUTHOR"].ToString();
                txtYayınevi.Text = read["PUBLISHER"].ToString();
                txtSayfaSayisi.Text = read["numberOfPage"].ToString();
                comboTür.Text = read["TYPE"].ToString();
                txtStokSayisi.Text = read["numberOfStock"].ToString();
                txtRafNo.Text = read["shelfNumber"].ToString();
                txtAciklama.Text = read["DESCRIPTION"].ToString();

            }

            baglanti.Close();
        }
    }
    }
    

