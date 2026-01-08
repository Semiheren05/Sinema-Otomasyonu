using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing; 
using System.Windows.Forms;

namespace MovieHubProjectV3
{
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }

        SQLBaglantisi bgl = new SQLBaglantisi();

        private void FrmKasa_Load(object sender, EventArgs e)
        {
            kasaListele();
            istatistikleriHesapla();
        }

        void kasaListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KasaTbl ORDER BY ID DESC", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        void istatistikleriHesapla()
        {
            try
            {
                double toplamCiro = 0;
                double iptalEdilenTutar = 0;
                int iptalSayisi = 0;

                SqlCommand komutKasa = new SqlCommand("SELECT * FROM KasaTbl", bgl.baglanti());
                SqlDataReader drKasa = komutKasa.ExecuteReader();
                while (drKasa.Read())
                {
                    double oAnkiTutar = Convert.ToDouble(drKasa["Tutar"]);
                    string aciklama = drKasa["Aciklama"].ToString().ToUpper();

                    toplamCiro += oAnkiTutar;

                    if (aciklama.Contains("İPTAL") || aciklama.Contains("İADE"))
                    {
                        iptalSayisi++;
                        iptalEdilenTutar += oAnkiTutar; 
                    }
                }
                bgl.baglanti().Close();

                lblToplam.Text = toplamCiro.ToString() + " TL";

                if (toplamCiro < 0) lblToplam.ForeColor = Color.Red;
                else lblToplam.ForeColor = Color.LimeGreen;

                int satilanBilet = 0;
                SqlCommand komutBilet = new SqlCommand("SELECT Count(*) FROM BiletTbl", bgl.baglanti());
                SqlDataReader drBilet = komutBilet.ExecuteReader();
                if (drBilet.Read())
                {
                    satilanBilet = Convert.ToInt32(drBilet[0]);
                }
                bgl.baglanti().Close();

                lblSatilanBilet.Text = satilanBilet.ToString();
                lblIptalBilet.Text = iptalSayisi.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hesaplama Hatası: " + ex.Message);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}