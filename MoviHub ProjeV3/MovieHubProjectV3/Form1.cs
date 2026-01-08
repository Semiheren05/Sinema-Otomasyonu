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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        
        SQLBaglantisi bgl = new SQLBaglantisi();

        
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        
        private void FrmGiris_Load(object sender, EventArgs e)
        {
            
            txtSifre.UseSystemPasswordChar = true;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifre alanlarını doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlCommand komut = new SqlCommand("Select * FROM KullanicilarTbl WHERE KullaniciAdi=@p1 AND KullaniciSifre=@p2", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text.Trim());
                komut.Parameters.AddWithValue("@p2", txtSifre.Text.Trim());

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Giriş Başarılı! Hoşgeldiniz: " + dr["AdSoyad"].ToString(), "MOVIE HUB", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtSifre.Text = "";
                    txtKullaniciAdi.Focus();

                }

                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Veritabanı bağlantısında bir sorun oluştu!\nDetay: " + ex.Message, "Sistem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            FrmKayit fr = new FrmKayit();
            fr.Show();
        }


        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSifreGoster.Checked)
            {

                txtSifre.UseSystemPasswordChar = false;
            }
            else
            {

                txtSifre.UseSystemPasswordChar = true;
            }
        }
    }
    
}