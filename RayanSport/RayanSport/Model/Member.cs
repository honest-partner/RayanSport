using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayanSport
{
    class Member
    {
        public int member_id { get; set; }
        public String member_name { get; set; }
        public String member_nationalCode { get; set; }
        public String member_tel { get; set; }
        //public Byte member_image { get; set; }
        public String member_gender { get; set; }
        public String member_blood { get; set; }
        public String member_sick { get; set; }
        public String member_address { get; set; }
        public long member_charge { get; set; }
        public Member(int member_id, string member_name, string member_nationalCode, string member_tel, string member_gender, string member_blood, string member_sick, string member_address, long member_charge)
        {
            this.member_id = member_id;
            this.member_name = member_name;
            this.member_nationalCode = member_nationalCode;
            this.member_tel = member_tel;
            this.member_gender = member_gender;
            this.member_blood = member_blood;
            this.member_sick = member_sick;
            this.member_address = member_address;
            this.member_charge = member_charge;
        }

       
    }
}
