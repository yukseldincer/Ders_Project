using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tekrarClasslar
{
   public class GeometrikSekil
    {
        protected int pozisyonX;
        protected int pozisyonY;

        public GeometrikSekil()
        {

        }

              public System.Drawing.Point PozisyonuGetir()
        {
            System.Drawing.Point point = new System.Drawing.Point(pozisyonX, pozisyonY);
            return point;
        }
    }
}
