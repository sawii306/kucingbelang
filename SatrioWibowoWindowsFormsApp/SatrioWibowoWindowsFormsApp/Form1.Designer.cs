namespace ZaidHanifWindowsFormsApp
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hitung = new System.Windows.Forms.Button();
            this.hasilteks = new System.Windows.Forms.TextBox();
            this.operator1 = new System.Windows.Forms.ComboBox();
            this.angka2 = new System.Windows.Forms.TextBox();
            this.angka1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hasil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nilai B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nilai A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Operasi";
            // 
            // hitung
            // 
            this.hitung.Location = new System.Drawing.Point(205, 109);
            this.hitung.Name = "hitung";
            this.hitung.Size = new System.Drawing.Size(75, 41);
            this.hitung.TabIndex = 13;
            this.hitung.Text = "Hitung";
            this.hitung.UseVisualStyleBackColor = true;
            this.hitung.Click += new System.EventHandler(this.hitung_Click);
            // 
            // hasilteks
            // 
            this.hasilteks.Location = new System.Drawing.Point(58, 130);
            this.hasilteks.Name = "hasilteks";
            this.hasilteks.Size = new System.Drawing.Size(121, 20);
            this.hasilteks.TabIndex = 12;
            // 
            // operator1
            // 
            this.operator1.FormattingEnabled = true;
            this.operator1.Items.AddRange(new object[] {
            "PENJUMLAHAN {+}",
            "PENGURANGAN {-}",
            "PERKALIAN {*}",
            "PEMBAGIAN{/}"});
            this.operator1.Location = new System.Drawing.Point(58, 12);
            this.operator1.Name = "operator1";
            this.operator1.Size = new System.Drawing.Size(121, 21);
            this.operator1.TabIndex = 11;
            // 
            // angka2
            // 
            this.angka2.Location = new System.Drawing.Point(58, 94);
            this.angka2.Name = "angka2";
            this.angka2.Size = new System.Drawing.Size(121, 20);
            this.angka2.TabIndex = 10;
            // 
            // angka1
            // 
            this.angka1.Location = new System.Drawing.Point(58, 54);
            this.angka1.Name = "angka1";
            this.angka1.Size = new System.Drawing.Size(121, 20);
            this.angka1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hitung);
            this.Controls.Add(this.hasilteks);
            this.Controls.Add(this.operator1);
            this.Controls.Add(this.angka2);
            this.Controls.Add(this.angka1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hitung;
        private System.Windows.Forms.TextBox hasilteks;
        private System.Windows.Forms.ComboBox operator1;
        private System.Windows.Forms.TextBox angka2;
        private System.Windows.Forms.TextBox angka1;
    }
}

