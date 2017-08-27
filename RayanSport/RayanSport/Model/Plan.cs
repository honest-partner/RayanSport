using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayanSport
{
    public class Plan
    {
        public Plan(int plan_memberId, string plan_description, string plan_date , string plan_coach)
        {
            this.plan_memberId = plan_memberId;
            this.plan_description = plan_description;
            this.plan_date = plan_date;
            this.plan_coach = plan_coach;
        }
        public Plan() { }

        public int plan_memberId { get; set; }
        public String plan_description { get; set; }
        public String plan_date { get; set; }
        public String  plan_coach{ get; set; }
    }
}
