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
using Microsoft.Data.SqlClient;
namespace MovieHub.cs
{
    public partial class FormOyuncuListecs : Form
    {
        SqlConnection baglanti = new SqlConnection
         ("data source=.\\SQLEXPRESS; initial catalog=movieHubDB; integrated security=true;" +
         "Trusted_Connection=True;" +
         "Encrypt=False;TrustServerCertificate=True;");
        public FormOyuncuListecs()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormOyuncuListecs_Load(object sender, EventArgs e)
        {

            listepaneli.Controls.Clear();
            baglanti.Open();
            string sorgu = "select * from OyuncularTbl order by AdSoyad asc ";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                UserControlOyuncu arac = new UserControlOyuncu();
                arac.labelID.Text = reader["ID"].ToString();
                arac.labeladsoyad.Text = reader["AdSoyad"].ToString();
                arac.pictureBoxfoto.ImageLocation = reader["fotograf"].ToString();
                listepaneli.Controls.Add(arac);

            }
            baglanti.Close();
        }

        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            listepaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand ara = new SqlCommand("select * from OyuncularTbl where AdSoyad like '%" + textBoxsearch.Text + "%'", baglanti);
            SqlDataReader reader = ara.ExecuteReader();
            while (reader.Read())
            {
                ControlYonetListe arac = new ControlYonetListe();
                arac.labelID.Text = reader["ID"].ToString();
                arac.labeladsoyad.Text = reader["AdSoyad"].ToString();
                arac.pictureBoxfoto.ImageLocation = reader["fotograf"].ToString();
                listepaneli.Controls.Add(arac);
            }

            baglanti.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
