namespace atYarisi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.kahveAt = new System.Windows.Forms.Button();
            this.beyazAt = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdnKahve = new System.Windows.Forms.RadioButton();
            this.rdnBeyaz = new System.Windows.Forms.RadioButton();
            this.cmbMisli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1020, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 397);
            this.label1.TabIndex = 0;
            this.label1.Text = "FINISH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kahveAt
            // 
            this.kahveAt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("kahveAt.BackgroundImage")));
            this.kahveAt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kahveAt.Location = new System.Drawing.Point(0, 100);
            this.kahveAt.Name = "kahveAt";
            this.kahveAt.Size = new System.Drawing.Size(80, 60);
            this.kahveAt.TabIndex = 1;
            this.kahveAt.UseVisualStyleBackColor = true;
            // 
            // beyazAt
            // 
            this.beyazAt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("beyazAt.BackgroundImage")));
            this.beyazAt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.beyazAt.Location = new System.Drawing.Point(0, 176);
            this.beyazAt.Name = "beyazAt";
            this.beyazAt.Size = new System.Drawing.Size(80, 60);
            this.beyazAt.TabIndex = 2;
            this.beyazAt.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Başla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(461, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "VELİ EFENDİ HİPODROMU";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1020, 10);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1019, 10);
            this.label4.TabIndex = 5;
            this.label4.Text = "label3";
            // 
            // label5
            // 
            this.label5.AllowDrop = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1021, 10);
            this.label5.TabIndex = 5;
            this.label5.Text = "label3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Seçilen At";
            // 
            // rdnKahve
            // 
            this.rdnKahve.AutoSize = true;
            this.rdnKahve.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdnKahve.Location = new System.Drawing.Point(74, 9);
            this.rdnKahve.Name = "rdnKahve";
            this.rdnKahve.Size = new System.Drawing.Size(92, 17);
            this.rdnKahve.TabIndex = 7;
            this.rdnKahve.TabStop = true;
            this.rdnKahve.Text = "Kahverengi At";
            this.rdnKahve.UseVisualStyleBackColor = true;
            // 
            // rdnBeyaz
            // 
            this.rdnBeyaz.AutoSize = true;
            this.rdnBeyaz.Location = new System.Drawing.Point(173, 9);
            this.rdnBeyaz.Name = "rdnBeyaz";
            this.rdnBeyaz.Size = new System.Drawing.Size(67, 17);
            this.rdnBeyaz.TabIndex = 8;
            this.rdnBeyaz.TabStop = true;
            this.rdnBeyaz.Text = "Beyaz At";
            this.rdnBeyaz.UseVisualStyleBackColor = true;
            // 
            // cmbMisli
            // 
            this.cmbMisli.Location = new System.Drawing.Point(51, 36);
            this.cmbMisli.Name = "cmbMisli";
            this.cmbMisli.Size = new System.Drawing.Size(61, 20);
            this.cmbMisli.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Bahis";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(246, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(67, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Kasa";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormatString = "N0";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(157, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(46, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Misli";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(247, 9);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 17);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Beraberlik";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1053, 394);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbMisli);
            this.Controls.Add(this.rdnBeyaz);
            this.Controls.Add(this.rdnKahve);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.beyazAt);
            this.Controls.Add(this.kahveAt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kahveAt;
        private System.Windows.Forms.Button beyazAt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdnKahve;
        private System.Windows.Forms.RadioButton rdnBeyaz;
        private System.Windows.Forms.TextBox cmbMisli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

