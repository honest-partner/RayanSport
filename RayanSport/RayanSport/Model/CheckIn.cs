using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayanSport
{
    class CheckIn
    {
       

        public long checkIn_cost { get; set; }
        public String checkIn_date { get; set; }
        public String checkIn_gender { get; set; }
        public int checkIn_commode { get; set; }
        public CheckIn(long checkIn_cost, string checkIn_date, string checkIn_gender, int checkIn_commode)
        {
            this.checkIn_cost = checkIn_cost;
            this.checkIn_date = checkIn_date;
            this.checkIn_gender = checkIn_gender;
            this.checkIn_commode = checkIn_commode;
        }
    }
}
