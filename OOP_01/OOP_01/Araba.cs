using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_01
{
    public class Araba :Arac
    {
        public string model;
        //private int tekerlekSayisi;
        //public string motorGucu;

        public Araba()
        {
            tekerlekSayisi = 4;
        }
        public int TekerlekSayisiniGetir()
        {
            return tekerlekSayisi;
        }
    }
}
