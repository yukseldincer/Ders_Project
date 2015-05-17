using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class BaharCicekleri : Cicek
    {
        public BaharCicekleri()
        {
            Cinsi = "Bahar";
        }

        public override DateTime EkimTarihiniGetir()
        {
            return DateTime.Now;
        }
    }
}
