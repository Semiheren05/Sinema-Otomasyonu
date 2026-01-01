namespace MovieHub.cs
{
    partial class FormBiletOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBiletOlustur));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            buttonExit = new Button();
            groupBox1 = new GroupBox();
            textadsoyad = new TextBox();
            groupBox2 = new GroupBox();
            textbarkod = new TextBox();
            groupBox3 = new GroupBox();
            texttelefon = new TextBox();
            groupBox4 = new GroupBox();
            combofilmad = new ComboBox();
            groupBox5 = new GroupBox();
            comboTarih = new ComboBox();
            groupBox6 = new GroupBox();
            labelseanssec = new Label();
            flowLayoutSeans = new FlowLayoutPanel();
            groupBox7 = new GroupBox();
            combosalonadi = new ComboBox();
            groupBox8 = new GroupBox();
            combobilettur = new ComboBox();
            groupBox9 = new GroupBox();
            labelkoltuksayisi = new Label();
            textkoltukno = new TextBox();
            buttonfilmkayıt = new Button();
            flowLayoutKoltuk = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buttonExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1323, 78);
            panel1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(242, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.FloralWhite;
            label4.Location = new Point(260, 25);
            label4.Name = "label4";
            label4.Size = new Size(146, 24);
            label4.TabIndex = 7;
            label4.Text = "Bütün Biletler";
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Sienna;
            buttonExit.BackgroundImage = (Image)resources.GetObject("buttonExit.BackgroundImage");
            buttonExit.BackgroundImageLayout = ImageLayout.Stretch;
            buttonExit.Cursor = Cursors.Hand;
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
            // groupBox1
            // 
            groupBox1.BackColor = Color.Sienna;
            groupBox1.Controls.Add(textadsoyad);
            groupBox1.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox1.ForeColor = Color.PeachPuff;
            groupBox1.Location = new Point(12, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 3, 3, 3);
            groupBox1.Size = new Size(326, 79);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ad - Soyad :";
            // 
            // textadsoyad
            // 
            textadsoyad.BorderStyle = BorderStyle.None;
            textadsoyad.Dock = DockStyle.Bottom;
            textadsoyad.Font = new Font("Harlow Solid Italic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textadsoyad.Location = new Point(10, 32);
            textadsoyad.Multiline = true;
            textadsoyad.Name = "textadsoyad";
            textadsoyad.Size = new Size(313, 44);
            textadsoyad.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Sienna;
            groupBox2.Controls.Add(textbarkod);
            groupBox2.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox2.ForeColor = Color.PeachPuff;
            groupBox2.Location = new Point(12, 206);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10, 3, 3, 3);
            groupBox2.Size = new Size(326, 79);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bilet No :";
            // 
            // textbarkod
            // 
            textbarkod.BorderStyle = BorderStyle.None;
            textbarkod.Dock = DockStyle.Bottom;
            textbarkod.Font = new Font("Harlow Solid Italic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textbarkod.ForeColor = Color.PeachPuff;
            textbarkod.Location = new Point(10, 32);
            textbarkod.Multiline = true;
            textbarkod.Name = "textbarkod";
            textbarkod.Size = new Size(313, 44);
            textbarkod.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Sienna;
            groupBox3.Controls.Add(texttelefon);
            groupBox3.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox3.ForeColor = Color.PeachPuff;
            groupBox3.Location = new Point(12, 306);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10, 3, 3, 3);
            groupBox3.Size = new Size(326, 79);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Telefon Numarası :";
            // 
            // texttelefon
            // 
            texttelefon.BorderStyle = BorderStyle.None;
            texttelefon.Dock = DockStyle.Bottom;
            texttelefon.Font = new Font("Harlow Solid Italic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            texttelefon.Location = new Point(10, 32);
            texttelefon.Multiline = true;
            texttelefon.Name = "texttelefon";
            texttelefon.Size = new Size(313, 44);
            texttelefon.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Sienna;
            groupBox4.Controls.Add(combofilmad);
            groupBox4.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox4.ForeColor = Color.PeachPuff;
            groupBox4.Location = new Point(12, 415);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(10, 3, 3, 3);
            groupBox4.Size = new Size(326, 79);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Film Adı:";
            // 
            // combofilmad
            // 
            combofilmad.Dock = DockStyle.Bottom;
            combofilmad.DropDownStyle = ComboBoxStyle.DropDownList;
            combofilmad.FlatStyle = FlatStyle.Flat;
            combofilmad.ForeColor = Color.Indigo;
            combofilmad.FormattingEnabled = true;
            combofilmad.Items.AddRange(new object[] { "V for vendetta", "Pan'ın Labirenti", "Elementler" });
            combofilmad.Location = new Point(10, 44);
            combofilmad.Name = "combofilmad";
            combofilmad.Size = new Size(313, 32);
            combofilmad.TabIndex = 0;
            combofilmad.SelectedIndexChanged += combofilmad_SelectedIndexChanged;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Sienna;
            groupBox5.Controls.Add(comboTarih);
            groupBox5.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox5.ForeColor = Color.PeachPuff;
            groupBox5.Location = new Point(366, 415);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(10, 3, 3, 3);
            groupBox5.Size = new Size(326, 79);
            groupBox5.TabIndex = 15;
            groupBox5.TabStop = false;
            groupBox5.Text = "Yayın tarihi :";
            // 
            // comboTarih
            // 
            comboTarih.Dock = DockStyle.Bottom;
            comboTarih.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTarih.FlatStyle = FlatStyle.Flat;
            comboTarih.ForeColor = Color.Indigo;
            comboTarih.FormattingEnabled = true;
            comboTarih.Location = new Point(10, 44);
            comboTarih.Name = "comboTarih";
            comboTarih.Size = new Size(313, 32);
            comboTarih.TabIndex = 1;
            comboTarih.SelectedIndexChanged += comboTarih_SelectedIndexChanged;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.Sienna;
            groupBox6.Controls.Add(labelseanssec);
            groupBox6.Controls.Add(flowLayoutSeans);
            groupBox6.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox6.ForeColor = Color.PeachPuff;
            groupBox6.Location = new Point(12, 511);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(10, 3, 3, 3);
            groupBox6.Size = new Size(326, 128);
            groupBox6.TabIndex = 16;
            groupBox6.TabStop = false;
            groupBox6.Text = "Oturum :";
            groupBox6.Enter += groupBox6_Enter;
            // 
            // labelseanssec
            // 
            labelseanssec.AutoSize = true;
            labelseanssec.Location = new Point(193, 0);
            labelseanssec.Name = "labelseanssec";
            labelseanssec.Size = new Size(109, 24);
            labelseanssec.TabIndex = 21;
            labelseanssec.Text = "seansSec";
            // 
            // flowLayoutSeans
            // 
            flowLayoutSeans.AutoScroll = true;
            flowLayoutSeans.Dock = DockStyle.Fill;
            flowLayoutSeans.FlowDirection = FlowDirection.TopDown;
            flowLayoutSeans.Font = new Font("Harlow Solid Italic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            flowLayoutSeans.Location = new Point(10, 28);
            flowLayoutSeans.Name = "flowLayoutSeans";
            flowLayoutSeans.Size = new Size(313, 97);
            flowLayoutSeans.TabIndex = 21;
            flowLayoutSeans.WrapContents = false;
            // 
            // groupBox7
            // 
            groupBox7.BackColor = Color.Sienna;
            groupBox7.Controls.Add(combosalonadi);
            groupBox7.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox7.ForeColor = Color.PeachPuff;
            groupBox7.Location = new Point(366, 100);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(10, 3, 3, 3);
            groupBox7.Size = new Size(326, 79);
            groupBox7.TabIndex = 17;
            groupBox7.TabStop = false;
            groupBox7.Text = "Tiyatro Adı:";
            // 
            // combosalonadi
            // 
            combosalonadi.Dock = DockStyle.Bottom;
            combosalonadi.DropDownStyle = ComboBoxStyle.DropDownList;
            combosalonadi.FlatStyle = FlatStyle.Flat;
            combosalonadi.ForeColor = Color.Indigo;
            combosalonadi.FormattingEnabled = true;
            combosalonadi.Location = new Point(10, 44);
            combosalonadi.Name = "combosalonadi";
            combosalonadi.Size = new Size(313, 32);
            combosalonadi.TabIndex = 0;
            combosalonadi.SelectedIndexChanged += combosalonadi_SelectedIndexChanged;
            // 
            // groupBox8
            // 
            groupBox8.BackColor = Color.Sienna;
            groupBox8.Controls.Add(combobilettur);
            groupBox8.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox8.ForeColor = Color.PeachPuff;
            groupBox8.Location = new Point(366, 206);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(10, 3, 3, 3);
            groupBox8.Size = new Size(326, 79);
            groupBox8.TabIndex = 18;
            groupBox8.TabStop = false;
            groupBox8.Text = "Bilet Tipi :";
            // 
            // combobilettur
            // 
            combobilettur.Dock = DockStyle.Bottom;
            combobilettur.DropDownStyle = ComboBoxStyle.DropDownList;
            combobilettur.FlatStyle = FlatStyle.Flat;
            combobilettur.ForeColor = Color.Indigo;
            combobilettur.FormattingEnabled = true;
            combobilettur.Items.AddRange(new object[] { "Adult", "Student", "under 6 years old", "as gift" });
            combobilettur.Location = new Point(10, 44);
            combobilettur.Name = "combobilettur";
            combobilettur.Size = new Size(313, 32);
            combobilettur.TabIndex = 0;
            // 
            // groupBox9
            // 
            groupBox9.BackColor = Color.Sienna;
            groupBox9.Controls.Add(labelkoltuksayisi);
            groupBox9.Controls.Add(textkoltukno);
            groupBox9.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox9.ForeColor = Color.PeachPuff;
            groupBox9.Location = new Point(366, 306);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(10, 3, 3, 3);
            groupBox9.Size = new Size(326, 79);
            groupBox9.TabIndex = 19;
            groupBox9.TabStop = false;
            groupBox9.Text = "Koltuk Numarası :";
            // 
            // labelkoltuksayisi
            // 
            labelkoltuksayisi.AutoSize = true;
            labelkoltuksayisi.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelkoltuksayisi.Location = new Point(232, 0);
            labelkoltuksayisi.Name = "labelkoltuksayisi";
            labelkoltuksayisi.Size = new Size(69, 16);
            labelkoltuksayisi.TabIndex = 23;
            labelkoltuksayisi.Text = "koltukSec";
            // 
            // textkoltukno
            // 
            textkoltukno.BorderStyle = BorderStyle.None;
            textkoltukno.Dock = DockStyle.Bottom;
            textkoltukno.Font = new Font("Harlow Solid Italic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textkoltukno.Location = new Point(10, 32);
            textkoltukno.Multiline = true;
            textkoltukno.Name = "textkoltukno";
            textkoltukno.ScrollBars = ScrollBars.Vertical;
            textkoltukno.Size = new Size(313, 44);
            textkoltukno.TabIndex = 0;
            // 
            // buttonfilmkayıt
            // 
            buttonfilmkayıt.BackColor = Color.Transparent;
            buttonfilmkayıt.BackgroundImage = (Image)resources.GetObject("buttonfilmkayıt.BackgroundImage");
            buttonfilmkayıt.BackgroundImageLayout = ImageLayout.Zoom;
            buttonfilmkayıt.Cursor = Cursors.Hand;
            buttonfilmkayıt.FlatAppearance.BorderSize = 0;
            buttonfilmkayıt.FlatStyle = FlatStyle.Flat;
            buttonfilmkayıt.Font = new Font("Harlow Solid Italic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonfilmkayıt.ForeColor = Color.Black;
            buttonfilmkayıt.Location = new Point(474, 539);
            buttonfilmkayıt.Name = "buttonfilmkayıt";
            buttonfilmkayıt.Size = new Size(130, 108);
            buttonfilmkayıt.TabIndex = 20;
            buttonfilmkayıt.UseVisualStyleBackColor = false;
            buttonfilmkayıt.Click += buttonfilmkayıt_Click;
            // 
            // flowLayoutKoltuk
            // 
            flowLayoutKoltuk.AutoScroll = true;
            flowLayoutKoltuk.Location = new Point(726, 156);
            flowLayoutKoltuk.Name = "flowLayoutKoltuk";
            flowLayoutKoltuk.Size = new Size(585, 538);
            flowLayoutKoltuk.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(856, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // FormBiletOlustur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1323, 747);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutKoltuk);
            Controls.Add(buttonfilmkayıt);
            Controls.Add(groupBox9);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Harlow Solid Italic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBiletOlustur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBiletOlustur";
            Load += FormBiletOlustur_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Button buttonExit;
        private GroupBox groupBox1;
        private TextBox textadsoyad;
        private GroupBox groupBox2;
        private TextBox textbarkod;
        private GroupBox groupBox3;
        private TextBox texttelefon;
        private GroupBox groupBox4;
        private ComboBox combofilmad;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private ComboBox combosalonadi;
        private GroupBox groupBox8;
        private ComboBox combobilettur;
        private GroupBox groupBox9;
        private TextBox textkoltukno;
        private Button buttonfilmkayıt;
        private ComboBox comboTarih;
        private FlowLayoutPanel flowLayoutSeans;
        private Label labelseanssec;
        private FlowLayoutPanel flowLayoutKoltuk;
        private PictureBox pictureBox1;
        private Label labelkoltuksayisi;
        private PictureBox pictureBox2;
    }
}