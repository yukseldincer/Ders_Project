using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int altSinir, ustSinir, tahmin;
        private void btnBasla_Click(object sender, EventArgs e)
        {
            try
            {
                altSinir = Convert.ToInt32(txtAltS.Text);
                ustSinir = Convert.ToInt32(txtUstsS.Text);
                
            }
            catch
            {
                MessageBox.Show("Sayısal Deger Giriniz");
                
            }

            tahmin = (altSinir + ustSinir) / 2;
            lblTahmin.Text = tahmin.ToString();
        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            ustSinir = tahmin;
            tahmin = (altSinir + ustSinir) / 2;
            lblTahmin.Text = tahmin.ToString();
        }

        private void btnArttir_Click(object sender, EventArgs e)
        {
            altSinir = tahmin;
            tahmin = (altSinir + ustSinir) / 2;
            lblTahmin.Text = tahmin.ToString();

        }
    }
}
