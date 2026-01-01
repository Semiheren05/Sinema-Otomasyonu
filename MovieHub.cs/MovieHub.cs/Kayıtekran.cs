using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MovieHub.cs
{
    public partial class Kayıtekran : Form
    {
        SqlConnection baglanti = new SqlConnection
            ("data source=.\\SQLEXPRESS; initial catalog=movieHubDB; integrated security=true;" +
            "Trusted_Connection=True;" +
            "Encrypt=False;TrustServerCertificate=True;");
        public Kayıtekran()
        {
            InitializeComponent();
        }

        private void Kayıtekran_Load(object sender, EventArgs e)
        {
            lblSifreUyari.Visible = false;
        }

        private void buttonWelcome_Click(object sender, EventArgs e)
        {
            // 1️⃣ Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(textAdSoyad.Text) ||
                string.IsNullOrWhiteSpace(textAdmin.Text) ||
                string.IsNullOrWhiteSpace(textPassword.Text) ||
                string.IsNullOrWhiteSpace(textPassword2.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }

            // 2️⃣ Şifreler uyuşuyor mu? (BAĞLANTIDAN ÖNCE)
            if (textPassword.Text != textPassword2.Text)
            {
                lblSifreUyari.Text = "Şifreler uyuşmuyor!";
                lblSifreUyari.Visible = true;
                return;
            }
            else
            {
                lblSifreUyari.Visible = false;
            }

            // 3️⃣ Veritabanı işlemleri
            baglanti.Open();

            // Kullanıcı adı var mı?
            SqlCommand kontrol = new SqlCommand(
                "SELECT COUNT(*) FROM KullanicilarTbl WHERE KullaniciAdi=@p1",
                baglanti);

            kontrol.Parameters.AddWithValue("@p1", textAdmin.Text);

            int sayi = (int)kontrol.ExecuteScalar();

            if (sayi > 0)
            {
                MessageBox.Show("Bu kullanıcı adı zaten kayıtlı!");
                baglanti.Close();
                return;
            }

            // 4️⃣ Kayıt ekle
            SqlCommand ekle = new SqlCommand(
                "INSERT INTO KullanicilarTbl (AdSoyad, KullaniciAdi, KullaniciSifre) VALUES (@p1, @p2, @p3)",
                baglanti);

            ekle.Parameters.AddWithValue("@p1", textAdSoyad.Text);
            ekle.Parameters.AddWithValue("@p2", textAdmin.Text);
            ekle.Parameters.AddWithValue("@p3", textPassword.Text);

            ekle.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt başarılı 🎉");

            // 5️⃣ Temizle
            textAdSoyad.Clear();
            textAdmin.Clear();
            textPassword.Clear();
            textPassword2.Clear();
            textAdSoyad.Focus();

        }

        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            bool goster = checkShow.Checked;

            textPassword.UseSystemPasswordChar = !goster;
            textPassword2.UseSystemPasswordChar = !goster;
        }

        private void lblSifreUyari_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
