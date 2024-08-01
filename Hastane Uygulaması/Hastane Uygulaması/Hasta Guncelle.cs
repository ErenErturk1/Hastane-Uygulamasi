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
    public partial class Hasta_Guncelle : Form
    {
        public Hasta_Guncelle()
        {
            InitializeComponent();
        }
        baglantiSinif bgl = new baglantiSinif();
        private void Hasta_Guncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneOtomasyonuDataSet.HastaBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hastaBilgiTableAdapter.Fill(this.hastaneOtomasyonuDataSet.HastaBilgi);
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
            txtTel.Text = "0";
            txtYakiniTel.Text = "0";
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
                SqlCommand komut = new SqlCommand("SELECT * FROM HastaBilgi Where hastaNumarasi Like " + txtAra.Text, connection);
                SqlDataAdapter adap = new SqlDataAdapter(komut);

                DataTable tablo = new DataTable();

                adap.Fill(tablo);
                dataGridView1.DataSource = tablo;

                if (dataGridView1.CurrentCell == null)
                {
                    MessageBox.Show("Aradığınız Hasta Bulunamadı", "İşlem Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Aradığınız Hasta Bulundu", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Arama İşlemi Başarısız", "İşlem Başarısızlıkla Sonuçlandı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btngüncel_Click(object sender, EventArgs e)
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
                    SqlCommand command = new SqlCommand("UPDATE HastaBilgi SET isim=@isim,soyisim=@soyisim,tc=@tc,tel=@tel,yakinitel=@yakinitel,hastalık=@hastalık,hastaNumarasi=@hastaNumarasi Where hastaNumarasi=@hastaNumarasi1", connection);
                    command.Parameters.AddWithValue("@isim", txtAd.Text);
                    command.Parameters.AddWithValue("@soyisim", txtSoyad.Text);
                    command.Parameters.AddWithValue("@tc", txtTc.Text);
                    command.Parameters.AddWithValue("@tel", txtTel.Text);
                    command.Parameters.AddWithValue("@yakinitel", txtYakiniTel.Text);
                    command.Parameters.AddWithValue("@hastalık", txtHastalik.Text);
                    command.Parameters.AddWithValue("@hastaNumarasi", txtHastaNo.Text);
                    command.Parameters.AddWithValue("@hastaNumarasi1", txtAra.Text);

                    command.ExecuteNonQuery();

                    DialogResult result = new DialogResult();

                    result = MessageBox.Show("Güncelleme İşlemi Başarılı", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (DialogResult.OK == result)
                    {
                        SqlCommand command1 = new SqlCommand("Select * From HastaBilgi", connection);
                        SqlDataAdapter adap = new SqlDataAdapter(command1);
                        DataTable table = new DataTable();

                        adap.Fill(table);

                        dataGridView1.DataSource = table;
                    }
                    txtAd.Text = "";
                    txtSoyad.Text = "";
                    txtTc.Text = "";
                    txtTel.Text = "0";
                    txtYakiniTel.Text = "0";
                    txtHastalik.Text = "";
                    txtHastaNo.Text = "";
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Bir Hata Meydana Geldi", "İşlem Başarısız!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Hastayı Önce Arayın!", "Lütfen Arama Yapınız!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
