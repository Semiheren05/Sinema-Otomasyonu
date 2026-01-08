using System;
using System.Data;
using System.Data.SqlClient; 
using System.Drawing; 
using System.IO; 
using System.Windows.Forms;

namespace MovieHubProjectV3
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        SQLBaglantisi bgl = new SQLBaglantisi();

        public void formGetir(Form frm)
        {
            panelAna.Controls.Clear(); 
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelAna.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();

            if (fr.ShowDialog() == DialogResult.OK)
            {
                filmAfisleriniGetir();
            }
            else
            {
                Application.Exit();
            }
        }
        void filmAfisleriniGetir()
        {
            panelAnaGovde.Controls.Clear();

            SqlCommand komut = new SqlCommand("SELECT * FROM FilmlerTbl ORDER BY ID DESC", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                GroupBox grup = new GroupBox();
                grup.Text = dr["filmad"].ToString(); 
                grup.Size = new Size(200, 320);
                grup.ForeColor = Color.White;
                grup.BackColor = Color.Transparent;

               
                PictureBox resim = new PictureBox();
                resim.Size = new Size(180, 260);
                resim.Location = new Point(10, 20);
                resim.SizeMode = PictureBoxSizeMode.StretchImage;
                resim.Cursor = Cursors.Hand;

                string resimYolu = dr["filmafis"].ToString();

                try
                {
                    if (File.Exists(resimYolu))
                    {
                        resim.Image = Image.FromFile(resimYolu);
                    }
                    else
                    {
                        resim.Image = null;
                    }
                }
                catch
                {
                    resim.Image = null;
                }
                resim.Tag = dr["ID"].ToString() + "|" + dr["filmad"].ToString() + "|" + resimYolu;

                resim.Click += Resim_Click;

                grup.Controls.Add(resim);
                panelAnaGovde.Controls.Add(grup);
            }
            bgl.baglanti().Close();
        }
        private void Resim_Click(object sender, EventArgs e)
        {
            PictureBox tiklananResim = (PictureBox)sender;

            string[] bilgiler = tiklananResim.Tag.ToString().Split('|');

            FrmFilmDetay fr = new FrmFilmDetay();
            fr.id = bilgiler[0];
            fr.filmAdi = bilgiler[1];
            fr.afisYolu = bilgiler[2];
            fr.Show();
        }
        private void btnYonetmen_Click(object sender, EventArgs e)
        {
            FrmYonetmen fr = new FrmYonetmen();
            formGetir(fr);
        }
        private void btnOyuncu_Click(object sender, EventArgs e)
        {
            FrmOyuncu fr = new FrmOyuncu();
            formGetir(fr);
        }
        private void btnOyuncu_Click_1(object sender, EventArgs e)
        {
            FrmOyuncu fr = new FrmOyuncu();
            formGetir(fr);
        }
        private void btnSalon_Click(object sender, EventArgs e)
        {
            FrmSalon fr = new FrmSalon();
            formGetir(fr);
        }
        private void btnFilm_Click(object sender, EventArgs e)
        {
            FrmFilm fr = new FrmFilm();
            formGetir(fr);
        }
        private void btnSeans_Click(object sender, EventArgs e)
        {
            FrmSeansListesi fr = new FrmSeansListesi();
            formGetir(fr);
        }
        private void btnBilet_Click(object sender, EventArgs e)
        {
            FrmBilet fr = new FrmBilet();
            formGetir(fr);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmKasa fr = new FrmKasa();
            formGetir(fr);
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Uygulamadan tamamen çıkmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void btnYonetmen_Click_1(object sender, EventArgs e)
        {
            FrmYonetmen fr = new FrmYonetmen();
            formGetir(fr);
        }
    }
}