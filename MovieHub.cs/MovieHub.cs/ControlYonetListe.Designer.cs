namespace MovieHub.cs
{
    partial class ControlYonetListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlYonetListe));
            panel1 = new Panel();
            labeladsoyad = new Label();
            pictureBoxfoto = new PictureBox();
            buttondelete = new Button();
            buttonDetails = new Button();
            labelID = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxfoto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(6, 96);
            panel1.TabIndex = 0;
            // 
            // labeladsoyad
            // 
            labeladsoyad.AutoSize = true;
            labeladsoyad.BackColor = Color.Transparent;
            labeladsoyad.Font = new Font("Harlow Solid Italic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labeladsoyad.ForeColor = Color.PeachPuff;
            labeladsoyad.Location = new Point(143, 18);
            labeladsoyad.Name = "labeladsoyad";
            labeladsoyad.Padding = new Padding(3);
            labeladsoyad.Size = new Size(105, 34);
            labeladsoyad.TabIndex = 1;
            labeladsoyad.Text = "labelname";
            labeladsoyad.Click += label1_Click;
            // 
            // pictureBoxfoto
            // 
            pictureBoxfoto.Image = (Image)resources.GetObject("pictureBoxfoto.Image");
            pictureBoxfoto.Location = new Point(12, 3);
            pictureBoxfoto.Name = "pictureBoxfoto";
            pictureBoxfoto.Size = new Size(125, 90);
            pictureBoxfoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxfoto.TabIndex = 2;
            pictureBoxfoto.TabStop = false;
            // 
            // buttondelete
            // 
            buttondelete.BackColor = Color.Transparent;
            buttondelete.Cursor = Cursors.Hand;
            buttondelete.FlatStyle = FlatStyle.Flat;
            buttondelete.Font = new Font("Harlow Solid Italic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttondelete.ForeColor = Color.PeachPuff;
            buttondelete.Location = new Point(414, 47);
            buttondelete.Margin = new Padding(2);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(80, 49);
            buttondelete.TabIndex = 7;
            buttondelete.Text = "detail";
            buttondelete.UseVisualStyleBackColor = false;
            buttondelete.Click += buttonDetails_Click;
            // 
            // buttonDetails
            // 
            buttonDetails.BackColor = Color.Transparent;
            buttonDetails.Cursor = Cursors.Hand;
            buttonDetails.FlatStyle = FlatStyle.Flat;
            buttonDetails.Font = new Font("Harlow Solid Italic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonDetails.ForeColor = Color.PeachPuff;
            buttonDetails.Location = new Point(414, -2);
            buttonDetails.Margin = new Padding(2);
            buttonDetails.Name = "buttonDetails";
            buttonDetails.Size = new Size(80, 45);
            buttonDetails.TabIndex = 8;
            buttonDetails.Text = "delete";
            buttonDetails.UseVisualStyleBackColor = false;
            buttonDetails.Click += buttondelete_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Harlow Solid Italic", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelID.ForeColor = Color.PeachPuff;
            labelID.Location = new Point(143, 52);
            labelID.Name = "labelID";
            labelID.Padding = new Padding(3);
            labelID.Size = new Size(75, 34);
            labelID.TabIndex = 9;
            labelID.Text = "labelid";
            // 
            // ControlYonetListe
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            Controls.Add(labelID);
            Controls.Add(buttonDetails);
            Controls.Add(buttondelete);
            Controls.Add(pictureBoxfoto);
            Controls.Add(labeladsoyad);
            Controls.Add(panel1);
            Font = new Font("Corbel", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "ControlYonetListe";
            Size = new Size(494, 96);
            Load += ControlYonetListe_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxfoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        public Label labeladsoyad;
        public PictureBox pictureBoxfoto;
        private Button buttondelete;
        private PictureBox pictureBox1;
        private Button buttonDetails;
        public Label labelID;
    }
}
