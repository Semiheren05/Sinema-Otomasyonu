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
using System.IO;


namespace MovieHub.cs
{
    public partial class FormFilmKayit : Form
    {
        SqlConnection baglanti = new SqlConnection
         ("data source=.\\SQLEXPRESS; initial catalog=movieHubDB; integrated security=true;" +
         "Trusted_Connection=True;" +
         "Encrypt=False;TrustServerCertificate=True;");
        public FormFilmKayit()
        {
            InitializeComponent();
        }

        private byte[] ResmiByteArrayYap()
        {
            if (pictureBoxMovie.Image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                pictureBoxMovie.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ylistegetir()
        {
            string sorgu = "select * from YonetmenlerTbl order by AdSoyad asc";
            flowPanelyonetmen.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                UserYonetmen arac = new UserYonetmen();
                arac.labeladsoyad.Text = rdr["AdSoyad"].ToString();
                flowPanelyonetmen.Controls.Add(arac);
            }
            baglanti.Close();
        }

        void oListegetir()
        {
            string sorgu = "select * from OyuncularTbl order by AdSoyad asc";
            flowPaneloyuncu.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                UserOyuncu arac = new UserOyuncu();
                arac.labeladsoyad.Text = rdr["AdSoyad"].ToString();
                flowPaneloyuncu.Controls.Add(arac);
            }
            baglanti.Close();
        }

        private void FormFilmKayit_Load(object sender, EventArgs e)
        {
            Imdbolustur(); ylistegetir(); oListegetir();
            maskedYayinTarihi.Mask = "00/00/0000";
        }

        string durum = "";

        private void TarihFarkiHesapla()
        {
            if (DateTime.TryParse(maskedYayinTarihi.Text, out DateTime vizyon))
            {
                DateTime bugun = DateTime.Today;
                TimeSpan fark = vizyon - bugun;

                if (fark.Days > 0)
                {
                    MessageBox.Show($"Filmin vizyona girmesine {fark.Days} gün kaldı.");
                    durum = "Pasif";
                }
                else if (fark.Days < 0)
                {
                    MessageBox.Show($"Film vizyona {Math.Abs(fark.Days)} gün önce girdi.");
                }
                else
                {
                    MessageBox.Show("Film bugün vizyona giriyor.");
                    durum = "Aktif";
                }
            }
            else
            {
                MessageBox.Show("Geçerli bir tarih giriniz.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TarihFarkiHesapla();
        }

        void Imdbolustur()
        {
            for (int i = 1; i <= 10; i++)
            {
                comboImdb.Items.Add(i);
            }
        }
        private void buttonphotoLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "foto seçme ekranı";
            dialog.Filter = "PNG (*.png)|*.png|JPG (*.jpg)|*.jpg|JPEG (*.jpeg)|*.jpeg|Tüm Dosyalar (*.*)|*.*";

            dialog.FilterIndex = 4;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMovie.Image = Image.FromFile(dialog.FileName);
                photo = dialog.FileName;
            }
        }
        private void richTextdetails_TextChanged(object sender, EventArgs e)
        {
            int count = richTextdetails.Text.Length;
            int countdown = 150 - count;
            label150.Text = countdown.ToString();
        }
        public string photo = "";

        string yonetmen = "";
        string oyuncu = "";

        void sYonetmen()
        {
            string sorgu = "select * from SecilenlerTbl where tur = 'Yonetmen'";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", "Yonetmen");
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                yonetmen += "," + oku["kisi"].ToString();
            }
            baglanti.Close();
        }

        void sOyuncu()
        {
            string sorgu = "select * from SecilenlerTbl where tur = 'Actor'";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", "Actor");
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oyuncu += "," + oku["kisi"].ToString();
            }
            baglanti.Close();
        }
        private void buttonfilmkayıt_Click(object sender, EventArgs e)
        {

            // Afişi byte[] yap
            byte[] afisBytes = ResmiByteArrayYap();

            // Diğer seçimleri hazırla
            tur();
            warnings11();
            sYonetmen();
            sOyuncu();

            // 🔴 BOŞ KONTROLLER
            if (string.IsNullOrWhiteSpace(textmoviename.Text))
            {
                MessageBox.Show("Film adı boş olamaz!");
                return;
            }

            if (string.IsNullOrWhiteSpace(comboImdb.Text))
            {
                MessageBox.Show("IMDB puanı seçiniz!");
                return;
            }

            // 🔴 TARİH KONTROLÜ
            DateTime filmTarih;
            if (!DateTime.TryParse(maskedYayinTarihi.Text, out filmTarih))
            {
                MessageBox.Show("Geçerli bir tarih giriniz!");
                return;
            }

            // 🔴 IMDB KONTROLÜ
            double imdbPuan;
            if (!double.TryParse(comboImdb.Text, out imdbPuan))
            {
                MessageBox.Show("IMDB puanı geçerli değil!");
                return;
            }

            // 🔴 NULL SAFE STRINGLER
            string turDeger = string.IsNullOrEmpty(secilenTur)
                ? ""
                : secilenTur.Length > 2 ? secilenTur.Substring(1) : secilenTur;

            string yonetmenDeger = string.IsNullOrEmpty(yonetmen)
                ? ""
                : yonetmen.Length > 2 ? yonetmen.Substring(1) : yonetmen;

            string oyuncuDeger = string.IsNullOrEmpty(oyuncu)
                ? ""
                : oyuncu.Length > 2 ? oyuncu.Substring(1) : oyuncu;

            // 🔴 VERİTABANI İŞLEMİ
            baglanti.Open();

            string sorgu = @"
INSERT INTO FilmlerTbl
(filmad, filmtur, filmyonetmen, filmoyuncu, imdb, filmtarih, filmafis, filmdurum, filmdetay)
VALUES
(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)";

            SqlCommand komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@p1", textmoviename.Text);
            komut.Parameters.AddWithValue("@p2", turDeger);
            komut.Parameters.AddWithValue("@p3", yonetmenDeger);
            komut.Parameters.AddWithValue("@p4", oyuncuDeger);

            // imdb → double
            komut.Parameters.Add("@p5", SqlDbType.Float).Value = imdbPuan;

            // tarih → Date
            komut.Parameters.Add("@p6", SqlDbType.Date).Value = filmTarih;

            // afiş → varbinary
            komut.Parameters.Add("@p7", SqlDbType.VarBinary).Value =
                afisBytes != null ? afisBytes : (object)DBNull.Value;

            komut.Parameters.AddWithValue("@p8", durum);
            komut.Parameters.AddWithValue("@p9", richTextdetails.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Film kaydı başarılı 🎉");

        }

        string secilenTur = "";
        string warnings1 = "";
        void tur()
        {
            foreach (Control arac in groupBoxTur.Controls)
            {

                if (arac is Label)
                {
                    if (arac.ForeColor == Color.Black)
                    {
                    }
                    else secilenTur += "," + arac.Text.ToString();


                }
            }

        }

        void warnings11()
        {


            foreach (Control arac in groupBoxWarnings.Controls)
            {

                if (arac is Label)
                {
                    if (arac.ForeColor == Color.Black)
                    {
                    }
                    else warnings1 += "," + arac.Text.ToString();


                }
            }


        }




        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            oyuncuAra();
        }
        void oyuncuAra()
        {

            string sorgu = "select * from OyuncularTbl where AdSoyad like '%" + textBox2.Text + "%' collate Turkish_CI_AS order by AdSoyad asc";
            flowPaneloyuncu.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                UserOyuncu arac = new UserOyuncu();
                arac.labeladsoyad.Text = rdr["AdSoyad"].ToString();
                flowPaneloyuncu.Controls.Add(arac);
            }
            baglanti.Close();
        }

        void yonetmenAra()
        {

            string sorgu = "select * from YonetmenlerTbl where AdSoyad like '%" + textBox1.Text + "%' collate Turkish_CI_AS order by AdSoyad asc";
            flowPanelyonetmen.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                UserYonetmen arac = new UserYonetmen();
                arac.labeladsoyad.Text = rdr["AdSoyad"].ToString();
                flowPanelyonetmen.Controls.Add(arac);
            }
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            yonetmenAra();
        }

        private void labelAksiyon_Click(object sender, EventArgs e)
        {
            if (labelAksiyon.ForeColor == Color.Black)
            {
                labelAksiyon.ForeColor = Color.Chocolate;
            }

            else
            {
                labelAksiyon.ForeColor = Color.Black;
            }
        }

        private void labelRomantik_Click(object sender, EventArgs e)
        {
            if (labelRomantik.ForeColor == Color.Black)
            {
                labelRomantik.ForeColor = Color.Chocolate;
            }

            else
            {
                labelRomantik.ForeColor = Color.Black;
            }
        }

        private void labelGerilim_Click(object sender, EventArgs e)
        {
            if (labelGerilim.ForeColor == Color.Black)
            {
                labelGerilim.ForeColor = Color.Chocolate;
            }

            else
            {
                labelGerilim.ForeColor = Color.Black;
            }
        }

        private void labelPsikolojik_Click(object sender, EventArgs e)
        {
            if (labelPsikolojik.ForeColor == Color.Black)
            {
                labelPsikolojik.ForeColor = Color.Chocolate;
            }

            else
            {
                labelPsikolojik.ForeColor = Color.Black;
            }
        }

        private void labelDram_Click(object sender, EventArgs e)
        {
            if (labelDram.ForeColor == Color.Black)
            {
                labelDram.ForeColor = Color.Chocolate;
            }

            else
            {
                labelDram.ForeColor = Color.Black;
            }
        }

        private void labelFantastik_Click(object sender, EventArgs e)
        {
            if (labelFantastik.ForeColor == Color.Black)
            {
                labelFantastik.ForeColor = Color.Chocolate;
            }

            else
            {
                labelFantastik.ForeColor = Color.Black;
            }
        }

        private void labelBilim_Click(object sender, EventArgs e)
        {
            if (labelBilim.ForeColor == Color.Black)
            {
                labelBilim.ForeColor = Color.Chocolate;
            }

            else
            {
                labelBilim.ForeColor = Color.Black;
            }
        }

        private void labelWestern_Click(object sender, EventArgs e)
        {
            if (labelWestern.ForeColor == Color.Black)
            {
                labelWestern.ForeColor = Color.Chocolate;
            }

            else
            {
                labelWestern.ForeColor = Color.Black;
            }
        }

        private void labelMüzik_Click(object sender, EventArgs e)
        {
            if (labelMüzik.ForeColor == Color.Black)
            {
                labelMüzik.ForeColor = Color.Chocolate;
            }

            else
            {

                labelMüzik.ForeColor = Color.Black;
            }
        }

        private void labelBelge_Click(object sender, EventArgs e)
        {
            if (labelBelge.ForeColor == Color.Black)
            {
                labelBelge.ForeColor = Color.Chocolate;
            }

            else
            {
                labelBelge.ForeColor = Color.Black;
            }
        }

        private void labelturkce_Click(object sender, EventArgs e)
        {
            if (labelturkce.ForeColor == Color.Black)
            {
                labelturkce.ForeColor = Color.Chocolate;
            }

            else
            {
                labelturkce.ForeColor = Color.Black;
            }
        }

        private void labelingilizce_Click(object sender, EventArgs e)
        {
            if (labelingilizce.ForeColor == Color.Black)
            {
                labelingilizce.ForeColor = Color.Chocolate;
            }

            else
            {
                labelingilizce.ForeColor = Color.Black;
            }
        }

        private void labelaltyazı_Click(object sender, EventArgs e)
        {
            if (labelaltyazı.ForeColor == Color.Black)
            {
                labelaltyazı.ForeColor = Color.Chocolate;
            }

            else
            {
                labelaltyazı.ForeColor = Color.Black;
            }
        }

        private void labelgenel_Click(object sender, EventArgs e)
        {
            if (labelgenel.ForeColor == Color.Black)
            {
                labelgenel.ForeColor = Color.Chocolate;
            }

            else
            {
                labelgenel.ForeColor = Color.Black;
            }
        }

        private void label13yas_Click(object sender, EventArgs e)
        {
            if (label13yas.ForeColor == Color.Black)
            {
                label13yas.ForeColor = Color.Chocolate;
            }

            else
            {
                label13yas.ForeColor = Color.Black;
            }
        }

        private void label18yas_Click(object sender, EventArgs e)
        {
            if (label18yas.ForeColor == Color.Black)
            {
                label18yas.ForeColor = Color.Chocolate;
            }

            else
            {
                label18yas.ForeColor = Color.Black;
            }
        }

        private void maskedYayinTarihi_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBoxTur_Enter(object sender, EventArgs e)
        {

        }
    }
}
    
   

