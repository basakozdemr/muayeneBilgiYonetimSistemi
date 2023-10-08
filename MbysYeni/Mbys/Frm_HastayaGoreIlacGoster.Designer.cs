namespace Mbys
{
    partial class Frm_HastayaGoreIlacGoster
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
            this.btn_IlacAra = new System.Windows.Forms.Button();
            this.dgv_ilacListele = new System.Windows.Forms.DataGridView();
            this.txt_AranacakTcNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ilacListele)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_IlacAra
            // 
            this.btn_IlacAra.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_IlacAra.Location = new System.Drawing.Point(472, 36);
            this.btn_IlacAra.Name = "btn_IlacAra";
            this.btn_IlacAra.Size = new System.Drawing.Size(160, 23);
            this.btn_IlacAra.TabIndex = 7;
            this.btn_IlacAra.Text = "İlaç Ara";
            this.btn_IlacAra.UseVisualStyleBackColor = false;
            this.btn_IlacAra.Click += new System.EventHandler(this.btn_IlacAra_Click);
            // 
            // dgv_ilacListele
            // 
            this.dgv_ilacListele.AllowUserToAddRows = false;
            this.dgv_ilacListele.AllowUserToDeleteRows = false;
            this.dgv_ilacListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ilacListele.Location = new System.Drawing.Point(47, 104);
            this.dgv_ilacListele.Name = "dgv_ilacListele";
            this.dgv_ilacListele.ReadOnly = true;
            this.dgv_ilacListele.RowTemplate.Height = 25;
            this.dgv_ilacListele.Size = new System.Drawing.Size(631, 265);
            this.dgv_ilacListele.TabIndex = 6;
            // 
            // txt_AranacakTcNo
            // 
            this.txt_AranacakTcNo.Location = new System.Drawing.Point(306, 36);
            this.txt_AranacakTcNo.Name = "txt_AranacakTcNo";
            this.txt_AranacakTcNo.Size = new System.Drawing.Size(145, 23);
            this.txt_AranacakTcNo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "İlaç Bilgisi Gösterilecek Hastanın Tc Numarası";
            // 
            // Frm_HastayaGoreIlacGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_IlacAra);
            this.Controls.Add(this.dgv_ilacListele);
            this.Controls.Add(this.txt_AranacakTcNo);
            this.Controls.Add(this.label1);
            this.Name = "Frm_HastayaGoreIlacGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_HastayaGoreIlacGoster";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ilacListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_IlacAra;
        private DataGridView dgv_ilacListele;
        private TextBox txt_AranacakTcNo;
        private Label label1;
    }
}