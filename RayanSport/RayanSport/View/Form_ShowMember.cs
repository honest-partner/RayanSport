using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayanSport.View
{
    public partial class Form_ShowMember : Form
    {
        public Member Member { get; set; }

        public Form_ShowMember(string user_name)
        {
            InitializeComponent(user_name);

        }
        public int setDataForUcShowMemberInfo(Member member)
        {
            uC_ShowMember_MemberInfo1.UC_ShowMember_MemberInfoCon(member);
            if (member.member_name == "" || member.member_name == null)
            {
                uC_ShowMember_ContractInfo1.Enabled = false;
            }
            else
            {
                uC_ShowMember_ContractInfo1.setData(member);
            }
           
            return 1;
        }
        public void changeContractEnabled(bool en,Member member)
        {
            uC_ShowMember_ContractInfo1.Enabled = en;
            uC_ShowMember_ContractInfo1.setData(member);
        }
    }
}
