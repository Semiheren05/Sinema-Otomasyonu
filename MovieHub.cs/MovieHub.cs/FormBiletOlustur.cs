using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace MovieHub.cs
{
    public partial class FormBiletOlustur : Form
    {
        public FormBiletOlustur()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(
            @"Data Source=.\SQLEXPRESS;
              Initial Catalog=movieHubDB;
              Integrated Security=True;
              Encrypt=False;
              TrustServerCertificate=True;"
        );

        private void FormBiletOlustur_Load(object sender, EventArgs e)
        {
            filmAdiGetir();
            biletNoOlustur();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void biletNoOlustur()
        {
            string kod = Guid.NewGuid().ToString("N").Substring(0, 12);
            textbarkod.Text = kod;
        }

        void filmAdiGetir()
        {
            combofilmad.Items.Clear();

            string sorgu = "SELECT filmad, filmtarih FROM FilmlerTbl ORDER BY filmad ASC";

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                using (SqlDataReader reader = komut.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime filmTarih = reader.GetDateTime(reader.GetOrdinal("filmtarih"));

                        if (filmTarih >= DateTime.Today)
                        {
                            string filmAdi = reader.GetString(reader.GetOrdinal("filmad"));
                            combofilmad.Items.Add(filmAdi);
                        }
                    }
                }
            }
            finally
            {
                baglanti.Close();
            }
        }


        private void combofilmad_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboTarih.Items.Clear();
            flowLayoutSeans.Controls.Clear();
            combosalonadi.Items.Clear();

            string sorgu = @"SELECT DISTINCT Tarih 
                             FROM KontrolTbl 
                             WHERE FilmAdi = @FilmAdi";

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.Add("@FilmAdi", SqlDbType.NVarChar, 100)
                                    .Value = combofilmad.Text;

                    using (SqlDataReader reader = komut.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime tarih = reader.GetDateTime(0);
                            comboTarih.Items.Add(tarih.ToShortDateString());
                        }
                    }
                }
            }
            finally
            {
                baglanti.Close();
            }
        }


        private void comboTarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutSeans.Controls.Clear();
            combosalonadi.Items.Clear();

            if (comboTarih.SelectedItem == null)
                return;

            string sorgu = @"SELECT DISTINCT Seans 
                             FROM KontrolTbl 
                             WHERE FilmAdi = @FilmAdi 
                               AND Tarih = @Tarih";

            DateTime secilenTarih = Convert.ToDateTime(comboTarih.SelectedItem);

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.Add("@FilmAdi", SqlDbType.NVarChar, 100)
                                    .Value = combofilmad.Text;

                    komut.Parameters.Add("@Tarih", SqlDbType.Date)
                                    .Value = secilenTarih.Date;

                    using (SqlDataReader reader = komut.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RadioButton rb = new RadioButton
                            {
                                Text = reader.GetString(0),
                                AutoSize = true,
                                ForeColor = Color.RebeccaPurple
                            };

                            rb.CheckedChanged += seansSaatler;
                            flowLayoutSeans.Controls.Add(rb);
                        }
                    }
                }
            }
            finally
            {
                baglanti.Close();
            }
        }


        private void seansSaatler(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb == null || !rb.Checked)
                return;

            string secilenSeans = rb.Text;
            labelseanssec.Text = secilenSeans;
            combosalonadi.Items.Clear();

            string sorgu = @"SELECT DISTINCT SalonAdi
                             FROM KontrolTbl 
                             WHERE FilmAdi = @FilmAdi 
                               AND Tarih = @Tarih 
                               AND Seans = @Seans";

            DateTime secilenTarih = Convert.ToDateTime(comboTarih.SelectedItem);

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.Add("@FilmAdi", SqlDbType.NVarChar, 100)
                                    .Value = combofilmad.Text;

                    komut.Parameters.Add("@Tarih", SqlDbType.Date)
                                    .Value = secilenTarih.Date;

                    komut.Parameters.Add("@Seans", SqlDbType.NVarChar, 20)
                                    .Value = secilenSeans;

                    using (SqlDataReader reader = komut.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            combosalonadi.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void combosalonadi_SelectedIndexChanged(object sender, EventArgs e)
        {


            string sorgu = @"SELECT * from salonlarTbl where salonadi=@salonadi";

            DateTime secilenTarih = Convert.ToDateTime(comboTarih.SelectedItem);
            RadioButton rb = sender as RadioButton;
            string secilenSeans = rb.Text;
            labelseanssec.Text = secilenSeans;


            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.Add("@salonadi", SqlDbType.NVarChar, 100)
                                    .Value = combosalonadi.Text;

                    using (SqlDataReader reader = komut.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            textkoltukno.AppendText(reader.GetString(0)
                                + Environment.NewLine);

                        }
                    }
                }
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void buttonfilmkayıt_Click(object sender, EventArgs e)
        {
            flowLayoutKoltuk.Controls.Clear();
            int gelensayi = Convert.ToInt16(labelkoltuksayisi.Text);
            for (int i = 1; i <= gelensayi; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Width = 50;
                btn.Height = 50;
                flowLayoutKoltuk.Controls.Add(btn);
            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
    }
}
