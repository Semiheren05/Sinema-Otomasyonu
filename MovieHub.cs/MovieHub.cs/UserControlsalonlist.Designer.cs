namespace MovieHub.cs
{
    partial class UserControlsalonlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlsalonlist));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            labelsalonadi = new Label();
            labelnmbr = new Label();
            labelkoltuksayisi = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Chocolate;
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Harlow Solid Italic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4);
            panel1.Size = new Size(4, 72);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(10, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelsalonadi
            // 
            labelsalonadi.AutoSize = true;
            labelsalonadi.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelsalonadi.ForeColor = Color.PeachPuff;
            labelsalonadi.Location = new Point(136, 10);
            labelsalonadi.Name = "labelsalonadi";
            labelsalonadi.Size = new Size(54, 19);
            labelsalonadi.TabIndex = 2;
            labelsalonadi.Text = "label1";
            // 
            // labelnmbr
            // 
            labelnmbr.AutoSize = true;
            labelnmbr.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelnmbr.ForeColor = Color.PeachPuff;
            labelnmbr.Location = new Point(178, 40);
            labelnmbr.Name = "labelnmbr";
            labelnmbr.Size = new Size(49, 19);
            labelnmbr.TabIndex = 3;
            labelnmbr.Text = "nmbr";
            // 
            // labelkoltuksayisi
            // 
            labelkoltuksayisi.AutoSize = true;
            labelkoltuksayisi.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelkoltuksayisi.ForeColor = Color.PeachPuff;
            labelkoltuksayisi.Location = new Point(111, 40);
            labelkoltuksayisi.Name = "labelkoltuksayisi";
            labelkoltuksayisi.Size = new Size(51, 19);
            labelkoltuksayisi.TabIndex = 4;
            labelkoltuksayisi.Text = "seat :";
            labelkoltuksayisi.Click += labelkoltuksayisi_Click;
            // 
            // UserControlsalonlist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            Controls.Add(labelkoltuksayisi);
            Controls.Add(labelnmbr);
            Controls.Add(labelsalonadi);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControlsalonlist";
            Size = new Size(242, 72);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        public Label labelsalonadi;
        public Label labelnmbr;
        public Label labelkoltuksayisi;
    }
}
