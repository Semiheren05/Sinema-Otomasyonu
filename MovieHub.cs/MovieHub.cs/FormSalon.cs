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

    public partial class FormSalon : Form
    {
        SqlConnection baglanti = new SqlConnection
         ("data source=.\\SQLEXPRESS; initial catalog=movieHubDB; integrated security=true;" +
         "Trusted_Connection=True;" +
         "Encrypt=False;TrustServerCertificate=True;");
        public FormSalon()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonphotoLoad_Click(object sender, EventArgs e)
        {
            if (textsalonadi.Text != "" && comboseats.Text != "")
            {
                baglanti.Open();
                SqlCommand kaydet = new SqlCommand("insert into salonlarTbl (salonadi,koltuksayisi) values (@p1,@p2)", baglanti);
                kaydet.Parameters.AddWithValue("@p1", textsalonadi.Text);
                kaydet.Parameters.AddWithValue("@p2", comboseats.Text);
                kaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Holly Jolly:))");
                textsalonadi.Text = "";
                comboseats.Text = "";
                textsalonadi.Focus();
                listeGetir();

            }
            else { MessageBox.Show("CHOOSE ONE OR MORE!"); }
        }

        private void FormSalon_Load(object sender, EventArgs e)
        {
            listeGetir(); koltukolustur();
        }
        void koltukolustur()
        {
            for (int i = 1; i <= 99; i++)
            {
                comboseats.Items.Add(i);
            }
        }

        void listeGetir()
        {
            flowSalonList.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from salonlarTbl order by salonadi asc ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                UserControlsalonlist arac = new UserControlsalonlist();
                arac.labelsalonadi.Text = oku["salonadi"].ToString();
                arac.labelnmbr.Text = oku["koltuksayisi"].ToString();
                flowSalonList.Controls.Add(arac);
            }
            baglanti.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
