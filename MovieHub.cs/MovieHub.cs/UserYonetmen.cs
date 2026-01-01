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
    public partial class UserYonetmen : UserControl
    {
        public UserYonetmen()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection
        ("data source=.\\SQLEXPRESS; initial catalog=movieHubDB; integrated security=true;" +
        "Trusted_Connection=True;" +
        "Encrypt=False;TrustServerCertificate=True;");

        private void UserYonetmen_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from SecilenlerTbl where kisi=@kisi and tur=@tur", baglanti);
            komut.Parameters.AddWithValue("@kisi", labeladsoyad.Text);
            komut.Parameters.AddWithValue("@tur", "Yonetmen");
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                labeladsoyad.ForeColor = Color.Chocolate;
            }
            else { labeladsoyad.ForeColor= Color.Red; }
            baglanti.Close();
        }

        private void labeladsoyad_Click(object sender, EventArgs e)
        {
            
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into SecilenlerTbl (kisi,tur) values (@p1,@p2)", baglanti);
                komut.Parameters.AddWithValue("@p1", labeladsoyad.Text);
                komut.Parameters.AddWithValue("@p2", "Yonetmen");
                komut.ExecuteNonQuery();
                baglanti.Close(); 
        }
    }
}
