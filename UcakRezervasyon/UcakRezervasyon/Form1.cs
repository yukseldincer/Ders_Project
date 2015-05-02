using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    Button bt = new Button();
                    if (x==2)
                    {
                        bt.Hide();  
                    }
                    else
                    {


                        int pointX = 10 + (x * 60);
                        int pointY = 20 + (y * 60);
                       
                        Point p = new Point();
                        p.X = pointX;
                        p.Y = pointY;
                        bt.Location = p;
                        bt.Size = new System.Drawing.Size(50, 50);
                        gbSira.Controls.Add(bt);
                    }
                }
            }
        }
    }
}
