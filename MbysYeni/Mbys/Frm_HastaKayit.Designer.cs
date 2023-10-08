namespace Mbys
{
    partial class Frm_HastaKayit
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
            this.btn_hastaEkle = new System.Windows.Forms.Button();
            this.msk_hastaAdres = new System.Windows.Forms.TextBox();
            this.msk_hastaDogumYeri = new System.Windows.Forms.ComboBox();
            this.msk_hastaMedeniHal = new System.Windows.Forms.ComboBox();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.msk_hastaTelno = new System.Windows.Forms.MaskedTextBox();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.lbl_Adi = new System.Windows.Forms.Label();
            this.lbl_dgmYeri = new System.Windows.Forms.Label();
            this.msk_hastaDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.lbl_dogum_tarihi = new System.Windows.Forms.Label();
            this.lbl_telefon = new System.Windows.Forms.Label();
            this.msk_hastaSoyad = new System.Windows.Forms.MaskedTextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.msk_hastaAdi = new System.Windows.Forms.MaskedTextBox();
            this.lbl_medenidurum = new System.Windows.Forms.Label();
            this.msk_HastaTc = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(300, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 37);
            this.label1.TabIndex = 36;
            this.label1.Text = "Hasta Kaydet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_hastaEkle);
            this.groupBox1.Controls.Add(this.msk_hastaAdres);
            this.groupBox1.Controls.Add(this.msk_hastaDogumYeri);
            this.groupBox1.Controls.Add(this.msk_hastaMedeniHal);
            this.groupBox1.Controls.Add(this.lbl_soyad);
            this.groupBox1.Controls.Add(this.msk_hastaTelno);
            this.groupBox1.Controls.Add(this.lbl_tc);
            this.groupBox1.Controls.Add(this.lbl_Adi);
            this.groupBox1.Controls.Add(this.lbl_dgmYeri);
            this.groupBox1.Controls.Add(this.msk_hastaDogumTarihi);
            this.groupBox1.Controls.Add(this.lbl_dogum_tarihi);
            this.groupBox1.Controls.Add(this.lbl_telefon);
            this.groupBox1.Controls.Add(this.msk_hastaSoyad);
            this.groupBox1.Controls.Add(this.lblAdres);
            this.groupBox1.Controls.Add(this.msk_hastaAdi);
            this.groupBox1.Controls.Add(this.lbl_medenidurum);
            this.groupBox1.Controls.Add(this.msk_HastaTc);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(185, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(430, 356);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Kayıt Bilgileri";
            // 
            // btn_hastaEkle
            // 
            this.btn_hastaEkle.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_hastaEkle.Location = new System.Drawing.Point(162, 312);
            this.btn_hastaEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hastaEkle.Name = "btn_hastaEkle";
            this.btn_hastaEkle.Size = new System.Drawing.Size(82, 40);
            this.btn_hastaEkle.TabIndex = 38;
            this.btn_hastaEkle.Text = "Ekle";
            this.btn_hastaEkle.UseVisualStyleBackColor = false;
            this.btn_hastaEkle.Click += new System.EventHandler(this.btn_hastaEkle_Click);
            // 
            // msk_hastaAdres
            // 
            this.msk_hastaAdres.Location = new System.Drawing.Point(162, 250);
            this.msk_hastaAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_hastaAdres.Multiline = true;
            this.msk_hastaAdres.Name = "msk_hastaAdres";
            this.msk_hastaAdres.Size = new System.Drawing.Size(203, 43);
            this.msk_hastaAdres.TabIndex = 37;
            // 
            // msk_hastaDogumYeri
            // 
            this.msk_hastaDogumYeri.FormattingEnabled = true;
            this.msk_hastaDogumYeri.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak",
            "Belirtilmemiş"});
            this.msk_hastaDogumYeri.Location = new System.Drawing.Point(162, 216);
            this.msk_hastaDogumYeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_hastaDogumYeri.Name = "msk_hastaDogumYeri";
            this.msk_hastaDogumYeri.Size = new System.Drawing.Size(110, 25);
            this.msk_hastaDogumYeri.TabIndex = 36;
            // 
            // msk_hastaMedeniHal
            // 
            this.msk_hastaMedeniHal.FormattingEnabled = true;
            this.msk_hastaMedeniHal.Items.AddRange(new object[] {
            "Bekar",
            "Evli ",
            "Dul",
            "Boşanmış",
            "Belirtilmemiş"});
            this.msk_hastaMedeniHal.Location = new System.Drawing.Point(162, 181);
            this.msk_hastaMedeniHal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_hastaMedeniHal.Name = "msk_hastaMedeniHal";
            this.msk_hastaMedeniHal.Size = new System.Drawing.Size(110, 25);
            this.msk_hastaMedeniHal.TabIndex = 35;
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_soyad.Location = new System.Drawing.Point(68, 90);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(46, 15);
            this.lbl_soyad.TabIndex = 2;
            this.lbl_soyad.Text = "Soyadı:";
            // 
            // msk_hastaTelno
            // 
            this.msk_hastaTelno.Location = new System.Drawing.Point(162, 150);
            this.msk_hastaTelno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_hastaTelno.Mask = "9990000000";
            this.msk_hastaTelno.Name = "msk_hastaTelno";
            this.msk_hastaTelno.Size = new System.Drawing.Size(110, 25);
            this.msk_hastaTelno.TabIndex = 17;
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tc.Location = new System.Drawing.Point(68, 31);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(22, 15);
            this.lbl_tc.TabIndex = 0;
            this.lbl_tc.Text = "Tc:";
            // 
            // lbl_Adi
            // 
            this.lbl_Adi.AutoSize = true;
            this.lbl_Adi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Adi.Location = new System.Drawing.Point(68, 61);
            this.lbl_Adi.Name = "lbl_Adi";
            this.lbl_Adi.Size = new System.Drawing.Size(28, 15);
            this.lbl_Adi.TabIndex = 1;
            this.lbl_Adi.Text = "Adı:";
            // 
            // lbl_dgmYeri
            // 
            this.lbl_dgmYeri.AutoSize = true;
            this.lbl_dgmYeri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dgmYeri.Location = new System.Drawing.Point(69, 215);
            this.lbl_dgmYeri.Name = "lbl_dgmYeri";
            this.lbl_dgmYeri.Size = new System.Drawing.Size(75, 15);
            this.lbl_dgmYeri.TabIndex = 3;
            this.lbl_dgmYeri.Text = "Doğum Yeri:";
            // 
            // msk_hastaDogumTarihi
            // 
            this.msk_hastaDogumTarihi.Location = new System.Drawing.Point(162, 122);
            this.msk_hastaDogumTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_hastaDogumTarihi.Mask = "00/00/0000";
            this.msk_hastaDogumTarihi.Name = "msk_hastaDogumTarihi";
            this.msk_hastaDogumTarihi.Size = new System.Drawing.Size(110, 25);
            this.msk_hastaDogumTarihi.TabIndex = 14;
            this.msk_hastaDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_dogum_tarihi
            // 
            this.lbl_dogum_tarihi.AutoSize = true;
            this.lbl_dogum_tarihi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dogum_tarihi.Location = new System.Drawing.Point(68, 121);
            this.lbl_dogum_tarihi.Name = "lbl_dogum_tarihi";
            this.lbl_dogum_tarihi.Size = new System.Drawing.Size(84, 15);
            this.lbl_dogum_tarihi.TabIndex = 4;
            this.lbl_dogum_tarihi.Text = "Doğum Tarihi:";
            // 
            // lbl_telefon
            // 
            this.lbl_telefon.AutoSize = true;
            this.lbl_telefon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_telefon.Location = new System.Drawing.Point(68, 149);
            this.lbl_telefon.Name = "lbl_telefon";
            this.lbl_telefon.Size = new System.Drawing.Size(71, 15);
            this.lbl_telefon.TabIndex = 7;
            this.lbl_telefon.Text = "Telefon No:";
            // 
            // msk_hastaSoyad
            // 
            this.msk_hastaSoyad.Location = new System.Drawing.Point(162, 91);
            this.msk_hastaSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_hastaSoyad.Name = "msk_hastaSoyad";
            this.msk_hastaSoyad.Size = new System.Drawing.Size(110, 25);
            this.msk_hastaSoyad.TabIndex = 12;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdres.Location = new System.Drawing.Point(80, 249);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(42, 15);
            this.lblAdres.TabIndex = 8;
            this.lblAdres.Text = "Adres:";
            // 
            // msk_hastaAdi
            // 
            this.msk_hastaAdi.Location = new System.Drawing.Point(162, 62);
            this.msk_hastaAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_hastaAdi.Name = "msk_hastaAdi";
            this.msk_hastaAdi.Size = new System.Drawing.Size(110, 25);
            this.msk_hastaAdi.TabIndex = 11;
            // 
            // lbl_medenidurum
            // 
            this.lbl_medenidurum.AutoSize = true;
            this.lbl_medenidurum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_medenidurum.Location = new System.Drawing.Point(68, 180);
            this.lbl_medenidurum.Name = "lbl_medenidurum";
            this.lbl_medenidurum.Size = new System.Drawing.Size(76, 15);
            this.lbl_medenidurum.TabIndex = 9;
            this.lbl_medenidurum.Text = "Medeni Hali:";
            // 
            // msk_HastaTc
            // 
            this.msk_HastaTc.Location = new System.Drawing.Point(162, 32);
            this.msk_HastaTc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msk_HastaTc.Mask = "00000000000";
            this.msk_HastaTc.Name = "msk_HastaTc";
            this.msk_HastaTc.Size = new System.Drawing.Size(110, 25);
            this.msk_HastaTc.TabIndex = 10;
            this.msk_HastaTc.ValidatingType = typeof(int);
            // 
            // Frm_HastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_HastaKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Kaydet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btn_hastaEkle;
        private TextBox msk_hastaAdres;
        private ComboBox msk_hastaDogumYeri;
        private ComboBox msk_hastaMedeniHal;
        private Label lbl_soyad;
        private MaskedTextBox msk_hastaTelno;
        private Label lbl_tc;
        private Label lbl_Adi;
        private Label lbl_dgmYeri;
        private MaskedTextBox msk_hastaDogumTarihi;
        private Label lbl_dogum_tarihi;
        private Label lbl_telefon;
        private MaskedTextBox msk_hastaSoyad;
        private Label lblAdres;
        private MaskedTextBox msk_hastaAdi;
        private Label lbl_medenidurum;
        private MaskedTextBox msk_HastaTc;
    }
}