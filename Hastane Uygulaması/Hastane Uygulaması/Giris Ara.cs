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
    public partial class Giris_Ara : Form
    {
        public Giris_Ara()
        {
            InitializeComponent();
        }
        baglantiSinif bgl = new baglantiSinif();
        private void Giris_Ara_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneOtomasyonuDataSet.GirisIslemi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.girisIslemiTableAdapter.Fill(this.hastaneOtomasyonuDataSet.GirisIslemi);
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

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand komut = new SqlCommand("select * from GirisIslemi where ID Like " + txtKod.Text, connection);
                SqlDataAdapter adap = new SqlDataAdapter(komut);

                DataTable tablo = new DataTable();

                adap.Fill(tablo);
                dataGridView1.DataSource = tablo;

                if (dataGridView1.CurrentCell == null)
                {
                    MessageBox.Show("Aradığınız Kayıt Bilgisi Bulunamadı", "İşlem Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Aradığınız Kayıt Bilgisi Bulundu", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Arama İşlemi Başarısız", "İşlem Başarısızlıkla Sonuçlandı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
