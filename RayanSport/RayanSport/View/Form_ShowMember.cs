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
        Member mem;
        public Form_ShowMember()
        {
            mem = new Member(114,"","","","","","","",0);
            InitializeComponent();
            foreach (var item in this.Controls)
            {
                if (item is UC_ShowMember_ContractInfo)
                    (item as UC_ShowMember_ContractInfo).member = mem;
            }
        }
        public int setDataForUcShowMemberInfo(Member member)
        {

            foreach(var uc in this.Controls)
            {
                if (uc is UC_ShowMember_MemberInfo)
                {
                    (uc as UC_ShowMember_MemberInfo).UC_ShowMember_MemberInfoCon(member);
                }

            }
            return 1;
        }
    }
}
