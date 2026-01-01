namespace MovieHub.cs
{
    partial class UserFilmListe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserFilmListe));
            groupBox8 = new GroupBox();
            labelID = new Label();
            labelFilmAdi = new Label();
            buttonfilm = new Button();
            pictureBoxMovie = new PictureBox();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMovie).BeginInit();
            SuspendLayout();
            // 
            // groupBox8
            // 
            groupBox8.BackColor = Color.Sienna;
            groupBox8.Controls.Add(labelID);
            groupBox8.Controls.Add(labelFilmAdi);
            groupBox8.Controls.Add(buttonfilm);
            groupBox8.Controls.Add(pictureBoxMovie);
            groupBox8.Font = new Font("Harlow Solid Italic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox8.Location = new Point(3, 10);
            groupBox8.Margin = new Padding(3, 2, 3, 2);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(9, 2, 3, 2);
            groupBox8.Size = new Size(262, 269);
            groupBox8.TabIndex = 18;
            groupBox8.TabStop = false;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Harlow Solid Italic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelID.ForeColor = Color.PeachPuff;
            labelID.Location = new Point(-3, 182);
            labelID.Name = "labelID";
            labelID.Size = new Size(67, 30);
            labelID.TabIndex = 21;
            labelID.Text = "label1";
            labelID.Visible = false;
            // 
            // labelFilmAdi
            // 
            labelFilmAdi.AutoSize = true;
            labelFilmAdi.Font = new Font("Harlow Solid Italic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelFilmAdi.ForeColor = Color.PeachPuff;
            labelFilmAdi.Location = new Point(0, 0);
            labelFilmAdi.Name = "labelFilmAdi";
            labelFilmAdi.Size = new Size(67, 30);
            labelFilmAdi.TabIndex = 20;
            labelFilmAdi.Text = "label1";
            // 
            // buttonfilm
            // 
            buttonfilm.BackColor = Color.Transparent;
            buttonfilm.BackgroundImage = (Image)resources.GetObject("buttonfilm.BackgroundImage");
            buttonfilm.BackgroundImageLayout = ImageLayout.Zoom;
            buttonfilm.Cursor = Cursors.Hand;
            buttonfilm.FlatAppearance.BorderSize = 0;
            buttonfilm.FlatStyle = FlatStyle.Flat;
            buttonfilm.Font = new Font("Harlow Solid Italic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonfilm.ForeColor = Color.LavenderBlush;
            buttonfilm.Location = new Point(80, 222);
            buttonfilm.Margin = new Padding(3, 2, 3, 2);
            buttonfilm.Name = "buttonfilm";
            buttonfilm.Size = new Size(92, 34);
            buttonfilm.TabIndex = 19;
            buttonfilm.UseVisualStyleBackColor = false;
            buttonfilm.Click += buttonfilm_Click;
            // 
            // pictureBoxMovie
            // 
            pictureBoxMovie.Image = (Image)resources.GetObject("pictureBoxMovie.Image");
            pictureBoxMovie.Location = new Point(0, 31);
            pictureBoxMovie.Margin = new Padding(3, 2, 3, 2);
            pictureBoxMovie.Name = "pictureBoxMovie";
            pictureBoxMovie.Size = new Size(248, 179);
            pictureBoxMovie.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMovie.TabIndex = 18;
            pictureBoxMovie.TabStop = false;
            pictureBoxMovie.Click += pictureBoxMovie_Click;
            // 
            // UserFilmListe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox8);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserFilmListe";
            Size = new Size(272, 281);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMovie).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonfilm;
        public GroupBox groupBox8;
        public PictureBox pictureBoxMovie;
        public Label labelFilmAdi;
        public Label labelID;
    }
}
