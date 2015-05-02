namespace Arrayler02
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
            this.btnSehirler = new System.Windows.Forms.Button();
            this.btnIlk = new System.Windows.Forms.Button();
            this.btnIki = new System.Windows.Forms.Button();
            this.btnSirala = new System.Windows.Forms.Button();
            this.btnTersSirala = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSehirler
            // 
            this.btnSehirler.Location = new System.Drawing.Point(91, 31);
            this.btnSehirler.Name = "btnSehirler";
            this.btnSehirler.Size = new System.Drawing.Size(108, 32);
            this.btnSehirler.TabIndex = 0;
            this.btnSehirler.Text = "Şehirleri Göster";
            this.btnSehirler.UseVisualStyleBackColor = true;
            this.btnSehirler.Click += new System.EventHandler(this.btnSehirler_Click);
            // 
            // btnIlk
            // 
            this.btnIlk.Location = new System.Drawing.Point(91, 69);
            this.btnIlk.Name = "btnIlk";
            this.btnIlk.Size = new System.Drawing.Size(108, 33);
            this.btnIlk.TabIndex = 1;
            this.btnIlk.Text = "İlk Değer";
            this.btnIlk.UseVisualStyleBackColor = true;
            this.btnIlk.Click += new System.EventHandler(this.btnIlk_Click);
            // 
            // btnIki
            // 
            this.btnIki.Location = new System.Drawing.Point(91, 108);
            this.btnIki.Name = "btnIki";
            this.btnIki.Size = new System.Drawing.Size(108, 33);
            this.btnIki.TabIndex = 1;
            this.btnIki.Text = "Son Değer";
            this.btnIki.UseVisualStyleBackColor = true;
            this.btnIki.Click += new System.EventHandler(this.btnIki_Click);
            // 
            // btnSirala
            // 
            this.btnSirala.Location = new System.Drawing.Point(91, 148);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(108, 37);
            this.btnSirala.TabIndex = 2;
            this.btnSirala.Text = "Sırala";
            this.btnSirala.UseVisualStyleBackColor = true;
            this.btnSirala.Click += new System.EventHandler(this.btnSirala_Click);
            // 
            // btnTersSirala
            // 
            this.btnTersSirala.Location = new System.Drawing.Point(91, 191);
            this.btnTersSirala.Name = "btnTersSirala";
            this.btnTersSirala.Size = new System.Drawing.Size(108, 37);
            this.btnTersSirala.TabIndex = 2;
            this.btnTersSirala.Text = "Sırala";
            this.btnTersSirala.UseVisualStyleBackColor = true;
            this.btnTersSirala.Click += new System.EventHandler(this.btnTersSirala_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnTersSirala);
            this.Controls.Add(this.btnSirala);
            this.Controls.Add(this.btnIki);
            this.Controls.Add(this.btnIlk);
            this.Controls.Add(this.btnSehirler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSehirler;
        private System.Windows.Forms.Button btnIlk;
        private System.Windows.Forms.Button btnIki;
        private System.Windows.Forms.Button btnSirala;
        private System.Windows.Forms.Button btnTersSirala;
    }
}

