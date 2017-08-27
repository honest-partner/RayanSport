using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayanSport
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string context = "نام کاربری یا رمز عبور اشتباه است";
            Alert alert = new Alert(context, "darkred", 5);
        }

       // #region  // mouse Enter and leave of menu
        private void pbx_mainHomeIcon_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainHomeIcon.Image = RayanSport.Properties.Resources.home_button;
            lbl_mainHome.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void pbx_mainHomeIcon_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainHomeIcon.Image = RayanSport.Properties.Resources.home_button_1_1;
            lbl_mainHome.ForeColor = lbl_mainHome.ForeColor = RayanSport.Properties.Settings.Default.LightGrey;
        }

        private void lbl_mainHome_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainHomeIcon.Image = RayanSport.Properties.Resources.home_button;
            lbl_mainHome.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void lbl_mainHome_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainHomeIcon.Image = RayanSport.Properties.Resources.home_button_1_1;
            lbl_mainHome.ForeColor = RayanSport.Properties.Settings.Default.LightGrey;
        }



        private void pbx_mainEntranceIcon_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainEntranceIcon.Image = RayanSport.Properties.Resources.checklist;
            lbl_mainEntrance.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void pbx_mainEntranceIcon_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainEntranceIcon.Image = RayanSport.Properties.Resources.checklistGrey;
            lbl_mainEntrance.ForeColor = RayanSport.Properties.Settings.Default.LightGrey;
        }

        private void lbl_mainEntrance_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainEntranceIcon.Image = RayanSport.Properties.Resources.checklist;
            lbl_mainEntrance.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void lbl_mainEntrance_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainEntranceIcon.Image = RayanSport.Properties.Resources.checklistGrey;
            lbl_mainEntrance.ForeColor = RayanSport.Properties.Settings.Default.LightGrey;
        }




        private void pbx_mainMemberIcon_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainMemberIcon.Image = RayanSport.Properties.Resources.strength_1_;
            lbl_mainMember.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void pbx_mainMemberIcon_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainMemberIcon.Image = RayanSport.Properties.Resources.strength;
            lbl_mainMember.ForeColor = RayanSport.Properties.Settings.Default.LightGrey;
        }

        private void lbl_mainMember_MouseEnter(object sender, EventArgs e)
        {
            pbx_mainMemberIcon.Image = RayanSport.Properties.Resources.strength;
            lbl_mainMember.ForeColor = RayanSport.Properties.Settings.Default.DarkYellow;
        }

        private void lbl_mainMember_MouseLeave(object sender, EventArgs e)
        {
            pbx_mainMemberIcon.Image = RayanSport.Properties.Resources.strength;
            lbl_mainMember.ForeColor = RayanSport.Properties.Settings.Default.LightGrey;
        }
    }
}
