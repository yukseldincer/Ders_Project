using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace donguler_biletRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Button btn = new Button();
            //btn.Location = new Point(10, 15);
            //btn.Size = new System.Drawing.Size(50, 50);
            //gbKoltuklar.Controls.Add(btn);

            //Button btn2 = new Button();
            //btn2.Location = new Point(10 + btn.Width + 10 , 15);
            //btn2.Size = new System.Drawing.Size(50, 50);
            //gbKoltuklar.Controls.Add(btn2);

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Button btn = new Button();
                    btn.Location = GetLocation(x,y);
                    btn.Size = new System.Drawing.Size(50, 50);
                    gbKoltuklar.Controls.Add(btn);
                   
                    if(x==1 && y==9)
                    {
                        
                        Button btn2 = new Button();
                        int pointX = 20 + ((x + 1) * 60);
                        int pointY = 20 + (y * 60);
                        btn2.Location = new Point(pointX,pointY);
                        btn2.Size = new System.Drawing.Size(50, 50);
                        gbKoltuklar.Controls.Add(btn2);
                    }

                }
                
            }
        }

        private Point GetLocation(int x, int y)
        {
            int pointX = 20 + (x * 60);
            int pointY = 20 + (y * 60);
            int koridor = 60;
            if (x > 1)
                pointX += koridor;
            Point p = new Point();
            p.X = pointX;
            p.Y = pointY;       
            return p;
        }
    }
}
