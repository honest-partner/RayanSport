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
    public partial class UC_CheckIn : UserControl
    {
        public string user_name{ get; set; }
        public UC_CheckIn(string user_name)
        {
            InitializeComponent();
            this.user_name = user_name;
        }

       

        private void btn_UcCheckInCheck_Click(object sender, EventArgs e)
        {
            int? commode;
            if (txb_UcCheckInPrice.Text.Equals(""))
            {
                
                //MessageBox.Show("لطفا قیمت جلسه را وارد نمایید");
                Alert alert = new Alert("لطفا قیمت جلسه را وارد نمایید", "red");
                txb_UcCheckInPrice.Focus();
            }
            else
            {
                if (txb_UcCheckInPrice.Text.Equals(""))
                {
                    commode = null;
                }
                else
                {
                    
                    commode = Convert.ToInt32(txb_UcCheckInPrice.Text);
                    DateTime d = DateTime.Now;
                    PersianCalendar pc = new PersianCalendar();
                    String date = String.Format("{0}/{1:00}/{2:00} - {3:00}:{4:00}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d), pc.GetHour(d), pc.GetMinute(d));
                    string date1 = string.Format("{0}/{1:00}/{2:00}" ,pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d));
                    string time1 = string.Format("{0:00}:{1:00}", pc.GetHour(d), pc.GetMinute(d));

                    //rayan_sportDataSet.logDataTable logeDataTable = new rayan_sportDataSet.logDataTable();
                    rayan_sportDataSetTableAdapters.logTableAdapter logTableAdapter = new rayan_sportDataSetTableAdapters.logTableAdapter();
                                        
                    rayan_sportDataSet.checkInDataTable checkInDataTabele = new rayan_sportDataSet.checkInDataTable();
                    rayan_sportDataSetTableAdapters.checkInTableAdapter checkInTableAdapter = new rayan_sportDataSetTableAdapters.checkInTableAdapter();
                    try
                    {
                        checkInTableAdapter.Insert(Convert.ToInt64(txb_UcCheckInPrice.Text), date, commode);
                        logTableAdapter.Insert("checked in one person","checkIn",user_name,date1,time1);
                        //MessageBox.Show("ورود با موفقیت انجام شد");
                        Alert alert = new Alert("ورود با موفقیت انجام شد", "green");
                        ClearTexts();
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message);
                        Alert alert = new Alert(ex.Message, "red");
                    }

                }
            }

        }

        private void txb_UcCheckInPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void btn_UcCheckInClear_Click(object sender, EventArgs e)
        {
            ClearTexts();
        }

        private void ClearTexts()
        {
            txb_UcCheckInCommode.Clear();
            txb_UcCheckInPrice.Clear();
        }

        private void UC_CheckIn_Load(object sender, EventArgs e)
        {
            btn_UcCheckInCheck.Enabled = false;
            btn_UcCheckInCheck.BackColor = Properties.Settings.Default.MediumGrey;
        }

        private void txb_UcCheckInPrice_TextChanged(object sender, EventArgs e)
        {
            bool has_text = !txb_UcCheckInPrice.Text.Equals("");
            btn_UcCheckInCheck.Enabled = has_text;
            if (has_text)
                btn_UcCheckInCheck.BackColor = Properties.Settings.Default.Blue;
            else
                btn_UcCheckInCheck.BackColor = Properties.Settings.Default.MediumGrey;
        }
    }
}
