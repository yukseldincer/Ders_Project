namespace methodlar01
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
            this.btnMethod = new System.Windows.Forms.Button();
            this.cbAylar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMethod
            // 
            this.btnMethod.Location = new System.Drawing.Point(197, 12);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(75, 23);
            this.btnMethod.TabIndex = 0;
            this.btnMethod.Text = "Method";
            this.btnMethod.UseVisualStyleBackColor = true;
            // 
            // cbAylar
            // 
            this.cbAylar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAylar.FormattingEnabled = true;
            this.cbAylar.Location = new System.Drawing.Point(12, 25);
            this.cbAylar.Name = "cbAylar";
            this.cbAylar.Size = new System.Drawing.Size(94, 21);
            this.cbAylar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aylar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAylar);
            this.Controls.Add(this.btnMethod);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMethod;
        private System.Windows.Forms.ComboBox cbAylar;
        private System.Windows.Forms.Label label1;
    }
}

