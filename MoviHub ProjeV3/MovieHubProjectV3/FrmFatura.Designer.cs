namespace MovieHubProjectV3
{
    partial class FrmFatura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFilm = new System.Windows.Forms.Label();
            this.lblSalonSeans = new System.Windows.Forms.Label();
            this.lblKoltuk = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "    MOVIE HUB\r\n             SİNEMALARI";
//            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bilet Fişi :";
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Location = new System.Drawing.Point(90, 193);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(68, 23);
            this.lblFilm.TabIndex = 2;
            this.lblFilm.Text = "filmadi";
            // 
            // lblSalonSeans
            // 
            this.lblSalonSeans.AutoSize = true;
            this.lblSalonSeans.Location = new System.Drawing.Point(90, 253);
            this.lblSalonSeans.Name = "lblSalonSeans";
            this.lblSalonSeans.Size = new System.Drawing.Size(105, 23);
            this.lblSalonSeans.TabIndex = 3;
            this.lblSalonSeans.Text = "salonseans";
            // 
            // lblKoltuk
            // 
            this.lblKoltuk.AutoSize = true;
            this.lblKoltuk.Location = new System.Drawing.Point(90, 312);
            this.lblKoltuk.Name = "lblKoltuk";
            this.lblKoltuk.Size = new System.Drawing.Size(87, 23);
            this.lblKoltuk.TabIndex = 4;
            this.lblKoltuk.Text = "koltukno";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(90, 367);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(108, 23);
            this.lblTur.TabIndex = 5;
            this.lblTur.Text = "tamogrenci";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(90, 420);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(77, 23);
            this.lblAdSoyad.TabIndex = 6;
            this.lblAdSoyad.Text = "müşteri";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(90, 474);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(49, 23);
            this.lblFiyat.TabIndex = 7;
            this.lblFiyat.Text = "fiyat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 582);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "\"İyi Seyirler Dileriz...\"";
            // 
            // FrmFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(388, 651);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblKoltuk);
            this.Controls.Add(this.lblSalonSeans);
            this.Controls.Add(this.lblFilm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("HarmonyOS Sans SC Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmFatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFatura";
            this.Load += new System.EventHandler(this.FrmFatura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Label lblSalonSeans;
        private System.Windows.Forms.Label lblKoltuk;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label label9;
    }
}