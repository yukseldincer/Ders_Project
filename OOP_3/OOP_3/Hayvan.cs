using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public class Hayvan
    {
        protected string Tur { get; set; }
        public string Ad { get; set; }
        public DateTime DogumTarihi { get; set; }

        private int yas;

        protected int Yas
        {
            get 
            {
                TimeSpan ts = DateTime.Now.Subtract(DogumTarihi);
                return Convert.ToInt32(ts.TotalDays / 365.25); 
            }

        }
        

        private int? ayakSayisi;
        public int? AyakSayisi
        {
            get { 
                
                return this.ayakSayisi; }

            set {
                if (this.ayakSayisi != null && this.ayakSayisi >= 0)
                {
                    this.ayakSayisi = value;
                    if (this.ayakSayisi==0)
                    this.Tur = "Surungen";
                }
                
            }
        }
        public virtual string DetaylariGetir()
        {
            return String.Format("Tur = {0}, Ad = {1}, Yas = {2}, Ayak Sayisi= {3}", this.Tur, this.Ad, this.Yas, this.AyakSayisi);
        }
    }
}
