namespace MovieHub.cs
{
    partial class FormFilmDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilmDetay));
            panel1 = new Panel();
            label4 = new Label();
            buttonExit = new Button();
            groupBox8 = new GroupBox();
            pictureBoxMovie = new PictureBox();
            groupBox1 = new GroupBox();
            labelfilmadi = new Label();
            textmoviename = new TextBox();
            groupBox2 = new GroupBox();
            labeltur = new Label();
            textBox1 = new TextBox();
            groupBox3 = new GroupBox();
            labelwarning = new Label();
            textBox2 = new TextBox();
            groupBox4 = new GroupBox();
            labeloyuncu = new Label();
            textBox3 = new TextBox();
            groupBox5 = new GroupBox();
            labelvizyontarihi = new Label();
            textBox4 = new TextBox();
            groupBox6 = new GroupBox();
            labelyonetmen = new Label();
            textBox5 = new TextBox();
            groupBox7 = new GroupBox();
            labelaktifpasif = new Label();
            textBox6 = new TextBox();
            groupBox10 = new GroupBox();
            labelimdb = new Label();
            textBox8 = new TextBox();
            groupBox11 = new GroupBox();
            labeldetay = new Label();
            textBox9 = new TextBox();
            panel1.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMovie).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox11.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buttonExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1323, 78);
            panel1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.FloralWhite;
            label4.Location = new Point(127, 21);
            label4.Name = "label4";
            label4.Size = new Size(145, 24);
            label4.TabIndex = 7;
            label4.Text = "Film Detayları";
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Sienna;
            buttonExit.BackgroundImage = (Image)resources.GetObject("buttonExit.BackgroundImage");
            buttonExit.BackgroundImageLayout = ImageLayout.Zoom;
            buttonExit.Cursor = Cursors.HSplit;
            buttonExit.Dock = DockStyle.Right;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Harlow Solid Italic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonExit.ForeColor = Color.FloralWhite;
            buttonExit.Location = new Point(1234, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(89, 78);
            buttonExit.TabIndex = 6;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // groupBox8
            // 
            groupBox8.BackColor = Color.Sienna;
            groupBox8.Controls.Add(pictureBoxMovie);
            groupBox8.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox8.ForeColor = Color.PeachPuff;
            groupBox8.Location = new Point(30, 93);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(10, 3, 3, 3);
            groupBox8.Size = new Size(1117, 328);
            groupBox8.TabIndex = 17;
            groupBox8.TabStop = false;
            groupBox8.Text = "Billboard";
            // 
            // pictureBoxMovie
            // 
            pictureBoxMovie.Image = (Image)resources.GetObject("pictureBoxMovie.Image");
            pictureBoxMovie.Location = new Point(31, 34);
            pictureBoxMovie.Name = "pictureBoxMovie";
            pictureBoxMovie.Size = new Size(1051, 283);
            pictureBoxMovie.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMovie.TabIndex = 18;
            pictureBoxMovie.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Sienna;
            groupBox1.Controls.Add(labelfilmadi);
            groupBox1.Controls.Add(textmoviename);
            groupBox1.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox1.ForeColor = Color.PeachPuff;
            groupBox1.Location = new Point(30, 439);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 3, 3, 3);
            groupBox1.Size = new Size(261, 79);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Film Adı";
            // 
            // labelfilmadi
            // 
            labelfilmadi.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            labelfilmadi.Location = new Point(6, 41);
            labelfilmadi.Name = "labelfilmadi";
            labelfilmadi.Size = new Size(252, 38);
            labelfilmadi.TabIndex = 1;
            labelfilmadi.Text = "label1";
            // 
            // textmoviename
            // 
            textmoviename.BorderStyle = BorderStyle.None;
            textmoviename.Dock = DockStyle.Bottom;
            textmoviename.Font = new Font("Harlow Solid Italic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textmoviename.Location = new Point(10, 48);
            textmoviename.Name = "textmoviename";
            textmoviename.Size = new Size(248, 28);
            textmoviename.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Sienna;
            groupBox2.Controls.Add(labeltur);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox2.ForeColor = Color.PeachPuff;
            groupBox2.Location = new Point(313, 439);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10, 3, 3, 3);
            groupBox2.Size = new Size(261, 79);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Film Türü";
            // 
            // labeltur
            // 
            labeltur.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            labeltur.Location = new Point(10, 38);
            labeltur.Name = "labeltur";
            labeltur.Size = new Size(251, 38);
            labeltur.TabIndex = 1;
            labeltur.Text = "label2";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Font = new Font("Harlow Solid Italic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(10, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 28);
            textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Sienna;
            groupBox3.Controls.Add(labelwarning);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox3.ForeColor = Color.PeachPuff;
            groupBox3.Location = new Point(873, 439);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10, 3, 3, 3);
            groupBox3.Size = new Size(261, 79);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Uyarılar";
            // 
            // labelwarning
            // 
            labelwarning.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            labelwarning.Location = new Point(10, 41);
            labelwarning.Name = "labelwarning";
            labelwarning.Size = new Size(251, 35);
            labelwarning.TabIndex = 1;
            labelwarning.Text = "label3";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Dock = DockStyle.Bottom;
            textBox2.Font = new Font("Harlow Solid Italic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(10, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 28);
            textBox2.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Sienna;
            groupBox4.Controls.Add(labeloyuncu);
            groupBox4.Controls.Add(textBox3);
            groupBox4.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox4.ForeColor = Color.PeachPuff;
            groupBox4.Location = new Point(30, 535);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(10, 3, 3, 3);
            groupBox4.Size = new Size(539, 79);
            groupBox4.TabIndex = 22;
            groupBox4.TabStop = false;
            groupBox4.Text = "Aktörler";
            // 
            // labeloyuncu
            // 
            labeloyuncu.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            labeloyuncu.Location = new Point(6, 38);
            labeloyuncu.Name = "labeloyuncu";
            labeloyuncu.Size = new Size(530, 38);
            labeloyuncu.TabIndex = 1;
            labeloyuncu.Text = "label5";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Dock = DockStyle.Bottom;
            textBox3.Font = new Font("Harlow Solid Italic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(10, 48);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(526, 28);
            textBox3.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Sienna;
            groupBox5.Controls.Add(labelvizyontarihi);
            groupBox5.Controls.Add(textBox4);
            groupBox5.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox5.ForeColor = Color.PeachPuff;
            groupBox5.Location = new Point(873, 535);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(10, 3, 3, 3);
            groupBox5.Size = new Size(261, 79);
            groupBox5.TabIndex = 21;
            groupBox5.TabStop = false;
            groupBox5.Text = "Yayın tarihi";
            // 
            // labelvizyontarihi
            // 
            labelvizyontarihi.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            labelvizyontarihi.Location = new Point(10, 41);
            labelvizyontarihi.Name = "labelvizyontarihi";
            labelvizyontarihi.Size = new Size(251, 35);
            labelvizyontarihi.TabIndex = 1;
            labelvizyontarihi.Text = "label6";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Dock = DockStyle.Bottom;
            textBox4.Font = new Font("Harlow Solid Italic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(10, 48);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(248, 28);
            textBox4.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.Sienna;
            groupBox6.Controls.Add(labelyonetmen);
            groupBox6.Controls.Add(textBox5);
            groupBox6.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox6.ForeColor = Color.PeachPuff;
            groupBox6.Location = new Point(584, 532);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(10, 3, 3, 3);
            groupBox6.Size = new Size(261, 79);
            groupBox6.TabIndex = 20;
            groupBox6.TabStop = false;
            groupBox6.Text = "Müdür";
            // 
            // labelyonetmen
            // 
            labelyonetmen.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            labelyonetmen.Location = new Point(10, 41);
            labelyonetmen.Name = "labelyonetmen";
            labelyonetmen.Size = new Size(248, 38);
            labelyonetmen.TabIndex = 1;
            labelyonetmen.Text = "label7";
            labelyonetmen.Click += label7_Click;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Dock = DockStyle.Bottom;
            textBox5.Font = new Font("Harlow Solid Italic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(10, 48);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(248, 28);
            textBox5.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.BackColor = Color.Sienna;
            groupBox7.Controls.Add(labelaktifpasif);
            groupBox7.Controls.Add(textBox6);
            groupBox7.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox7.ForeColor = Color.PeachPuff;
            groupBox7.Location = new Point(587, 439);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(10, 3, 3, 3);
            groupBox7.Size = new Size(261, 79);
            groupBox7.TabIndex = 25;
            groupBox7.TabStop = false;
            groupBox7.Text = "Aktif / Pasif";
            // 
            // labelaktifpasif
            // 
            labelaktifpasif.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            labelaktifpasif.Location = new Point(10, 41);
            labelaktifpasif.Name = "labelaktifpasif";
            labelaktifpasif.Size = new Size(245, 38);
            labelaktifpasif.TabIndex = 1;
            labelaktifpasif.Text = "label8";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Dock = DockStyle.Bottom;
            textBox6.Font = new Font("Harlow Solid Italic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(10, 48);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(248, 28);
            textBox6.TabIndex = 0;
            // 
            // groupBox10
            // 
            groupBox10.BackColor = Color.Sienna;
            groupBox10.Controls.Add(labelimdb);
            groupBox10.Controls.Add(textBox8);
            groupBox10.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox10.ForeColor = Color.PeachPuff;
            groupBox10.Location = new Point(870, 639);
            groupBox10.Name = "groupBox10";
            groupBox10.Padding = new Padding(10, 3, 3, 3);
            groupBox10.Size = new Size(264, 79);
            groupBox10.TabIndex = 23;
            groupBox10.TabStop = false;
            groupBox10.Text = "Imdb";
            // 
            // labelimdb
            // 
            labelimdb.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            labelimdb.Location = new Point(3, 41);
            labelimdb.Name = "labelimdb";
            labelimdb.Size = new Size(261, 35);
            labelimdb.TabIndex = 1;
            labelimdb.Text = "label10";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Dock = DockStyle.Bottom;
            textBox8.Font = new Font("Harlow Solid Italic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(10, 48);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(251, 28);
            textBox8.TabIndex = 0;
            // 
            // groupBox11
            // 
            groupBox11.BackColor = Color.Sienna;
            groupBox11.Controls.Add(labeldetay);
            groupBox11.Controls.Add(textBox9);
            groupBox11.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox11.ForeColor = Color.PeachPuff;
            groupBox11.Location = new Point(30, 639);
            groupBox11.Name = "groupBox11";
            groupBox11.Padding = new Padding(10, 3, 3, 3);
            groupBox11.Size = new Size(811, 107);
            groupBox11.TabIndex = 26;
            groupBox11.TabStop = false;
            groupBox11.Text = "Film Detayları";
            // 
            // labeldetay
            // 
            labeldetay.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            labeldetay.Location = new Point(6, 41);
            labeldetay.Name = "labeldetay";
            labeldetay.Size = new Size(805, 63);
            labeldetay.TabIndex = 1;
            labeldetay.Text = "label11";
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Dock = DockStyle.Bottom;
            textBox9.Font = new Font("Harlow Solid Italic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(10, 41);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(798, 63);
            textBox9.TabIndex = 0;
            // 
            // FormFilmDetay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1323, 747);
            Controls.Add(groupBox11);
            Controls.Add(groupBox7);
            Controls.Add(groupBox10);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox8);
            Controls.Add(panel1);
            Font = new Font("Harlow Solid Italic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFilmDetay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormFilmDetay";
            Load += FormFilmDetay_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMovie).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Button buttonExit;
        private GroupBox groupBox8;
        private PictureBox pictureBoxMovie;
        private GroupBox groupBox1;
        private TextBox textmoviename;
        private Label labelfilmadi;
        private GroupBox groupBox2;
        private Label labeltur;
        private TextBox textBox1;
        private GroupBox groupBox3;
        private Label labelwarning;
        private TextBox textBox2;
        private GroupBox groupBox4;
        private Label labeloyuncu;
        private TextBox textBox3;
        private GroupBox groupBox5;
        private Label labelvizyontarihi;
        private TextBox textBox4;
        private GroupBox groupBox6;
        private Label labelyonetmen;
        private TextBox textBox5;
        private GroupBox groupBox7;
        private Label labelaktifpasif;
        private TextBox textBox6;
        private GroupBox groupBox10;
        private Label labelimdb;
        private TextBox textBox8;
        private GroupBox groupBox11;
        private Label labeldetay;
        private TextBox textBox9;
    }
}