﻿using System;
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
    public partial class UC_CheckIn_Info : UserControl
    {
        long membershipId;
        String memberGender;
        String memberName;
        //id for people that are not member but they came gym
        int member_id;
        int remainingSession;
        public UC_CheckIn_Info()
        {
            InitializeComponent();
        }

        private void txb_UcCheckInMemberId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //check that input is numeric
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);

        }

       

        private void txb_UcCheckInMemberId_KeyDown(object sender, KeyEventArgs e)
        {
            
            //check if enter key is entered
            if (e.KeyCode == Keys.Enter) {
                enterMember();
            }
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
                    if(!txt.ToString().Equals(txb_UcCheckInInfoMemberId.ToString()))
                    ((TextBox)txt).Clear();
                txb_UcCheckInInfoMemberShipType.BackColor = SystemColors.Window;
                txb_UcCheckInInfoMemberRemainingSession.BackColor = SystemColors.Window;
                txb_UcCheckInInfoMembershipEndDate.BackColor = SystemColors.Window;
                btn_UcCheckInInfoMemberCheck.Enabled = false;
            }
        }

        private void btn_UcCheckInInfoMemberCheck_Click(object sender, EventArgs e)
        {
            enterMember();
            
        }

        private void enterMember()
        {
            if (txb_UcCheckInInfoMemberId.Text.Equals("")) {
                MessageBox.Show("کد عضویت ورزشکار را وارد نمایید");
                txb_UcCheckInInfoMemberId.Focus();
            }
            else{
                int? commode;
                if (txb_UcCheckInInfoCommodeNum.Text.Equals(""))
                {
                    commode = null;
                }
                else
                {
                    commode = Convert.ToInt32(txb_UcCheckInInfoCommodeNum.Text);
                }
                rayan_sportDataSet.memberCheckInDataTable memberCheckInDataTable = new rayan_sportDataSet.memberCheckInDataTable();
                rayan_sportDataSetTableAdapters.memberCheckInTableAdapter memberCheckInTableAdapter = new rayan_sportDataSetTableAdapters.memberCheckInTableAdapter();
                DateTime d = DateTime.Now;
                PersianCalendar pc = new PersianCalendar();
                String date = string.Format("{0}/{1}/{2}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d));

                memberCheckInTableAdapter.Insert(membershipId, date, commode);
                MessageBox.Show(memberGender + " " + memberName + " " + "وارد شد.");
                ClearTexts();
                txb_UcCheckInInfoMemberId.Clear();
                rayan_sportDataSet.membershipDataTable membershipDataTable = new rayan_sportDataSet.membershipDataTable();
                rayan_sportDataSetTableAdapters.membershipTableAdapter tableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
                tableAdapter.IncreaseRemainingSession(remainingSession - 1, member_id, membershipId);
            }
        }

        private void txb_UcCheckInInfoMemberId_TextChanged(object sender, EventArgs e)
        {
            if (!txb_UcCheckInInfoMemberId.Text.Equals(""))
            {
                rayan_sportDataSet.memberDataTable memberDataTable = new rayan_sportDataSet.memberDataTable();
                rayan_sportDataSetTableAdapters.memberTableAdapter membertableAdapter = new rayan_sportDataSetTableAdapters.memberTableAdapter();
                int rows = membertableAdapter.FillBySelectByMemberId(memberDataTable, Convert.ToInt32(txb_UcCheckInInfoMemberId.Text));
                
                if (rows == 1)
                {
                    txb_UcCheckInInfoMemberName.Text = memberDataTable[0].member_name;
                    member_id = memberDataTable[0].member_id;
                    memberGender = memberDataTable[0].member_gender;
                    memberName = memberDataTable[0].member_name;
                    rayan_sportDataSet.membershipDataTable membershipDataTable = new rayan_sportDataSet.membershipDataTable();
                    rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
                    int rows1 = membershipTableAdapter.FillBySelectMembersWithStatusAndId(membershipDataTable, Convert.ToInt32(txb_UcCheckInInfoMemberId.Text), "فعال");

                    if (rows1 == 1)
                    {
                        if (membershipDataTable[0].membership_remainingSession > 0)
                        {
                            membershipId = membershipDataTable[0].membership_id;
                            remainingSession = membershipDataTable[0].membership_remainingSession;
                            txb_UcCheckInInfoMemberShipType.Text = membershipDataTable[0].membership_type;
                            txb_UcCheckInInfoMemberRemainingSession.Text = membershipDataTable[0].membership_remainingSession + "";
                            txb_UcCheckInInfoMembershipEndDate.Text = membershipDataTable[0].membership_endDate;
                            btn_UcCheckInInfoMemberCheck.Enabled = true;
                        }
                        else
                        {
                            txb_UcCheckInInfoMemberShipType.Text = "قرار داد فعال وجود ندارد";
                            txb_UcCheckInInfoMemberRemainingSession.Text = "قرار داد فعال وجود ندارد";
                            txb_UcCheckInInfoMembershipEndDate.Text = "قرار داد فعال وجود ندارد";
                            txb_UcCheckInInfoMemberShipType.BackColor = Color.LightSalmon;
                            txb_UcCheckInInfoMemberRemainingSession.BackColor = Color.LightSalmon;
                            txb_UcCheckInInfoMembershipEndDate.BackColor = Color.LightSalmon;
                            btn_UcCheckInInfoMemberCheck.Enabled = false;
                        }

                    }
                    else
                    {
                        txb_UcCheckInInfoMemberShipType.Text = "قرار داد فعال وجود ندارد";
                            txb_UcCheckInInfoMemberRemainingSession.Text = "قرار داد فعال وجود ندارد";
                            txb_UcCheckInInfoMembershipEndDate.Text = "قرار داد فعال وجود ندارد";
                            txb_UcCheckInInfoMemberShipType.BackColor = Color.LightSalmon;
                            txb_UcCheckInInfoMemberRemainingSession.BackColor = Color.LightSalmon;
                            txb_UcCheckInInfoMembershipEndDate.BackColor = Color.LightSalmon;
                            btn_UcCheckInInfoMemberCheck.Enabled = false;

                    }
                }
                else {
                    ClearTexts();
                }

            }
        }
    }
}
