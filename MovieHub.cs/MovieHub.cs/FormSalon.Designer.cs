namespace MovieHub.cs
{
    partial class FormSalon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalon));
            label1 = new Label();
            label2 = new Label();
            textsalonadi = new TextBox();
            comboseats = new ComboBox();
            groupBox1 = new GroupBox();
            buttonsalonLoad = new Button();
            groupBox2 = new GroupBox();
            flowSalonList = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            buttonExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            label1.ForeColor = Color.PeachPuff;
            label1.Location = new Point(84, 24);
            label1.Name = "label1";
            label1.Size = new Size(213, 35);
            label1.TabIndex = 10;
            label1.Text = "Film Adı";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            label2.ForeColor = Color.PeachPuff;
            label2.Location = new Point(346, 24);
            label2.Name = "label2";
            label2.Size = new Size(238, 35);
            label2.TabIndex = 11;
            label2.Text = "Koltuk Numarası";
            // 
            // textsalonadi
            // 
            textsalonadi.BackColor = Color.Snow;
            textsalonadi.BorderStyle = BorderStyle.None;
            textsalonadi.Font = new Font("Harlow Solid Italic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textsalonadi.ForeColor = Color.Indigo;
            textsalonadi.Location = new Point(84, 61);
            textsalonadi.Name = "textsalonadi";
            textsalonadi.Size = new Size(238, 24);
            textsalonadi.TabIndex = 12;
            // 
            // comboseats
            // 
            comboseats.FormattingEnabled = true;
            comboseats.Items.AddRange(new object[] { "1", "2", "3" });
            comboseats.Location = new Point(346, 58);
            comboseats.Name = "comboseats";
            comboseats.Size = new Size(237, 28);
            comboseats.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Sienna;
            groupBox1.Controls.Add(buttonsalonLoad);
            groupBox1.Controls.Add(comboseats);
            groupBox1.Controls.Add(textsalonadi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.MediumVioletRed;
            groupBox1.Location = new Point(149, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(843, 119);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // buttonsalonLoad
            // 
            buttonsalonLoad.BackColor = Color.Sienna;
            buttonsalonLoad.BackgroundImage = (Image)resources.GetObject("buttonsalonLoad.BackgroundImage");
            buttonsalonLoad.BackgroundImageLayout = ImageLayout.Center;
            buttonsalonLoad.Cursor = Cursors.Hand;
            buttonsalonLoad.FlatAppearance.BorderSize = 0;
            buttonsalonLoad.FlatStyle = FlatStyle.Flat;
            buttonsalonLoad.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            buttonsalonLoad.ForeColor = Color.PeachPuff;
            buttonsalonLoad.Location = new Point(715, 42);
            buttonsalonLoad.Name = "buttonsalonLoad";
            buttonsalonLoad.Size = new Size(98, 52);
            buttonsalonLoad.TabIndex = 18;
            buttonsalonLoad.UseVisualStyleBackColor = false;
            buttonsalonLoad.Click += buttonphotoLoad_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Sienna;
            groupBox2.Controls.Add(flowSalonList);
            groupBox2.ForeColor = Color.MediumVioletRed;
            groupBox2.Location = new Point(12, 278);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1143, 530);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // flowSalonList
            // 
            flowSalonList.AutoScroll = true;
            flowSalonList.Dock = DockStyle.Fill;
            flowSalonList.Location = new Point(3, 24);
            flowSalonList.Name = "flowSalonList";
            flowSalonList.Size = new Size(1137, 503);
            flowSalonList.TabIndex = 0;
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
            panel1.Size = new Size(1190, 86);
            panel1.TabIndex = 11;
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
            label4.Text = "Salon";
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
            buttonExit.Location = new Point(1067, 0);
            buttonExit.Margin = new Padding(4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(123, 86);
            buttonExit.TabIndex = 6;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click_1;
            // 
            // FormSalon
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1190, 835);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Harlow Solid Italic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormSalon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSalon";
            Load += FormSalon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textsalonadi;
        private ComboBox comboseats;
        private GroupBox groupBox1;
        private Button buttonsalonLoad;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowSalonList;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
        private Button buttonExit;
    }
}