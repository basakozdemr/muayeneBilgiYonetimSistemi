namespace Mbys
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_IlacKaydet = new System.Windows.Forms.Button();
            this.btn_MuayeneKaydet = new System.Windows.Forms.Button();
            this.btn_HastaKaydet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_KayitliHastalar = new System.Windows.Forms.Button();
            this.btn_KayitliIlaclar = new System.Windows.Forms.Button();
            this.btn_receteler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_IlacKaydet
            // 
            this.btn_IlacKaydet.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_IlacKaydet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_IlacKaydet.Location = new System.Drawing.Point(37, 413);
            this.btn_IlacKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_IlacKaydet.Name = "btn_IlacKaydet";
            this.btn_IlacKaydet.Size = new System.Drawing.Size(128, 58);
            this.btn_IlacKaydet.TabIndex = 6;
            this.btn_IlacKaydet.Text = "İlaç Kaydet";
            this.btn_IlacKaydet.UseVisualStyleBackColor = false;
            this.btn_IlacKaydet.Click += new System.EventHandler(this.btn_IlacKaydet_Click);
            // 
            // btn_MuayeneKaydet
            // 
            this.btn_MuayeneKaydet.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_MuayeneKaydet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MuayeneKaydet.Location = new System.Drawing.Point(37, 335);
            this.btn_MuayeneKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_MuayeneKaydet.Name = "btn_MuayeneKaydet";
            this.btn_MuayeneKaydet.Size = new System.Drawing.Size(128, 58);
            this.btn_MuayeneKaydet.TabIndex = 5;
            this.btn_MuayeneKaydet.Text = "Muayene Kaydet";
            this.btn_MuayeneKaydet.UseVisualStyleBackColor = false;
            this.btn_MuayeneKaydet.Click += new System.EventHandler(this.btn_MuayeneKaydet_Click);
            // 
            // btn_HastaKaydet
            // 
            this.btn_HastaKaydet.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_HastaKaydet.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_HastaKaydet.Location = new System.Drawing.Point(37, 258);
            this.btn_HastaKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_HastaKaydet.Name = "btn_HastaKaydet";
            this.btn_HastaKaydet.Size = new System.Drawing.Size(128, 58);
            this.btn_HastaKaydet.TabIndex = 4;
            this.btn_HastaKaydet.Text = "Hasta Kaydet";
            this.btn_HastaKaydet.UseVisualStyleBackColor = false;
            this.btn_HastaKaydet.Click += new System.EventHandler(this.btn_HastaKaydet_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(232, 304);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "İlaca Göre Hasta Bul";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightBlue;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(232, 382);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 58);
            this.button2.TabIndex = 8;
            this.button2.Text = "Hastaya Göre İlaçları Göster";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_KayitliHastalar
            // 
            this.btn_KayitliHastalar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_KayitliHastalar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_KayitliHastalar.Location = new System.Drawing.Point(429, 258);
            this.btn_KayitliHastalar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_KayitliHastalar.Name = "btn_KayitliHastalar";
            this.btn_KayitliHastalar.Size = new System.Drawing.Size(128, 58);
            this.btn_KayitliHastalar.TabIndex = 9;
            this.btn_KayitliHastalar.Text = "Kayıtlı Hastalar";
            this.btn_KayitliHastalar.UseVisualStyleBackColor = false;
            this.btn_KayitliHastalar.Click += new System.EventHandler(this.btn_KayitliHastalar_Click);
            // 
            // btn_KayitliIlaclar
            // 
            this.btn_KayitliIlaclar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_KayitliIlaclar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_KayitliIlaclar.Location = new System.Drawing.Point(429, 336);
            this.btn_KayitliIlaclar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_KayitliIlaclar.Name = "btn_KayitliIlaclar";
            this.btn_KayitliIlaclar.Size = new System.Drawing.Size(128, 58);
            this.btn_KayitliIlaclar.TabIndex = 10;
            this.btn_KayitliIlaclar.Text = "Kayıtlı İlaçlar";
            this.btn_KayitliIlaclar.UseVisualStyleBackColor = false;
            this.btn_KayitliIlaclar.Click += new System.EventHandler(this.btn_KayitliIlaclar_Click);
            // 
            // btn_receteler
            // 
            this.btn_receteler.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_receteler.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_receteler.Location = new System.Drawing.Point(429, 414);
            this.btn_receteler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_receteler.Name = "btn_receteler";
            this.btn_receteler.Size = new System.Drawing.Size(128, 58);
            this.btn_receteler.TabIndex = 11;
            this.btn_receteler.Text = "Reçeteler";
            this.btn_receteler.UseVisualStyleBackColor = false;
            this.btn_receteler.Click += new System.EventHandler(this.btn_receteler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(155, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Muayene Bilgi Yönetim Sistemi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mbys.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(189, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 536);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_receteler);
            this.Controls.Add(this.btn_KayitliIlaclar);
            this.Controls.Add(this.btn_KayitliHastalar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_IlacKaydet);
            this.Controls.Add(this.btn_MuayeneKaydet);
            this.Controls.Add(this.btn_HastaKaydet);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENÜ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_IlacKaydet;
        private Button btn_MuayeneKaydet;
        private Button btn_HastaKaydet;
        private Button button1;
        private Button button2;
        private Button btn_KayitliHastalar;
        private Button btn_KayitliIlaclar;
        private Button btn_receteler;
        private Label label1;
        private PictureBox pictureBox1;
    }
}