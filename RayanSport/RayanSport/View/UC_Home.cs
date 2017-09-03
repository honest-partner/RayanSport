using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace RayanSport.View
{
    public partial class UC_Home : UserControl
    {

        public int Iam;
        public String activeContract;
        public UC_Home()
        {
            InitializeComponent();
            rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
            int count = (int)membershipTableAdapter.ScalarCountOfContract();
            lbl_UcHomeAllContractNum.Text = count.ToString();

            activeContract = "فعال";
            rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter1 = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
            int activeCount = (int)membershipTableAdapter1.ScalarCountByActiveContract(activeContract);
            lbl_UcHomeActiveContract.Text = activeCount.ToString();


            rayan_sportDataSetTableAdapters.memberTableAdapter memberTableAdapter = new rayan_sportDataSetTableAdapters.memberTableAdapter();
            int numMember = (int)memberTableAdapter.ScalarCountByMemberNum();
            lbl_UcHomeAllMember.Text = numMember.ToString();



           String todeyDate1 = getDateShamsi(DateTime.Now.ToString("M/d/yyyy"));
           
            rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter2 = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
            int expiredContract = (int)membershipTableAdapter1.ScalarCountByTodayExpiredContract(todeyDate1);
            
            lbl_UcHomeExoiredContract.Text = expiredContract.ToString();



            rayan_sportDataSetTableAdapters.checkInTableAdapter checkInTableAdapter = new rayan_sportDataSetTableAdapters.checkInTableAdapter();
            int notMember = (int)checkInTableAdapter.ScalarCountByNotMember(todeyDate1);
            lbl_UcHomeDayliMemberNum.Text = notMember.ToString();

            Iam = 0;



        }



        public string getDateShamsi(string date)
        {


            DateTime d = DateTime.Parse(date);
            PersianCalendar pc = new PersianCalendar();
            return string.Format("{0}/{1:00}/{2:00}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d));//---> miladi to shamsi*/

        }

        

        private void llb_UcHomeAllContractNum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Iam = 1;
        }

        private void llb_UcHomeAllMember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Iam = 2;
        }

        private void llb_UcHomeActiveContract_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Iam = 3;
        }

        private void llb_UcHomeDayliMemberNum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Iam = 4;
        }

        private void llb_UcHomeExoiredContract_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Iam = 5;
        }
    }
}
