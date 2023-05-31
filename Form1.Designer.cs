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
            this.cozbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Dosyabutton
            // 
            this.Dosyabutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Dosyabutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dosyabutton.Location = new System.Drawing.Point(31, 26);
            this.Dosyabutton.Name = "Dosyabutton";
            this.Dosyabutton.Size = new System.Drawing.Size(167, 51);
            this.Dosyabutton.TabIndex = 0;
            this.Dosyabutton.Text = "Dosya Seç";
            this.Dosyabutton.UseVisualStyleBackColor = false;
            this.Dosyabutton.Click += new System.EventHandler(this.Dosyabutton_Click);
            // 
            // Sifrebutton
            // 
            this.Sifrebutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Sifrebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sifrebutton.Location = new System.Drawing.Point(31, 182);
            this.Sifrebutton.Name = "Sifrebutton";
            this.Sifrebutton.Size = new System.Drawing.Size(167, 48);
            this.Sifrebutton.TabIndex = 1;
            this.Sifrebutton.Text = "Şifreleme";
            this.Sifrebutton.UseVisualStyleBackColor = false;
            this.Sifrebutton.Click += new System.EventHandler(this.Sifrebutton_Click);
            // 
            // cozbutton
            // 
            this.cozbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cozbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cozbutton.Location = new System.Drawing.Point(31, 256);
            this.cozbutton.Name = "cozbutton";
            this.cozbutton.Size = new System.Drawing.Size(167, 48);
            this.cozbutton.TabIndex = 2;
            this.cozbutton.Text = "Çöz";
            this.cozbutton.UseVisualStyleBackColor = false;
            this.cozbutton.Click += new System.EventHandler(this.cozbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dosya Uzantısı:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 117);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 38);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(474, 369);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cozbutton);
            this.Controls.Add(this.Sifrebutton);
            this.Controls.Add(this.Dosyabutton);
            this.Name = "Form1";
            this.Text = "Dosya Şifreleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Dosyabutton;
        private Button Sifrebutton;
        private Button cozbutton;
        private Label label1;
        private TextBox textBox1;
    }
}