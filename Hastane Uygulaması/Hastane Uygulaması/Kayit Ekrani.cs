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
    public partial class Kayit_Ekrani : Form
    {
        public Kayit_Ekrani()
        {
            InitializeComponent();
        }
        baglantiSinif bgl = new baglantiSinif();
        private void Kayit_Ekrani_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
            txtID.Focus();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("Insert Into GirisIslemi(ID,Sifre) values (@ID,@Sifre)", connection);

                command.Parameters.AddWithValue("@ID", txtID.Text);
                command.Parameters.AddWithValue("@Sifre", txtSifre.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Kayıt Ekleme İşlemi Başarılı!", "Kayıt Ekleme İşlemi Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Giris_Ekrani ekran = new Giris_Ekrani();
                ekran.Show();
                this.Hide();

            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Ekleme İşlemi Başarısız Oldu!", "Kayıt Ekleme İşlemi Durumu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtID.Text = "";
            txtSifre.Text = "";

        }

        private void btnEkran_Click(object sender, EventArgs e)
        {
            Giris_Ekrani ekran = new Giris_Ekrani();
            ekran.Show();
            this.Hide();
        }
    }
}
