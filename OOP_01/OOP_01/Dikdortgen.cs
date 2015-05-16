using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_01
{
    public class  Dikdortgen
    {
       public double widht;
       public double height;
        public Dikdortgen()
        {

        }
        public Dikdortgen(int w,int h)
        {
            widht = w;
            height = h;
        }
        public double GetArea()
        {
            return widht * height;
        }
    }
}
