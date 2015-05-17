using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public abstract class Cicek
    {
        public static int Id { get; set; }
        public string Cinsi { get; set; }

        public abstract DateTime EkimTarihiniGetir();
        public Cicek()
        {

        }

        static Cicek()
        {

        }
    }
}
