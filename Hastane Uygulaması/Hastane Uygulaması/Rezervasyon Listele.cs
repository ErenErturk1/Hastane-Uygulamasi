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
    public partial class Rezervasyon_Listele : Form
    {
        public Rezervasyon_Listele()
        {
            InitializeComponent();
        }
        baglantiSinif bgl = new baglantiSinif();
        private void Rezervasyon_Listele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneOtomasyonuDataSet.RezervasyonIslemi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.rezervasyonIslemiTableAdapter.Fill(this.hastaneOtomasyonuDataSet.RezervasyonIslemi);
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();

            SqlCommand command = new SqlCommand("select * from RezervasyonIslemi", connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adap.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Ana_Sayfa ana = new Ana_Sayfa();
            ana.Show();
            this.Hide();
        }
    }
}
