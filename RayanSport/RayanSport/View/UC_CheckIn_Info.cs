using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayanSport.View
{
    public partial class UC_CheckIn_Info : UserControl
    {
        //id for people that are not member but they came gym
        int not_member_id;
        public UC_CheckIn_Info()
        {
            InitializeComponent();
        }

        private void txb_UcCheckInMemberId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //check that input is numeric
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);

        }

        private void btn_UcCheckInMemberCheck_Click(object sender, EventArgs e)
        {

        }

        private void txb_UcCheckInMemberId_KeyDown(object sender, KeyEventArgs e)
        {
            
            //check if enter key is entered
            if (e.KeyCode == Keys.Enter) {
                
                
            }
        }
        //check id is corect.if corect is it memeber or not
        private void CheckId(String member_id)
        {
            int member_id_int;
            bool access = Int32.TryParse(member_id, out member_id_int);
            if (!access)
            {
                MessageBox.Show("لطفا کد عضویت را بصورت صحیح وارد کنید");
            }
            else {
                if (member_id_int == not_member_id)
                    NotMemberEntered();
                else
                    CheckMember();
            }
            
        }
        //do task if entered id is member or not
        private void CheckMember()
        {
            
        }
        //do task if entered id is for not memebers
        private void NotMemberEntered()
        {
            
        }

        private void txb_UcCheckInInfoMemberClear_Click(object sender, EventArgs e)
        {
            ClearTexts();
            
        }

        private void ClearTexts()
        {
            foreach (var txt in this.Controls)
            {
                if (txt is TextBox)
                    ((TextBox)txt).Clear();
            }
        }

        private void btn_UcCheckInInfoMemberCheck_Click(object sender, EventArgs e)
        {
            
        }

        private void txb_UcCheckInInfoMemberId_TextChanged(object sender, EventArgs e)
        {
            /*rayan_sportDataSet.membershipDataTable dataTable = new rayan_sportDataSet.membershipDataTable();
            rayan_sportDataSetTableAdapters.membershipTableAdapter adapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
            int rows =adapter.FillByCheckMemberIsExist(dataTable, Convert.ToInt64(txb_UcCheckInInfoMemberId.Text));
            if (rows == 1)
            {
                txb_UcCheckInInfoMemberName.Text = dataTable[0].membership_memberName;
                txb_UcCheckInInfoMemberShipType.Text = dataTable[0].membership_type;
                txb_UcCheckInInfoMemberRemainingSession.Text = dataTable[0].membership_remainingSession + "";
                txb_UcCheckInInfoMembershipEndDate.Text = dataTable[0].membership_endDate;
                //txb_UcCheckInInfoMemberDes.Text = dataTable[0].
            }
            else {
                MessageBox.Show("نام کاربری و یا رمز عبور وارد شده صحیح نمیباشد");
                ClearTexts();
            }*/
        }
    }
}
