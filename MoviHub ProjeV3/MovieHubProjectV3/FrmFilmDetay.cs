using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MovieHubProjectV3
{
    public partial class FrmFilmDetay : Form
    {
        public FrmFilmDetay()
        {
            InitializeComponent();
        }

        SQLBaglantisi bgl = new SQLBaglantisi();

        public string id, filmAdi, afisYolu;

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFilmDetay_Load(object sender, EventArgs e)
        {
            lblFilmAdi.Text = filmAdi;

            try
            {
                pbAfis.ImageLocation = afisYolu;
            }
            catch
            {
            }
            try
            {
                string sorgu = "SELECT * FROM FilmlerTbl WHERE ID=@p1";
                SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", id);
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    lblYonetmen.Text = "YÖNETMEN: " + dr["filmyonetmen"].ToString();
                    lblOyuncular.Text = "OYUNCULAR: " + dr["filmoyuncu"].ToString();
                    lblTur.Text = "TÜR: " + dr["filmtur"].ToString();
                    lblOzet.Text = dr["filmdetay"].ToString();
                }
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Detaylar yüklenirken hata oluştu: " + ex.Message);
            }
        }
    }
}