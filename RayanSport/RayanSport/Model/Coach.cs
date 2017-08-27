using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayanSport
{
    public class Coach
    {
        public Coach(string coach_name)
        {
            this.coach_name = coach_name;
        }
        public Coach() { }
        public String coach_name { get; set; }
    }
}
