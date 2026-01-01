using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieHub.cs
{
    public partial class FormAnaEkran : Form
    {
        public FormAnaEkran()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormYonetmenKayit form = new FormYonetmenKayit();
            form.ShowDialog(); //açılır pencere

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormYonetmenListe form = new FormYonetmenListe();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormOyuncu form = new FormOyuncu();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormOyuncuListecs form = new FormOyuncuListecs();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormSalon form = new FormSalon();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormFilmKayit form = new FormFilmKayit();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormFilmLİste form = new FormFilmLİste();
            form.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormBiletOlustur form = new FormBiletOlustur();
            form.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            misirsatis form = new misirsatis();
            form.ShowDialog();
        }
    }
}
