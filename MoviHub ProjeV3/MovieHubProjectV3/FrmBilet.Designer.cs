namespace MovieHubProjectV3
{
    partial class FrmBilet
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
            this.btnKapat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cmbBiletTuru = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnBiletKes = new System.Windows.Forms.Button();
            this.txtKoltukNo = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.cmbSeans = new System.Windows.Forms.ComboBox();
            this.cmbTarih = new System.Windows.Forms.ComboBox();
            this.cmbSalon = new System.Windows.Forms.ComboBox();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelKoltuklar = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Red;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(1181, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(39, 51);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.cmbBiletTuru);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnIptal);
            this.groupBox1.Controls.Add(this.btnBiletKes);
            this.groupBox1.Controls.Add(this.txtKoltukNo);
            this.groupBox1.Controls.Add(this.txtTelNo);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.cmbSeans);
            this.groupBox1.Controls.Add(this.cmbTarih);
            this.groupBox1.Controls.Add(this.cmbSalon);
            this.groupBox1.Controls.Add(this.cmbFilm);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(195)))), ((int)(((byte)(10)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 709);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçim ve Müşteri Bilgileri";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtMail.Location = new System.Drawing.Point(188, 557);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(225, 32);
            this.txtMail.TabIndex = 8;
            // 
            // cmbBiletTuru
            // 
            this.cmbBiletTuru.BackColor = System.Drawing.Color.PapayaWhip;
            this.cmbBiletTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBiletTuru.FormattingEnabled = true;
            this.cmbBiletTuru.Items.AddRange(new object[] {
            "tam bilet : 375.00 tl",
            "indirimli bilet : 250.00 tl"});
            this.cmbBiletTuru.Location = new System.Drawing.Point(188, 493);
            this.cmbBiletTuru.Name = "cmbBiletTuru";
            this.cmbBiletTuru.Size = new System.Drawing.Size(225, 32);
            this.cmbBiletTuru.TabIndex = 7;
            this.cmbBiletTuru.SelectedIndexChanged += new System.EventHandler(this.cmbBiletTuru_SelectedIndexChanged);
            this.cmbBiletTuru.Click += new System.EventHandler(this.cmbBiletTuru_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(20, 501);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 28);
            this.label10.TabIndex = 18;
            this.label10.Text = "Bilet Türü :";
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.DarkRed;
            this.btnIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(209, 616);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(126, 67);
            this.btnIptal.TabIndex = 17;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnBiletKes
            // 
            this.btnBiletKes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBiletKes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBiletKes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBiletKes.Location = new System.Drawing.Point(35, 616);
            this.btnBiletKes.Name = "btnBiletKes";
            this.btnBiletKes.Size = new System.Drawing.Size(126, 67);
            this.btnBiletKes.TabIndex = 9;
            this.btnBiletKes.Text = "Bilet Kes";
            this.btnBiletKes.UseVisualStyleBackColor = false;
            this.btnBiletKes.Click += new System.EventHandler(this.btnBiletKes_Click);
            // 
            // txtKoltukNo
            // 
            this.txtKoltukNo.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtKoltukNo.Enabled = false;
            this.txtKoltukNo.Location = new System.Drawing.Point(188, 435);
            this.txtKoltukNo.Name = "txtKoltukNo";
            this.txtKoltukNo.Size = new System.Drawing.Size(225, 32);
            this.txtKoltukNo.TabIndex = 6;
            // 
            // txtTelNo
            // 
            this.txtTelNo.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtTelNo.Location = new System.Drawing.Point(188, 374);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(225, 32);
            this.txtTelNo.TabIndex = 5;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtAdSoyad.Location = new System.Drawing.Point(188, 302);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(225, 32);
            this.txtAdSoyad.TabIndex = 4;
            // 
            // cmbSeans
            // 
            this.cmbSeans.BackColor = System.Drawing.Color.PapayaWhip;
            this.cmbSeans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeans.FormattingEnabled = true;
            this.cmbSeans.Location = new System.Drawing.Point(188, 234);
            this.cmbSeans.Name = "cmbSeans";
            this.cmbSeans.Size = new System.Drawing.Size(225, 32);
            this.cmbSeans.TabIndex = 3;
            this.cmbSeans.SelectedIndexChanged += new System.EventHandler(this.cmbSeans_SelectedIndexChanged);
            this.cmbSeans.Click += new System.EventHandler(this.cmbSeans_SelectedIndexChanged);
            // 
            // cmbTarih
            // 
            this.cmbTarih.BackColor = System.Drawing.Color.PapayaWhip;
            this.cmbTarih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarih.FormattingEnabled = true;
            this.cmbTarih.Location = new System.Drawing.Point(188, 164);
            this.cmbTarih.Name = "cmbTarih";
            this.cmbTarih.Size = new System.Drawing.Size(225, 32);
            this.cmbTarih.TabIndex = 2;
            this.cmbTarih.SelectedIndexChanged += new System.EventHandler(this.cmbTarih_SelectedIndexChanged);
            this.cmbTarih.Click += new System.EventHandler(this.cmbTarih_SelectedIndexChanged);
            // 
            // cmbSalon
            // 
            this.cmbSalon.BackColor = System.Drawing.Color.PapayaWhip;
            this.cmbSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalon.FormattingEnabled = true;
            this.cmbSalon.Location = new System.Drawing.Point(188, 101);
            this.cmbSalon.Name = "cmbSalon";
            this.cmbSalon.Size = new System.Drawing.Size(225, 32);
            this.cmbSalon.TabIndex = 1;
            this.cmbSalon.SelectedIndexChanged += new System.EventHandler(this.cmbSalon_SelectedIndexChanged);
            this.cmbSalon.Click += new System.EventHandler(this.cmbSalon_SelectedIndexChanged);
            // 
            // cmbFilm
            // 
            this.cmbFilm.BackColor = System.Drawing.Color.PapayaWhip;
            this.cmbFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(188, 41);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(225, 32);
            this.cmbFilm.TabIndex = 0;
            this.cmbFilm.SelectedIndexChanged += new System.EventHandler(this.cmbFilm_SelectedIndexChanged);
            this.cmbFilm.Click += new System.EventHandler(this.cmbFilm_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(18, 561);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "E Posta :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(19, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Koltuk No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(19, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(19, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 56);
            this.label5.TabIndex = 4;
            this.label5.Text = "Müşteri \r\nAd Soyad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seans :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salon Seçin :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Seçin :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelKoltuklar);
            this.panel1.Location = new System.Drawing.Point(557, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 664);
            this.panel1.TabIndex = 15;
            // 
            // panelKoltuklar
            // 
            this.panelKoltuklar.AutoScroll = true;
            this.panelKoltuklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKoltuklar.Location = new System.Drawing.Point(0, 0);
            this.panelKoltuklar.Name = "panelKoltuklar";
            this.panelKoltuklar.Size = new System.Drawing.Size(598, 664);
            this.panelKoltuklar.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Firebrick;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(791, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 38);
            this.label9.TabIndex = 0;
            this.label9.Text = "P E R D E";
            // 
            // FrmBilet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1221, 764);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBilet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBilet";
            this.Load += new System.EventHandler(this.FrmBilet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtKoltukNo;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.ComboBox cmbSeans;
        private System.Windows.Forms.ComboBox cmbTarih;
        private System.Windows.Forms.ComboBox cmbSalon;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBiletKes;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panelKoltuklar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBiletTuru;
        private System.Windows.Forms.Label label10;
    }
}