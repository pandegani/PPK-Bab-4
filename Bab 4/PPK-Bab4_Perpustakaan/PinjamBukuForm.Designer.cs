﻿namespace PPK_Bab4_Perpustakaan
{
    partial class PinjamBukuForm
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
            this.textBoxIdBuku = new System.Windows.Forms.TextBox();
            this.comboBoxListPeminjam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmitPinjam = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Buku";
            // 
            // textBoxIdBuku
            // 
            this.textBoxIdBuku.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIdBuku.Location = new System.Drawing.Point(120, 72);
            this.textBoxIdBuku.Name = "textBoxIdBuku";
            this.textBoxIdBuku.Size = new System.Drawing.Size(121, 20);
            this.textBoxIdBuku.TabIndex = 1;
            // 
            // comboBoxListPeminjam
            // 
            this.comboBoxListPeminjam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxListPeminjam.FormattingEnabled = true;
            this.comboBoxListPeminjam.Location = new System.Drawing.Point(120, 128);
            this.comboBoxListPeminjam.Name = "comboBoxListPeminjam";
            this.comboBoxListPeminjam.Size = new System.Drawing.Size(121, 21);
            this.comboBoxListPeminjam.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Peminjam";
            // 
            // btnSubmitPinjam
            // 
            this.btnSubmitPinjam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSubmitPinjam.Location = new System.Drawing.Point(304, 72);
            this.btnSubmitPinjam.Name = "btnSubmitPinjam";
            this.btnSubmitPinjam.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitPinjam.TabIndex = 4;
            this.btnSubmitPinjam.Text = "OK";
            this.btnSubmitPinjam.UseVisualStyleBackColor = true;
            this.btnSubmitPinjam.Click += new System.EventHandler(this.btnSubmitPinjam_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Form Pinjam Buku";
            // 
            // PinjamBukuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 214);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmitPinjam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxListPeminjam);
            this.Controls.Add(this.textBoxIdBuku);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PinjamBukuForm";
            this.Text = "PinjamBukuForm";
            this.Load += new System.EventHandler(this.PinjamBukuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdBuku;
        private System.Windows.Forms.ComboBox comboBoxListPeminjam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmitPinjam;
        private System.Windows.Forms.Label label3;
    }
}