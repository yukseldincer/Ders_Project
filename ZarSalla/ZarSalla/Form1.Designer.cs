namespace ZarSalla
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
            this.lblZar1 = new System.Windows.Forms.Label();
            this.lblZar2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblZar1
            // 
            this.lblZar1.BackColor = System.Drawing.Color.Silver;
            this.lblZar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblZar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZar1.Location = new System.Drawing.Point(31, 9);
            this.lblZar1.Name = "lblZar1";
            this.lblZar1.Size = new System.Drawing.Size(95, 118);
            this.lblZar1.TabIndex = 0;
            this.lblZar1.Text = "0";
            // 
            // lblZar2
            // 
            this.lblZar2.BackColor = System.Drawing.Color.Silver;
            this.lblZar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblZar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZar2.Location = new System.Drawing.Point(147, 9);
            this.lblZar2.Name = "lblZar2";
            this.lblZar2.Size = new System.Drawing.Size(95, 118);
            this.lblZar2.TabIndex = 0;
            this.lblZar2.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(99, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zar At";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 193);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblZar2);
            this.Controls.Add(this.lblZar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblZar1;
        private System.Windows.Forms.Label lblZar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

