using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayanSport
{
    public class Member_CheckIn
    {
        

        public long memberCheckIn_membershipId { get; set; }
        public String memberCheckIn_date { get; set; }
        public int memberCheckIn_commode { get; set; }
        public Member_CheckIn(int memberCheckIn_membershipId, string memberCheckIn_date, int memberCheckIn_commode)
        {
            this.memberCheckIn_membershipId = memberCheckIn_membershipId;
            this.memberCheckIn_date = memberCheckIn_date;
            this.memberCheckIn_commode = memberCheckIn_commode;
        }
        public Member_CheckIn() { }
    }
}
