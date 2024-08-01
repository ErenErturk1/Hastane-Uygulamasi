using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Uygulaması
{
    public partial class Ana_Sayfa : Form
    {
        public Ana_Sayfa()
        {
            InitializeComponent();
        }

        private void btnHastaKayit_Click(object sender, EventArgs e)
        {
            Hasta_Kayit a = new Hasta_Kayit();
            a.Show();
            this.Hide();
        }

        private void btnHastaListele_Click(object sender, EventArgs e)
        {
            Hasta_Listele hasta_Listele = new Hasta_Listele();  
            hasta_Listele.Show();
            this.Hide();
        }

        private void btnHastaAra_Click(object sender, EventArgs e)
        {
            Hasta_Ara hasta_Ara = new Hasta_Ara();  
            hasta_Ara.Show();
            this.Hide();
        }

        private void btnHastaGuncelle_Click(object sender, EventArgs e)
        {
            Hasta_Guncelle hasta = new Hasta_Guncelle();
            hasta.Show();
            this.Hide();
        }

        private void btnHastaSil_Click(object sender, EventArgs e)
        {
            Hasta_Sil hasta_Sil = new Hasta_Sil();
            hasta_Sil.Show();
            this.Hide();
        }

        private void btnDoktorKayit_Click(object sender, EventArgs e)
        {
            Doktor_Kayit doktor_Kayit = new Doktor_Kayit();
            doktor_Kayit.Show();
            this.Hide();
        }

        private void btnDoktorListele_Click(object sender, EventArgs e)
        {
            Doktor_Listele doktor = new Doktor_Listele();
            doktor.Show();
            this.Hide();
        }

        private void btnDoktorAra_Click(object sender, EventArgs e)
        {
            Doktor_Ara ara = new Doktor_Ara();
            ara.Show();
            this.Hide();
        }

        private void btnDoktorGuncelle_Click(object sender, EventArgs e)
        {
            Doktor_Guncelle guncelle = new Doktor_Guncelle();
            guncelle.Show();
            this.Hide();
        }

        private void btnDoktorSil_Click(object sender, EventArgs e)
        {
            Doktor_Sil sil = new Doktor_Sil();
            sil.Show();
            this.Hide();
        }

        private void btnRezervGuncel_Click(object sender, EventArgs e)
        {
            Rezervasyon_Guncelle guncel = new Rezervasyon_Guncelle();
            guncel.Show();
            this.Hide();
        }

        private void btnRezervSil_Click(object sender, EventArgs e)
        {
            Rezervasyon_Sil sil = new Rezervasyon_Sil();
            sil.Show();
            this.Hide();
        }

        private void btnRezervAra_Click(object sender, EventArgs e)
        {
            Rezervasyon_Ara ara = new Rezervasyon_Ara();
            ara.Show();
            this.Hide();
        }

        private void btnRezervListe_Click(object sender, EventArgs e)
        {
            Rezervasyon_Listele list = new Rezervasyon_Listele();
            list.Show();
            this.Hide();
        }

        private void btnRezervKayit_Click(object sender, EventArgs e)
        {
            Rezervasyon_Kayit kayit = new Rezervasyon_Kayit();
            kayit.Show();
            this.Hide();
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            Giris_Guncelle guncelle = new Giris_Guncelle(); 
            guncelle.Show();
            this.Hide();
        }

        private void btnBilgiSil_Click(object sender, EventArgs e)
        {
            Giris_Sil giris = new Giris_Sil();  
            giris.Show();
            this.Hide();
        }

        private void btnBilgiAra_Click(object sender, EventArgs e)
        {
            Giris_Ara giris = new Giris_Ara();  
            giris.Show();
            this.Hide();
        }

        private void btnBilgiListele_Click(object sender, EventArgs e)
        {
            Giris_Listele lis = new Giris_Listele();
            lis.Show();
            this.Hide();
        }

        private void btnGirisKayit_Click(object sender, EventArgs e)
        {
            Giris_Kayit kay = new Giris_Kayit();
            kay.Show();
            this.Hide();
        }
    }
}
