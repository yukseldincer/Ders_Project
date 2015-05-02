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
        #region değişkenler

        int koltukXSira = 0, koltukYSira = 0;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

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
            if(Boslukmu(x, y))
            {
                //
            }
            else
            {
                Button btn = new Button();
                
                if (SoforKoltuguysa(x, y))
                {
                    btn.Size = new System.Drawing.Size(100, 50);//(koltukXSira / 2 * 60) - 10
                }
                else
                {
                    btn.Size = new System.Drawing.Size(50, 50);
                }

                btn.Location = GetLocation(x, y, koridorVarmi);
                gbKoltuklar.Controls.Add(btn);
            }
        }

        private bool SoforKoltuguysa(int x, int y)
        {
            if (x == 0 && y == 0)
            {
                return true;
            }
            else
                return false;

        }

        private bool Boslukmu(int x, int y)
        {
            if (
                x >= (koltukXSira / 2)// sağ koridorda mı
                && (y == koltukYSira / 2 || y == 0) //Otobusun ortasındaysa veya en bastaysa 
                //2 sıraysa (arka arkaya 9 koltuk varsa 4. ve 5. koltuj ise
                )
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
            koltukXSira = Convert.ToInt32(txtKoltukGenislik.Text);
            koltukYSira = Convert.ToInt32(txtKoltukYukseklik.Text);
            KoltuklariYarat(koltukXSira, koltukYSira);
        }
        
    }
}
