using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MovieHub.cs
{
    public partial class FormFilmLİste : Form
    {
        public FormFilmLİste()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection baglanti = new SqlConnection
          ("data source=.\\SQLEXPRESS; initial catalog=movieHubDB; integrated security=true;" +
          "Trusted_Connection=True;" +
          "Encrypt=False;TrustServerCertificate=True;");
        private void FormFilmLİste_Load(object sender, EventArgs e)
        {
            flowLayoutFilm1.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from FilmlerTbl order by filmad asc", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                UserFilmListe arac = new UserFilmListe();
                arac.labelFilmAdi.Text = reader["filmad"].ToString();
                arac.pictureBoxMovie.ImageLocation = reader["filmafis"].ToString();
                arac.labelID.Text = reader["ID"].ToString();
                flowLayoutFilm1.Controls.Add(arac);
            }
            baglanti.Close();
        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            flowLayoutFilm1.Controls.Clear();

            baglanti.Open();

            SqlCommand ara = new SqlCommand(
                "SELECT * FROM FilmlerTbl WHERE filmad LIKE @p1",
                baglanti);

            ara.Parameters.AddWithValue("@p1", "%" + textBoxsearch.Text + "%");

            SqlDataReader reader = ara.ExecuteReader();

            while (reader.Read())
            {
                UserFilmListe arac = new UserFilmListe();
                arac.labelID.Text = reader["ID"].ToString();
                arac.labelFilmAdi.Text = reader["filmad"].ToString();
                arac.pictureBoxMovie.ImageLocation = reader["afis"].ToString();
                flowLayoutFilm1.Controls.Add(arac);
            }

            reader.Close();   
            baglanti.Close();
        }
    }
}
