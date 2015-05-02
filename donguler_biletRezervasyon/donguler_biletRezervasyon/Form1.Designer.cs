namespace donguler_biletRezervasyon
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
            this.gbKoltuklar = new System.Windows.Forms.GroupBox();
            this.txtKoltukGenislik = new System.Windows.Forms.TextBox();
            this.txtKoltukYukseklik = new System.Windows.Forms.TextBox();
            this.btnUret = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gbKoltuklar
            // 
            this.gbKoltuklar.Location = new System.Drawing.Point(12, 51);
            this.gbKoltuklar.Name = "gbKoltuklar";
            this.gbKoltuklar.Size = new System.Drawing.Size(334, 575);
            this.gbKoltuklar.TabIndex = 0;
            this.gbKoltuklar.TabStop = false;
            this.gbKoltuklar.Text = "Koltuklar";
            // 
            // txtKoltukGenislik
            // 
            this.txtKoltukGenislik.Location = new System.Drawing.Point(34, 25);
            this.txtKoltukGenislik.Name = "txtKoltukGenislik";
            this.txtKoltukGenislik.Size = new System.Drawing.Size(100, 20);
            this.txtKoltukGenislik.TabIndex = 1;
            // 
            // txtKoltukYukseklik
            // 
            this.txtKoltukYukseklik.Location = new System.Drawing.Point(140, 25);
            this.txtKoltukYukseklik.Name = "txtKoltukYukseklik";
            this.txtKoltukYukseklik.Size = new System.Drawing.Size(100, 20);
            this.txtKoltukYukseklik.TabIndex = 2;
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(256, 24);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(75, 20);
            this.btnUret.TabIndex = 3;
            this.btnUret.Text = "Koltuk Üret";
            this.btnUret.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Koltuk Genişliği";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Koltuk Yüksekliği";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 638);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.txtKoltukYukseklik);
            this.Controls.Add(this.txtKoltukGenislik);
            this.Controls.Add(this.gbKoltuklar);
            this.Name = "Form1";
            this.Text = "Bilet Rezervasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKoltuklar;
        private System.Windows.Forms.TextBox txtKoltukGenislik;
        private System.Windows.Forms.TextBox txtKoltukYukseklik;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

