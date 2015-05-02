using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarSalla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int turSayisi = 0;
        int red, green, blue;
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
           
            timer1.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            red = rnd.Next(0, 256);
            green = rnd.Next(0, 256);
            blue = rnd.Next(0, 256);
            int zar1 = rnd.Next(1, 7);
            int zar2 = rnd.Next(1, 7);
            lblZar1.Text = zar1.ToString();
            lblZar1.BackColor = Color.FromArgb(red, green, blue);
            lblZar2.Text = zar2.ToString();
            lblZar2.BackColor = Color.FromArgb(red, green, blue);
            turSayisi++;
            if(turSayisi==40)
            {
                timer1.Stop();
                turSayisi = 0;
            }
        }
    }
}
