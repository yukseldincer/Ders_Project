using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_05
{
    public class Egitmen : IKisi
    {
        public string TCKimlikNo { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string CepNo { get; set; }
        public int Yas
        {
            get 
            {
                return Convert.ToInt32(DateTime.Now.Subtract(this.DogumTarihi).TotalDays / 365.25);
            }
        }

        public string BilgileriGoster()
        {
            return String.Format("Ad : {0}, Yas : {1}", this.Ad, this.Yas);
        }

        public string CalistigiKurum { get; set; }
    }
}
 