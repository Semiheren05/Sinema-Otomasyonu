namespace MovieHub.cs
{
    partial class Kayıtekran
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayıtekran));
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            textAdmin = new TextBox();
            textPassword = new TextBox();
            textPassword2 = new TextBox();
            buttonWelcome = new Button();
            checkShow = new CheckBox();
            label4 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textAdSoyad = new TextBox();
            lblSifreUyari = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.PeachPuff;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(242, 128);
            label2.Name = "label2";
            label2.Size = new Size(181, 32);
            label2.TabIndex = 6;
            label2.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.PeachPuff;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(242, 189);
            label1.Name = "label1";
            label1.Size = new Size(75, 32);
            label1.TabIndex = 7;
            label1.Text = "Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.PeachPuff;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(242, 250);
            label3.Name = "label3";
            label3.Size = new Size(174, 32);
            label3.TabIndex = 8;
            label3.Text = "Şifre Tekrarı";
            // 
            // textAdmin
            // 
            textAdmin.BackColor = Color.White;
            textAdmin.BorderStyle = BorderStyle.None;
            textAdmin.Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textAdmin.ForeColor = Color.DarkRed;
            textAdmin.Location = new Point(242, 163);
            textAdmin.Name = "textAdmin";
            textAdmin.Size = new Size(216, 23);
            textAdmin.TabIndex = 9;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.White;
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textPassword.ForeColor = Color.DarkRed;
            textPassword.Location = new Point(242, 224);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(216, 23);
            textPassword.TabIndex = 10;
            textPassword.UseSystemPasswordChar = true;
            // 
            // textPassword2
            // 
            textPassword2.BackColor = Color.White;
            textPassword2.BorderStyle = BorderStyle.None;
            textPassword2.Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textPassword2.ForeColor = Color.DarkRed;
            textPassword2.Location = new Point(242, 285);
            textPassword2.Name = "textPassword2";
            textPassword2.Size = new Size(216, 23);
            textPassword2.TabIndex = 11;
            textPassword2.UseSystemPasswordChar = true;
            // 
            // buttonWelcome
            // 
            buttonWelcome.BackColor = Color.Sienna;
            buttonWelcome.Cursor = Cursors.Hand;
            buttonWelcome.FlatAppearance.BorderColor = Color.Black;
            buttonWelcome.FlatStyle = FlatStyle.Flat;
            buttonWelcome.Font = new Font("Arial", 12F, FontStyle.Bold);
            buttonWelcome.ForeColor = Color.PeachPuff;
            buttonWelcome.Location = new Point(280, 358);
            buttonWelcome.Name = "buttonWelcome";
            buttonWelcome.Size = new Size(143, 62);
            buttonWelcome.TabIndex = 12;
            buttonWelcome.Text = "Kayıt ol";
            buttonWelcome.UseVisualStyleBackColor = false;
            buttonWelcome.Click += buttonWelcome_Click;
            // 
            // checkShow
            // 
            checkShow.AutoSize = true;
            checkShow.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            checkShow.ForeColor = Color.PeachPuff;
            checkShow.Location = new Point(242, 314);
            checkShow.Name = "checkShow";
            checkShow.Size = new Size(67, 20);
            checkShow.TabIndex = 13;
            checkShow.Text = "Göster";
            checkShow.UseVisualStyleBackColor = false;
            checkShow.CheckedChanged += checkShow_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.PeachPuff;
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(242, 67);
            label4.Name = "label4";
            label4.Size = new Size(180, 32);
            label4.TabIndex = 14;
            label4.Text = "Ad Ve Soyad";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textAdSoyad
            // 
            textAdSoyad.BackColor = Color.White;
            textAdSoyad.BorderStyle = BorderStyle.None;
            textAdSoyad.Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textAdSoyad.ForeColor = Color.DarkRed;
            textAdSoyad.Location = new Point(242, 102);
            textAdSoyad.Name = "textAdSoyad";
            textAdSoyad.Size = new Size(216, 23);
            textAdSoyad.TabIndex = 16;
            // 
            // lblSifreUyari
            // 
            lblSifreUyari.AutoSize = true;
            lblSifreUyari.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSifreUyari.ForeColor = Color.PeachPuff;
            lblSifreUyari.Location = new Point(483, 215);
            lblSifreUyari.Name = "lblSifreUyari";
            lblSifreUyari.Size = new Size(65, 22);
            lblSifreUyari.TabIndex = 17;
            lblSifreUyari.Text = "label5";
            lblSifreUyari.Click += lblSifreUyari_Click;
            // 
            // Kayıtekran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 489);
            Controls.Add(lblSifreUyari);
            Controls.Add(textAdSoyad);
            Controls.Add(label4);
            Controls.Add(checkShow);
            Controls.Add(buttonWelcome);
            Controls.Add(textPassword2);
            Controls.Add(textPassword);
            Controls.Add(textAdmin);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Kayıtekran";
            Text = "Kayıtekran";
            Load += Kayıtekran_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textAdmin;
        private TextBox textPassword;
        private TextBox textPassword2;
        private Button buttonWelcome;
        private CheckBox checkShow;
        private Label label4;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textAdSoyad;
        private Label lblSifreUyari;
    }
}