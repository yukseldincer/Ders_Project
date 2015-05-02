namespace Donguler_Rezervasyon
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
            this.nubXSirasi = new System.Windows.Forms.NumericUpDown();
            this.nubYSirasi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKoltuklariYerlestir = new System.Windows.Forms.Button();
            this.scAnaPanel = new System.Windows.Forms.SplitContainer();
            this.pnlSecenekler = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rbHicbiri = new System.Windows.Forms.RadioButton();
            this.rbBayan = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKoltuk = new System.Windows.Forms.ComboBox();
            this.lbKoltukTipi = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nubXSirasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubYSirasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scAnaPanel)).BeginInit();
            this.scAnaPanel.Panel1.SuspendLayout();
            this.scAnaPanel.Panel2.SuspendLayout();
            this.scAnaPanel.SuspendLayout();
            this.pnlSecenekler.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yan Yana Koltuk Sayısı";
            // 
            // nubXSirasi
            // 
            this.nubXSirasi.Location = new System.Drawing.Point(181, 16);
            this.nubXSirasi.Margin = new System.Windows.Forms.Padding(2);
            this.nubXSirasi.Name = "nubXSirasi";
            this.nubXSirasi.Size = new System.Drawing.Size(60, 20);
            this.nubXSirasi.TabIndex = 1;
            // 
            // nubYSirasi
            // 
            this.nubYSirasi.Location = new System.Drawing.Point(181, 36);
            this.nubYSirasi.Margin = new System.Windows.Forms.Padding(2);
            this.nubYSirasi.Name = "nubYSirasi";
            this.nubYSirasi.Size = new System.Drawing.Size(60, 20);
            this.nubYSirasi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arka Arkaya Koltuk Sayısı";
            // 
            // btnKoltuklariYerlestir
            // 
            this.btnKoltuklariYerlestir.Location = new System.Drawing.Point(250, 16);
            this.btnKoltuklariYerlestir.Margin = new System.Windows.Forms.Padding(2);
            this.btnKoltuklariYerlestir.Name = "btnKoltuklariYerlestir";
            this.btnKoltuklariYerlestir.Size = new System.Drawing.Size(74, 35);
            this.btnKoltuklariYerlestir.TabIndex = 4;
            this.btnKoltuklariYerlestir.Text = "Koltuklari Yerleştir";
            this.btnKoltuklariYerlestir.UseVisualStyleBackColor = true;
            this.btnKoltuklariYerlestir.Click += new System.EventHandler(this.btnKoltuklariYerlestir_Click);
            // 
            // scAnaPanel
            // 
            this.scAnaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scAnaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scAnaPanel.Location = new System.Drawing.Point(0, 0);
            this.scAnaPanel.Margin = new System.Windows.Forms.Padding(2);
            this.scAnaPanel.Name = "scAnaPanel";
            this.scAnaPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scAnaPanel.Panel1
            // 
            this.scAnaPanel.Panel1.Controls.Add(this.label1);
            this.scAnaPanel.Panel1.Controls.Add(this.btnKoltuklariYerlestir);
            this.scAnaPanel.Panel1.Controls.Add(this.nubXSirasi);
            this.scAnaPanel.Panel1.Controls.Add(this.nubYSirasi);
            this.scAnaPanel.Panel1.Controls.Add(this.label2);
            // 
            // scAnaPanel.Panel2
            // 
            this.scAnaPanel.Panel2.Controls.Add(this.pnlSecenekler);
            this.scAnaPanel.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.scAnaPanel_Panel2_Paint);
            this.scAnaPanel.Size = new System.Drawing.Size(462, 477);
            this.scAnaPanel.SplitterDistance = 77;
            this.scAnaPanel.SplitterWidth = 2;
            this.scAnaPanel.TabIndex = 5;
            // 
            // pnlSecenekler
            // 
            this.pnlSecenekler.Controls.Add(this.lbKoltukTipi);
            this.pnlSecenekler.Controls.Add(this.cbKoltuk);
            this.pnlSecenekler.Controls.Add(this.label4);
            this.pnlSecenekler.Controls.Add(this.label3);
            this.pnlSecenekler.Controls.Add(this.rbHicbiri);
            this.pnlSecenekler.Controls.Add(this.rbBayan);
            this.pnlSecenekler.Controls.Add(this.rbErkek);
            this.pnlSecenekler.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSecenekler.Location = new System.Drawing.Point(314, 0);
            this.pnlSecenekler.Name = "pnlSecenekler";
            this.pnlSecenekler.Size = new System.Drawing.Size(146, 396);
            this.pnlSecenekler.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cinsiyet";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rbHicbiri
            // 
            this.rbHicbiri.AutoSize = true;
            this.rbHicbiri.Checked = true;
            this.rbHicbiri.Location = new System.Drawing.Point(3, 81);
            this.rbHicbiri.Name = "rbHicbiri";
            this.rbHicbiri.Size = new System.Drawing.Size(54, 17);
            this.rbHicbiri.TabIndex = 0;
            this.rbHicbiri.TabStop = true;
            this.rbHicbiri.Text = "Hiçbiri";
            this.rbHicbiri.UseVisualStyleBackColor = true;
            // 
            // rbBayan
            // 
            this.rbBayan.AutoSize = true;
            this.rbBayan.Location = new System.Drawing.Point(3, 58);
            this.rbBayan.Name = "rbBayan";
            this.rbBayan.Size = new System.Drawing.Size(55, 17);
            this.rbBayan.TabIndex = 0;
            this.rbBayan.Text = "Bayan";
            this.rbBayan.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(3, 35);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 0;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Koltuk Tipi";
            // 
            // cbKoltuk
            // 
            this.cbKoltuk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKoltuk.FormattingEnabled = true;
            this.cbKoltuk.Items.AddRange(new object[] {
            "Pencere",
            "Koridor"});
            this.cbKoltuk.Location = new System.Drawing.Point(4, 134);
            this.cbKoltuk.Name = "cbKoltuk";
            this.cbKoltuk.Size = new System.Drawing.Size(93, 21);
            this.cbKoltuk.TabIndex = 3;
            this.cbKoltuk.SelectedIndexChanged += new System.EventHandler(this.cbKoltuk_SelectedIndexChanged);
            // 
            // lbKoltukTipi
            // 
            this.lbKoltukTipi.FormattingEnabled = true;
            this.lbKoltukTipi.Items.AddRange(new object[] {
            "Kadın",
            "Erkek",
            "Hiçbiri"});
            this.lbKoltukTipi.Location = new System.Drawing.Point(4, 162);
            this.lbKoltukTipi.Name = "lbKoltukTipi";
            this.lbKoltukTipi.Size = new System.Drawing.Size(93, 69);
            this.lbKoltukTipi.TabIndex = 4;
            this.lbKoltukTipi.SelectedIndexChanged += new System.EventHandler(this.lbKoltukTipi_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 477);
            this.Controls.Add(this.scAnaPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nubXSirasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubYSirasi)).EndInit();
            this.scAnaPanel.Panel1.ResumeLayout(false);
            this.scAnaPanel.Panel1.PerformLayout();
            this.scAnaPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scAnaPanel)).EndInit();
            this.scAnaPanel.ResumeLayout(false);
            this.pnlSecenekler.ResumeLayout(false);
            this.pnlSecenekler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nubXSirasi;
        private System.Windows.Forms.NumericUpDown nubYSirasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKoltuklariYerlestir;
        private System.Windows.Forms.SplitContainer scAnaPanel;
        private System.Windows.Forms.Panel pnlSecenekler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbHicbiri;
        private System.Windows.Forms.RadioButton rbBayan;
        private System.Windows.Forms.ComboBox cbKoltuk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbKoltukTipi;
    }
}

