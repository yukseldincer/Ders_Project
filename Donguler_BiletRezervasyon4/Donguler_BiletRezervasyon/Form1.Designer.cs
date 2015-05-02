namespace Donguler_BiletRezervasyon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKoltukYukseklik = new System.Windows.Forms.TextBox();
            this.txtKoltukGenislik = new System.Windows.Forms.TextBox();
            this.btnKoltuklariYarat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gbKoltuklar
            // 
            this.gbKoltuklar.Location = new System.Drawing.Point(12, 68);
            this.gbKoltuklar.Name = "gbKoltuklar";
            this.gbKoltuklar.Size = new System.Drawing.Size(300, 570);
            this.gbKoltuklar.TabIndex = 0;
            this.gbKoltuklar.TabStop = false;
            this.gbKoltuklar.Text = "Koltuklar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Koltukların Genişliği";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Koltukların Yüksekliği";
            // 
            // txtKoltukYukseklik
            // 
            this.txtKoltukYukseklik.Location = new System.Drawing.Point(234, 42);
            this.txtKoltukYukseklik.Name = "txtKoltukYukseklik";
            this.txtKoltukYukseklik.Size = new System.Drawing.Size(100, 32);
            this.txtKoltukYukseklik.TabIndex = 3;
            this.txtKoltukYukseklik.Text = "9";
            // 
            // txtKoltukGenislik
            // 
            this.txtKoltukGenislik.Location = new System.Drawing.Point(234, 6);
            this.txtKoltukGenislik.Name = "txtKoltukGenislik";
            this.txtKoltukGenislik.Size = new System.Drawing.Size(100, 32);
            this.txtKoltukGenislik.TabIndex = 4;
            this.txtKoltukGenislik.Text = "4";
            // 
            // btnKoltuklariYarat
            // 
            this.btnKoltuklariYarat.Location = new System.Drawing.Point(340, 6);
            this.btnKoltuklariYarat.Name = "btnKoltuklariYarat";
            this.btnKoltuklariYarat.Size = new System.Drawing.Size(117, 68);
            this.btnKoltuklariYarat.TabIndex = 5;
            this.btnKoltuklariYarat.Text = "Koltuklari Yarat";
            this.btnKoltuklariYarat.UseVisualStyleBackColor = true;
            this.btnKoltuklariYarat.Click += new System.EventHandler(this.btnKoltuklariYarat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 650);
            this.Controls.Add(this.btnKoltuklariYarat);
            this.Controls.Add(this.txtKoltukGenislik);
            this.Controls.Add(this.txtKoltukYukseklik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbKoltuklar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Bilet Rezervasyon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKoltuklar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKoltukYukseklik;
        private System.Windows.Forms.TextBox txtKoltukGenislik;
        private System.Windows.Forms.Button btnKoltuklariYarat;
    }
}

