namespace Method03
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
            this.cbYil = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAy = new System.Windows.Forms.ComboBox();
            this.cbGun = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGorev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbGorevListesi = new System.Windows.Forms.ListBox();
            this.btnGorevEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yıl (2000 - 2015)";
            // 
            // cbYil
            // 
            this.cbYil.FormattingEnabled = true;
            this.cbYil.Location = new System.Drawing.Point(17, 38);
            this.cbYil.Name = "cbYil";
            this.cbYil.Size = new System.Drawing.Size(168, 33);
            this.cbYil.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ay";
            // 
            // cbAy
            // 
            this.cbAy.FormattingEnabled = true;
            this.cbAy.Location = new System.Drawing.Point(210, 38);
            this.cbAy.Name = "cbAy";
            this.cbAy.Size = new System.Drawing.Size(121, 33);
            this.cbAy.TabIndex = 3;
            this.cbAy.SelectedIndexChanged += new System.EventHandler(this.cbAy_SelectedIndexChanged);
            // 
            // cbGun
            // 
            this.cbGun.FormattingEnabled = true;
            this.cbGun.Location = new System.Drawing.Point(351, 38);
            this.cbGun.Name = "cbGun";
            this.cbGun.Size = new System.Drawing.Size(121, 33);
            this.cbGun.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gün";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Görev";
            // 
            // txtGorev
            // 
            this.txtGorev.Location = new System.Drawing.Point(17, 121);
            this.txtGorev.Multiline = true;
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Size = new System.Drawing.Size(455, 122);
            this.txtGorev.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Görev Listesi";
            // 
            // lbGorevListesi
            // 
            this.lbGorevListesi.FormattingEnabled = true;
            this.lbGorevListesi.ItemHeight = 25;
            this.lbGorevListesi.Location = new System.Drawing.Point(17, 337);
            this.lbGorevListesi.Name = "lbGorevListesi";
            this.lbGorevListesi.Size = new System.Drawing.Size(455, 154);
            this.lbGorevListesi.TabIndex = 9;
            // 
            // btnGorevEkle
            // 
            this.btnGorevEkle.Location = new System.Drawing.Point(320, 249);
            this.btnGorevEkle.Name = "btnGorevEkle";
            this.btnGorevEkle.Size = new System.Drawing.Size(152, 43);
            this.btnGorevEkle.TabIndex = 10;
            this.btnGorevEkle.Text = "Görev Ekle";
            this.btnGorevEkle.UseVisualStyleBackColor = true;
            this.btnGorevEkle.Click += new System.EventHandler(this.btnGorevEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 502);
            this.Controls.Add(this.btnGorevEkle);
            this.Controls.Add(this.lbGorevListesi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGorev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbGun);
            this.Controls.Add(this.cbAy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbYil);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbYil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAy;
        private System.Windows.Forms.ComboBox cbGun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGorev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbGorevListesi;
        private System.Windows.Forms.Button btnGorevEkle;
    }
}

