using System;
using System.Data;
using System.Data.SqlClient; 
using System.Windows.Forms;

namespace MovieHubProjectV3
{
    public partial class FrmSalon : Form
    {
        public FrmSalon()
        {
            InitializeComponent();
        }

        SQLBaglantisi bgl = new SQLBaglantisi();

        
        void listeGetir()
        {
            
            string sorgu = "SELECT * FROM salonlarTbl ORDER BY ID ASC";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

           
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].Width = 50; // ID
                dataGridView1.Columns[1].Width = 200; // Salon Adı
            }
        }

        private void FrmSalon_Load(object sender, EventArgs e)
        {
            listeGetir();
            
            if (cbKoltukSayisi.Items.Count > 0)
            {
                cbKoltukSayisi.SelectedIndex = 0;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            if (txtSalonAdi.Text == "")
            {
                MessageBox.Show("Lütfen Salon Adını yazınız!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalonAdi.Focus();
                return;
            }

            try
            {
               
                string sorgu = "INSERT INTO salonlarTbl (salonadi, koltuksayisi) VALUES (@p1, @p2)";

                SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", txtSalonAdi.Text.ToUpper()); 
                komut.Parameters.AddWithValue("@p2", cbKoltukSayisi.Text); 

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Salon Başarıyla Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                listeGetir();
                txtSalonAdi.Text = "";
                txtSalonAdi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu! Aynı isimde salon olabilir mi?\nHata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
            private void btnSil_Click(object sender, EventArgs e)
        {
        
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek kaydı listeden seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            string secilenID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string secilenAd = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            
            DialogResult karar = MessageBox.Show(secilenAd + "silmek istediğinize emin misiniz?\nBu işlem geri alınamaz!", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (karar == DialogResult.Yes)
            {
                try
                {
                    
                    string sorgu = "DELETE FROM salonlarTbl WHERE ID = @p1";
                    SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", secilenID);

                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();

                    MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    listeGetir();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme işlemi başarısız oldu.\nHata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    
}