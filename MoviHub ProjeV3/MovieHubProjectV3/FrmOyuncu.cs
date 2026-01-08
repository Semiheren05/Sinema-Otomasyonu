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

namespace MovieHubProjectV3
{
    public partial class FrmOyuncu : Form
    {
        public FrmOyuncu()
        {
            InitializeComponent();
        }

        SQLBaglantisi bgl = new SQLBaglantisi();


        void listeGetir()
        {
            string sorgu = "SELECT * FROM OyuncularTbl ORDER BY ID DESC";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmOyuncu_Load(object sender, EventArgs e)
        {
            listeGetir();
        }


        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Oyuncu Resmi Seç";
            ofd.Filter = "Resim Dosyaları |*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxResim.ImageLocation = ofd.FileName;
                txtResimYolu.Text = ofd.FileName;
            }
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (txtAdSoyad.Text == "" || txtBiyografi.Text == "" || txtResimYolu.Text == "")
            {
                MessageBox.Show("Lütfen Ad, Biyografi ve Resim alanlarını doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string cinsiyet = "0";
                if (rdbErkek.Checked) cinsiyet = "1";
                if (rdbKadin.Checked) cinsiyet = "2";

                string sorgu = "INSERT INTO OyuncularTbl (AdSoyad, Cinsiyet, Yas, Biyografi, Fotograf) VALUES (@p1, @p2, @p3, @p4, @p5)";
                SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text.ToUpper());
                komut.Parameters.AddWithValue("@p2", cinsiyet);
                komut.Parameters.AddWithValue("@p3", nudYas.Value.ToString());
                komut.Parameters.AddWithValue("@p4", txtBiyografi.Text);
                komut.Parameters.AddWithValue("@p5", txtResimYolu.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Oyuncu Başarıyla Eklendi!", "İşlem Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listeGetir();
                temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void temizle()
        {
            txtAdSoyad.Text = "";
            txtBiyografi.Text = "";
            txtResimYolu.Text = "";
            nudYas.Value = 18;
            pictureBoxResim.Image = null;
            rdbErkek.Checked = false;
            rdbKadin.Checked = false;
            txtAdSoyad.Focus();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
            private void btnSil_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek kaydı listeden seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            string secilenID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string secilenAd = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            
            DialogResult karar = MessageBox.Show(secilenAd + " adlı kişiyi silmek istediğinize emin misiniz?\nBu işlem geri alınamaz!", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (karar == DialogResult.Yes)
            {
                try
                {
                    
                    string sorgu = "DELETE FROM OyuncularTbl WHERE ID = @p1";
                    SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", secilenID);

                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();

                    MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    listeGetir();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi başarısız oldu.\nHata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    
}