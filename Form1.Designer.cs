namespace DosyaOrganizasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dosyabutton = new System.Windows.Forms.Button();
            this.Sifrebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Dosyabutton
            // 
            this.Dosyabutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Dosyabutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dosyabutton.Location = new System.Drawing.Point(874, 63);
            this.Dosyabutton.Name = "Dosyabutton";
            this.Dosyabutton.Size = new System.Drawing.Size(188, 51);
            this.Dosyabutton.TabIndex = 0;
            this.Dosyabutton.Text = "Dosya Seç";
            this.Dosyabutton.UseVisualStyleBackColor = false;
            this.Dosyabutton.Click += new System.EventHandler(this.Dosyabutton_Click);
            // 
            // Sifrebutton
            // 
            this.Sifrebutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Sifrebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sifrebutton.Location = new System.Drawing.Point(393, 468);
            this.Sifrebutton.Name = "Sifrebutton";
            this.Sifrebutton.Size = new System.Drawing.Size(270, 50);
            this.Sifrebutton.TabIndex = 1;
            this.Sifrebutton.Text = "Şifreleme";
            this.Sifrebutton.UseVisualStyleBackColor = false;
            this.Sifrebutton.Click += new System.EventHandler(this.Sifrebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dosya Uzantısı:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(727, 51);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 173);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(444, 265);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(588, 173);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(402, 265);
            this.textBox3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1110, 542);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sifrebutton);
            this.Controls.Add(this.Dosyabutton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Dosya Şifreleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Dosyabutton;
        private Button Sifrebutton;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}