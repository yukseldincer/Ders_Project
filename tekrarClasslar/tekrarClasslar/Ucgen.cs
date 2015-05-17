using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tekrarClasslar
{
    class Ucgen:GeometrikSekil
    {
        public int taban;
        public int yukseklik;

        public Ucgen()
        {

        }
        public int AlanHesapla()
        {
            return (taban * yukseklik) / 2;
        }
        public Point SolAltKonumGetir()
        {
            Point solKonum = new Point(pozisyonX-(taban / 2), pozisyonY + yukseklik);
            return solKonum;
        }
    }
}
