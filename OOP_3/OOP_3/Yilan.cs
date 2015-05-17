using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Yilan : Hayvan
    {
        public Yilan()
        {
            //Ad = "Hulusi";
            //DogumTarihi = DateTime.Now.AddYears(-5);
            Tur = "Surungen";
        }
        public override string DetaylariGetir()
        {
            return base.DetaylariGetir();
        }
    }
}
