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
    public partial class UC_CheckInLog : UserControl
    {


        public String endDateFrom;
        public String endDateUntil;


        public UC_CheckInLog()
        {
            InitializeComponent();
        }

        private void UC_CheckInLog_Load(object sender, EventArgs e)
        {
            //////////////fill DataGridView of Show Member///////////
            rayan_sportDataSet.memberCheckInDataTable dataTable = new rayan_sportDataSet.memberCheckInDataTable();
            rayan_sportDataSetTableAdapters.memberCheckInTableAdapter adapter = new rayan_sportDataSetTableAdapters.memberCheckInTableAdapter();
            adapter.Fill(dataTable);
            dgv_UcCheckInLogShowMember.DataSource = dataTable;


            //////////////fill DataGridView of Show NotMember///////////
            rayan_sportDataSet.checkInDataTable dataTable2 = new rayan_sportDataSet.checkInDataTable();
            rayan_sportDataSetTableAdapters.checkInTableAdapter adapter2 = new rayan_sportDataSetTableAdapters.checkInTableAdapter();
            adapter2.Fill(dataTable2);
            dgv_UcCheckInLogShowNotMember.DataSource = dataTable2;

        }



        public string getDateShamsi(string date)
        {


            DateTime d = DateTime.Parse(date);
            PersianCalendar pc = new PersianCalendar();
            return string.Format("{0}/{1:00}/{2:00}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d));//---> miladi to shamsi*/

        }

        private void dts_UcCheckInLogDateFrom_ValueChanged(object sender, EventArgs e)
        {
            endDateFrom = dts_UcCheckInLogDateFrom.Value.Value.ToString("M/d/yyyy");
            endDateFrom = getDateShamsi(endDateFrom);
        }

        private void dts_UcCheckInLogDateUntil_ValueChanged(object sender, EventArgs e)
        {
            endDateUntil = dts_UcCheckInLogDateUntil.Value.Value.ToString("M/d/yyyy");
            endDateUntil = getDateShamsi(endDateUntil);
        }

        private void btn_UcCheckInLogSearch_Click(object sender, EventArgs e)
        {
            if (endDateFrom != "" && endDateUntil != "")
            {
                rayan_sportDataSet.memberCheckInDataTable memberCheckInDataTable = new rayan_sportDataSet.memberCheckInDataTable();
                rayan_sportDataSetTableAdapters.memberCheckInTableAdapter memberCheckInTableAdapter = new rayan_sportDataSetTableAdapters.memberCheckInTableAdapter();
                memberCheckInTableAdapter.FillBySelectByDate2(memberCheckInDataTable, endDateFrom, endDateUntil);
                dgv_UcCheckInLogShowMember.DataSource = memberCheckInDataTable;


                rayan_sportDataSet.checkInDataTable checkInDataTable = new rayan_sportDataSet.checkInDataTable();
                rayan_sportDataSetTableAdapters.checkInTableAdapter checkInTableAdapter = new rayan_sportDataSetTableAdapters.checkInTableAdapter();
                checkInTableAdapter.Fill(checkInDataTable);
                dgv_UcCheckInLogShowNotMember.DataSource = checkInDataTable;



            }

        }
    }
}
