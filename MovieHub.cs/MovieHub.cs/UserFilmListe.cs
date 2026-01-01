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
    public partial class UserFilmListe : UserControl
    {
        public UserFilmListe()
        {
            InitializeComponent();
        }

        private void pictureBoxMovie_Click(object sender, EventArgs e)
        {
            MessageBox.Show(labelID.Text);
        }

        private void buttonfilm_Click(object sender, EventArgs e)
        {
            FormFilmDetay form = new FormFilmDetay();
            form.idno=labelID.Text;
            form.ShowDialog();
        }
    }
}
