using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; 
using System.Windows.Forms;

namespace MovieHubProjectV3
{
    public partial class FrmFilm : Form
    {
        public FrmFilm()
        {
            InitializeComponent();
        }

        SQLBaglantisi bgl = new SQLBaglantisi();
        void filmListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FilmlerTbl ORDER BY ID DESC", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void yonetmenListesi()
        {
            cmbYonetmen.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT AdSoyad FROM YonetmenlerTbl ORDER BY AdSoyad ASC", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbYonetmen.Items.Add(dr[0].ToString());
            }
            bgl.baglanti().Close();
        }

        void oyuncuListesi()
        {
            cListOyuncular.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT AdSoyad FROM OyuncularTbl ORDER BY AdSoyad ASC", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cListOyuncular.Items.Add(dr[0].ToString());
            }
            bgl.baglanti().Close();
        }
        private void FrmFilm_Load(object sender, EventArgs e)
        {
            filmListesi();
            yonetmenListesi();
            oyuncuListesi();
        }
        private void btnAfisSec_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Film Afişi Seç";
            ofd.Filter = "Resim Dosyaları |*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picAfis.ImageLocation = ofd.FileName;
                txtResimYolu.Text = ofd.FileName;
            }
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            if (txtFilmAdi.Text == "" || cmbYonetmen.Text == "" || cmbTur.Text == "" || txtResimYolu.Text == "")
            {
                MessageBox.Show("Lütfen Film Adı, Tür, Yönetmen ve Afiş alanlarını doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string oyuncular = "";
                foreach (object item in cListOyuncular.CheckedItems)
                {
                    oyuncular += item.ToString() + ", ";
                }
               
                if (oyuncular.Length > 2)
                    oyuncular = oyuncular.Substring(0, oyuncular.Length - 2);

                string sorgu = "INSERT INTO FilmlerTbl (filmad, filmtur, filmyonetmen, filmoyuncu, imdb, filmafis, filmdurum, filmdetay) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)";
                SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", txtFilmAdi.Text.ToUpper());
                komut.Parameters.AddWithValue("@p2", cmbTur.Text);
                komut.Parameters.AddWithValue("@p3", cmbYonetmen.Text);
                komut.Parameters.AddWithValue("@p4", oyuncular);
                komut.Parameters.AddWithValue("@p5", txtImdb.Text);
                komut.Parameters.AddWithValue("@p6", txtResimYolu.Text);
                komut.Parameters.AddWithValue("@p7", cmbDurum.Text); 
                komut.Parameters.AddWithValue("@p8", txtDetay.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Film başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filmListesi(); 
                temizle(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek filmi listeden seçiniz!", "Seçim Yapılmadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string filmAdi = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            DialogResult karar = MessageBox.Show(filmAdi + " filmini silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (karar == DialogResult.Yes)
            {
                try
                {
                    SqlCommand komut = new SqlCommand("DELETE FROM FilmlerTbl WHERE ID=@p1", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", id);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();

                    MessageBox.Show("Film silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    filmListesi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme hatası: " + ex.Message);
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            
            txtFilmAdi.Text = dataGridView1.Rows[secilen].Cells["filmad"].Value.ToString();
            cmbTur.Text = dataGridView1.Rows[secilen].Cells["filmtur"].Value.ToString();
            cmbYonetmen.Text = dataGridView1.Rows[secilen].Cells["filmyonetmen"].Value.ToString();
            txtImdb.Text = dataGridView1.Rows[secilen].Cells["imdb"].Value.ToString();
            cmbDurum.Text = dataGridView1.Rows[secilen].Cells["filmdurum"].Value.ToString();
            txtDetay.Text = dataGridView1.Rows[secilen].Cells["filmdetay"].Value.ToString();

         
            txtResimYolu.Text = dataGridView1.Rows[secilen].Cells["filmafis"].Value.ToString();

          
            if (!string.IsNullOrEmpty(txtResimYolu.Text))
            {
                picAfis.ImageLocation = txtResimYolu.Text;
            }
            else
            {
                picAfis.Image = null;
            }
        }

            void temizle()
        {
            txtFilmAdi.Text = "";
            txtImdb.Text = "";
            txtDetay.Text = "";
            txtResimYolu.Text = "";
            picAfis.Image = null;
            for (int i = 0; i < cListOyuncular.Items.Count; i++)
            {
                cListOyuncular.SetItemChecked(i, false);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnAfisSec_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void btnKaydet_Click_1(object sender, EventArgs e)
        //{

        //}
    }
}
