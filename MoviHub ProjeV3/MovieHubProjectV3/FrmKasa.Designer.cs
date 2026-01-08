namespace MovieHubProjectV3
{
    partial class FrmKasa
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnKapat = new System.Windows.Forms.Button();
            this.lblSatilanBiletBaslik = new System.Windows.Forms.Label();
            this.lblSatilanBilet = new System.Windows.Forms.Label();
            this.lblIptalBiletBaslik = new System.Windows.Forms.Label();
            this.lblIptalBilet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("HarmonyOS Sans SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Kasa Tutarı :";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("HarmonyOS Sans SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplam.ForeColor = System.Drawing.Color.Gold;
            this.lblToplam.Location = new System.Drawing.Point(648, 156);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(54, 26);
            this.lblToplam.TabIndex = 1;
            this.lblToplam.Text = "00 tl";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(769, 271);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Red;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(784, 1);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(39, 51);
            this.btnKapat.TabIndex = 14;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblSatilanBiletBaslik
            // 
            this.lblSatilanBiletBaslik.AutoSize = true;
            this.lblSatilanBiletBaslik.BackColor = System.Drawing.Color.BurlyWood;
            this.lblSatilanBiletBaslik.Font = new System.Drawing.Font("HarmonyOS Sans SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatilanBiletBaslik.Location = new System.Drawing.Point(63, 37);
            this.lblSatilanBiletBaslik.Name = "lblSatilanBiletBaslik";
            this.lblSatilanBiletBaslik.Size = new System.Drawing.Size(134, 26);
            this.lblSatilanBiletBaslik.TabIndex = 15;
            this.lblSatilanBiletBaslik.Text = "kesilen bilet :";
            // 
            // lblSatilanBilet
            // 
            this.lblSatilanBilet.AutoSize = true;
            this.lblSatilanBilet.BackColor = System.Drawing.Color.BurlyWood;
            this.lblSatilanBilet.Font = new System.Drawing.Font("HarmonyOS Sans SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatilanBilet.Location = new System.Drawing.Point(241, 37);
            this.lblSatilanBilet.Name = "lblSatilanBilet";
            this.lblSatilanBilet.Size = new System.Drawing.Size(42, 26);
            this.lblSatilanBilet.TabIndex = 16;
            this.lblSatilanBilet.Text = "\"0\"";
            // 
            // lblIptalBiletBaslik
            // 
            this.lblIptalBiletBaslik.AutoSize = true;
            this.lblIptalBiletBaslik.BackColor = System.Drawing.Color.BurlyWood;
            this.lblIptalBiletBaslik.Font = new System.Drawing.Font("HarmonyOS Sans SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIptalBiletBaslik.Location = new System.Drawing.Point(63, 111);
            this.lblIptalBiletBaslik.Name = "lblIptalBiletBaslik";
            this.lblIptalBiletBaslik.Size = new System.Drawing.Size(114, 26);
            this.lblIptalBiletBaslik.TabIndex = 17;
            this.lblIptalBiletBaslik.Text = "iptal/iade :";
            // 
            // lblIptalBilet
            // 
            this.lblIptalBilet.AutoSize = true;
            this.lblIptalBilet.BackColor = System.Drawing.Color.Red;
            this.lblIptalBilet.Font = new System.Drawing.Font("HarmonyOS Sans SC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIptalBilet.Location = new System.Drawing.Point(241, 111);
            this.lblIptalBilet.Name = "lblIptalBilet";
            this.lblIptalBilet.Size = new System.Drawing.Size(42, 26);
            this.lblIptalBilet.TabIndex = 18;
            this.lblIptalBilet.Text = "\"0\"";
            // 
            // FrmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(825, 495);
            this.Controls.Add(this.lblIptalBilet);
            this.Controls.Add(this.lblIptalBiletBaslik);
            this.Controls.Add(this.lblSatilanBilet);
            this.Controls.Add(this.lblSatilanBiletBaslik);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKasa";
            this.Load += new System.EventHandler(this.FrmKasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label lblSatilanBiletBaslik;
        private System.Windows.Forms.Label lblSatilanBilet;
        private System.Windows.Forms.Label lblIptalBiletBaslik;
        private System.Windows.Forms.Label lblIptalBilet;
    }
}