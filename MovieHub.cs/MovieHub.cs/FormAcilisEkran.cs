
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

    public partial class FormAcilisEkran : Form
    {
        SqlConnection baglanti = new SqlConnection
            ("data source=.\\SQLEXPRESS; initial catalog=movieHubDB; integrated security=true;" +
            "Trusted_Connection=True;" +
            "Encrypt=False;TrustServerCertificate=True;");
        public FormAcilisEkran()
        {
            InitializeComponent();
        }



        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void buttonWelcome_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormAcilisEkran_Load(object sender, EventArgs e)
        {

        }

        private void textAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Panel içini temizle (önceden açýk form varsa)
            panel1.Controls.Clear();

            // Açýlacak form
            Kayýtekran frm = new Kayýtekran();

            // Formu panel içine gömebilmek için
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            // Panel içine ekle
            panel1.Controls.Add(frm);

            // Formu göster
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Panel içini temizle (önceden açýk form varsa)
            panel1.Controls.Clear();

            // Açýlacak form
            GiriþEkran frm = new GiriþEkran();

            // Formu panel içine gömebilmek için
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            // Panel içine ekle
            panel1.Controls.Add(frm);

            // Formu göster
            frm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool dragging = false;
        Point dragCursorPoint;
        Point dragFormPoint;
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}


