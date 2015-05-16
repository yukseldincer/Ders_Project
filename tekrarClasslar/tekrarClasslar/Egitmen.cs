using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tekrarClasslar
{
    public class Egitmen
    {
        private string ad_Variable;
        public string Ad_Property
        {
            get
            {
                return ad_Variable;
            }
            set
            {
                ad_Variable = value;
            }
        }
    }
}
