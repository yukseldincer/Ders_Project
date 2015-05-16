using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_01
{
    public class Personel
    {
        public string personelNo;
        public string ad;
        public string soyad;

        public Personel()
        {

        }
        public Personel(string pa, string a, string s)
        {
            personelNo = pa;
            ad = a;
            soyad = s;
        }
        public string PersonelBilgisiGetir()
        {
            return personelNo + " " + ad + " " + soyad;
        }
    }
}
