using System;
using System.Windows.Forms;

namespace MovieHubProjectV3
{
    public partial class FrmFatura : Form
    {
        public FrmFatura()
        {
            InitializeComponent();
        }

        public string film, salon, tarih, seans, koltuk, adsoyad, tur, fiyat;

        private void FrmFatura_Load(object sender, EventArgs e)
        {
            lblFilm.Text = "FİLM: " + film;
            lblSalonSeans.Text = salon + " / " + tarih + " " + seans;
            lblKoltuk.Text = "KOLTUK: " + koltuk;
            lblTur.Text = "TARİFE: " + tur;
            lblAdSoyad.Text = "SAYIN: " + adsoyad;
            lblFiyat.Text = "TUTAR: " + fiyat + " TL";
        }
    }
}
