using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_BiletRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int genislik;
        int yukseklik;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void KoltuklariYarat(int widht, int height)
        {
            gbKoltuklar.Controls.Clear();
            gbKoltuklar.Width = (widht + 1) * (50 + 10) + 10;

            int koridorBasindakiKoltuk = (widht / 2) - 1;
            int sonKoltuk = height - 1;
            // Her X sırasındaki koltuk sayısı kadar dongu
            for (int x = 0; x < widht; x++)
            {
                // Her Y sırasındaki koltuk sayısı kadar dongu
                for (int y = 0; y < height; y++)
                {
                    KoltukYarat(x, y, (x > koridorBasindakiKoltuk));
                    // Arka Koltukları beşlemek için kordor boşluğuna bir buton daha atıldı
                    if (x == koridorBasindakiKoltuk && y == sonKoltuk)
                        KoltukYarat(x + 1, y, false);
                }
            }
        }

        // Group Box içine koltukları buton olarak yaratır
        private void KoltukYarat(int x, int y, bool koridorVarmi)
        {
            if (soforSirasimi(x,y))
            {
                Button btn2 = new Button();
                btn2.Location = GetLocation(x, y, koridorVarmi);
                btn2.Size = new System.Drawing.Size(110, 50);
                gbKoltuklar.Controls.Add(btn2);

            }
            else
            {
                if (x >= ((genislik / 2)-1) && (y == (yukseklik / 2) || y==0))
                {

                }
                else
                {
                    Button btn = new Button();
                    btn.Location = GetLocation(x, y, koridorVarmi);
                    btn.Size = new System.Drawing.Size(50, 50);
                    gbKoltuklar.Controls.Add(btn);
                }
            }
        }

        private bool soforSirasimi(int x,int y)
        {
            if (x>=0 && y==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Koltuğun konumuna göre groupbox taki orjinal location degerini dondurur
        private Point GetLocation(int x, int y, bool koridorVarmi)
        {
            int pointX = 10 + (x * 60);
            int pointY = 30 + (y * 60);
            int koridor = 60;
            if (koridorVarmi)
                pointX += koridor;//pointX = pointX + koridor;

            Point p = new Point();
            p.X = pointX;
            p.Y = pointY;

            return p;
        }
        private void btnKoltuklariYarat_Click(object sender, EventArgs e)
        {
            genislik = Convert.ToInt32(txtKoltukGenislik.Text);
            yukseklik = Convert.ToInt32(txtKoltukYukseklik.Text);
            KoltuklariYarat(genislik, yukseklik);
            
        }

    }
}
