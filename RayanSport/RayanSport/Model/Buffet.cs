using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayanSport
{
    class Buffet
    {
        public Buffet(string buffet_foodName, long buffet_foodPrice)
        {
            this.buffet_foodName = buffet_foodName;
            this.buffet_foodPrice = buffet_foodPrice;
        }

        public String buffet_foodName { get; set; }
        public long buffet_foodPrice { get; set; }
    }
}
