using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RayanSport.View;
using System.Globalization;

namespace RayanSport
{
    public partial class Form_Main : Form
    {
        public bool isHomeActive, isCheckInLogActive, isMemberActive, isContractActive, isBuffetActive, isUserActive, isSettingActive, isAboutUsActive, isLogActive;
        public bool isCheckInFormOpen = false;
        public Form_CheckIn formCheckIn;

        public UC_Home ucHome = new UC_Home();
        //public UC_ShowAllMember ucShowAllMember = new UC_ShowAllMember("usernameShouldBeHere");
        public UC_ShowAllContract ucShowAllContract = new UC_ShowAllContract(0);
        public UC_Setting ucSetting = new UC_Setting();
        public UC_AboutUs ucAboutUs = new UC_AboutUs();
        public UC_Log ucLog = new UC_Log();
        public UC_CheckInLog ucCheckInLog = new UC_CheckInLog();


       

        public Form_Main(string username)
        {
            InitializeComponent();

            if(username!="999999999")
            {
                btn_mainLog.Visible = false;
                btn_mainLog.Enabled = false;
            }

            lbl_mainClock.Text = DateTime.Now.ToString("h : mm : ss");// Initialize of digital Clock

            #region //Initializing UserControls to speed up MainForm

            tlp_mainHeader.Controls.Clear();
            deactiveAll();
            tlp_mainHeader.Controls.Add(ucHome, 1, 1);
            ucHome.Dock = DockStyle.Fill;
            isHomeActive = true;


            /*tlp_mainHeader.Controls.Clear();
                deactiveAll();
                tlp_mainHeader.Controls.Add(ucShowAllMember, 1, 1);
                ucShowAllMember.Dock = DockStyle.Fill;
                isMemberActive = true;*/


            tlp_mainHeader.Controls.Clear();
            deactiveAll();
            tlp_mainHeader.Controls.Add(ucShowAllContract, 1, 1);
            ucShowAllContract.Dock = DockStyle.Fill;
            isContractActive = true;


            //BUFFET's USER CONTROL OR FORM SHOULD IMPLEMENT HERE


            //USER's USER CONTROL OR FORM SHOULD IMPLEMENT HERE

            tlp_mainHeader.Controls.Clear();
            deactiveAll();
            tlp_mainHeader.Controls.Add(ucSetting, 1, 1);
            ucSetting.Dock = DockStyle.Fill;
            isSettingActive = true;


            tlp_mainHeader.Controls.Clear();
            deactiveAll();
            tlp_mainHeader.Controls.Add(ucAboutUs, 1, 1);
            ucAboutUs.Dock = DockStyle.Fill;
            isAboutUsActive = true;



            #endregion


            deactiveAll();
            ucHome = new UC_Home();
            tlp_mainHeader.Controls.Add(ucHome, 1, 1);
            ucHome.Dock = DockStyle.Fill;
            isHomeActive = true;
        }

        #region  // mouse Enter and leave of menu items
        private void pbx_mainHomeIcon_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainHomeIcon.Image = RayanSport.Properties.Resources.homeYellow;
            lbl_mainHome.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainHomeIcon.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainHome.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void pbx_mainHomeIcon_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainHomeIcon.Image = RayanSport.Properties.Resources.homeGrey;
            lbl_mainHome.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainHomeIcon.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainHome.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
        }

        private void lbl_mainHome_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainHomeIcon.Image = RayanSport.Properties.Resources.homeYellow;
            lbl_mainHome.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainHomeIcon.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainHome.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void lbl_mainHome_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainHomeIcon.Image = RayanSport.Properties.Resources.homeGrey;
            lbl_mainHome.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainHomeIcon.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainHome.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
        }






        private void pbx_mainEntranceIcon_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainEntranceIcon.Image = RayanSport.Properties.Resources.checklistYellow;
            lbl_mainEntrance.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainEntranceIcon.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainEntrance.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void pbx_mainEntranceIcon_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainEntranceIcon.Image = RayanSport.Properties.Resources.checklistGrey;
            lbl_mainEntrance.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainEntranceIcon.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainEntrance.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
        }

        private void lbl_mainEntrance_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainEntranceIcon.Image = RayanSport.Properties.Resources.checklistYellow;
            lbl_mainEntrance.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainEntranceIcon.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainEntrance.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void lbl_mainEntrance_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainEntranceIcon.Image = RayanSport.Properties.Resources.checklistGrey;
            lbl_mainEntrance.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainEntranceIcon.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainEntrance.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
        }






        private void pbx_mainMemberIcon_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainMemberIcon.Image = RayanSport.Properties.Resources.strongYellow;
            lbl_mainMember.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainMemberIcon.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainMember.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void pbx_mainMemberIcon_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainMemberIcon.Image = RayanSport.Properties.Resources.strongGrey;
            lbl_mainMember.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainMemberIcon.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainMember.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
        }

        private void lbl_mainMember_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainMemberIcon.Image = RayanSport.Properties.Resources.strongYellow;
            lbl_mainMember.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainMemberIcon.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainMember.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void lbl_mainMember_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainMemberIcon.Image = RayanSport.Properties.Resources.strongGrey;
            lbl_mainMember.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainMemberIcon.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainMember.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
        }





        private void pbx_mainContractIcon_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainContractIcon.Image = RayanSport.Properties.Resources.FileYellow;
            lbl_mainContract.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainContractIcon.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainContract.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void pbx_mainContractIcon_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainContractIcon.Image = RayanSport.Properties.Resources.FileGrey;
            lbl_mainContract.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainContractIcon.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainContract.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
        }

        private void lbl_mainContract_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainContractIcon.Image = RayanSport.Properties.Resources.FileYellow;
            lbl_mainContract.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainContractIcon.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainContract.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void lbl_mainContract_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainContractIcon.Image = RayanSport.Properties.Resources.FileGrey;
            lbl_mainContract.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainContractIcon.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainContract.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
        }






        private void pbx_mainBuffetIcon_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainBuffetIcon.Image = RayanSport.Properties.Resources.juiceYellow;
            lbl_mainBuffet.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainBuffetIcon.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainBuffet.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void pbx_mainBuffetIcon_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainBuffetIcon.Image = RayanSport.Properties.Resources.juiceGrey;
            lbl_mainBuffet.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainBuffetIcon.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainBuffet.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
        }

        private void lbl_mainBuffet_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainBuffetIcon.Image = RayanSport.Properties.Resources.juiceYellow;
            lbl_mainBuffet.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainBuffetIcon.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainBuffet.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void lbl_mainBuffet_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainBuffetIcon.Image = RayanSport.Properties.Resources.juiceGrey;
            lbl_mainBuffet.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainBuffetIcon.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainBuffet.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
        }





        private void pbx_mainUserIcon_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainUserIcon.Image = RayanSport.Properties.Resources.userYellow;
            lbl_mainUser.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainUserIcon.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainUser.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void pbx_mainUserIcon_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainUserIcon.Image = RayanSport.Properties.Resources.userGrey;
            lbl_mainUser.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainUserIcon.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainUser.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
        }

        private void lbl_mainUser_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainUserIcon.Image = RayanSport.Properties.Resources.userYellow;
            lbl_mainUser.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainUserIcon.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainUser.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void lbl_mainUser_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainUserIcon.Image = RayanSport.Properties.Resources.userGrey;
            lbl_mainUser.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainUserIcon.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainUser.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
        }





        private void pbx_mainSettingIcon_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainSettingIcon.Image = RayanSport.Properties.Resources.settingYellow;
            lbl_mainSetting.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainSettingIcon.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainSetting.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void pbx_mainSettingIcon_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainSettingIcon.Image = RayanSport.Properties.Resources.settingGrey;
            lbl_mainSetting.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainSettingIcon.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainSetting.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
        }

        private void lbl_mainSetting_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainSettingIcon.Image = RayanSport.Properties.Resources.settingYellow;
            lbl_mainSetting.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainSettingIcon.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainSetting.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void lbl_mainSetting_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainSettingIcon.Image = RayanSport.Properties.Resources.settingGrey;
            lbl_mainSetting.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainSettingIcon.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainSetting.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
        }






        private void pbx_mainAboutIcon_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainAboutIcon.Image = RayanSport.Properties.Resources.aboutYellow;
            lbl_mainAbout.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainAboutIcon.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainAbout.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void pbx_mainAboutIcon_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainAboutIcon.Image = RayanSport.Properties.Resources.aboutGrey;
            lbl_mainAbout.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainAboutIcon.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainAbout.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
        }

        private void lbl_mainAbout_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainAboutIcon.Image = RayanSport.Properties.Resources.aboutYellow;
            lbl_mainAbout.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainAboutIcon.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainAbout.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void lbl_mainAbout_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainAboutIcon.Image = RayanSport.Properties.Resources.aboutGrey;
            lbl_mainAbout.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainAboutIcon.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainAbout.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
        }






        private void pbx_mainExitIcon_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainExitIcon.Image = RayanSport.Properties.Resources.exitYellow;
            lbl_mainExit.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainExitIcon.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainExit.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void pbx_mainExitIcon_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainExitIcon.Image = RayanSport.Properties.Resources.exitGrey;
            lbl_mainExit.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainExitIcon.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainExit.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
        }

        private void lbl_mainExit_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainExitIcon.Image = RayanSport.Properties.Resources.exitYellow;
            lbl_mainExit.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainExitIcon.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
            lin_mainExit.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void lbl_mainExit_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainExitIcon.Image = RayanSport.Properties.Resources.exitGrey;
            lbl_mainExit.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainExitIcon.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
            lin_mainExit.ForeColor = RayanSport.Properties.Settings.Default.MediumGrey;
        }
        #endregion

        #region // mouse click of menu items
        private void pbx_mainHomeIcon_Click(object sender, EventArgs e)
        {
            if(!isHomeActive)
            {
                tlp_mainHeader.Controls.Clear();
                deactiveAll();
                tlp_mainHeader.Controls.Add(ucHome, 1, 1);
                ucHome.Dock = DockStyle.Fill;
                isHomeActive = true;
            }
        }

        private void pbx_mainEntranceIcon_Click(object sender, EventArgs e)
        {
            isCheckInFormOpen = false;
            foreach (var item in Application.OpenForms)
            {
                if (item is Form_CheckIn)
                {
                    (item as Form_CheckIn).TopMost = true;
                    (item as Form_CheckIn).TopMost = false;
                    isCheckInFormOpen = true;
                }
            }
            if (!isCheckInFormOpen)
            {
                formCheckIn = new Form_CheckIn("usernameShouldBeHere");
                formCheckIn.Show();
                isCheckInFormOpen = true;
            }

            if (!isCheckInLogActive)
            {
                tlp_mainHeader.Controls.Clear();
                deactiveAll();
                tlp_mainHeader.Controls.Add(ucCheckInLog, 1, 1);
                ucCheckInLog.Dock = DockStyle.Fill;
                isCheckInLogActive = true;
            }
        }

        private void pbx_mainMemberIcon_Click(object sender, EventArgs e)
        {
            if(!isMemberActive)
            {
                /*tlp_mainHeader.Controls.Clear();
                deactiveAll();
                tlp_mainHeader.Controls.Add(ucShowAllMember, 1, 1);
                ucShowAllMember.Dock = DockStyle.Fill;
                isMemberActive = true;*/
            }
        }

        private void pbx_mainContractIcon_Click(object sender, EventArgs e)
        {
            if (!isContractActive)
            {
                tlp_mainHeader.Controls.Clear();
                deactiveAll();
                tlp_mainHeader.Controls.Add(ucShowAllContract, 1, 1);
                ucShowAllContract.Dock = DockStyle.Fill;
                isContractActive = true;
            }
        }

        private void pbx_mainBuffetIcon_Click(object sender, EventArgs e)
        {
            //BUFFET's USER CONTROL OR FORM SHOULD IMPLEMENT HERE
        }

        private void pbx_mainUserIcon_Click(object sender, EventArgs e)
        {
            //USER's USER CONTROL OR FORM SHOULD IMPLEMENT HERE
        }

        private void pbx_mainSettingIcon_Click(object sender, EventArgs e)
        {
            if (!isSettingActive)
            {
                tlp_mainHeader.Controls.Clear();
                deactiveAll();
                tlp_mainHeader.Controls.Add(ucSetting, 1, 1);
                ucSetting.Dock = DockStyle.Fill;
                isSettingActive = true;
            }
        }

        private void lbl_mainExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mainLog_Click(object sender, EventArgs e)
        {
            if (!isLogActive)
            {
                tlp_mainHeader.Controls.Clear();
                deactiveAll();
                tlp_mainHeader.Controls.Add(ucLog, 1, 1);
                ucLog.Dock = DockStyle.Fill;
                isLogActive = true;
            }
        }

        private void pbx_mainAboutIcon_Click(object sender, EventArgs e)
        {
            if (!isAboutUsActive)
            {
                tlp_mainHeader.Controls.Clear();
                deactiveAll();
                tlp_mainHeader.Controls.Add(ucAboutUs, 1, 1);
                ucAboutUs.Dock = DockStyle.Fill;
                isAboutUsActive = true;
            }
        }

        #endregion

        #region //main time and date 
        private void tmr_mainClock_Tick(object sender, EventArgs e)
        {
            lbl_mainClock.Text = DateTime.Now.ToString("h : mm : ss");

            if (DateTime.Now.ToString("hh🇲🇲ss tt").Contains("PM"))
                lbl_mainTimeOfDay.Text = "بـعد از ظهر";
            else
                lbl_mainTimeOfDay.Text = "قـبل از ظهر";

            lbl_mainDate.Text = getDateShamsi(DateTime.Now.ToString()) + "    " + getPersianDayOfWeek(DateTime.Now.DayOfWeek.ToString());
        }

        public string getDateShamsi(string date)
        {
            DateTime d = DateTime.Parse(date);
            PersianCalendar pc = new PersianCalendar();
            return string.Format("{0}/{1:00}/{2:00}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d));//---> miladi to shamsi*/
        }

        public string getPersianDayOfWeek(string day)
        {
            if (day == "Saturday")
                return "شنبه";
            else if (day == "Sunday")
                return "یکشنبه";
            else if (day == "Monday")
                return "دوشنبه";
            else if (day == "Tuesday")
                return "سه شنبه";
            else if (day == "Wednesday")
                return "چهارشنبه";
            else if (day == "Thursday")
                return "پنج شنبه";
            else
                return "جمعه";
        }
        #endregion



        public void deactiveAll()
        {
            isHomeActive = false;
            isCheckInLogActive = false;
            isMemberActive = false;
            isContractActive = false;
            isBuffetActive = false;
            isUserActive = false;
            isSettingActive = false;
            isAboutUsActive = false;
            isLogActive = false;
        }



        public void setUC(UserControl uc)
        {
            tlp_mainHeader.Controls.Clear();
            deactiveAll();
            tlp_mainHeader.Controls.Add(uc, 1, 1);
            uc.Dock = DockStyle.Fill;
            isContractActive = true;
        }
    }
}
