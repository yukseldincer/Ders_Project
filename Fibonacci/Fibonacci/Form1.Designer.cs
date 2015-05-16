namespace Fibonacci
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudIlkEleman = new System.Windows.Forms.NumericUpDown();
            this.nudDiziUzunluk = new System.Windows.Forms.NumericUpDown();
            this.nudDiziElemanı = new System.Windows.Forms.NumericUpDown();
            this.btnGoster = new System.Windows.Forms.Button();
            this.lbDiziListesi = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudIlkEleman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiziUzunluk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiziElemanı)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlk Eleman";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dizinin Uzunluğu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dizinin Elemanını Getir";
            // 
            // nudIlkEleman
            // 
            this.nudIlkEleman.Location = new System.Drawing.Point(17, 38);
            this.nudIlkEleman.Name = "nudIlkEleman";
            this.nudIlkEleman.Size = new System.Drawing.Size(229, 32);
            this.nudIlkEleman.TabIndex = 1;
            this.nudIlkEleman.Visible = false;
            // 
            // nudDiziUzunluk
            // 
            this.nudDiziUzunluk.Location = new System.Drawing.Point(260, 38);
            this.nudDiziUzunluk.Name = "nudDiziUzunluk";
            this.nudDiziUzunluk.Size = new System.Drawing.Size(229, 32);
            this.nudDiziUzunluk.TabIndex = 1;
            // 
            // nudDiziElemanı
            // 
            this.nudDiziElemanı.Location = new System.Drawing.Point(17, 198);
            this.nudDiziElemanı.Name = "nudDiziElemanı";
            this.nudDiziElemanı.Size = new System.Drawing.Size(229, 32);
            this.nudDiziElemanı.TabIndex = 1;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(260, 172);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(214, 58);
            this.btnGoster.TabIndex = 2;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // lbDiziListesi
            // 
            this.lbDiziListesi.FormattingEnabled = true;
            this.lbDiziListesi.ItemHeight = 25;
            this.lbDiziListesi.Location = new System.Drawing.Point(17, 267);
            this.lbDiziListesi.Name = "lbDiziListesi";
            this.lbDiziListesi.Size = new System.Drawing.Size(472, 204);
            this.lbDiziListesi.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 502);
            this.Controls.Add(this.lbDiziListesi);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.nudDiziUzunluk);
            this.Controls.Add(this.nudDiziElemanı);
            this.Controls.Add(this.nudIlkEleman);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudIlkEleman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiziUzunluk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiziElemanı)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudIlkEleman;
        private System.Windows.Forms.NumericUpDown nudDiziUzunluk;
        private System.Windows.Forms.NumericUpDown nudDiziElemanı;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.ListBox lbDiziListesi;
    }
}

