﻿namespace Metotlar2
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
            this.cbYıl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGun = new System.Windows.Forms.ComboBox();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yıl (2000-2015)";
            // 
            // cbYıl
            // 
            this.cbYıl.FormattingEnabled = true;
            this.cbYıl.Location = new System.Drawing.Point(12, 33);
            this.cbYıl.Name = "cbYıl";
            this.cbYıl.Size = new System.Drawing.Size(121, 21);
            this.cbYıl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(144, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aylar";
            // 
            // cbAy
            // 
            this.cbAy.FormattingEnabled = true;
            this.cbAy.Location = new System.Drawing.Point(144, 33);
            this.cbAy.Name = "cbAy";
            this.cbAy.Size = new System.Drawing.Size(93, 21);
            this.cbAy.TabIndex = 1;
            this.cbAy.SelectedIndexChanged += new System.EventHandler(this.cbAy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(248, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Günler";
            // 
            // cbGun
            // 
            this.cbGun.FormattingEnabled = true;
            this.cbGun.Location = new System.Drawing.Point(248, 33);
            this.cbGun.Name = "cbGun";
            this.cbGun.Size = new System.Drawing.Size(51, 21);
            this.cbGun.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Görev";
            // 
            // txtGorev
            // 
            this.txtGorev.Location = new System.Drawing.Point(12, 86);
            this.txtGorev.Multiline = true;
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Size = new System.Drawing.Size(287, 125);
            this.txtGorev.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Görev Listesi";
            // 
            // lbGorevListesi
            // 
            this.lbGorevListesi.FormattingEnabled = true;
            this.lbGorevListesi.Location = new System.Drawing.Point(12, 276);
            this.lbGorevListesi.Name = "lbGorevListesi";
            this.lbGorevListesi.Size = new System.Drawing.Size(287, 199);
            this.lbGorevListesi.TabIndex = 3;
            // 
            // btnGorevEkle
            // 
            this.btnGorevEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGorevEkle.Location = new System.Drawing.Point(12, 218);
            this.btnGorevEkle.Name = "btnGorevEkle";
            this.btnGorevEkle.Size = new System.Drawing.Size(121, 34);
            this.btnGorevEkle.TabIndex = 4;
            this.btnGorevEkle.Text = "Ekle";
            this.btnGorevEkle.UseVisualStyleBackColor = true;
            this.btnGorevEkle.Click += new System.EventHandler(this.btnGorevEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 487);
            this.Controls.Add(this.btnGorevEkle);
            this.Controls.Add(this.lbGorevListesi);
            this.Controls.Add(this.txtGorev);
            this.Controls.Add(this.cbGun);
            this.Controls.Add(this.cbAy);
            this.Controls.Add(this.cbYıl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbYıl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGorev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbGorevListesi;
        private System.Windows.Forms.Button btnGorevEkle;
    }
}

