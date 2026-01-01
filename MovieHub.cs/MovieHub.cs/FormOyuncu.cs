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
namespace MovieHub.cs
{
    public partial class FormOyuncu : Form
    {
        SqlConnection baglanti = new SqlConnection
           ("data source=.\\SQLEXPRESS; initial catalog=movieHubDB; integrated security=true;" +
           "Trusted_Connection=True;" +
           "Encrypt=False;TrustServerCertificate=True;");
        public FormOyuncu()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string photo = "";
        private void buttonphotoLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "foto seçme ekranı";
            dialog.Filter = "PNG (*.png)|*.png|JPG (*.jpg)|*.jpg|JPEG (*.jpeg)|*.jpeg|Tüm Dosyalar (*.*)|*.*";

            dialog.FilterIndex = 4;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxyonetmen.Image = Image.FromFile(dialog.FileName);
                photo = dialog.FileName;
            }
        }
        public string gender = "0";
        private void radiofemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "1";
        }

        private void radiomale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "0";
        }


        private void buttonoyuncukayıt_Click(object sender, EventArgs e)
        {

            if (textad.Text != "" && textsoyad.Text != "" && maskeddogum.Text != "" && photo != "")
            {
                string adsoyad = textad.Text + " " + textsoyad.Text;
                int yas = YasHesapla(maskeddogum.Text);
                baglanti.Open();
                SqlCommand kayit = new SqlCommand("insert into OyuncularTbl (AdSoyad,cinsiyet,yas,biyografi,fotograf)" +
                    " values (@p1,@p2,@p3,@p4,@p5)", baglanti);
                kayit.Parameters.AddWithValue("@p1", adsoyad);
                kayit.Parameters.AddWithValue("@p2", gender);
                kayit.Parameters.AddWithValue("@p3", yas);
                kayit.Parameters.AddWithValue("@p4", richTextbiyografi.Text);
                kayit.Parameters.AddWithValue("@p5", photo);
                kayit.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("success");
                toolclean();
            }
            else { MessageBox.Show("Check it Once! or Check-it-Twice"); }

        }
        void toolclean()
        {
            textad.Text = "";
            textsoyad.Text = "";
            maskeddogum.Text = string.Empty;
            richTextbiyografi.Text = string.Empty;
            pictureBoxyonetmen.ImageLocation = @"C:\Users\yesim\Pictures\Saved Pictures\Queen.JPG";
            radiomale.Checked = false;
            radiofemale.Checked = true;
            label150.Text = "150";


            textad.Focus();
        }
        private int YasHesapla(string tarihMetni)
        {
            if (!DateTime.TryParse(tarihMetni, out DateTime dogumTarihi))
                return -1;  // Geçersiz tarih

            DateTime bugun = DateTime.Today;

            int yas = bugun.Year - dogumTarihi.Year;

            if (dogumTarihi > bugun.AddYears(-yas))
                yas--;

            return yas;
        }
        private void richTextbiyografi_TextChanged(object sender, EventArgs e)
        {
            int count = richTextbiyografi.Text.Length;
            int countdown = 150 - count;
            label150.Text = countdown.ToString();
        }

        //private void richTextbiyografi_TextChanged_1(object sender, EventArgs e)
        //{

        //}
    }
}
