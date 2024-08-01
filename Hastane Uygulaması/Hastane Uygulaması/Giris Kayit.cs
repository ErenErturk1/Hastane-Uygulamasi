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
    public partial class Giris_Kayit : Form
    {
        public Giris_Kayit()
        {
            InitializeComponent();
        }
        baglantiSinif bgl = new baglantiSinif();
        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Ana_Sayfa ana = new Ana_Sayfa();
            ana.Show();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            txtID.Text="";
            txtSifre.Text = "";
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            if (txtID.Text != "" && txtSifre.Text != "")
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    SqlCommand command = new SqlCommand("INSERT INTO GirisIslemi(ID,Sifre) values (@ID,@Sifre)", connection);

                    command.Parameters.AddWithValue("@ID", txtID.Text);
                    command.Parameters.AddWithValue("@Sifre", txtSifre.Text);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Kayıt Ekleme İşlemi Başarılı!", "Kayıt Ekleme İşlemi Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("Kayıt Ekleme İşlemi Başarısız Oldu!", "Kayıt Ekleme İşlemi Durumu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtID.Text = "";
                txtSifre.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen Atlamadan Yeniden Deneyin!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Giris_Kayit_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
            txtID.Focus();
        }
    }
}
