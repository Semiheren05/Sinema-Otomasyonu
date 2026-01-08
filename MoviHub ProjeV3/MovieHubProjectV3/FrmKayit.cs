using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions; 

namespace MovieHubProjectV3
{
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }

        SQLBaglantisi bgl = new SQLBaglantisi();

        private void btnKayitTamamla_Click_1(object sender, EventArgs e)
        {
            
            if (txtAdSoyad.Text == "" || txtKullaniciAdi.Text == "" || txtSifre.Text == "" || txtSifreTekrar.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz! Boş alan bırakılamaz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            
            if (Regex.IsMatch(txtAdSoyad.Text, @"\d"))
            {
                MessageBox.Show("Ad Soyad kısmına rakam yazılamaz! Lütfen geçerli bir isim giriniz.", "Yazım Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdSoyad.Focus(); 
                return;
            }

            
            if (txtKullaniciAdi.Text.Length < 3)
            {
                MessageBox.Show("Kullanıcı adı en az 3 karakter olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKullaniciAdi.Focus();
                return;
            }

            
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor! Lütfen tekrar deneyiniz.", "Şifre Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSifre.Text = "";
                txtSifreTekrar.Text = "";
                txtSifre.Focus();
                return;
            }

            
            if (txtSifre.Text.Length < 6)
            {
                MessageBox.Show("Şifreniz çok kısa! Güvenlik için en az 6 karakter giriniz.", "Zayıf Şifre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            try
            {
                string sorgu = "INSERT INTO KullanicilarTbl (AdSoyad, KullaniciAdi, KullaniciSifre) VALUES (@p1, @p2, @p3)";
                SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text.ToUpper().Trim()); 
                komut.Parameters.AddWithValue("@p2", txtKullaniciAdi.Text.Trim());
                komut.Parameters.AddWithValue("@p3", txtSifre.Text.Trim());

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Kayıt işleminiz başarıyla gerçekleşti! Giriş yapabilirsiniz.", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt yapılamadı! Bu Kullanıcı Adı zaten kullanılıyor olabilir.\n\nHata Detayı: " + ex.Message, "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSifreGoster.Checked)
            {
                txtSifre.UseSystemPasswordChar = false;
                txtSifreTekrar.UseSystemPasswordChar = false;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
                txtSifreTekrar.UseSystemPasswordChar = true;
            }
        }

        //private void btnKayitTamamla_Click_1(object sender, EventArgs e)
        //{

        //}
    }
}