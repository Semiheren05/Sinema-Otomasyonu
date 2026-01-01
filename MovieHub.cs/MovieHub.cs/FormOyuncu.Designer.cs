namespace MovieHub.cs
{
    partial class FormOyuncu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOyuncu));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            buttonExit = new Button();
            buttonoyuncukayıt = new Button();
            groupBox3 = new GroupBox();
            label150 = new Label();
            richTextbiyografi = new RichTextBox();
            label8 = new Label();
            groupBox2 = new GroupBox();
            buttonphotoLoad = new Button();
            pictureBoxyonetmen = new PictureBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            radiomale = new RadioButton();
            radiofemale = new RadioButton();
            maskeddogum = new MaskedTextBox();
            label3 = new Label();
            textsoyad = new TextBox();
            textad = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxyonetmen).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buttonExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1323, 86);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 13);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.FloralWhite;
            label4.Location = new Point(167, 25);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(288, 49);
            label4.TabIndex = 7;
            label4.Text = "Actor Registiration";
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
            buttonExit.Location = new Point(1200, 0);
            buttonExit.Margin = new Padding(4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(123, 86);
            buttonExit.TabIndex = 6;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonoyuncukayıt
            // 
            buttonoyuncukayıt.BackColor = Color.Transparent;
            buttonoyuncukayıt.BackgroundImage = (Image)resources.GetObject("buttonoyuncukayıt.BackgroundImage");
            buttonoyuncukayıt.BackgroundImageLayout = ImageLayout.Stretch;
            buttonoyuncukayıt.Cursor = Cursors.Hand;
            buttonoyuncukayıt.FlatAppearance.BorderSize = 0;
            buttonoyuncukayıt.FlatStyle = FlatStyle.Flat;
            buttonoyuncukayıt.Font = new Font("Harlow Solid Italic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonoyuncukayıt.ForeColor = Color.Transparent;
            buttonoyuncukayıt.Location = new Point(911, 566);
            buttonoyuncukayıt.Name = "buttonoyuncukayıt";
            buttonoyuncukayıt.Size = new Size(121, 96);
            buttonoyuncukayıt.TabIndex = 22;
            buttonoyuncukayıt.UseVisualStyleBackColor = false;
            buttonoyuncukayıt.Click += buttonoyuncukayıt_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Sienna;
            groupBox3.Controls.Add(label150);
            groupBox3.Controls.Add(richTextbiyografi);
            groupBox3.Controls.Add(label8);
            groupBox3.ForeColor = Color.MediumVioletRed;
            groupBox3.Location = new Point(789, 126);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(298, 411);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            // 
            // label150
            // 
            label150.AutoSize = true;
            label150.BackColor = Color.Snow;
            label150.ForeColor = Color.Violet;
            label150.Location = new Point(213, 329);
            label150.Name = "label150";
            label150.Size = new Size(30, 20);
            label150.TabIndex = 12;
            label150.Text = "150";
            // 
            // richTextbiyografi
            // 
            richTextbiyografi.BackColor = Color.Snow;
            richTextbiyografi.BorderStyle = BorderStyle.None;
            richTextbiyografi.Font = new Font("Harlow Solid Italic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            richTextbiyografi.ForeColor = Color.Indigo;
            richTextbiyografi.Location = new Point(32, 38);
            richTextbiyografi.MaxLength = 150;
            richTextbiyografi.Name = "richTextbiyografi";
            richTextbiyografi.Size = new Size(230, 329);
            richTextbiyografi.TabIndex = 11;
            richTextbiyografi.Text = "";
            richTextbiyografi.TextChanged += richTextbiyografi_TextChanged;
            // 
            // label8
            // 
            label8.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label8.ForeColor = Color.PeachPuff;
            label8.Location = new Point(65, 0);
            label8.Name = "label8";
            label8.Size = new Size(150, 35);
            label8.TabIndex = 10;
            label8.Text = "Biyografisi";
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.BackColor = Color.Sienna;
            groupBox2.Controls.Add(buttonphotoLoad);
            groupBox2.Controls.Add(pictureBoxyonetmen);
            groupBox2.Controls.Add(label5);
            groupBox2.ForeColor = Color.MediumVioletRed;
            groupBox2.Location = new Point(419, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(346, 402);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            // 
            // buttonphotoLoad
            // 
            buttonphotoLoad.BackColor = Color.Transparent;
            buttonphotoLoad.BackgroundImage = (Image)resources.GetObject("buttonphotoLoad.BackgroundImage");
            buttonphotoLoad.BackgroundImageLayout = ImageLayout.Stretch;
            buttonphotoLoad.Cursor = Cursors.Hand;
            buttonphotoLoad.FlatAppearance.BorderSize = 0;
            buttonphotoLoad.FlatStyle = FlatStyle.Flat;
            buttonphotoLoad.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            buttonphotoLoad.ForeColor = Color.PeachPuff;
            buttonphotoLoad.Location = new Point(123, 315);
            buttonphotoLoad.Name = "buttonphotoLoad";
            buttonphotoLoad.Size = new Size(105, 59);
            buttonphotoLoad.TabIndex = 17;
            buttonphotoLoad.UseVisualStyleBackColor = false;
            buttonphotoLoad.Click += buttonphotoLoad_Click;
            // 
            // pictureBoxyonetmen
            // 
            pictureBoxyonetmen.Image = (Image)resources.GetObject("pictureBoxyonetmen.Image");
            pictureBoxyonetmen.Location = new Point(17, 38);
            pictureBoxyonetmen.Name = "pictureBoxyonetmen";
            pictureBoxyonetmen.Size = new Size(305, 265);
            pictureBoxyonetmen.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxyonetmen.TabIndex = 16;
            pictureBoxyonetmen.TabStop = false;
            // 
            // label5
            // 
            label5.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label5.ForeColor = Color.PeachPuff;
            label5.Location = new Point(84, 0);
            label5.Name = "label5";
            label5.Size = new Size(176, 35);
            label5.TabIndex = 14;
            label5.Text = "Fotoğrafı";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Sienna;
            groupBox1.Controls.Add(radiomale);
            groupBox1.Controls.Add(radiofemale);
            groupBox1.Controls.Add(maskeddogum);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textsoyad);
            groupBox1.Controls.Add(textad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.MediumVioletRed;
            groupBox1.Location = new Point(40, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 402);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // radiomale
            // 
            radiomale.AutoSize = true;
            radiomale.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            radiomale.ForeColor = Color.PeachPuff;
            radiomale.Location = new Point(149, 315);
            radiomale.Name = "radiomale";
            radiomale.Size = new Size(86, 28);
            radiomale.TabIndex = 17;
            radiomale.Text = "Erkek";
            radiomale.UseVisualStyleBackColor = true;
            // 
            // radiofemale
            // 
            radiofemale.AutoSize = true;
            radiofemale.Checked = true;
            radiofemale.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            radiofemale.ForeColor = Color.PeachPuff;
            radiofemale.Location = new Point(8, 315);
            radiofemale.Name = "radiofemale";
            radiofemale.Size = new Size(86, 28);
            radiofemale.TabIndex = 16;
            radiofemale.TabStop = true;
            radiofemale.Text = "Kadın";
            radiofemale.UseVisualStyleBackColor = true;
            // 
            // maskeddogum
            // 
            maskeddogum.BackColor = Color.Snow;
            maskeddogum.BeepOnError = true;
            maskeddogum.BorderStyle = BorderStyle.None;
            maskeddogum.Font = new Font("Harlow Solid Italic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            maskeddogum.ForeColor = Color.Indigo;
            maskeddogum.Location = new Point(74, 240);
            maskeddogum.Mask = "00/00/0000";
            maskeddogum.Name = "maskeddogum";
            maskeddogum.Size = new Size(237, 28);
            maskeddogum.TabIndex = 15;
            maskeddogum.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label3.ForeColor = Color.PeachPuff;
            label3.Location = new Point(8, 202);
            label3.Name = "label3";
            label3.Size = new Size(170, 35);
            label3.TabIndex = 14;
            label3.Text = "Doğum Tarihi";
            // 
            // textsoyad
            // 
            textsoyad.BackColor = Color.Snow;
            textsoyad.BorderStyle = BorderStyle.None;
            textsoyad.Font = new Font("Harlow Solid Italic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textsoyad.ForeColor = Color.Indigo;
            textsoyad.Location = new Point(73, 160);
            textsoyad.Name = "textsoyad";
            textsoyad.Size = new Size(238, 24);
            textsoyad.TabIndex = 13;
            // 
            // textad
            // 
            textad.BackColor = Color.Snow;
            textad.BorderStyle = BorderStyle.None;
            textad.Font = new Font("Harlow Solid Italic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textad.ForeColor = Color.Indigo;
            textad.Location = new Point(74, 67);
            textad.Name = "textad";
            textad.Size = new Size(238, 24);
            textad.TabIndex = 12;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label2.ForeColor = Color.PeachPuff;
            label2.Location = new Point(8, 111);
            label2.Name = "label2";
            label2.Size = new Size(238, 35);
            label2.TabIndex = 11;
            label2.Text = "Aktör Soyismi";
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.PeachPuff;
            label1.Location = new Point(8, 29);
            label1.Name = "label1";
            label1.Size = new Size(213, 35);
            label1.TabIndex = 10;
            label1.Text = "Aktör İsmi";
            // 
            // FormOyuncu
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1323, 747);
            Controls.Add(buttonoyuncukayıt);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Harlow Solid Italic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormOyuncu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOyuncu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxyonetmen).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
        private Button buttonExit;
        private Button buttonoyuncukayıt;
        private GroupBox groupBox3;
        private RichTextBox richTextbiyografi;
        private Label label8;
        private GroupBox groupBox2;
        private Button buttonphotoLoad;
        private PictureBox pictureBoxyonetmen;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton radiomale;
        private RadioButton radiofemale;
        private MaskedTextBox maskeddogum;
        private Label label3;
        private TextBox textsoyad;
        private TextBox textad;
        private Label label2;
        private Label label1;
        public Label label150;
    }
}