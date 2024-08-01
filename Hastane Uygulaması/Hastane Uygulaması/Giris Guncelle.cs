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
    public partial class Giris_Guncelle : Form
    {
        public Giris_Guncelle()
        {
            InitializeComponent();
        }
        baglantiSinif bgl = new baglantiSinif();
        private void Giris_Guncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneOtomasyonuDataSet.GirisIslemi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.girisIslemiTableAdapter.Fill(this.hastaneOtomasyonuDataSet.GirisIslemi);
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
            txtAra.Focus();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand komut = new SqlCommand("SELECT * FROM GirisIslemi Where ID Like " + txtAra.Text, connection);
                SqlDataAdapter adap = new SqlDataAdapter(komut);

                DataTable tablo = new DataTable();

                adap.Fill(tablo);
                dataGridView1.DataSource = tablo;

                if (dataGridView1.CurrentCell == null)
                {
                    MessageBox.Show("Aradığınız Kayıt Bulunamadı", "İşlem Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Aradığınız Kayıt Bulundu", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Arama İşlemi Başarısız", "İşlem Başarısızlıkla Sonuçlandı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGüncel_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            if (txtAra.Text != "")
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    SqlCommand command = new SqlCommand("UPDATE GirisIslemi SET ID=@ID,Sifre=@Sifre where ID=@ID1", connection);
                    command.Parameters.AddWithValue("@ID", txtID.Text);
                    command.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                    command.Parameters.AddWithValue("@ID1", txtAra.Text);

                    command.ExecuteNonQuery();

                    DialogResult result = new DialogResult();

                    result = MessageBox.Show("Güncelleme İşlemi Başarılı", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (DialogResult.OK == result)
                    {
                        SqlCommand command1 = new SqlCommand("Select * From GirisIslemi", connection);
                        SqlDataAdapter adap = new SqlDataAdapter(command1);
                        DataTable table = new DataTable();

                        adap.Fill(table);

                        dataGridView1.DataSource = table;
                    }
                    txtID.Text = "";
                    txtSifre.Text = "";

                }
                catch (Exception)
                {
                    MessageBox.Show("Bir Hata Meydana Geldi", "İşlem Başarısız!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Doktoru Önce Arayın!", "Lütfen Arama Yapınız!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
