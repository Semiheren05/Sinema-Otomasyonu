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
    public partial class UserControlOyuncu : UserControl
    {
        SqlConnection baglanti = new SqlConnection
         ("data source=.\\SQLEXPRESS; initial catalog=movieHubDB; integrated security=true;" +
         "Trusted_Connection=True;" +
         "Encrypt=False;TrustServerCertificate=True;");
        public UserControlOyuncu()
        {
            InitializeComponent();
        }

        private void UserControlOyuncu_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            string sorgu = "select * from YonetmenlerTbl where ID = @p1 ";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", labelID.Text);
            SqlDataReader reader = komut.ExecuteReader();

            baglanti.Close();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from OyuncularTbl where ID=@p1", baglanti);
            sil.Parameters.AddWithValue("@p1", labelID.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("just Deleted");
            this.Hide();
        }

        private void buttonDetails_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from OyuncularTbl where ID =@p1";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", labelID.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read()) { MessageBox.Show(oku["biyografi"].ToString()); }
            baglanti.Close();
            
        }
    }
}
