using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tekrarClasslar
{
    class Cember:GeometrikSekil
    {
        public int yaricap;
        private int pi = 3;

        public Cember()
        {
          
        }

        public int AlanHesapla()
        {
            return pi * yaricap*yaricap;
        }

        public Point UstKonumGetir()
        {
            Point ustKonum = new Point(pozisyonX,yaricap - pozisyonY);
            return ustKonum;
        }
    }
}
