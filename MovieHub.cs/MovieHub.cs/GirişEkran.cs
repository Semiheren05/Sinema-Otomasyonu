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
using Microsoft.Data.SqlClient;

namespace MovieHub.cs
{
    public partial class GirişEkran : Form
    {
        SqlConnection baglanti = new SqlConnection
            ("data source=.\\SQLEXPRESS; initial catalog=movieHubDB; integrated security=true;" +
            "Trusted_Connection=True;" +
            "Encrypt=False;TrustServerCertificate=True;");
        public GirişEkran()
        {
            InitializeComponent();
        }

        private void textAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonWelcome_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand(
                "SELECT * FROM KullanicilarTbl WHERE KullaniciAdi=@p1 AND KullaniciSifre=@p2",
                baglanti);

            komut.Parameters.AddWithValue("@p1", textAdmin.Text);
            komut.Parameters.AddWithValue("@p2", textPassword.Text);

            SqlDataReader reader = komut.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Access Granted :)");

                FormAnaEkran anaEkran = new FormAnaEkran();

                this.Hide();              // Login formu gizle
                anaEkran.ShowDialog();    // Ana ekranı modal aç
                this.Close();             // Ana ekran kapanınca login de kapansın
            }
            else
            {
                MessageBox.Show("Failure!! Try Again!");
            }

            baglanti.Close();

            textAdmin.Text = "";
            textPassword.Text = "";
            textAdmin.Focus();
        }

        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShow.Checked)
            {
                textPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textPassword.UseSystemPasswordChar = true;
            }
        }

        private void GirişEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
