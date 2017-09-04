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
    public partial class UC_CheckIn_Info : UserControl
    {
        public string user_name { get; set; }
        long membershipId;
        String memberGender;
        String memberName;
        Member member;
        //id for people that are not member but they came gym
        int member_id;
        int remainingSession;
        public UC_CheckIn_Info(string user_name)
        {
            InitializeComponent();
            this.user_name = user_name;
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
                btn_UcCheckInInfoMemberCheck.BackColor = Properties.Settings.Default.MediumGrey;
                
            }
        }

        private void btn_UcCheckInInfoMemberCheck_Click(object sender, EventArgs e)
        {
            enterMember();
            
        }

        private void enterMember()
        {
            if (txb_UcCheckInInfoMemberId.Text.Equals("")) {
                //MessageBox.Show("کد عضویت ورزشکار را وارد نمایید");
                Alert alert = new Alert("کد عضویت ورزشکار را وارد نمایید", "red");
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
                try
                {
                    
                    rayan_sportDataSetTableAdapters.logTableAdapter logTableAdapter = new rayan_sportDataSetTableAdapters.logTableAdapter();
                    rayan_sportDataSet.memberCheckInDataTable memberCheckInDataTable = new rayan_sportDataSet.memberCheckInDataTable();
                    rayan_sportDataSetTableAdapters.memberCheckInTableAdapter memberCheckInTableAdapter = new rayan_sportDataSetTableAdapters.memberCheckInTableAdapter();
                    DateTime d = DateTime.Now;
                    PersianCalendar pc = new PersianCalendar();
                    String date = String.Format("{0}/{1:00}/{2:00} - {3:00}:{4:00}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d), pc.GetHour(d), pc.GetMinute(d));
                    string date1 = string.Format("{0}/{1:00}/{2:00}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d));
                    string time1 = string.Format("{0:00}:{1:00}", pc.GetHour(d), pc.GetMinute(d));
                    
                    memberCheckInTableAdapter.Insert(membershipId, date, commode);
                    //MessageBox.Show(memberGender + " " + memberName + " " + "وارد شد.");
                    Alert alert = new Alert(memberGender + " " + memberName + " " + "وارد شد.", "green");
                    
                    
                    txb_UcCheckInInfoMemberId.Clear();
                    ClearTexts();
                    llb_UcCheckInInfoShowMemberDetail.Enabled = false;
                    pcb_UcCheckInInfoMemberRemainingSession.BackgroundImage = null;
                    pcb_UcCheckInInfoMembershipEndDate.BackgroundImage = null;
                    pcb_UcCheckInInfoMemberShipType.BackgroundImage = null;
                    pbx_UcCheckInInfoMemberPicture.Image = Properties.Resources.no_image;
                    rayan_sportDataSet.membershipDataTable membershipDataTable = new rayan_sportDataSet.membershipDataTable();
                    rayan_sportDataSetTableAdapters.membershipTableAdapter tableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
                    tableAdapter.IncreaseRemainingSession(remainingSession - 1, member_id, membershipId);
                    logTableAdapter.Insert("checked in member : "+memberName,"memberCheckIn",user_name,date1,time1);
                }
                catch (Exception ex)
                {
                    Alert alert = new Alert(ex.Message, "red");
                    //throw;
                }

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
                    llb_UcCheckInInfoShowMemberDetail.Enabled = true;
                    txb_UcCheckInInfoMemberName.Text = memberDataTable[0].member_name;
                    member_id = memberDataTable[0].member_id;
                    memberGender = memberDataTable[0].member_gender;
                    memberName = memberDataTable[0].member_name;
                    member = new Member(memberDataTable[0].member_id, memberDataTable[0].member_name, memberDataTable[0].member_nationalCode, memberDataTable[0].member_tel, memberDataTable[0].member_gender, memberDataTable[0].member_blood, memberDataTable[0].member_sick, memberDataTable[0].member_address, memberDataTable[0].member_charge);
                    rayan_sportDataSet.membershipDataTable membershipDataTable = new rayan_sportDataSet.membershipDataTable();
                    rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
                    int rows1 = membershipTableAdapter.FillBySelectMembersWithStatusAndId(membershipDataTable, Convert.ToInt32(txb_UcCheckInInfoMemberId.Text), "فعال");
                    try
                    {

                        string path;
                        path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\member_image\";
                        pbx_UcCheckInInfoMemberPicture.Image = Image.FromFile(path + member_id + ".Jpeg");
                        pbx_UcCheckInInfoMemberPicture.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch (Exception ex) { }
                    if (rows1 == 1)
                    {
                        if (membershipDataTable[0].membership_remainingSession > 0)
                        {
                            membershipId = membershipDataTable[0].membership_id;
                            remainingSession = membershipDataTable[0].membership_remainingSession;
                            txb_UcCheckInInfoMemberShipType.Text = membershipDataTable[0].membership_type;
                            txb_UcCheckInInfoMemberRemainingSession.Text = membershipDataTable[0].membership_remainingSession + "";
                            txb_UcCheckInInfoMembershipEndDate.Text = membershipDataTable[0].membership_endDate;
                            pcb_UcCheckInInfoMemberRemainingSession.BackgroundImage = Properties.Resources._checked;
                            pcb_UcCheckInInfoMembershipEndDate.BackgroundImage = Properties.Resources._checked;
                            pcb_UcCheckInInfoMemberShipType.BackgroundImage = Properties.Resources._checked;
                            btn_UcCheckInInfoMemberCheck.Enabled = true;
                            btn_UcCheckInInfoMemberCheck.BackColor = Properties.Settings.Default.Blue;
                           
                            
                        }
                        else
                        {
                            txb_UcCheckInInfoMemberShipType.Text = "قرار داد فعال وجود ندارد";
                            txb_UcCheckInInfoMemberRemainingSession.Text = "قرار داد فعال وجود ندارد";
                            txb_UcCheckInInfoMembershipEndDate.Text = "قرار داد فعال وجود ندارد";
                            pcb_UcCheckInInfoMemberRemainingSession.BackgroundImage = Properties.Resources.cancel;
                            pcb_UcCheckInInfoMembershipEndDate.BackgroundImage = Properties.Resources.cancel;
                            pcb_UcCheckInInfoMemberShipType.BackgroundImage = Properties.Resources.cancel;

                            txb_UcCheckInInfoMemberShipType.ForeColor = Properties.Settings.Default.Red;
                            txb_UcCheckInInfoMemberRemainingSession.ForeColor = Properties.Settings.Default.Red;
                            txb_UcCheckInInfoMembershipEndDate.ForeColor = Properties.Settings.Default.Red;

                            
                            btn_UcCheckInInfoMemberCheck.Enabled = false;
                            btn_UcCheckInInfoMemberCheck.BackColor = Properties.Settings.Default.MediumGrey;
                        }

                    }
                    else
                    {
                        txb_UcCheckInInfoMemberShipType.Text = "قرار داد فعال وجود ندارد";
                            txb_UcCheckInInfoMemberRemainingSession.Text = "قرار داد فعال وجود ندارد";
                            txb_UcCheckInInfoMembershipEndDate.Text = "قرار داد فعال وجود ندارد";

                        pcb_UcCheckInInfoMemberRemainingSession.BackgroundImage = Properties.Resources.cancel;
                        pcb_UcCheckInInfoMembershipEndDate.BackgroundImage = Properties.Resources.cancel;
                        pcb_UcCheckInInfoMemberShipType.BackgroundImage = Properties.Resources.cancel;


                        txb_UcCheckInInfoMemberShipType.ForeColor = Properties.Settings.Default.Red;
                            txb_UcCheckInInfoMemberRemainingSession.ForeColor = Properties.Settings.Default.Red;
                        txb_UcCheckInInfoMembershipEndDate.ForeColor = Properties.Settings.Default.Red;

                        
                        btn_UcCheckInInfoMemberCheck.Enabled = false;
                        btn_UcCheckInInfoMemberCheck.BackColor = Properties.Settings.Default.MediumGrey;
                    }
                }
                else {
                    ClearTexts();
                    llb_UcCheckInInfoShowMemberDetail.Enabled = false;
                    pcb_UcCheckInInfoMemberRemainingSession.BackgroundImage = null;
                    pcb_UcCheckInInfoMembershipEndDate.BackgroundImage = null;
                    pcb_UcCheckInInfoMemberShipType.BackgroundImage = null;
                    pbx_UcCheckInInfoMemberPicture.Image = Properties.Resources.no_image;
                }

            }
        }

        private void UC_CheckIn_Info_Load(object sender, EventArgs e)
        {
            btn_UcCheckInInfoMemberCheck.Enabled = false;
            btn_UcCheckInInfoMemberCheck.BackColor = Properties.Settings.Default.MediumGrey;
            pbx_UcCheckInInfoMemberPicture.SizeMode = PictureBoxSizeMode.Zoom;





        }

        private void llb_UcCheckInInfoShowMemberDetail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_ShowMember show_member = new Form_ShowMember();
            show_member.Show();
        }
    }
}
