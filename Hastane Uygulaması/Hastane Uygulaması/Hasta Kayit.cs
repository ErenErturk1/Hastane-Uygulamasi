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

namespace Hastane_Uygulaması
{
    public partial class Hasta_Kayit : Form
    {
        public Hasta_Kayit()
        {
            InitializeComponent();
        }
        baglantiSinif snf= new baglantiSinif();
        private void Hasta_Kayit_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(snf.adres);
            connection.Open();
            txtAd.Focus();
            txtYakiniTel.Text = "0";
            txtTel.Text = "0";
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTC.Text = "";
            txtTel.Text = "0";
            txtHastalık.Text = "";
            txtYakiniTel.Text = "0";
            txtHastaNo.Text = "";
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(snf.adres);
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtTC.Text != "" && txtTel.Text != "" && txtHastalık.Text != "" && txtYakiniTel.Text != "" && txtHastaNo.Text != "")
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    SqlCommand command = new SqlCommand("INSERT INTO HastaBilgi(isim,soyisim,tc,tel,yakinitel,hastalık,hastaNumarasi) values (@isim,@soyisim,@tc,@tel,@yakinitel,@hastalık,@hastaNumarasi)", connection);

                    command.Parameters.AddWithValue("@isim", txtAd.Text);
                    command.Parameters.AddWithValue("@soyisim", txtSoyad.Text);
                    command.Parameters.AddWithValue("@tc", txtTC.Text);
                    command.Parameters.AddWithValue("@tel", txtTel.Text);
                    command.Parameters.AddWithValue("@yakinitel", txtYakiniTel.Text);
                    command.Parameters.AddWithValue("@hastalık", txtHastalık.Text);
                    command.Parameters.AddWithValue("@hastaNumarasi", txtHastaNo.Text);

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
                txtHastalık.Text = "";
                txtYakiniTel.Text = "0";
                txtHastaNo.Text = "";
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
