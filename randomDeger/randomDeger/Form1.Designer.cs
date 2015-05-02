namespace randomDeger
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIlk = new System.Windows.Forms.Button();
            this.btnSon = new System.Windows.Forms.Button();
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.lbUceBolunen = new System.Windows.Forms.ListBox();
            this.btn3Bol = new System.Windows.Forms.Button();
            this.btn3BolBuyuk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(30, 27);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(112, 33);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIlk
            // 
            this.btnIlk.Location = new System.Drawing.Point(30, 66);
            this.btnIlk.Name = "btnIlk";
            this.btnIlk.Size = new System.Drawing.Size(112, 33);
            this.btnIlk.TabIndex = 1;
            this.btnIlk.Text = "İlk Değer";
            this.btnIlk.UseVisualStyleBackColor = true;
            this.btnIlk.Click += new System.EventHandler(this.btnIlk_Click);
            // 
            // btnSon
            // 
            this.btnSon.Location = new System.Drawing.Point(30, 105);
            this.btnSon.Name = "btnSon";
            this.btnSon.Size = new System.Drawing.Size(112, 31);
            this.btnSon.TabIndex = 2;
            this.btnSon.Text = "Son Değer";
            this.btnSon.UseVisualStyleBackColor = true;
            this.btnSon.Click += new System.EventHandler(this.btnSon_Click);
            // 
            // lbSayilar
            // 
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.Location = new System.Drawing.Point(337, 12);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(74, 368);
            this.lbSayilar.TabIndex = 3;
            // 
            // lbUceBolunen
            // 
            this.lbUceBolunen.FormattingEnabled = true;
            this.lbUceBolunen.Location = new System.Drawing.Point(248, 12);
            this.lbUceBolunen.Name = "lbUceBolunen";
            this.lbUceBolunen.Size = new System.Drawing.Size(83, 368);
            this.lbUceBolunen.TabIndex = 4;
            // 
            // btn3Bol
            // 
            this.btn3Bol.Location = new System.Drawing.Point(30, 151);
            this.btn3Bol.Name = "btn3Bol";
            this.btn3Bol.Size = new System.Drawing.Size(112, 38);
            this.btn3Bol.TabIndex = 5;
            this.btn3Bol.Text = "3 e Bölnenler";
            this.btn3Bol.UseVisualStyleBackColor = true;
            this.btn3Bol.Click += new System.EventHandler(this.btn3Bol_Click);
            // 
            // btn3BolBuyuk
            // 
            this.btn3BolBuyuk.Location = new System.Drawing.Point(30, 196);
            this.btn3BolBuyuk.Name = "btn3BolBuyuk";
            this.btn3BolBuyuk.Size = new System.Drawing.Size(112, 36);
            this.btn3BolBuyuk.TabIndex = 6;
            this.btn3BolBuyuk.Text = "3 e Bölünenlerin En Büyüğü";
            this.btn3BolBuyuk.UseVisualStyleBackColor = true;
            this.btn3BolBuyuk.Click += new System.EventHandler(this.btn3BolBuyuk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 385);
            this.Controls.Add(this.btn3BolBuyuk);
            this.Controls.Add(this.btn3Bol);
            this.Controls.Add(this.lbUceBolunen);
            this.Controls.Add(this.lbSayilar);
            this.Controls.Add(this.btnSon);
            this.Controls.Add(this.btnIlk);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIlk;
        private System.Windows.Forms.Button btnSon;
        private System.Windows.Forms.ListBox lbSayilar;
        private System.Windows.Forms.ListBox lbUceBolunen;
        private System.Windows.Forms.Button btn3Bol;
        private System.Windows.Forms.Button btn3BolBuyuk;
    }
}

