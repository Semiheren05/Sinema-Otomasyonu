namespace MovieHub.cs
{
    partial class FormOyuncuListecs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOyuncuListecs));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            buttonExit = new Button();
            panel2 = new Panel();
            textBoxsearch = new TextBox();
            label1 = new Label();
            listepaneli = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1306, 69);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.Sienna;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.PeachPuff;
            label4.Location = new Point(198, 16);
            label4.Name = "label4";
            label4.Size = new Size(262, 39);
            label4.TabIndex = 7;
            label4.Text = "Aktör Listesi";
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Sienna;
            buttonExit.BackgroundImage = (Image)resources.GetObject("buttonExit.BackgroundImage");
            buttonExit.BackgroundImageLayout = ImageLayout.Center;
            buttonExit.Cursor = Cursors.Hand;
            buttonExit.Dock = DockStyle.Right;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Harlow Solid Italic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonExit.ForeColor = Color.DarkRed;
            buttonExit.Location = new Point(1224, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(82, 69);
            buttonExit.TabIndex = 6;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Sienna;
            panel2.Controls.Add(textBoxsearch);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 69);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1306, 46);
            panel2.TabIndex = 9;
            // 
            // textBoxsearch
            // 
            textBoxsearch.BackColor = Color.PeachPuff;
            textBoxsearch.BorderStyle = BorderStyle.None;
            textBoxsearch.Font = new Font("Harlow Solid Italic", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxsearch.Location = new Point(316, 7);
            textBoxsearch.Name = "textBoxsearch";
            textBoxsearch.Size = new Size(249, 27);
            textBoxsearch.TabIndex = 1;
            textBoxsearch.TextChanged += textBoxsearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.PeachPuff;
            label1.Location = new Point(94, 6);
            label1.Name = "label1";
            label1.Size = new Size(143, 24);
            label1.TabIndex = 0;
            label1.Text = "İsim Soyisim:";
            label1.Click += label1_Click;
            // 
            // listepaneli
            // 
            listepaneli.AutoScroll = true;
            listepaneli.AutoSize = true;
            listepaneli.BackColor = Color.CadetBlue;
            listepaneli.BackgroundImage = (Image)resources.GetObject("listepaneli.BackgroundImage");
            listepaneli.BackgroundImageLayout = ImageLayout.Stretch;
            listepaneli.FlowDirection = FlowDirection.TopDown;
            listepaneli.Location = new Point(59, 119);
            listepaneli.Margin = new Padding(2);
            listepaneli.Name = "listepaneli";
            listepaneli.Padding = new Padding(3);
            listepaneli.Size = new Size(495, 705);
            listepaneli.TabIndex = 11;
            // 
            // FormOyuncuListecs
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1323, 747);
            Controls.Add(listepaneli);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Harlow Solid Italic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormOyuncuListecs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOyuncuListecs";
            Load += FormOyuncuListecs_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
        private Button buttonExit;
        private Panel panel2;
        private TextBox textBoxsearch;
        private Label label1;
        private FlowLayoutPanel listepaneli;
    }
}