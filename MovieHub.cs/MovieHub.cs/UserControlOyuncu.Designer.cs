namespace MovieHub.cs
{
    partial class UserControlOyuncu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlOyuncu));
            buttonDetails = new Button();
            buttondelete = new Button();
            labelID = new Label();
            pictureBoxfoto = new PictureBox();
            labeladsoyad = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxfoto).BeginInit();
            SuspendLayout();
            // 
            // buttonDetails
            // 
            buttonDetails.BackColor = Color.PeachPuff;
            buttonDetails.Cursor = Cursors.Hand;
            buttonDetails.FlatStyle = FlatStyle.Flat;
            buttonDetails.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonDetails.ForeColor = Color.Sienna;
            buttonDetails.Location = new Point(360, 34);
            buttonDetails.Margin = new Padding(2);
            buttonDetails.Name = "buttonDetails";
            buttonDetails.Size = new Size(70, 37);
            buttonDetails.TabIndex = 8;
            buttonDetails.Text = "detail";
            buttonDetails.UseVisualStyleBackColor = false;
            buttonDetails.Click += buttonDetails_Click;
            // 
            // buttondelete
            // 
            buttondelete.BackColor = Color.PeachPuff;
            buttondelete.Cursor = Cursors.Hand;
            buttondelete.FlatStyle = FlatStyle.Flat;
            buttondelete.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttondelete.ForeColor = Color.Sienna;
            buttondelete.Location = new Point(360, 2);
            buttondelete.Margin = new Padding(2);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(70, 34);
            buttondelete.TabIndex = 9;
            buttondelete.Text = "delete";
            buttondelete.UseVisualStyleBackColor = false;
            buttondelete.Click += buttondelete_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            labelID.ForeColor = Color.PeachPuff;
            labelID.Location = new Point(123, 39);
            labelID.Name = "labelID";
            labelID.Padding = new Padding(3, 2, 3, 2);
            labelID.Size = new Size(81, 28);
            labelID.TabIndex = 15;
            labelID.Text = "labelid";
            // 
            // pictureBoxfoto
            // 
            pictureBoxfoto.Image = (Image)resources.GetObject("pictureBoxfoto.Image");
            pictureBoxfoto.Location = new Point(9, 2);
            pictureBoxfoto.Margin = new Padding(3, 2, 3, 2);
            pictureBoxfoto.Name = "pictureBoxfoto";
            pictureBoxfoto.Size = new Size(109, 68);
            pictureBoxfoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxfoto.TabIndex = 14;
            pictureBoxfoto.TabStop = false;
            // 
            // labeladsoyad
            // 
            labeladsoyad.AutoSize = true;
            labeladsoyad.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            labeladsoyad.ForeColor = Color.PeachPuff;
            labeladsoyad.Location = new Point(123, 8);
            labeladsoyad.Name = "labeladsoyad";
            labeladsoyad.Padding = new Padding(3, 2, 3, 2);
            labeladsoyad.Size = new Size(119, 28);
            labeladsoyad.TabIndex = 13;
            labeladsoyad.Text = "labelname";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 72);
            panel1.TabIndex = 12;
            // 
            // UserControlOyuncu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            Controls.Add(labelID);
            Controls.Add(pictureBoxfoto);
            Controls.Add(labeladsoyad);
            Controls.Add(panel1);
            Controls.Add(buttondelete);
            Controls.Add(buttonDetails);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserControlOyuncu";
            Size = new Size(432, 72);
            Load += UserControlOyuncu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxfoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDetails;
        private Button buttondelete;
        public Label labelID;
        public PictureBox pictureBoxfoto;
        public Label labeladsoyad;
        private Panel panel1;
    }
}
