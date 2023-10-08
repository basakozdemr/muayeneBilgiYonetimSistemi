namespace Mbys
{
    partial class Frm_Recete_goster
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
            this.dgv_Receteler = new System.Windows.Forms.DataGridView();
            this.btn_azalan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Receteler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(323, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "REÇETELER";
            // 
            // dgv_Receteler
            // 
            this.dgv_Receteler.AllowUserToAddRows = false;
            this.dgv_Receteler.AllowUserToDeleteRows = false;
            this.dgv_Receteler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Receteler.Location = new System.Drawing.Point(64, 132);
            this.dgv_Receteler.Name = "dgv_Receteler";
            this.dgv_Receteler.ReadOnly = true;
            this.dgv_Receteler.RowTemplate.Height = 25;
            this.dgv_Receteler.Size = new System.Drawing.Size(672, 248);
            this.dgv_Receteler.TabIndex = 2;
            // 
            // btn_azalan
            // 
            this.btn_azalan.Location = new System.Drawing.Point(454, 88);
            this.btn_azalan.Name = "btn_azalan";
            this.btn_azalan.Size = new System.Drawing.Size(138, 37);
            this.btn_azalan.TabIndex = 4;
            this.btn_azalan.Text = "Önce Yeni";
            this.btn_azalan.UseVisualStyleBackColor = true;
            this.btn_azalan.Click += new System.EventHandler(this.btn_azalan_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(598, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Önce Eski";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_Recete_goster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_azalan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Receteler);
            this.Name = "Frm_Recete_goster";
            this.Text = "Frm_Recete_goster";
            this.Load += new System.EventHandler(this.Frm_Recete_goster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Receteler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgv_Receteler;
        private Button btn_azalan;
        private Button button2;
    }
}