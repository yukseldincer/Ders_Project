using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_05
{
    public interface IKisi
    {
        string TCKimlikNo { get; set; }
        string Ad { get; set; }
        string Soyad { get; set; }
        DateTime DogumTarihi { get; set; }
        string CepNo { get; set; }
        int Yas { get; }

        string BilgileriGoster();
    }
}
