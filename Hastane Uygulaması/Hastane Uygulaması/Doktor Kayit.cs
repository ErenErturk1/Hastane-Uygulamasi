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

namespace Hastane_Uygulaması
{
    public partial class Doktor_Kayit : Form
    {
        public Doktor_Kayit()
        {
            InitializeComponent();
        }
        baglantiSinif snf = new baglantiSinif();
        private void btnSil_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTC.Text = "";
            txtTel.Text = "0";
            txtBrans.Text = "";
            txtNo.Text = "";
        }
       
        private void Doktor_Kayit_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(snf.adres);
            connection.Open();
            txtAd.Focus();
            txtTel.Text = "0";
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(snf.adres);
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtTC.Text != "" && txtTel.Text != "" && txtBrans.Text != "" && txtNo.Text != "")
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    SqlCommand command = new SqlCommand("INSERT INTO DoktorBilgi(ad,soyad,tc,tel,brans,doktorNumarasi) values (@ad,@soyad,@tc,@tel,@brans,@doktorNumarasi)", connection);

                    command.Parameters.AddWithValue("@ad", txtAd.Text);
                    command.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    command.Parameters.AddWithValue("@tc", txtTC.Text);
                    command.Parameters.AddWithValue("@tel", txtTel.Text);
                    command.Parameters.AddWithValue("@brans", txtBrans.Text);
                    command.Parameters.AddWithValue("@doktorNumarasi", txtNo.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı!", "Kayıt Ekleme İşlemi Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("Kayıt Ekleme İşlemi Başarısız Oldu!", "Kayıt Ekleme İşlemi Durumu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtTC.Text = "";
                txtTel.Text = "0";
                txtBrans.Text = "";
                txtNo.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Atlamadan Yeniden Deneyin!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Ana_Sayfa sayfa = new Ana_Sayfa();
            sayfa.Show();
            this.Hide();
        }
    }
}
