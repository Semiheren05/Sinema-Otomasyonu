using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MovieHubProjectV3
{
    public partial class FrmSeansListesi : Form
    {
        
        public FrmSeansListesi()
        {
            InitializeComponent();

            filmGetir();
            salonGetir();
            seansListele();
        }

        SQLBaglantisi bgl = new SQLBaglantisi();

        void filmGetir()
        {
            string sorgu = "SELECT filmad FROM FilmlerTbl ORDER BY filmad ASC";
            SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            cmbFilm.Items.Clear(); 
            while (dr.Read())
            {
                cmbFilm.Items.Add(dr[0].ToString());
            }
            bgl.baglanti().Close();
        }

        // SALONLARI GETİR
        void salonGetir()
        {
            string sorgu = "SELECT salonadi FROM salonlarTbl ORDER BY salonadi ASC";
            SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            cmbSalon.Items.Clear();
            while (dr.Read())
            {
                cmbSalon.Items.Add(dr[0].ToString());
            }
            bgl.baglanti().Close();
        }
        void seansListele()
        {
            try
            {
                string sorgu = "SELECT * FROM KontrolTbl ORDER BY Tarih, Seans ASC";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);
            }
        }

        private void FrmSeansListesi_Load(object sender, EventArgs e)
        {
            dtpTarih.MinDate = DateTime.Today;
            dtpTarih.Format = DateTimePickerFormat.Short;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbFilm.Text == "" || cmbSalon.Text == "" || cmbSeans.Text == "")
            {
                MessageBox.Show("Lütfen tüm seçimleri yapınız!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlCommand kontrol = new SqlCommand("SELECT Count(*) FROM KontrolTbl WHERE SalonAdi=@s1 AND Tarih=@s2 AND Seans=@s3", bgl.baglanti());
                kontrol.Parameters.AddWithValue("@s1", cmbSalon.Text);
                kontrol.Parameters.AddWithValue("@s2", dtpTarih.Value.ToString("dd.MM.yyyy"));
                kontrol.Parameters.AddWithValue("@s3", cmbSeans.Text);

                int sonuc = Convert.ToInt32(kontrol.ExecuteScalar());
                bgl.baglanti().Close();

                if (sonuc > 0)
                {
                    MessageBox.Show("Bu salonda ve saatte zaten bir seans var!", "Çakışma", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string sorgu = "INSERT INTO KontrolTbl (FilmAdi, Tarih, Seans, SalonAdi, Koltuklar) VALUES (@p1, @p2, @p3, @p4, @p5)";
                SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", cmbFilm.Text);
                komut.Parameters.AddWithValue("@p2", dtpTarih.Value.ToString("dd.MM.yyyy"));
                komut.Parameters.AddWithValue("@p3", cmbSeans.Text);
                komut.Parameters.AddWithValue("@p4", cmbSalon.Text);
                komut.Parameters.AddWithValue("@p5", ""); // Boş koltuklar

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Seans Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                seansListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Silinecek seansı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string film = dataGridView1.CurrentRow.Cells[1].Value.ToString(); 

            DialogResult karar = MessageBox.Show(film + " filminin seansını iptal etmek istiyor musunuz?\n\n(Bu işlem kasaya 'İPTAL' olarak yansıyacaktır)", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (karar == DialogResult.Yes)
            {
                try
                {
                   
                    SqlCommand komutSil = new SqlCommand("DELETE FROM KontrolTbl WHERE ID = @p1", bgl.baglanti());
                    komutSil.Parameters.AddWithValue("@p1", id);
                    komutSil.ExecuteNonQuery();
                    bgl.baglanti().Close();

                    string sorguKasa = "INSERT INTO KasaTbl (Tutar, Aciklama, Tarih) VALUES (@k1, @k2, @k3)";
                    SqlCommand komutKasa = new SqlCommand(sorguKasa, bgl.baglanti());

                    
                    komutKasa.Parameters.AddWithValue("@k1", "-200");
                    komutKasa.Parameters.AddWithValue("@k2", film + " seansı İPTAL/İADE");
                    komutKasa.Parameters.AddWithValue("@k3", DateTime.Now.ToString());
                    komutKasa.ExecuteNonQuery();
                    bgl.baglanti().Close();

                    MessageBox.Show("Seans iptal edildi ve kasaya iade olarak işlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    seansListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme Hatası: " + ex.Message);
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}