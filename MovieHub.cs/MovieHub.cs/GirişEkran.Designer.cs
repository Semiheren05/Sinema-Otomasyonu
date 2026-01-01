namespace MovieHub.cs
{
    partial class GirişEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirişEkran));
            textAdmin = new TextBox();
            textPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonWelcome = new Button();
            checkShow = new CheckBox();
            SuspendLayout();
            // 
            // textAdmin
            // 
            textAdmin.BackColor = Color.White;
            textAdmin.BorderStyle = BorderStyle.None;
            textAdmin.Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textAdmin.ForeColor = Color.DarkRed;
            textAdmin.Location = new Point(253, 130);
            textAdmin.Name = "textAdmin";
            textAdmin.Size = new Size(216, 23);
            textAdmin.TabIndex = 3;
            textAdmin.TextChanged += textAdmin_TextChanged;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.White;
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textPassword.ForeColor = Color.DarkRed;
            textPassword.Location = new Point(253, 191);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(216, 23);
            textPassword.TabIndex = 4;
            textPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.PeachPuff;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(244, 95);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.PeachPuff;
            label2.Location = new Point(244, 156);
            label2.Name = "label2";
            label2.Size = new Size(75, 32);
            label2.TabIndex = 6;
            label2.Text = "Şifre";
            // 
            // buttonWelcome
            // 
            buttonWelcome.BackColor = Color.Sienna;
            buttonWelcome.Cursor = Cursors.Hand;
            buttonWelcome.FlatAppearance.BorderColor = Color.Black;
            buttonWelcome.FlatStyle = FlatStyle.Flat;
            buttonWelcome.Font = new Font("Arial", 12F, FontStyle.Bold);
            buttonWelcome.ForeColor = Color.PeachPuff;
            buttonWelcome.Location = new Point(279, 265);
            buttonWelcome.Name = "buttonWelcome";
            buttonWelcome.Size = new Size(143, 62);
            buttonWelcome.TabIndex = 8;
            buttonWelcome.Text = "Giriş Yap";
            buttonWelcome.UseVisualStyleBackColor = false;
            buttonWelcome.Click += buttonWelcome_Click;
            // 
            // checkShow
            // 
            checkShow.AutoSize = true;
            checkShow.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            checkShow.ForeColor = Color.PeachPuff;
            checkShow.Location = new Point(252, 220);
            checkShow.Name = "checkShow";
            checkShow.Size = new Size(67, 20);
            checkShow.TabIndex = 9;
            checkShow.Text = "Göster";
            checkShow.UseVisualStyleBackColor = false;
            checkShow.CheckedChanged += checkShow_CheckedChanged;
            // 
            // GirişEkran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(checkShow);
            Controls.Add(buttonWelcome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textPassword);
            Controls.Add(textAdmin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GirişEkran";
            Text = "GirişEkran";
            Load += GirişEkran_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textAdmin;
        private TextBox textPassword;
        private Label label1;
        private Label label2;
        private Button buttonWelcome;
        private CheckBox checkShow;
    }
}