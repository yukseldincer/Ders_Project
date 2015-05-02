using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string girilenSayi;
        int sonuc = 0;
        private void btn1_Click(object sender, EventArgs e)
        {
            girilenSayi += btn1.Text;
            textBox1.Text = girilenSayi;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            girilenSayi += btn2.Text;
            textBox1.Text = girilenSayi;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            girilenSayi += btn3.Text;
            textBox1.Text = girilenSayi;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            girilenSayi += btn4.Text;
            textBox1.Text = girilenSayi;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            girilenSayi += btn5.Text;
            textBox1.Text = girilenSayi;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            girilenSayi += btn6.Text;
            textBox1.Text = girilenSayi;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            girilenSayi += btn7.Text;
            textBox1.Text = girilenSayi;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            girilenSayi += btn8.Text;
            textBox1.Text = girilenSayi;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            girilenSayi += btn9.Text;
            textBox1.Text = girilenSayi;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            girilenSayi += btn0.Text;
            textBox1.Text = girilenSayi;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            sonuc += Convert.ToInt32(girilenSayi);
            textBox1.Text = sonuc.ToString();
            girilenSayi = "";
        }

        private void btnCıkar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           sonuc -= Convert.ToInt32(girilenSayi);
            textBox1.Text = sonuc.ToString();
            girilenSayi = "";
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "";
            
            girilenSayi=
            
            textBox1.Text = sonuc.ToString();
            girilenSayi = "";
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            sonuc *= Convert.ToInt32(girilenSayi);
            textBox1.Text = sonuc.ToString();
            girilenSayi = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            girilenSayi = "";
            textBox1.Text = "";
            sonuc = 0;
        }
    }
}
