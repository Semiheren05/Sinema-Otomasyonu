namespace MovieHub.cs
{
    partial class UserOyuncu
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
            labeladsoyad = new Label();
            SuspendLayout();
            // 
            // labeladsoyad
            // 
            labeladsoyad.AutoSize = true;
            labeladsoyad.BackColor = Color.Transparent;
            labeladsoyad.Font = new Font("Harlow Solid Italic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labeladsoyad.ForeColor = Color.PeachPuff;
            labeladsoyad.Location = new Point(18, 0);
            labeladsoyad.Name = "labeladsoyad";
            labeladsoyad.Padding = new Padding(3, 2, 3, 2);
            labeladsoyad.Size = new Size(83, 24);
            labeladsoyad.TabIndex = 2;
            labeladsoyad.Text = "+labelname";
            // 
            // UserOyuncu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chocolate;
            Controls.Add(labeladsoyad);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserOyuncu";
            Size = new Size(137, 32);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labeladsoyad;
    }
}
