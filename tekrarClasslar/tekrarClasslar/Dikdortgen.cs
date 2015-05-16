using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tekrarClasslar
{
    class Dikdortgen:GeometrikSekil
    {
        private int yukseklik;
        private int genislik;

        public Dikdortgen(int yuk,int gen)
        {
            yukseklik = yuk;
            genislik = gen;
        }

        public int AlanHesapla()
        {
            return yukseklik * genislik;
        }

        private Point SagUstKonumuGetir()
        {
            Point sagUstKonumNoktası = new Point(pozisyonX + genislik, pozisyonY);
            return sagUstKonumNoktası;
        }
    }
}
