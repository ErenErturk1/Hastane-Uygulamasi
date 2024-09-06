using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Uygulaması
{
    public partial class Rezervasyon_Kayit : Form
    {
        public Rezervasyon_Kayit()
        {
            InitializeComponent();
        }
        baglantiSinif bgl = new baglantiSinif();
        private void btnSil_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTC.Text = "";
            txtHastane.Text = "";
            dateTimePicker1.Text = "";
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Ana_Sayfa sayfa = new Ana_Sayfa();
            sayfa.Show();
            this.Hide();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);

            if (txtAd.Text != "" && txtSoyad.Text != "" && txtTC.Text != "" && txtHastane.Text != "")
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    DateTime dt = dateTimePicker1.Value;

                    SqlCommand command = new SqlCommand("INSERT INTO RezervasyonIslemi(ad,soyad,tc,hastane,rezerveTarihi) values (@ad,@soyad,@tc,@hastane,@rezerveTarihi)", connection);

                    command.Parameters.AddWithValue("@ad", txtAd.Text);
                    command.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    command.Parameters.AddWithValue("@tc", txtTC.Text);
                    command.Parameters.AddWithValue("@hastane", txtHastane.Text);
                    command.Parameters.AddWithValue("@rezerveTarihi", dt);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Rezervasyon Başarıyla Oluşturuldu!", "Rezervasyon Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("Rezervasyon Oluşturulamadı!", "Rezervasyon Durumu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtTC.Text = "";
                txtHastane.Text = "";
                dateTimePicker1.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Atlamadan Yeniden Deneyin!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Rezervasyon_Kayit_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
            txtAd.Focus();
        }
    }
}
