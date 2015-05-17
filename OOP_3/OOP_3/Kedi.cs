using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Kedi : Hayvan
    {
        public Kedi()
        {
            //Ad = "Minnoş";
            Tur = "Memeli";
            //DogumTarihi = DateTime.Now.AddYears(-10);
            AyakSayisi = 4;
        }
        public Kedi(string ad, DateTime dogumTarihi)
            : this()
        {
            Ad = ad;
            DogumTarihi = dogumTarihi;
        }
        public Kedi(string ad, DateTime dogumTarihi, int ayakSayisi)
            : this(ad, dogumTarihi)
        {
            AyakSayisi = ayakSayisi;
        }

        public override string DetaylariGetir()
        {
            return "Kedi Classından" + base.DetaylariGetir();
        }
    }
}
