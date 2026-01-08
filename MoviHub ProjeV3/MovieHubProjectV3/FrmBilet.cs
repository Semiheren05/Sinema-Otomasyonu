using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace MovieHubProjectV3
{
    public partial class FrmBilet : Form
    {
        public FrmBilet()
        {
            InitializeComponent();
        }

        SQLBaglantisi bgl = new SQLBaglantisi();
        double toplamFiyat = 0;

        private void FrmBilet_Load(object sender, EventArgs e)
        {
            filmGetir();

            if (cmbBiletTuru.Items.Count > 0)
            {
                cmbBiletTuru.SelectedIndex = 0;
            }

            panelKoltuklar.AutoScroll = true;
            panelMesajYaz();
        }

        void panelMesajYaz()
        {
            panelKoltuklar.Controls.Clear();
            Label lbl = new Label();
            lbl.Text = "Lütfen Koltukları Görmek İçin\nFilm, Salon ve Seans Seçimi Yapınız...";
            lbl.ForeColor = Color.Orange;
            lbl.Font = new Font("Segoe UI", 12, FontStyle.Italic);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            lbl.AutoSize = false;
            lbl.Dock = DockStyle.Fill;
            panelKoltuklar.Controls.Add(lbl);
        }

        void filmGetir()
        {
            string sorgu = "SELECT DISTINCT FilmAdi FROM KontrolTbl ORDER BY FilmAdi ASC";
            SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            cmbFilm.Items.Clear();
            while (dr.Read()) { cmbFilm.Items.Add(dr[0].ToString()); }
            bgl.baglanti().Close();
        }
        private void cmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSalon.Items.Clear(); cmbTarih.Items.Clear(); cmbSeans.Items.Clear();
            cmbSalon.Text = ""; cmbTarih.Text = ""; cmbSeans.Text = ""; txtKoltukNo.Text = "";
            panelMesajYaz();

            string sorgu = "SELECT DISTINCT SalonAdi FROM KontrolTbl WHERE FilmAdi=@p1";
            SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbFilm.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) { cmbSalon.Items.Add(dr[0].ToString()); }
            bgl.baglanti().Close();
        }

        private void cmbSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTarih.Items.Clear(); cmbSeans.Items.Clear();
            cmbTarih.Text = ""; cmbSeans.Text = "";
            panelMesajYaz();

            string sorgu = "SELECT DISTINCT Tarih FROM KontrolTbl WHERE FilmAdi=@p1 AND SalonAdi=@p2";
            SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbFilm.Text);
            komut.Parameters.AddWithValue("@p2", cmbSalon.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) { cmbTarih.Items.Add(dr[0].ToString()); }
            bgl.baglanti().Close();
        }

        private void cmbTarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSeans.Items.Clear(); cmbSeans.Text = "";
            panelMesajYaz();

            string sorgu = "SELECT DISTINCT Seans FROM KontrolTbl WHERE FilmAdi=@p1 AND SalonAdi=@p2 AND Tarih=@p3";
            SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbFilm.Text);
            komut.Parameters.AddWithValue("@p2", cmbSalon.Text);
            komut.Parameters.AddWithValue("@p3", cmbTarih.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) { cmbSeans.Items.Add(dr[0].ToString()); }
            bgl.baglanti().Close();
        }

        private void cmbSeans_SelectedIndexChanged(object sender, EventArgs e)
        {
            koltuklariDose();
        }

        void koltuklariDose()
        {
            panelKoltuklar.Controls.Clear();
            txtKoltukNo.Text = "";
            toplamFiyat = 0;

            int koltukSayisi = 0;
            SqlCommand komutSalon = new SqlCommand("SELECT koltuksayisi FROM salonlarTbl WHERE salonadi=@p1", bgl.baglanti());
            komutSalon.Parameters.AddWithValue("@p1", cmbSalon.Text);
            SqlDataReader drSalon = komutSalon.ExecuteReader();
            if (drSalon.Read()) { koltukSayisi = Convert.ToInt32(drSalon[0]); }
            bgl.baglanti().Close();

            string doluKoltuklar = "";
            SqlCommand komutSeans = new SqlCommand("SELECT Koltuklar FROM KontrolTbl WHERE FilmAdi=@p1 AND SalonAdi=@p2 AND Tarih=@p3 AND Seans=@p4", bgl.baglanti());
            komutSeans.Parameters.AddWithValue("@p1", cmbFilm.Text);
            komutSeans.Parameters.AddWithValue("@p2", cmbSalon.Text);
            komutSeans.Parameters.AddWithValue("@p3", cmbTarih.Text);
            komutSeans.Parameters.AddWithValue("@p4", cmbSeans.Text);
            SqlDataReader drSeans = komutSeans.ExecuteReader();
            if (drSeans.Read()) { doluKoltuklar = drSeans[0].ToString(); }
            bgl.baglanti().Close();

            for (int i = 1; i <= koltukSayisi; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                btn.Size = new Size(50, 50);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Margin = new Padding(3);
                btn.ForeColor = Color.White;
                btn.Tag = i;

                bool doluMu = false;
                if (!string.IsNullOrEmpty(doluKoltuklar))
                {
                    foreach (string s in doluKoltuklar.Split(','))
                    {
                        if (s.Trim() == i.ToString()) doluMu = true;
                    }
                }

                if (doluMu)
                {
                    btn.BackColor = Color.DarkRed;
                    btn.Enabled = false;
                }
                else
                {
                    btn.BackColor = Color.FromArgb(0, 100, 200);
                    btn.Cursor = Cursors.Hand;
                    btn.Click += Btn_Koltuk_Click;
                }
                panelKoltuklar.Controls.Add(btn);
            }
        }

        private void Btn_Koltuk_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            if (tiklanan.BackColor == Color.Orange)
                tiklanan.BackColor = Color.FromArgb(0, 100, 200);
            else
                tiklanan.BackColor = Color.Orange;

            hesaplaVeYazdir();
        }

        private void cmbBiletTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            hesaplaVeYazdir();
        }
        void hesaplaVeYazdir()
        {
            string secilenKoltuklar = "";
            int secilenAdet = 0;
            double birimFiyat = 0;

            string secilenTur = cmbBiletTuru.Text.ToLower();

            if (secilenTur.Contains("indirimli"))
            {
                birimFiyat = 250;
            }
            else
            {
                birimFiyat = 375;
            }

            foreach (Control ctrl in panelKoltuklar.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = (Button)ctrl;
                    if (btn.BackColor == Color.Orange)
                    {
                        secilenKoltuklar += btn.Text + ",";
                        secilenAdet++;
                    }
                }
            }

            if (secilenKoltuklar.Length > 0)
                secilenKoltuklar = secilenKoltuklar.Substring(0, secilenKoltuklar.Length - 1);

            txtKoltukNo.Text = secilenKoltuklar;
            toplamFiyat = secilenAdet * birimFiyat;

            this.Text = "Bilet Ekranı - Toplam Tutar: " + toplamFiyat.ToString() + " TL";
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            temizleForm();
        }

        void temizleForm()
        {
            txtAdSoyad.Text = ""; txtTelNo.Text = ""; txtKoltukNo.Text = ""; txtMail.Text = "";
            toplamFiyat = 0;
            this.Text = "Bilet Ekranı";
            cmbFilm.SelectedIndex = -1;
            cmbSalon.Items.Clear(); cmbSalon.Text = "";
            cmbTarih.Items.Clear(); cmbTarih.Text = "";
            cmbSeans.Items.Clear(); cmbSeans.Text = "";
            panelMesajYaz();
        }
        private void btnBiletKes_Click(object sender, EventArgs e)
        {
            if (txtKoltukNo.Text == "" || txtAdSoyad.Text == "" || txtMail.Text == "")
            {
                MessageBox.Show("Lütfen Koltuk, İsim ve E-Posta giriniz.", "Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sorgu = "INSERT INTO BiletTbl (AdSoyad, TelNo, KoltukNo, Film, Tarih, Seans, Salon, Tur, IslemSaati) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)";
                SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text.ToUpper());
                komut.Parameters.AddWithValue("@p2", txtTelNo.Text);
                komut.Parameters.AddWithValue("@p3", txtKoltukNo.Text);
                komut.Parameters.AddWithValue("@p4", cmbFilm.Text);
                komut.Parameters.AddWithValue("@p5", cmbTarih.Text);
                komut.Parameters.AddWithValue("@p6", cmbSeans.Text);
                komut.Parameters.AddWithValue("@p7", cmbSalon.Text);
                komut.Parameters.AddWithValue("@p8", cmbBiletTuru.Text);
                komut.Parameters.AddWithValue("@p9", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

               
                string guncelle = "UPDATE KontrolTbl SET Koltuklar = Koltuklar + @k1 WHERE FilmAdi=@p1 AND SalonAdi=@p2 AND Tarih=@p3 AND Seans=@p4";
                SqlCommand komut2 = new SqlCommand(guncelle, bgl.baglanti());
                komut2.Parameters.AddWithValue("@k1", txtKoltukNo.Text + ",");
                komut2.Parameters.AddWithValue("@p1", cmbFilm.Text);
                komut2.Parameters.AddWithValue("@p2", cmbSalon.Text);
                komut2.Parameters.AddWithValue("@p3", cmbTarih.Text);
                komut2.Parameters.AddWithValue("@p4", cmbSeans.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();

               
                string kasaSorgu = "INSERT INTO KasaTbl (Tutar, Aciklama, Tarih) VALUES (@k1, @k2, @k3)";
                SqlCommand komutKasa = new SqlCommand(kasaSorgu, bgl.baglanti());
                komutKasa.Parameters.AddWithValue("@k1", toplamFiyat.ToString());
                komutKasa.Parameters.AddWithValue("@k2", cmbFilm.Text + " filmi bilet satışı");
                komutKasa.Parameters.AddWithValue("@k3", DateTime.Now.ToString());
                komutKasa.ExecuteNonQuery();
                bgl.baglanti().Close();

                
                mailGonder();

                
                FrmFatura fr = new FrmFatura();
                fr.film = cmbFilm.Text;
                fr.salon = cmbSalon.Text;
                fr.tarih = cmbTarih.Text;
                fr.seans = cmbSeans.Text;
                fr.koltuk = txtKoltukNo.Text;
                fr.adsoyad = txtAdSoyad.Text;
                fr.tur = cmbBiletTuru.Text;
                fr.fiyat = toplamFiyat.ToString();
                fr.Show();

                
                koltuklariDose();
                txtAdSoyad.Text = ""; txtTelNo.Text = ""; txtMail.Text = ""; txtKoltukNo.Text = "";
                toplamFiyat = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        void mailGonder()
        {
            try
            {
                MailMessage mesaj = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new NetworkCredential("24bilp0046@isik.edu.tr", "Yesim2024!");
                istemci.Port = 587;
                istemci.Host = "smtp-mail.outlook.com";
                istemci.EnableSsl = true;

                mesaj.To.Add(txtMail.Text);
                mesaj.From = new MailAddress("24bilp0046@isik.edu.tr", "Movie Hub Sinemaları");
                mesaj.Subject = "Sinema Biletiniz";

                string govde = "<h2>Sayın " + txtAdSoyad.Text + "</h2>";
                govde += "<p>Biletiniz başarıyla oluşturulmuştur.</p>";
                govde += "<br>Film: " + cmbFilm.Text;
                govde += "<br>Salon: " + cmbSalon.Text;
                govde += "<br>Tarih: " + cmbTarih.Text + " Saat: " + cmbSeans.Text;
                govde += "<br>Koltuklar: " + txtKoltukNo.Text;
                govde += "<br>Bilet Türü: " + cmbBiletTuru.Text;
                govde += "<br><strong>Ödenen Tutar: " + toplamFiyat.ToString() + " TL</strong>";

                mesaj.Body = govde;
                mesaj.IsBodyHtml = true;

                istemci.Send(mesaj);
            }
            catch (Exception)
            {
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}