namespace Mbys
{
    partial class Frm_MuayeneKayit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_MuayeneKayit = new System.Windows.Forms.Button();
            this.btn_ReceteOlustur = new System.Windows.Forms.Button();
            this.msk_muayene_soyad = new System.Windows.Forms.MaskedTextBox();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_Adi = new System.Windows.Forms.Label();
            this.msk_muayane_adi = new System.Windows.Forms.MaskedTextBox();
            this.msk_hasta_tc = new System.Windows.Forms.MaskedTextBox();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.msk_hasta_tedavi = new System.Windows.Forms.MaskedTextBox();
            this.lbl_muayaneTarihi = new System.Windows.Forms.Label();
            this.msk_hasta_Tani = new System.Windows.Forms.MaskedTextBox();
            this.lbl_sikayet = new System.Windows.Forms.Label();
            this.msk_hasta_sikayet = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Tani = new System.Windows.Forms.Label();
            this.msk_hasta_muayaneTarihi = new System.Windows.Forms.MaskedTextBox();
            this.lbl_tedavi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(300, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 37);
            this.label1.TabIndex = 35;
            this.label1.Text = "Muayene Bilgisi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_MuayeneKayit);
            this.groupBox1.Controls.Add(this.btn_ReceteOlustur);
            this.groupBox1.Controls.Add(this.msk_muayene_soyad);
            this.groupBox1.Controls.Add(this.lbl_soyad);
            this.groupBox1.Controls.Add(this.lbl_Adi);
            this.groupBox1.Controls.Add(this.msk_muayane_adi);
            this.groupBox1.Controls.Add(this.msk_hasta_tc);
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Controls.Add(this.msk_hasta_tedavi);
            this.groupBox1.Controls.Add(this.lbl_muayaneTarihi);
            this.groupBox1.Controls.Add(this.msk_hasta_Tani);
            this.groupBox1.Controls.Add(this.lbl_sikayet);
            this.groupBox1.Controls.Add(this.msk_hasta_sikayet);
            this.groupBox1.Controls.Add(this.lbl_Tani);
            this.groupBox1.Controls.Add(this.msk_hasta_muayaneTarihi);
            this.groupBox1.Controls.Add(this.lbl_tedavi);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(135, 124);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(530, 267);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Muayene Bilgileri";
            // 
            // btn_MuayeneKayit
            // 
            this.btn_MuayeneKayit.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_MuayeneKayit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_MuayeneKayit.Location = new System.Drawing.Point(226, 222);
            this.btn_MuayeneKayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_MuayeneKayit.Name = "btn_MuayeneKayit";
            this.btn_MuayeneKayit.Size = new System.Drawing.Size(119, 36);
            this.btn_MuayeneKayit.TabIndex = 40;
            this.btn_MuayeneKayit.Text = "Muayene Kaydet";
            this.btn_MuayeneKayit.UseVisualStyleBackColor = false;
            this.btn_MuayeneKayit.Click += new System.EventHandler(this.btn_MuayeneKayit_Click);
            // 
            // btn_ReceteOlustur
            // 
            this.btn_ReceteOlustur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ReceteOlustur.Location = new System.Drawing.Point(226, 229);
            this.btn_ReceteOlustur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ReceteOlustur.Name = "btn_ReceteOlustur";
            this.btn_ReceteOlustur.Size = new System.Drawing.Size(119, 29);
            this.btn_ReceteOlustur.TabIndex = 39;
            this.btn_ReceteOlustur.Text = "Reçete Oluştur";
            this.btn_ReceteOlustur.UseVisualStyleBackColor = true;
            this.btn_ReceteOlustur.Visible = false;
            this.btn_ReceteOlustur.Click += new System.EventHandler(this.btn_ReceteOlustur_Click);
            // 
            // msk_muayene_soyad
            // 
            this.msk_muayene_soyad.Location = new System.Drawing.Point(387, 78);
            this.msk_muayene_soyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_muayene_soyad.Name = "msk_muayene_soyad";
            this.msk_muayene_soyad.Size = new System.Drawing.Size(110, 25);
            this.msk_muayene_soyad.TabIndex = 37;
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_soyad.Location = new System.Drawing.Point(326, 82);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(46, 15);
            this.lbl_soyad.TabIndex = 35;
            this.lbl_soyad.Text = "Soyadı:";
            // 
            // lbl_Adi
            // 
            this.lbl_Adi.AutoSize = true;
            this.lbl_Adi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Adi.Location = new System.Drawing.Point(334, 48);
            this.lbl_Adi.Name = "lbl_Adi";
            this.lbl_Adi.Size = new System.Drawing.Size(28, 15);
            this.lbl_Adi.TabIndex = 34;
            this.lbl_Adi.Text = "Adı:";
            // 
            // msk_muayane_adi
            // 
            this.msk_muayane_adi.Location = new System.Drawing.Point(387, 46);
            this.msk_muayane_adi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_muayane_adi.Name = "msk_muayane_adi";
            this.msk_muayane_adi.Size = new System.Drawing.Size(110, 25);
            this.msk_muayane_adi.TabIndex = 36;
            // 
            // msk_hasta_tc
            // 
            this.msk_hasta_tc.Location = new System.Drawing.Point(147, 44);
            this.msk_hasta_tc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_hasta_tc.Mask = "00000000000";
            this.msk_hasta_tc.Name = "msk_hasta_tc";
            this.msk_hasta_tc.Size = new System.Drawing.Size(106, 25);
            this.msk_hasta_tc.TabIndex = 26;
            this.msk_hasta_tc.ValidatingType = typeof(int);
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tc.Location = new System.Drawing.Point(23, 43);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(22, 15);
            this.lbl_tc.TabIndex = 18;
            this.lbl_tc.Text = "Tc:";
            // 
            // msk_hasta_tedavi
            // 
            this.msk_hasta_tedavi.Location = new System.Drawing.Point(147, 161);
            this.msk_hasta_tedavi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_hasta_tedavi.Name = "msk_hasta_tedavi";
            this.msk_hasta_tedavi.Size = new System.Drawing.Size(350, 25);
            this.msk_hasta_tedavi.TabIndex = 30;
            // 
            // lbl_muayaneTarihi
            // 
            this.lbl_muayaneTarihi.AutoSize = true;
            this.lbl_muayaneTarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_muayaneTarihi.Location = new System.Drawing.Point(23, 73);
            this.lbl_muayaneTarihi.Name = "lbl_muayaneTarihi";
            this.lbl_muayaneTarihi.Size = new System.Drawing.Size(94, 15);
            this.lbl_muayaneTarihi.TabIndex = 19;
            this.lbl_muayaneTarihi.Text = "Muayene Tarihi:";
            // 
            // msk_hasta_Tani
            // 
            this.msk_hasta_Tani.Location = new System.Drawing.Point(147, 132);
            this.msk_hasta_Tani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_hasta_Tani.Name = "msk_hasta_Tani";
            this.msk_hasta_Tani.Size = new System.Drawing.Size(350, 25);
            this.msk_hasta_Tani.TabIndex = 29;
            // 
            // lbl_sikayet
            // 
            this.lbl_sikayet.AutoSize = true;
            this.lbl_sikayet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_sikayet.Location = new System.Drawing.Point(23, 102);
            this.lbl_sikayet.Name = "lbl_sikayet";
            this.lbl_sikayet.Size = new System.Drawing.Size(51, 15);
            this.lbl_sikayet.TabIndex = 20;
            this.lbl_sikayet.Text = "Şikayet:";
            // 
            // msk_hasta_sikayet
            // 
            this.msk_hasta_sikayet.Location = new System.Drawing.Point(147, 103);
            this.msk_hasta_sikayet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_hasta_sikayet.Name = "msk_hasta_sikayet";
            this.msk_hasta_sikayet.Size = new System.Drawing.Size(350, 25);
            this.msk_hasta_sikayet.TabIndex = 28;
            // 
            // lbl_Tani
            // 
            this.lbl_Tani.AutoSize = true;
            this.lbl_Tani.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Tani.Location = new System.Drawing.Point(23, 131);
            this.lbl_Tani.Name = "lbl_Tani";
            this.lbl_Tani.Size = new System.Drawing.Size(32, 15);
            this.lbl_Tani.TabIndex = 21;
            this.lbl_Tani.Text = "Tanı:";
            // 
            // msk_hasta_muayaneTarihi
            // 
            this.msk_hasta_muayaneTarihi.BackColor = System.Drawing.SystemColors.Window;
            this.msk_hasta_muayaneTarihi.Location = new System.Drawing.Point(147, 74);
            this.msk_hasta_muayaneTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_hasta_muayaneTarihi.Name = "msk_hasta_muayaneTarihi";
            this.msk_hasta_muayaneTarihi.ReadOnly = true;
            this.msk_hasta_muayaneTarihi.Size = new System.Drawing.Size(148, 25);
            this.msk_hasta_muayaneTarihi.TabIndex = 27;
            this.msk_hasta_muayaneTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_tedavi
            // 
            this.lbl_tedavi.AutoSize = true;
            this.lbl_tedavi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tedavi.Location = new System.Drawing.Point(23, 160);
            this.lbl_tedavi.Name = "lbl_tedavi";
            this.lbl_tedavi.Size = new System.Drawing.Size(97, 15);
            this.lbl_tedavi.TabIndex = 22;
            this.lbl_tedavi.Text = "Önerilen Tedavi:";
            // 
            // Frm_MuayeneKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_MuayeneKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MuayeneKayit";
            this.Load += new System.EventHandler(this.Frm_MuayeneKayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        public GroupBox groupBox1;
        private Button btn_MuayeneKayit;
        private Button btn_ReceteOlustur;
        public MaskedTextBox msk_muayene_soyad;
        public Label lbl_soyad;
        public Label lbl_Adi;
        public MaskedTextBox msk_muayane_adi;
        public MaskedTextBox msk_hasta_tc;
        private Label lbl_tc;
        private MaskedTextBox msk_hasta_tedavi;
        public Label lbl_muayaneTarihi;
        public MaskedTextBox msk_hasta_Tani;
        private Label lbl_sikayet;
        private MaskedTextBox msk_hasta_sikayet;
        private Label lbl_Tani;
        public MaskedTextBox msk_hasta_muayaneTarihi;
        private Label lbl_tedavi;
    }
}