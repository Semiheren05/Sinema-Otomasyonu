namespace MovieHub.cs
{
    partial class FormFilmKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilmKayit));
            panel1 = new Panel();
            label4 = new Label();
            buttonExit = new Button();
            groupBox1 = new GroupBox();
            textmoviename = new TextBox();
            groupBoxTur = new GroupBox();
            labelBelge = new Label();
            labelMüzik = new Label();
            labelWestern = new Label();
            labelBilim = new Label();
            labelFantastik = new Label();
            labelDram = new Label();
            labelPsikolojik = new Label();
            labelGerilim = new Label();
            labelRomantik = new Label();
            labelAksiyon = new Label();
            groupBoxWarnings = new GroupBox();
            label18yas = new Label();
            label13yas = new Label();
            labelgenel = new Label();
            labelaltyazı = new Label();
            labelingilizce = new Label();
            labelturkce = new Label();
            groupBoxYonetmen = new GroupBox();
            label2 = new Label();
            textBox1 = new TextBox();
            flowPanelyonetmen = new FlowLayoutPanel();
            groupBoxOyuncular = new GroupBox();
            label1 = new Label();
            textBox2 = new TextBox();
            flowPaneloyuncu = new FlowLayoutPanel();
            groupBox6 = new GroupBox();
            button1 = new Button();
            maskedYayinTarihi = new MaskedTextBox();
            groupBoxImdb = new GroupBox();
            comboImdb = new ComboBox();
            groupBox8 = new GroupBox();
            buttonphotoLoad = new Button();
            pictureBoxMovie = new PictureBox();
            groupBoxDetaylar = new GroupBox();
            label150 = new Label();
            richTextdetails = new RichTextBox();
            buttonfilmkayıt = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxTur.SuspendLayout();
            groupBoxWarnings.SuspendLayout();
            groupBoxYonetmen.SuspendLayout();
            groupBoxOyuncular.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBoxImdb.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMovie).BeginInit();
            groupBoxDetaylar.SuspendLayout();
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
            panel1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.FloralWhite;
            label4.Location = new Point(127, 21);
            label4.Name = "label4";
            label4.Size = new Size(203, 24);
            label4.TabIndex = 7;
            label4.Text = "Movie Registiration";
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Sienna;
            buttonExit.BackgroundImage = (Image)resources.GetObject("buttonExit.BackgroundImage");
            buttonExit.BackgroundImageLayout = ImageLayout.Zoom;
            buttonExit.Cursor = Cursors.Hand;
            buttonExit.Dock = DockStyle.Right;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Harlow Solid Italic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonExit.ForeColor = Color.Transparent;
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
            groupBox1.Controls.Add(textmoviename);
            groupBox1.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox1.ForeColor = Color.PeachPuff;
            groupBox1.Location = new Point(23, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 3, 3, 3);
            groupBox1.Size = new Size(261, 79);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Movie Name";
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
            // groupBoxTur
            // 
            groupBoxTur.BackColor = Color.Sienna;
            groupBoxTur.Controls.Add(labelBelge);
            groupBoxTur.Controls.Add(labelMüzik);
            groupBoxTur.Controls.Add(labelWestern);
            groupBoxTur.Controls.Add(labelBilim);
            groupBoxTur.Controls.Add(labelFantastik);
            groupBoxTur.Controls.Add(labelDram);
            groupBoxTur.Controls.Add(labelPsikolojik);
            groupBoxTur.Controls.Add(labelGerilim);
            groupBoxTur.Controls.Add(labelRomantik);
            groupBoxTur.Controls.Add(labelAksiyon);
            groupBoxTur.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBoxTur.ForeColor = Color.PeachPuff;
            groupBoxTur.Location = new Point(23, 214);
            groupBoxTur.Name = "groupBoxTur";
            groupBoxTur.Padding = new Padding(10, 3, 3, 3);
            groupBoxTur.Size = new Size(261, 559);
            groupBoxTur.TabIndex = 10;
            groupBoxTur.TabStop = false;
            groupBoxTur.Text = "Movie Genres ";
            groupBoxTur.Enter += groupBoxTur_Enter;
            // 
            // labelBelge
            // 
            labelBelge.AutoSize = true;
            labelBelge.Cursor = Cursors.Hand;
            labelBelge.ForeColor = Color.PeachPuff;
            labelBelge.Location = new Point(28, 472);
            labelBelge.Name = "labelBelge";
            labelBelge.Size = new Size(96, 24);
            labelBelge.TabIndex = 9;
            labelBelge.Text = "Belgesel";
            labelBelge.Click += labelBelge_Click;
            // 
            // labelMüzik
            // 
            labelMüzik.AutoSize = true;
            labelMüzik.Cursor = Cursors.Hand;
            labelMüzik.ForeColor = Color.PeachPuff;
            labelMüzik.Location = new Point(28, 422);
            labelMüzik.Name = "labelMüzik";
            labelMüzik.Size = new Size(85, 24);
            labelMüzik.TabIndex = 8;
            labelMüzik.Text = "Müzikal";
            labelMüzik.Click += labelMüzik_Click;
            // 
            // labelWestern
            // 
            labelWestern.AutoSize = true;
            labelWestern.Cursor = Cursors.Hand;
            labelWestern.ForeColor = Color.PeachPuff;
            labelWestern.Location = new Point(28, 376);
            labelWestern.Name = "labelWestern";
            labelWestern.Size = new Size(95, 24);
            labelWestern.TabIndex = 7;
            labelWestern.Text = "Western";
            labelWestern.Click += labelWestern_Click;
            // 
            // labelBilim
            // 
            labelBilim.AutoSize = true;
            labelBilim.Cursor = Cursors.Hand;
            labelBilim.ForeColor = Color.PeachPuff;
            labelBilim.Location = new Point(28, 323);
            labelBilim.Name = "labelBilim";
            labelBilim.Size = new Size(127, 24);
            labelBilim.TabIndex = 6;
            labelBilim.Text = "Bilim Kurgu";
            labelBilim.Click += labelBilim_Click;
            // 
            // labelFantastik
            // 
            labelFantastik.AutoSize = true;
            labelFantastik.Cursor = Cursors.Hand;
            labelFantastik.ForeColor = Color.PeachPuff;
            labelFantastik.Location = new Point(28, 278);
            labelFantastik.Name = "labelFantastik";
            labelFantastik.Size = new Size(103, 24);
            labelFantastik.TabIndex = 5;
            labelFantastik.Text = "Fantastik";
            labelFantastik.Click += labelFantastik_Click;
            // 
            // labelDram
            // 
            labelDram.AutoSize = true;
            labelDram.Cursor = Cursors.Hand;
            labelDram.ForeColor = Color.PeachPuff;
            labelDram.Location = new Point(28, 227);
            labelDram.Name = "labelDram";
            labelDram.Size = new Size(64, 24);
            labelDram.TabIndex = 4;
            labelDram.Text = "Dram";
            labelDram.Click += labelDram_Click;
            // 
            // labelPsikolojik
            // 
            labelPsikolojik.AutoSize = true;
            labelPsikolojik.Cursor = Cursors.Hand;
            labelPsikolojik.ForeColor = Color.PeachPuff;
            labelPsikolojik.Location = new Point(28, 180);
            labelPsikolojik.Name = "labelPsikolojik";
            labelPsikolojik.Size = new Size(106, 24);
            labelPsikolojik.TabIndex = 3;
            labelPsikolojik.Text = "Psikolojik";
            labelPsikolojik.Click += labelPsikolojik_Click;
            // 
            // labelGerilim
            // 
            labelGerilim.AutoSize = true;
            labelGerilim.Cursor = Cursors.Hand;
            labelGerilim.ForeColor = Color.PeachPuff;
            labelGerilim.Location = new Point(28, 132);
            labelGerilim.Name = "labelGerilim";
            labelGerilim.Size = new Size(80, 24);
            labelGerilim.TabIndex = 2;
            labelGerilim.Text = "Gerilim";
            labelGerilim.Click += labelGerilim_Click;
            // 
            // labelRomantik
            // 
            labelRomantik.AutoSize = true;
            labelRomantik.Cursor = Cursors.Hand;
            labelRomantik.ForeColor = Color.PeachPuff;
            labelRomantik.Location = new Point(28, 86);
            labelRomantik.Name = "labelRomantik";
            labelRomantik.Size = new Size(106, 24);
            labelRomantik.TabIndex = 1;
            labelRomantik.Text = "Romantik";
            labelRomantik.Click += labelRomantik_Click;
            // 
            // labelAksiyon
            // 
            labelAksiyon.AutoSize = true;
            labelAksiyon.Cursor = Cursors.Hand;
            labelAksiyon.ForeColor = Color.PeachPuff;
            labelAksiyon.Location = new Point(28, 38);
            labelAksiyon.Name = "labelAksiyon";
            labelAksiyon.Size = new Size(91, 24);
            labelAksiyon.TabIndex = 0;
            labelAksiyon.Text = "Aksiyon";
            labelAksiyon.Click += labelAksiyon_Click;
            // 
            // groupBoxWarnings
            // 
            groupBoxWarnings.BackColor = Color.Sienna;
            groupBoxWarnings.Controls.Add(label18yas);
            groupBoxWarnings.Controls.Add(label13yas);
            groupBoxWarnings.Controls.Add(labelgenel);
            groupBoxWarnings.Controls.Add(labelaltyazı);
            groupBoxWarnings.Controls.Add(labelingilizce);
            groupBoxWarnings.Controls.Add(labelturkce);
            groupBoxWarnings.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBoxWarnings.ForeColor = Color.PeachPuff;
            groupBoxWarnings.Location = new Point(915, 118);
            groupBoxWarnings.Name = "groupBoxWarnings";
            groupBoxWarnings.Padding = new Padding(10, 3, 3, 3);
            groupBoxWarnings.Size = new Size(261, 222);
            groupBoxWarnings.TabIndex = 11;
            groupBoxWarnings.TabStop = false;
            groupBoxWarnings.Text = "Warnings";
            // 
            // label18yas
            // 
            label18yas.AutoSize = true;
            label18yas.Cursor = Cursors.Hand;
            label18yas.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label18yas.ForeColor = Color.PeachPuff;
            label18yas.Location = new Point(184, 112);
            label18yas.Name = "label18yas";
            label18yas.Size = new Size(52, 24);
            label18yas.TabIndex = 8;
            label18yas.Text = "+ 18";
            label18yas.Click += label18yas_Click;
            // 
            // label13yas
            // 
            label13yas.AutoSize = true;
            label13yas.Cursor = Cursors.Hand;
            label13yas.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label13yas.ForeColor = Color.PeachPuff;
            label13yas.Location = new Point(184, 67);
            label13yas.Name = "label13yas";
            label13yas.Size = new Size(52, 24);
            label13yas.TabIndex = 7;
            label13yas.Text = "+ 13";
            label13yas.Click += label13yas_Click;
            // 
            // labelgenel
            // 
            labelgenel.AutoSize = true;
            labelgenel.Cursor = Cursors.Hand;
            labelgenel.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            labelgenel.ForeColor = Color.PeachPuff;
            labelgenel.Location = new Point(24, 112);
            labelgenel.Name = "labelgenel";
            labelgenel.Size = new Size(140, 24);
            labelgenel.TabIndex = 6;
            labelgenel.Text = "Genel izleyici";
            labelgenel.Click += labelgenel_Click;
            // 
            // labelaltyazı
            // 
            labelaltyazı.AutoSize = true;
            labelaltyazı.Cursor = Cursors.Hand;
            labelaltyazı.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            labelaltyazı.ForeColor = Color.PeachPuff;
            labelaltyazı.Location = new Point(24, 149);
            labelaltyazı.Name = "labelaltyazı";
            labelaltyazı.Size = new Size(83, 24);
            labelaltyazı.TabIndex = 5;
            labelaltyazı.Text = "Alt Yazı";
            labelaltyazı.Click += labelaltyazı_Click;
            // 
            // labelingilizce
            // 
            labelingilizce.AutoSize = true;
            labelingilizce.Cursor = Cursors.Hand;
            labelingilizce.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            labelingilizce.ForeColor = Color.PeachPuff;
            labelingilizce.Location = new Point(24, 76);
            labelingilizce.Name = "labelingilizce";
            labelingilizce.Size = new Size(91, 24);
            labelingilizce.TabIndex = 4;
            labelingilizce.Text = "Ingilizce";
            labelingilizce.Click += labelingilizce_Click;
            // 
            // labelturkce
            // 
            labelturkce.AutoSize = true;
            labelturkce.Cursor = Cursors.Hand;
            labelturkce.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            labelturkce.ForeColor = Color.PeachPuff;
            labelturkce.Location = new Point(24, 47);
            labelturkce.Name = "labelturkce";
            labelturkce.Size = new Size(80, 24);
            labelturkce.TabIndex = 3;
            labelturkce.Text = "Türkçe";
            labelturkce.Click += labelturkce_Click;
            // 
            // groupBoxYonetmen
            // 
            groupBoxYonetmen.BackColor = Color.Sienna;
            groupBoxYonetmen.Controls.Add(label2);
            groupBoxYonetmen.Controls.Add(textBox1);
            groupBoxYonetmen.Controls.Add(flowPanelyonetmen);
            groupBoxYonetmen.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBoxYonetmen.ForeColor = Color.PeachPuff;
            groupBoxYonetmen.Location = new Point(327, 118);
            groupBoxYonetmen.Name = "groupBoxYonetmen";
            groupBoxYonetmen.Padding = new Padding(10, 3, 3, 3);
            groupBoxYonetmen.Size = new Size(261, 290);
            groupBoxYonetmen.TabIndex = 12;
            groupBoxYonetmen.TabStop = false;
            groupBoxYonetmen.Text = "Directors";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.PeachPuff;
            label2.Location = new Point(201, 255);
            label2.Name = "label2";
            label2.Size = new Size(49, 16);
            label2.TabIndex = 3;
            label2.Text = "search";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 244);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 32);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // flowPanelyonetmen
            // 
            flowPanelyonetmen.Location = new Point(5, 46);
            flowPanelyonetmen.Name = "flowPanelyonetmen";
            flowPanelyonetmen.Size = new Size(250, 176);
            flowPanelyonetmen.TabIndex = 0;
            // 
            // groupBoxOyuncular
            // 
            groupBoxOyuncular.BackColor = Color.Sienna;
            groupBoxOyuncular.Controls.Add(label1);
            groupBoxOyuncular.Controls.Add(textBox2);
            groupBoxOyuncular.Controls.Add(flowPaneloyuncu);
            groupBoxOyuncular.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBoxOyuncular.ForeColor = Color.PeachPuff;
            groupBoxOyuncular.Location = new Point(327, 441);
            groupBoxOyuncular.Name = "groupBoxOyuncular";
            groupBoxOyuncular.Padding = new Padding(10, 3, 3, 3);
            groupBoxOyuncular.Size = new Size(261, 332);
            groupBoxOyuncular.TabIndex = 13;
            groupBoxOyuncular.TabStop = false;
            groupBoxOyuncular.Text = "Actors";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.PeachPuff;
            label1.Location = new Point(201, 289);
            label1.Name = "label1";
            label1.Size = new Size(49, 16);
            label1.TabIndex = 2;
            label1.Text = "search";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 277);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 32);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // flowPaneloyuncu
            // 
            flowPaneloyuncu.Location = new Point(9, 35);
            flowPaneloyuncu.Name = "flowPaneloyuncu";
            flowPaneloyuncu.Size = new Size(250, 206);
            flowPaneloyuncu.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.Sienna;
            groupBox6.Controls.Add(button1);
            groupBox6.Controls.Add(maskedYayinTarihi);
            groupBox6.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox6.ForeColor = Color.PeachPuff;
            groupBox6.Location = new Point(625, 118);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(10, 3, 3, 3);
            groupBox6.Size = new Size(261, 132);
            groupBox6.TabIndex = 14;
            groupBox6.TabStop = false;
            groupBox6.Text = "Release Date";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.LavenderBlush;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(74, 82);
            button1.Name = "button1";
            button1.Size = new Size(94, 44);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // maskedYayinTarihi
            // 
            maskedYayinTarihi.Location = new Point(13, 34);
            maskedYayinTarihi.Mask = "00/00/0000";
            maskedYayinTarihi.Name = "maskedYayinTarihi";
            maskedYayinTarihi.Size = new Size(242, 32);
            maskedYayinTarihi.TabIndex = 0;
            maskedYayinTarihi.ValidatingType = typeof(DateTime);
            maskedYayinTarihi.MaskInputRejected += maskedYayinTarihi_MaskInputRejected;
            // 
            // groupBoxImdb
            // 
            groupBoxImdb.BackColor = Color.Sienna;
            groupBoxImdb.Controls.Add(comboImdb);
            groupBoxImdb.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBoxImdb.ForeColor = Color.PeachPuff;
            groupBoxImdb.Location = new Point(625, 256);
            groupBoxImdb.Name = "groupBoxImdb";
            groupBoxImdb.Padding = new Padding(10, 3, 3, 3);
            groupBoxImdb.Size = new Size(261, 84);
            groupBoxImdb.TabIndex = 15;
            groupBoxImdb.TabStop = false;
            groupBoxImdb.Text = "Imdb / 10";
            // 
            // comboImdb
            // 
            comboImdb.FormattingEnabled = true;
            comboImdb.Location = new Point(0, 41);
            comboImdb.Name = "comboImdb";
            comboImdb.Size = new Size(261, 32);
            comboImdb.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.BackColor = Color.Sienna;
            groupBox8.Controls.Add(buttonphotoLoad);
            groupBox8.Controls.Add(pictureBoxMovie);
            groupBox8.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBox8.ForeColor = Color.PeachPuff;
            groupBox8.Location = new Point(603, 363);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(10, 3, 3, 3);
            groupBox8.Size = new Size(292, 410);
            groupBox8.TabIndex = 16;
            groupBox8.TabStop = false;
            groupBox8.Text = "Billboard";
            // 
            // buttonphotoLoad
            // 
            buttonphotoLoad.BackColor = Color.Snow;
            buttonphotoLoad.Cursor = Cursors.Hand;
            buttonphotoLoad.FlatAppearance.BorderSize = 0;
            buttonphotoLoad.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonphotoLoad.ForeColor = Color.LavenderBlush;
            buttonphotoLoad.Image = (Image)resources.GetObject("buttonphotoLoad.Image");
            buttonphotoLoad.Location = new Point(85, 355);
            buttonphotoLoad.Name = "buttonphotoLoad";
            buttonphotoLoad.Size = new Size(105, 42);
            buttonphotoLoad.TabIndex = 19;
            buttonphotoLoad.Text = "load photo";
            buttonphotoLoad.UseVisualStyleBackColor = false;
            buttonphotoLoad.Click += buttonphotoLoad_Click;
            // 
            // pictureBoxMovie
            // 
            pictureBoxMovie.ErrorImage = (Image)resources.GetObject("pictureBoxMovie.ErrorImage");
            pictureBoxMovie.Image = (Image)resources.GetObject("pictureBoxMovie.Image");
            pictureBoxMovie.Location = new Point(13, 41);
            pictureBoxMovie.Name = "pictureBoxMovie";
            pictureBoxMovie.Size = new Size(270, 308);
            pictureBoxMovie.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMovie.TabIndex = 18;
            pictureBoxMovie.TabStop = false;
            // 
            // groupBoxDetaylar
            // 
            groupBoxDetaylar.BackColor = Color.Sienna;
            groupBoxDetaylar.Controls.Add(label150);
            groupBoxDetaylar.Controls.Add(richTextdetails);
            groupBoxDetaylar.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            groupBoxDetaylar.ForeColor = Color.PeachPuff;
            groupBoxDetaylar.Location = new Point(915, 363);
            groupBoxDetaylar.Name = "groupBoxDetaylar";
            groupBoxDetaylar.Padding = new Padding(10, 3, 3, 3);
            groupBoxDetaylar.Size = new Size(261, 215);
            groupBoxDetaylar.TabIndex = 17;
            groupBoxDetaylar.TabStop = false;
            groupBoxDetaylar.Text = "Details";
            // 
            // label150
            // 
            label150.AutoSize = true;
            label150.BackColor = Color.Snow;
            label150.ForeColor = Color.Salmon;
            label150.Location = new Point(197, 168);
            label150.Name = "label150";
            label150.Size = new Size(46, 24);
            label150.TabIndex = 13;
            label150.Text = "150";
            // 
            // richTextdetails
            // 
            richTextdetails.BorderStyle = BorderStyle.None;
            richTextdetails.Dock = DockStyle.Fill;
            richTextdetails.Location = new Point(10, 28);
            richTextdetails.Name = "richTextdetails";
            richTextdetails.Size = new Size(248, 184);
            richTextdetails.TabIndex = 0;
            richTextdetails.Text = "";
            richTextdetails.TextChanged += richTextdetails_TextChanged;
            // 
            // buttonfilmkayıt
            // 
            buttonfilmkayıt.BackColor = Color.Transparent;
            buttonfilmkayıt.BackgroundImage = (Image)resources.GetObject("buttonfilmkayıt.BackgroundImage");
            buttonfilmkayıt.BackgroundImageLayout = ImageLayout.Stretch;
            buttonfilmkayıt.Cursor = Cursors.Hand;
            buttonfilmkayıt.FlatAppearance.BorderSize = 0;
            buttonfilmkayıt.FlatStyle = FlatStyle.Flat;
            buttonfilmkayıt.Font = new Font("Harlow Solid Italic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonfilmkayıt.ForeColor = Color.White;
            buttonfilmkayıt.ImageAlign = ContentAlignment.MiddleRight;
            buttonfilmkayıt.Location = new Point(995, 603);
            buttonfilmkayıt.Name = "buttonfilmkayıt";
            buttonfilmkayıt.Size = new Size(156, 107);
            buttonfilmkayıt.TabIndex = 19;
            buttonfilmkayıt.UseVisualStyleBackColor = false;
            buttonfilmkayıt.Click += buttonfilmkayıt_Click;
            // 
            // FormFilmKayit
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1323, 747);
            Controls.Add(buttonfilmkayıt);
            Controls.Add(groupBoxDetaylar);
            Controls.Add(groupBox8);
            Controls.Add(groupBoxImdb);
            Controls.Add(groupBox6);
            Controls.Add(groupBoxOyuncular);
            Controls.Add(groupBoxYonetmen);
            Controls.Add(groupBoxWarnings);
            Controls.Add(groupBoxTur);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Harlow Solid Italic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormFilmKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormFilmKayit";
            Load += FormFilmKayit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxTur.ResumeLayout(false);
            groupBoxTur.PerformLayout();
            groupBoxWarnings.ResumeLayout(false);
            groupBoxWarnings.PerformLayout();
            groupBoxYonetmen.ResumeLayout(false);
            groupBoxYonetmen.PerformLayout();
            groupBoxOyuncular.ResumeLayout(false);
            groupBoxOyuncular.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBoxImdb.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMovie).EndInit();
            groupBoxDetaylar.ResumeLayout(false);
            groupBoxDetaylar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Button buttonExit;
        private GroupBox groupBox1;
        private TextBox textmoviename;
        private GroupBox groupBoxTur;
        private GroupBox groupBoxWarnings;
        private GroupBox groupBoxYonetmen;
        private GroupBox groupBoxOyuncular;
        private GroupBox groupBox6;
        private GroupBox groupBoxImdb;
        private GroupBox groupBox8;
        private GroupBox groupBoxDetaylar;
        private ComboBox comboImdb;
        private RichTextBox richTextdetails;
        private Button buttonfilmkayıt;
        private Label label150;
        private Button buttonphotoLoad;
        private PictureBox pictureBoxMovie;
        private MaskedTextBox maskedYayinTarihi;
        private Label label2;
        private TextBox textBox1;
        private FlowLayoutPanel flowPanelyonetmen;
        private Label label1;
        private TextBox textBox2;
        private FlowLayoutPanel flowPaneloyuncu;
        private Label labelAksiyon;
        private Label labelRomantik;
        private Label labelPsikolojik;
        private Label labelGerilim;
        private Label labelDram;
        private Label labelWestern;
        private Label labelBilim;
        private Label labelFantastik;
        private Label labelMüzik;
        private Label labelBelge;
        private Label labelaltyazı;
        private Label labelingilizce;
        private Label labelturkce;
        private Label label18yas;
        private Label label13yas;
        private Label labelgenel;
        private Button button1;
    }
}