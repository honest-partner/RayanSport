using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayanSport
{
    class BuffetLog
    {
      
        public String buffetLog_userName { get; set; }
        public int buffetLog_memberId { get; set; }
        public String buffetLog_memberName { get; set; }
        public String buffetLog_dateTime { get; set; }
        public long buffetLog_price { get; set; }
        public String buffetLog_description { get; set; }
        public BuffetLog(string buffetLog_userName, int buffetLog_memberId , string buffetLog_memberName, string buffetLog_dateTime, long buffetLog_price , string buffetLog_description)
        {
            this.buffetLog_userName = buffetLog_userName;
            this.buffetLog_memberId = buffetLog_memberId;
            this.buffetLog_memberName = buffetLog_memberName;
            this.buffetLog_dateTime = buffetLog_dateTime;
            this.buffetLog_price = buffetLog_price;
            this.buffetLog_description = buffetLog_description;
        }

    }
}
