namespace MovieHub.cs
{
    partial class FormFilmLİste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilmLİste));
            panel1 = new Panel();
            label4 = new Label();
            buttonExit = new Button();
            panel2 = new Panel();
            flowLayoutFilm = new FlowLayoutPanel();
            textBoxsearch = new TextBox();
            label1 = new Label();
            flowLayoutFilm1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buttonExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1323, 60);
            panel1.TabIndex = 8;
            // 
            // label4
            // 
            label4.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label4.ForeColor = Color.Linen;
            label4.Location = new Point(63, 10);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(195, 42);
            label4.TabIndex = 7;
            label4.Text = "Movie List";
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Sienna;
            buttonExit.BackgroundImage = (Image)resources.GetObject("buttonExit.BackgroundImage");
            buttonExit.Cursor = Cursors.Hand;
            buttonExit.Dock = DockStyle.Right;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Harlow Solid Italic", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonExit.ForeColor = Color.Linen;
            buttonExit.ImageAlign = ContentAlignment.MiddleRight;
            buttonExit.Location = new Point(1249, 0);
            buttonExit.Margin = new Padding(2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(74, 60);
            buttonExit.TabIndex = 6;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Sienna;
            panel2.Controls.Add(flowLayoutFilm);
            panel2.Controls.Add(textBoxsearch);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 60);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1323, 49);
            panel2.TabIndex = 9;
            // 
            // flowLayoutFilm
            // 
            flowLayoutFilm.Location = new Point(0, 47);
            flowLayoutFilm.Name = "flowLayoutFilm";
            flowLayoutFilm.Size = new Size(894, 740);
            flowLayoutFilm.TabIndex = 10;
            // 
            // textBoxsearch
            // 
            textBoxsearch.BackColor = Color.LavenderBlush;
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
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.LavenderBlush;
            label1.Location = new Point(94, 6);
            label1.Name = "label1";
            label1.Size = new Size(146, 24);
            label1.TabIndex = 0;
            label1.Text = "Movie Name :";
            // 
            // flowLayoutFilm1
            // 
            flowLayoutFilm1.AutoScroll = true;
            flowLayoutFilm1.Location = new Point(337, 114);
            flowLayoutFilm1.Name = "flowLayoutFilm1";
            flowLayoutFilm1.Size = new Size(545, 723);
            flowLayoutFilm1.TabIndex = 10;
            // 
            // FormFilmLİste
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1323, 747);
            Controls.Add(flowLayoutFilm1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Harlow Solid Italic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormFilmLİste";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormFilmLİste";
            Load += FormFilmLİste_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Button buttonExit;
        private Panel panel2;
        private TextBox textBoxsearch;
        private Label label1;
        private FlowLayoutPanel flowLayoutFilm;
        private FlowLayoutPanel flowLayoutFilm1;
    }
}