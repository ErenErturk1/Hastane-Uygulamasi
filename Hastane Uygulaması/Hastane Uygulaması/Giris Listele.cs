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
    public partial class Giris_Listele : Form
    {
        public Giris_Listele()
        {
            InitializeComponent();
        }
        baglantiSinif bgl = new baglantiSinif();
        private void Giris_Listele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'hastaneOtomasyonuDataSet.GirisIslemi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.girisIslemiTableAdapter.Fill(this.hastaneOtomasyonuDataSet.GirisIslemi);
            SqlConnection connection = new SqlConnection(bgl.adres);
            connection.Open();

            SqlCommand command = new SqlCommand("select * from GirisIslemi", connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adap.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Ana_Sayfa sayfa = new Ana_Sayfa();
            sayfa.Show();
            this.Hide();
        }
    }
}
