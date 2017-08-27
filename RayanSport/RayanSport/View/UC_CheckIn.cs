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
        public UC_CheckIn()
        {
            InitializeComponent();
        }

       

        private void btn_UcCheckInCheck_Click(object sender, EventArgs e)
        {
            int? commode;
            if (txb_UcCheckInPrice.Text.Equals(""))
            {
                MessageBox.Show("لطفا قیمت جلسه را وارد نمایید");
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
                    String date = String.Format("{0}/{1}/{2} {3}:{4}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d), pc.GetHour(d), pc.GetMinute(d));



                    rayan_sportDataSet.checkInDataTable checkInDataTabele = new rayan_sportDataSet.checkInDataTable();
                    rayan_sportDataSetTableAdapters.checkInTableAdapter checkInTableAdapter = new rayan_sportDataSetTableAdapters.checkInTableAdapter();
                    try
                    {
                        checkInTableAdapter.Insert(Convert.ToInt64(txb_UcCheckInPrice.Text), date, commode);
                        MessageBox.Show("ورود با موفقیت انجام شد");
                        ClearTexts();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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
    }
}
