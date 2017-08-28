using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayanSport
{
    public class Membership
    {
        public Membership(long membership_id, int membership_memberId, string membership_memberName, string membership_startDate, string membership_endDate, string membership_type, int membership_remainingSession, long membership_receiptNumber, string membership_paymentType, long membership_price, long membership_payment, string membership_description , string membership_status)
        {
            this.membership_id = membership_id;
            this.membership_memberId = membership_memberId;
            this.membership_memberName = membership_memberName;
            this.membership_startDate = membership_startDate;
            this.membership_endDate = membership_endDate;
            this.membership_type = membership_type;
            this.membership_remainingSession = membership_remainingSession;
            this.membership_receiptNumber = membership_receiptNumber;
            this.membership_paymentType = membership_paymentType;
            this.membership_price = membership_price;
            this.membership_payment = membership_payment;
            this.membership_description = membership_description;
            this.membership_status = membership_status;
        }

        /*public bool isExpired()
        {
            
        }*/
        public Membership() { }
        public long membership_id { get; set; }
        public int membership_memberId { get; set; }
        public String membership_memberName { get; set; }
        public String membership_startDate { get; set; }
        public String membership_endDate { get; set; }
        public String membership_type { get; set; }
        public int membership_remainingSession { get; set; }
        public long membership_receiptNumber { get; set; }
        public String membership_paymentType { get; set; }
        public long membership_price { get; set; }
        public long membership_payment { get; set; }
        public string membership_description { get; set; }
        public String membership_status{ get; set; }
        public String toString() {
            return String.Format("membership_id:{0},membership_memberId:{1},membership_memberName:{2},membership_startDate:{3},membership_endDate:{4},membership_type:{5} ,membership_remainingSession:{6},membership_receiptNumber:{7},membership_paymentType:{8},membership_price:{9},membership_payment:{10},membership_description:{11},membership_status:{12} "
                , membership_id, membership_memberId, membership_memberName, membership_startDate, membership_endDate, membership_type, membership_remainingSession, membership_receiptNumber, membership_paymentType, membership_price,membership_payment, membership_description, membership_status);

        }

    }
}
