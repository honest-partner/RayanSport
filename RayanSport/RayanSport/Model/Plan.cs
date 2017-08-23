using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayanSport
{
    class Plan
    {
        public Plan(int plan_memberId, string plan_detail, string plan_date)
        {
            this.plan_memberId = plan_memberId;
            this.plan_detail = plan_detail;
            this.plan_date = plan_date;
        }

        public int plan_memberId { get; set; }
        public String plan_detail { get; set; }
        public String plan_date { get; set; }
    }
}
