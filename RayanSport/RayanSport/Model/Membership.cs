using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayanSport
{
    class Membership
    {
       

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
        public Membership(long membership_id, int membership_memberId, string membership_memberName, string membership_startDate, string membership_endDate, string membership_type, int membership_remainingSession, long membership_receiptNumber, string membership_paymentType, long membership_price, long membership_payment)
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
        }
    }
}
