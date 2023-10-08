namespace Mbys
{
    partial class Frm_HastaGoster
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
            this.dgv_KayitliHastalar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KayitliHastalar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_KayitliHastalar
            // 
            this.dgv_KayitliHastalar.AllowUserToAddRows = false;
            this.dgv_KayitliHastalar.AllowUserToDeleteRows = false;
            this.dgv_KayitliHastalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KayitliHastalar.Location = new System.Drawing.Point(50, 106);
            this.dgv_KayitliHastalar.Name = "dgv_KayitliHastalar";
            this.dgv_KayitliHastalar.ReadOnly = true;
            this.dgv_KayitliHastalar.RowTemplate.Height = 25;
            this.dgv_KayitliHastalar.Size = new System.Drawing.Size(672, 248);
            this.dgv_KayitliHastalar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(267, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "KAYITLI HASTALAR";
            // 
            // Frm_HastaGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_KayitliHastalar);
            this.Name = "Frm_HastaGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_HastaGoster";
            this.Load += new System.EventHandler(this.Frm_HastaGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KayitliHastalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_KayitliHastalar;
        private Label label1;
    }
}