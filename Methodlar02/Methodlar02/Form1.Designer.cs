namespace Methodlar02
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
            this.cbTasitCinsi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTasit = new System.Windows.Forms.ListBox();
            this.rbDizel = new System.Windows.Forms.RadioButton();
            this.rbBenzin = new System.Windows.Forms.RadioButton();
            this.rbLpg = new System.Windows.Forms.RadioButton();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taşıt Cinsi";
            // 
            // cbTasitCinsi
            // 
            this.cbTasitCinsi.FormattingEnabled = true;
            this.cbTasitCinsi.Location = new System.Drawing.Point(12, 36);
            this.cbTasitCinsi.Name = "cbTasitCinsi";
            this.cbTasitCinsi.Size = new System.Drawing.Size(225, 21);
            this.cbTasitCinsi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Taşıtlar";
            // 
            // lbTasit
            // 
            this.lbTasit.FormattingEnabled = true;
            this.lbTasit.Location = new System.Drawing.Point(12, 200);
            this.lbTasit.Name = "lbTasit";
            this.lbTasit.Size = new System.Drawing.Size(225, 147);
            this.lbTasit.TabIndex = 3;
            // 
            // rbDizel
            // 
            this.rbDizel.AutoSize = true;
            this.rbDizel.Location = new System.Drawing.Point(12, 91);
            this.rbDizel.Name = "rbDizel";
            this.rbDizel.Size = new System.Drawing.Size(48, 17);
            this.rbDizel.TabIndex = 4;
            this.rbDizel.TabStop = true;
            this.rbDizel.Text = "Dizel";
            this.rbDizel.UseVisualStyleBackColor = true;
            // 
            // rbBenzin
            // 
            this.rbBenzin.AutoSize = true;
            this.rbBenzin.Location = new System.Drawing.Point(66, 91);
            this.rbBenzin.Name = "rbBenzin";
            this.rbBenzin.Size = new System.Drawing.Size(57, 17);
            this.rbBenzin.TabIndex = 5;
            this.rbBenzin.TabStop = true;
            this.rbBenzin.Text = "Benzin";
            this.rbBenzin.UseVisualStyleBackColor = true;
            // 
            // rbLpg
            // 
            this.rbLpg.AutoSize = true;
            this.rbLpg.Location = new System.Drawing.Point(129, 91);
            this.rbLpg.Name = "rbLpg";
            this.rbLpg.Size = new System.Drawing.Size(46, 17);
            this.rbLpg.TabIndex = 6;
            this.rbLpg.TabStop = true;
            this.rbLpg.Text = "LPG";
            this.rbLpg.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(12, 353);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(225, 49);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Marka";
            // 
            // cbMarka
            // 
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(12, 144);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(225, 21);
            this.cbMarka.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yakıt Tipi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 414);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.rbLpg);
            this.Controls.Add(this.rbBenzin);
            this.Controls.Add(this.rbDizel);
            this.Controls.Add(this.lbTasit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMarka);
            this.Controls.Add(this.cbTasitCinsi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTasitCinsi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbTasit;
        private System.Windows.Forms.RadioButton rbDizel;
        private System.Windows.Forms.RadioButton rbBenzin;
        private System.Windows.Forms.RadioButton rbLpg;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.Label label4;
    }
}

