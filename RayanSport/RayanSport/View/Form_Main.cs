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
        public Form_Main()
        {
            InitializeComponent();

            lbl_mainClock.Text = DateTime.Now.ToString("h : mm : ss");// Initialize of digital Clock
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
            pbx_mainHeaderIcon.Image = RayanSport.Properties.Resources.homeYellow;
            lbl_mainHeaderText.Text = lbl_mainHome.Text;
        }

        private void pbx_mainEntranceIcon_Click(object sender, EventArgs e)
        {
            pbx_mainHeaderIcon.Image = RayanSport.Properties.Resources.checklistYellow;
            lbl_mainHeaderText.Text = lbl_mainEntrance.Text;
        }

        private void pbx_mainMemberIcon_Click(object sender, EventArgs e)
        {
            pbx_mainHeaderIcon.Image = RayanSport.Properties.Resources.strongYellow;
            lbl_mainHeaderText.Text = lbl_mainMember.Text;
        }

        private void pbx_mainContractIcon_Click(object sender, EventArgs e)
        {
            pbx_mainHeaderIcon.Image = RayanSport.Properties.Resources.FileYellow;
            lbl_mainHeaderText.Text = lbl_mainContract.Text;
        }

        private void pbx_mainBuffetIcon_Click(object sender, EventArgs e)
        {
            pbx_mainHeaderIcon.Image = RayanSport.Properties.Resources.juiceYellow;
            lbl_mainHeaderText.Text = lbl_mainBuffet.Text;
        }

        private void pbx_mainUserIcon_Click(object sender, EventArgs e)
        {
            pbx_mainHeaderIcon.Image = RayanSport.Properties.Resources.userYellow;
            lbl_mainHeaderText.Text = lbl_mainUser.Text;
        }

        private void pbx_mainSettingIcon_Click(object sender, EventArgs e)
        {
            pbx_mainHeaderIcon.Image = RayanSport.Properties.Resources.settingYellow;
            lbl_mainHeaderText.Text = lbl_mainSetting.Text;
        }

        private void pbx_mainAboutIcon_Click(object sender, EventArgs e)
        {
            pbx_mainHeaderIcon.Image = RayanSport.Properties.Resources.aboutYellow;
            lbl_mainHeaderText.Text = lbl_mainAbout.Text;
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



    }
}
