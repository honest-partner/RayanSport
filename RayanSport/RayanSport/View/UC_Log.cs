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
    public partial class UC_Log : UserControl
    {
        public UC_Log()
        {
            InitializeComponent();
            DateTime d = DateTime.Now;
            PersianCalendar pc = new PersianCalendar();
            String date = String.Format("{0}/{1:00}/{2:00}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d));
            //Alert alert = new Alert(date, "red");
            string start_date= date;
            string end_date = date;
            setData(start_date,end_date);
        }

        private void setData(string start_date,string end_date)
        {
            rayan_sportDataSet.logDataTable logDataTable = new rayan_sportDataSet.logDataTable();
            rayan_sportDataSetTableAdapters.logTableAdapter logTableAdapter = new rayan_sportDataSetTableAdapters.logTableAdapter();
            logTableAdapter.FillBySelectLogByDate(logDataTable,start_date,end_date);
            dgv_UcShowMemberContractInfoContracts.DataSource = logDataTable;
        }

        private void btn_UcLogSearchDate_Click(object sender, EventArgs e)
        {
            try
            {
                string startDate = dts_UcLogStartDate.Value.Value.ToString("M/d/yyyy");
                startDate = getDateShamsi(startDate);
                string endDate = dts_UcLogEndDate.Value.Value.ToString("M/d/yyyy");
                endDate = getDateShamsi(endDate);
                setData(startDate,endDate);
            }
            catch (Exception ex)
            {
                Alert alert = new Alert(ex.Message,"red"); 
                
            }
        }

        private string getDateShamsi(string date)
        {
            DateTime d = DateTime.Parse(date);
            PersianCalendar pc = new PersianCalendar();
            //MessageBox.Show(string.Format("{0}/{1:00}/{2:00}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d)));
            return string.Format("{0}/{1:00}/{2:00}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d));
            
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // UC_Log
            // 
            this.Name = "UC_Log";
            this.Size = new System.Drawing.Size(670, 380);
            this.ResumeLayout(false);

        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // UC_Log
        //    // 
        //    this.Name = "UC_Log";
        //    this.Size = new System.Drawing.Size(270, 208);
        //    this.ResumeLayout(false);

        //}
    }
}
