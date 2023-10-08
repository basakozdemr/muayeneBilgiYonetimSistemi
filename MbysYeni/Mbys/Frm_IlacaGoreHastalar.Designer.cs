namespace Mbys
{
    partial class Frm_IlacaGoreHastalar
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
            this.txt_AranacakIlac = new System.Windows.Forms.TextBox();
            this.dgv_hastaListele = new System.Windows.Forms.DataGridView();
            this.btn_IlacAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hastaListele)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aranacak İlacın Adı";
            // 
            // txt_AranacakIlac
            // 
            this.txt_AranacakIlac.Location = new System.Drawing.Point(162, 55);
            this.txt_AranacakIlac.Name = "txt_AranacakIlac";
            this.txt_AranacakIlac.Size = new System.Drawing.Size(176, 23);
            this.txt_AranacakIlac.TabIndex = 1;
            // 
            // dgv_hastaListele
            // 
            this.dgv_hastaListele.AllowUserToAddRows = false;
            this.dgv_hastaListele.AllowUserToDeleteRows = false;
            this.dgv_hastaListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hastaListele.Location = new System.Drawing.Point(32, 122);
            this.dgv_hastaListele.Name = "dgv_hastaListele";
            this.dgv_hastaListele.ReadOnly = true;
            this.dgv_hastaListele.RowTemplate.Height = 25;
            this.dgv_hastaListele.Size = new System.Drawing.Size(631, 159);
            this.dgv_hastaListele.TabIndex = 2;
            // 
            // btn_IlacAra
            // 
            this.btn_IlacAra.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_IlacAra.Location = new System.Drawing.Point(364, 50);
            this.btn_IlacAra.Name = "btn_IlacAra";
            this.btn_IlacAra.Size = new System.Drawing.Size(160, 31);
            this.btn_IlacAra.TabIndex = 3;
            this.btn_IlacAra.Text = "İlaç Ara";
            this.btn_IlacAra.UseVisualStyleBackColor = false;
            this.btn_IlacAra.Click += new System.EventHandler(this.btn_IlacAra_Click);
            // 
            // Frm_IlacaGoreHastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_IlacAra);
            this.Controls.Add(this.dgv_hastaListele);
            this.Controls.Add(this.txt_AranacakIlac);
            this.Controls.Add(this.label1);
            this.Name = "Frm_IlacaGoreHastalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_IlacaGoreHastalar";
            this.Load += new System.EventHandler(this.Frm_IlacaGoreHastalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hastaListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_AranacakIlac;
        private DataGridView dgv_hastaListele;
        private Button btn_IlacAra;
    }
}