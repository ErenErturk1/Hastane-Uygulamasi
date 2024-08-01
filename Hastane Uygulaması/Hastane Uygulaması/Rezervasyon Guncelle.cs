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
    public partial class Rezervasyon_Guncelle : Form
    {
        public Rezervasyon_Guncelle()
        {
            InitializeComponent();
        }
        baglantiSinif bgl = new baglantiSinif();
        private void Rezervasyon_Guncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneOtomasyonuDataSet.RezervasyonIslemi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.rezervasyonIslemiTableAdapter.Fill(this.hastaneOtomasyonuDataSet.RezervasyonIslemi);
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
                SqlCommand komut = new SqlCommand("SELECT * FROM RezervasyonIslemi Where tc Like " + txtAra.Text, connection);
                SqlDataAdapter adap = new SqlDataAdapter(komut);

                DataTable tablo = new DataTable();

                adap.Fill(tablo);
                dataGridView1.DataSource = tablo;

                if (dataGridView1.CurrentCell == null)
                {
                    MessageBox.Show("Rezervasyon Bulunamadı", "İşlem Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Rezervasyon Bulundu", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                    DateTime dt = dateTimePicker1.Value;

                    SqlCommand command = new SqlCommand("UPDATE RezervasyonIslemi SET ad=@ad,soyad=@soyad,tc=@tc,hastane=@hastane,rezerveTarihi=@rezerveTarihi Where tc=@tc1", connection);
                    command.Parameters.AddWithValue("@ad", txtAd.Text);
                    command.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                    command.Parameters.AddWithValue("@tc", txtTc.Text);
                    command.Parameters.AddWithValue("@hastane", txtHastane.Text);
                    command.Parameters.AddWithValue("@rezerveTarihi", dt);
                    command.Parameters.AddWithValue("@tc1", txtAra.Text);

                    command.ExecuteNonQuery();

                    DialogResult result = new DialogResult();

                    result = MessageBox.Show("Güncelleme İşlemi Başarılı", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (DialogResult.OK == result)
                    {
                        SqlCommand command1 = new SqlCommand("Select * From RezervasyonIslemi", connection);
                        SqlDataAdapter adap = new SqlDataAdapter(command1);
                        DataTable table = new DataTable();

                        adap.Fill(table);

                        dataGridView1.DataSource = table;
                    }
                    txtAd.Text = "";
                    txtSoyad.Text = "";
                    txtTc.Text = "";
                    txtHastane.Text = "";
                    dateTimePicker1.Text = "";

                }
                catch (Exception)
                {
                    MessageBox.Show("Bir Hata Meydana Geldi", "İşlem Başarısız!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Rezervasyonu Önce Arayın!", "Lütfen Arama Yapınız!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Ana_Sayfa sa = new Ana_Sayfa();
            sa.Show();
            this.Hide();
        }
    }
}
