using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayanSport
{
    public class CheckIn
    {
       

        public long checkIn_cost { get; set; }
        public String checkIn_date { get; set; }
        public int checkIn_commode { get; set; }
        public CheckIn() { }
        public CheckIn(long checkIn_cost, string checkIn_date, string checkIn_gender, int checkIn_commode)
        {
            this.checkIn_cost = checkIn_cost;
            this.checkIn_date = checkIn_date;
            this.checkIn_commode = checkIn_commode;
        }
        public String toString() {
            return (String.Format("checkIn_cost:{0},checkIn_date:{1},checkIn_commode:{2}", checkIn_cost, checkIn_date, checkIn_commode));
        }
    }
}
