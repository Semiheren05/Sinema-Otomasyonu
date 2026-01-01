using Microsoft.Data.SqlClient;
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

namespace MovieHub.cs
{
    public partial class FormFilmDetay : Form
    {
        public FormFilmDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection
        ("data source=.\\SQLEXPRESS; initial catalog=movieHubDB; integrated security=true;" +
        "Trusted_Connection=True;" +
        "Encrypt=False;TrustServerCertificate=True;");

        public string idno = "0";
        private void FormFilmDetay_Load(object sender, EventArgs e)
        {
           baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from FilmlerTbl where ID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", idno);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read()) 
            {
                pictureBoxMovie.ImageLocation= reader["filmafis"].ToString();
                labelfilmadi.Text = reader["filmad"].ToString();
                labeltur.Text = reader["filmtur"].ToString();
                labelwarning.Text = reader["filmad"].ToString();
                labelyonetmen.Text = reader["filmyonetmen"].ToString();
                labelimdb.Text = reader["imdb"].ToString();
                labelvizyontarihi.Text = reader["filmtarih"].ToString();
                labeloyuncu.Text = reader["filmoyuncu"].ToString();
                labelaktifpasif.Text = reader["filmdurum"].ToString();
                labeldetay.Text = reader["filmdetay"].ToString();
            }
            baglanti.Close();

            if (labelaktifpasif.Text == "0")
            {
                labelaktifpasif.Text = "it's SHOWTIME !!";
            }
            else
            {
                labelaktifpasif.Text = "Coming Soon..";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
