namespace MovieHubProjectV3
{
    partial class FrmFilmDetay
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
            this.pbAfis = new System.Windows.Forms.PictureBox();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblYonetmen = new System.Windows.Forms.Label();
            this.lblOyuncular = new System.Windows.Forms.Label();
            this.lblOzet = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfis)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAfis
            // 
            this.pbAfis.Location = new System.Drawing.Point(21, 12);
            this.pbAfis.Name = "pbAfis";
            this.pbAfis.Size = new System.Drawing.Size(284, 391);
            this.pbAfis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAfis.TabIndex = 0;
            this.pbAfis.TabStop = false;
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.Font = new System.Drawing.Font("HarmonyOS Sans SC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmAdi.ForeColor = System.Drawing.Color.Gold;
            this.lblFilmAdi.Location = new System.Drawing.Point(344, 50);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(97, 38);
            this.lblFilmAdi.TabIndex = 1;
            this.lblFilmAdi.Text = "Başlık";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Font = new System.Drawing.Font("HarmonyOS Sans SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTur.ForeColor = System.Drawing.Color.Gold;
            this.lblTur.Location = new System.Drawing.Point(346, 167);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(44, 26);
            this.lblTur.TabIndex = 2;
            this.lblTur.Text = "Tür";
            // 
            // lblYonetmen
            // 
            this.lblYonetmen.AutoSize = true;
            this.lblYonetmen.Font = new System.Drawing.Font("HarmonyOS Sans SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYonetmen.ForeColor = System.Drawing.Color.Gold;
            this.lblYonetmen.Location = new System.Drawing.Point(346, 220);
            this.lblYonetmen.Name = "lblYonetmen";
            this.lblYonetmen.Size = new System.Drawing.Size(107, 26);
            this.lblYonetmen.TabIndex = 3;
            this.lblYonetmen.Text = "Yönetmen";
            // 
            // lblOyuncular
            // 
            this.lblOyuncular.AutoSize = true;
            this.lblOyuncular.Font = new System.Drawing.Font("HarmonyOS Sans SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOyuncular.ForeColor = System.Drawing.Color.Gold;
            this.lblOyuncular.Location = new System.Drawing.Point(346, 281);
            this.lblOyuncular.Name = "lblOyuncular";
            this.lblOyuncular.Size = new System.Drawing.Size(105, 26);
            this.lblOyuncular.TabIndex = 4;
            this.lblOyuncular.Text = "oyuncular";
            // 
            // lblOzet
            // 
            this.lblOzet.AutoSize = true;
            this.lblOzet.Font = new System.Drawing.Font("HarmonyOS Sans SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOzet.ForeColor = System.Drawing.Color.Gold;
            this.lblOzet.Location = new System.Drawing.Point(348, 341);
            this.lblOzet.Name = "lblOzet";
            this.lblOzet.Size = new System.Drawing.Size(53, 26);
            this.lblOzet.TabIndex = 5;
            this.lblOzet.Text = "özet";
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Red;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(851, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(39, 51);
            this.btnKapat.TabIndex = 14;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FrmFilmDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(891, 426);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.lblOzet);
            this.Controls.Add(this.lblOyuncular);
            this.Controls.Add(this.lblYonetmen);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblFilmAdi);
            this.Controls.Add(this.pbAfis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFilmDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFilmDetay";
            this.Load += new System.EventHandler(this.FrmFilmDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAfis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAfis;
        private System.Windows.Forms.Label lblFilmAdi;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblYonetmen;
        private System.Windows.Forms.Label lblOyuncular;
        private System.Windows.Forms.Label lblOzet;
        private System.Windows.Forms.Button btnKapat;
    }
}