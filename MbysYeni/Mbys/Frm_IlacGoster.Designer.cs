﻿namespace Mbys
{
    partial class Frm_IlacGoster
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
            this.dgv_Ilaclar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ilaclar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(281, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "KAYITLI iLAÇLAR";
            // 
            // dgv_Ilaclar
            // 
            this.dgv_Ilaclar.AllowUserToAddRows = false;
            this.dgv_Ilaclar.AllowUserToDeleteRows = false;
            this.dgv_Ilaclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ilaclar.Location = new System.Drawing.Point(64, 132);
            this.dgv_Ilaclar.Name = "dgv_Ilaclar";
            this.dgv_Ilaclar.ReadOnly = true;
            this.dgv_Ilaclar.RowTemplate.Height = 25;
            this.dgv_Ilaclar.Size = new System.Drawing.Size(672, 248);
            this.dgv_Ilaclar.TabIndex = 2;
            // 
            // Frm_IlacGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Ilaclar);
            this.Name = "Frm_IlacGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_IlacGoster";
            this.Load += new System.EventHandler(this.Frm_IlacGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ilaclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgv_Ilaclar;
    }
}