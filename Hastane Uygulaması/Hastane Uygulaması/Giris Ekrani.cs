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
    public partial class Giris_Ekrani : Form
    {
        public Giris_Ekrani()
        {
            InitializeComponent();
        }
        baglantiSinif bgl = new baglantiSinif();
        private void btnDurum_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            if (txtsifre.PasswordChar == '*')
            {
                btnDurum.Text = "Gizle";
                txtsifre.PasswordChar = '\0';
                btnDurum.ForeColor = Color.Black;
                btnDurum.BackColor = Color.White;
            }
            else
            {
                btnDurum.Text = "Göster";
                txtsifre.PasswordChar = '*';
                btnDurum.ForeColor = Color.White;
                btnDurum.BackColor = Color.Black;
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Kayit_Ekrani ekran = new Kayit_Ekrani();
            ekran.Show();
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("Select * From GirisIslemi Where ID=@ID And Sifre=@Sifre", connection);
                command.Parameters.AddWithValue("@ID", txtID.Text);
                command.Parameters.AddWithValue("@Sifre", txtsifre.Text);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Giriş İşlemi Başarılı!", "Giriş İşlemi Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Ana_Sayfa ana = new Ana_Sayfa();
                    ana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adını veya Şifrenizi Kontrol Ediniz!", "Giriş İşlemi Durumu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Boş Bırakmayınız!", "Giriş İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Giris_Ekrani_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
            txtID.Focus();
        }
    }
}
