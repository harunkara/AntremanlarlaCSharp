namespace formHesapMakinesi
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
            this.txtSayı1 = new System.Windows.Forms.TextBox();
            this.txtSayı2 = new System.Windows.Forms.TextBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.labelSayı1 = new System.Windows.Forms.Label();
            this.labelSayı2 = new System.Windows.Forms.Label();
            this.labelSonuc = new System.Windows.Forms.Label();
            this.btnToplama = new System.Windows.Forms.Button();
            this.btnCıkarma = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btnBolme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayı1
            // 
            this.txtSayı1.Location = new System.Drawing.Point(209, 12);
            this.txtSayı1.Name = "txtSayı1";
            this.txtSayı1.Size = new System.Drawing.Size(100, 20);
            this.txtSayı1.TabIndex = 0;
            // 
            // txtSayı2
            // 
            this.txtSayı2.Location = new System.Drawing.Point(209, 51);
            this.txtSayı2.Name = "txtSayı2";
            this.txtSayı2.Size = new System.Drawing.Size(100, 20);
            this.txtSayı2.TabIndex = 1;
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(209, 97);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(100, 20);
            this.txtSonuc.TabIndex = 2;
            // 
            // labelSayı1
            // 
            this.labelSayı1.AutoSize = true;
            this.labelSayı1.Location = new System.Drawing.Point(103, 19);
            this.labelSayı1.Name = "labelSayı1";
            this.labelSayı1.Size = new System.Drawing.Size(34, 13);
            this.labelSayı1.TabIndex = 3;
            this.labelSayı1.Text = "1.sayı";
            // 
            // labelSayı2
            // 
            this.labelSayı2.AutoSize = true;
            this.labelSayı2.Location = new System.Drawing.Point(103, 58);
            this.labelSayı2.Name = "labelSayı2";
            this.labelSayı2.Size = new System.Drawing.Size(34, 13);
            this.labelSayı2.TabIndex = 4;
            this.labelSayı2.Text = "2.sayı";
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.Location = new System.Drawing.Point(103, 104);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(36, 13);
            this.labelSonuc.TabIndex = 5;
            this.labelSonuc.Text = "sonuc";
            // 
            // btnToplama
            // 
            this.btnToplama.Location = new System.Drawing.Point(379, 9);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(75, 23);
            this.btnToplama.TabIndex = 6;
            this.btnToplama.Text = "+";
            this.btnToplama.UseVisualStyleBackColor = true;
            this.btnToplama.Click += new System.EventHandler(this.btnToplama_Click);
            // 
            // btnCıkarma
            // 
            this.btnCıkarma.Location = new System.Drawing.Point(379, 38);
            this.btnCıkarma.Name = "btnCıkarma";
            this.btnCıkarma.Size = new System.Drawing.Size(75, 23);
            this.btnCıkarma.TabIndex = 7;
            this.btnCıkarma.Text = "-";
            this.btnCıkarma.UseVisualStyleBackColor = true;
            this.btnCıkarma.Click += new System.EventHandler(this.btnCıkarma_Click);
            // 
            // btnCarpma
            // 
            this.btnCarpma.Location = new System.Drawing.Point(379, 67);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(75, 23);
            this.btnCarpma.TabIndex = 8;
            this.btnCarpma.Text = "*";
            this.btnCarpma.UseVisualStyleBackColor = true;
            this.btnCarpma.Click += new System.EventHandler(this.btnCarpma_Click);
            // 
            // btnBolme
            // 
            this.btnBolme.Location = new System.Drawing.Point(379, 94);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(75, 23);
            this.btnBolme.TabIndex = 9;
            this.btnBolme.Text = "/";
            this.btnBolme.UseVisualStyleBackColor = true;
            this.btnBolme.Click += new System.EventHandler(this.btnBolme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBolme);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btnCıkarma);
            this.Controls.Add(this.btnToplama);
            this.Controls.Add(this.labelSonuc);
            this.Controls.Add(this.labelSayı2);
            this.Controls.Add(this.labelSayı1);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.txtSayı2);
            this.Controls.Add(this.txtSayı1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayı1;
        private System.Windows.Forms.TextBox txtSayı2;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label labelSayı1;
        private System.Windows.Forms.Label labelSayı2;
        private System.Windows.Forms.Label labelSonuc;
        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.Button btnCıkarma;
        private System.Windows.Forms.Button btnCarpma;
        private System.Windows.Forms.Button btnBolme;
    }
}

