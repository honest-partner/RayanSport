using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayanSport
{
    public class BuffetSell
    {
        public BuffetSell(long buffetSell_Id, string buffetSell_date, string buffetSell_description, long buffetSell_billPrice, int buffetSell_membershipId, string buffetSell_paymentCondition)
        {
            this.buffetSell_Id = buffetSell_Id;
            this.buffetSell_date = buffetSell_date;
            this.buffetSell_description = buffetSell_description;
            this.buffetSell_billPrice = buffetSell_billPrice;
            this.buffetSell_membershipId = buffetSell_membershipId;
            this.buffetSell_paymentCondition = buffetSell_paymentCondition;
            
        }

        public BuffetSell() { }
        public long buffetSell_Id { get; set; }
        public String buffetSell_date { get; set; }
        public String buffetSell_description { get; set; }
        public long buffetSell_billPrice { get; set; }
        public long buffetSell_membershipId { get; set; }
        public String buffetSell_paymentCondition { get; set; }
        //public int buffetSell_description { get; set; }

    }
}
