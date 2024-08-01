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
    public partial class Doktor_Sil : Form
    {
        public Doktor_Sil()
        {
            InitializeComponent();
        }
        baglantiSinif bgl = new baglantiSinif();
        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Silme İşlemi Başarısız - " + txtKod.Text + " - Kodlu Doktor Bulunamamaktadır.", "İşlem Başarısızlıkla Sonuçlandı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand komut = new SqlCommand("Delete from DoktorBilgi where doktorNumarasi=@doktorNumarasi", connection);
                komut.Parameters.AddWithValue("@doktorNumarasi", txtKod.Text);

                komut.ExecuteNonQuery();

                DialogResult result = new DialogResult();
                result = MessageBox.Show("Silme İşlemi Başarılı", "İşlem Başarı İle Sonuçlandı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (DialogResult.OK == result)
                {
                    SqlCommand command1 = new SqlCommand("select * from DoktorBilgi", connection);
                    SqlDataAdapter adap = new SqlDataAdapter(command1);
                    DataTable table = new DataTable();

                    adap.Fill(table);

                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception h)
            {
                MessageBox.Show("Silme İşlemi Başarısız" + h, "İşlem Başarısızlıkla Sonuçlandı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtKod.Text = "";
        }

        private void Doktor_Sil_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneOtomasyonuDataSet.DoktorBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.doktorBilgiTableAdapter.Fill(this.hastaneOtomasyonuDataSet.DoktorBilgi);
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
            txtKod.Focus();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Ana_Sayfa sayfa = new Ana_Sayfa();
            sayfa.Show();
            this.Hide();
        }
    }
}
