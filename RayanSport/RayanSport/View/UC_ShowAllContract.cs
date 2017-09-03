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
    public partial class UC_ShowAllContract : UserControl
    {
        public int WhoIsIt;
        public String endDate1;
        public String endDate2;
        public String Name;
        public String todeyDate;
        public String status="فعال";

    
        public UC_ShowAllContract()
        {
            InitializeComponent();
           // dts_UcShowAllContractDateSelectorFrom.Value = DateTime.Now;
           // dts_UcShowAllContractDateSelectorUntil.Value = DateTime.Now;
            rdb_UcShowAllContractAllContarct.Enabled = false;
            rdb_UcShowAllContractEnded.Enabled = false;
            rdb_UcShowAllContractEnding.Enabled = false;
            rdb_UcShowAllContractTodayExpired.Enabled = false;
            rdb_UcShowAllContractActiveContract.Enabled = false;
            lbl_UcShowAllContractDateFrom.Enabled = true;
            dts_UcShowAllContractDateSelectorFrom.Enabled = true;
            lbl_UcShowAllContractDateUntil.Enabled = true;
            dts_UcShowAllContractDateSelectorUntil.Enabled = true;
            lbl_UcShowAllContractName.Enabled = true;
            txb_UcShowAllContractName.Enabled = true;

            ////////come from home to see allContracts//////////
            if(WhoIsIt == 1)
            {
                rdb_UcShowAllContractEnded.IsChecked = false;
                rdb_UcShowAllContractEnding.IsChecked = false;
                rdb_UcShowAllContractTodayExpired.IsChecked = false;
                rdb_UcShowAllContractAllContarct.IsChecked = true;
                rdb_UcShowAllContractActiveContract.IsChecked = false;
                rdb_UcShowAllContractAllContarct.Enabled = true;
                rdb_UcShowAllContractEnded.Enabled = true;
                rdb_UcShowAllContractEnding.Enabled = true;
                rdb_UcShowAllContractTodayExpired.Enabled = true;
                rdb_UcShowAllContractActiveContract.Enabled = true;
                lbl_UcShowAllContractDateFrom.Enabled = true;
                dts_UcShowAllContractDateSelectorFrom.Enabled = false;
                lbl_UcShowAllContractDateUntil.Enabled =false;
                dts_UcShowAllContractDateSelectorUntil.Enabled = false;
                lbl_UcShowAllContractName.Enabled = false;
                txb_UcShowAllContractName.Enabled = false;


                rayan_sportDataSet.membershipDataTable dataTable = new rayan_sportDataSet.membershipDataTable();
                rayan_sportDataSetTableAdapters.membershipTableAdapter adapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
                adapter.Fill(dataTable);
                dgv_UcShowAllContractShowContract.DataSource = dataTable;

            }

            else if (WhoIsIt == 3)
            {
                status = "فعال";


                rdb_UcShowAllContractEnded.IsChecked = false;
                rdb_UcShowAllContractEnding.IsChecked = false;
                rdb_UcShowAllContractTodayExpired.IsChecked = false;
                rdb_UcShowAllContractAllContarct.IsChecked = false;
                rdb_UcShowAllContractActiveContract.IsChecked = true;
                rdb_UcShowAllContractAllContarct.Enabled = true;
                rdb_UcShowAllContractEnded.Enabled = true;
                rdb_UcShowAllContractEnding.Enabled = true;
                rdb_UcShowAllContractTodayExpired.Enabled = true;
                rdb_UcShowAllContractActiveContract.Enabled = true;
                lbl_UcShowAllContractDateFrom.Enabled = true;
                dts_UcShowAllContractDateSelectorFrom.Enabled = false;
                lbl_UcShowAllContractDateUntil.Enabled = false;
                dts_UcShowAllContractDateSelectorUntil.Enabled = false;
                lbl_UcShowAllContractName.Enabled = false;
                txb_UcShowAllContractName.Enabled = false;

                rayan_sportDataSet.membershipDataTable membershipDataTable = new rayan_sportDataSet.membershipDataTable();
                rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
                membershipTableAdapter.FillBySelectByActiveStatus(membershipDataTable, status);
                dgv_UcShowAllContractShowContract.DataSource = membershipDataTable;
            }
            else if(WhoIsIt == 5)
            {
                rdb_UcShowAllContractEnded.IsChecked = false;
                rdb_UcShowAllContractEnding.IsChecked = false;
                rdb_UcShowAllContractTodayExpired.IsChecked = true;
                rdb_UcShowAllContractAllContarct.IsChecked = false;
                rdb_UcShowAllContractActiveContract.IsChecked = false;
                rdb_UcShowAllContractAllContarct.Enabled = true;
                rdb_UcShowAllContractEnded.Enabled = true;
                rdb_UcShowAllContractEnding.Enabled = true;
                rdb_UcShowAllContractTodayExpired.Enabled = true;
                rdb_UcShowAllContractActiveContract.Enabled = true;
                lbl_UcShowAllContractDateFrom.Enabled = true;
                dts_UcShowAllContractDateSelectorFrom.Enabled = false;
                lbl_UcShowAllContractDateUntil.Enabled = false;
                dts_UcShowAllContractDateSelectorUntil.Enabled = false;
                lbl_UcShowAllContractName.Enabled = false;
                txb_UcShowAllContractName.Enabled = false;


                todeyDate = getDateShamsi(DateTime.Now.ToString("M/d/yyyy"));


                rayan_sportDataSet.membershipDataTable membershipDataTable = new rayan_sportDataSet.membershipDataTable();
                rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
                membershipTableAdapter.FillBySelectByTodayExpired(membershipDataTable, todeyDate);
                dgv_UcShowAllContractShowContract.DataSource = membershipDataTable;

            }


        }

        private void rdb_UcShowAllContractAllContarct_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (rdb_UcShowAllContractAllContarct.IsChecked)
            {
                rdb_UcShowAllContractEnded.IsChecked = false;
                rdb_UcShowAllContractEnding.IsChecked = false;
                rdb_UcShowAllContractTodayExpired.IsChecked = false;
                rdb_UcShowAllContractActiveContract.IsChecked = false;
            }
        }

       

        private void rdb_UcShowAllContractEnding_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (rdb_UcShowAllContractEnding.IsChecked)
            {
                rdb_UcShowAllContractEnded.IsChecked = false;
                rdb_UcShowAllContractAllContarct.IsChecked = false;
                rdb_UcShowAllContractTodayExpired.IsChecked = false;
                rdb_UcShowAllContractActiveContract.IsChecked = false;
            }
        }

        private void rdb_UcShowAllContractEnded_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (rdb_UcShowAllContractEnded.IsChecked)
            {
                rdb_UcShowAllContractEnding.IsChecked = false;
                rdb_UcShowAllContractAllContarct.IsChecked = false;
                rdb_UcShowAllContractTodayExpired.IsChecked = false;
                rdb_UcShowAllContractActiveContract.IsChecked = false;
            }
        }

        private void rdb_UcShowAllContractTodayExpired_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (rdb_UcShowAllContractTodayExpired.IsChecked)
            {
                rdb_UcShowAllContractEnding.IsChecked = false;
                rdb_UcShowAllContractAllContarct.IsChecked = false;
                rdb_UcShowAllContractEnded.IsChecked = false;
                rdb_UcShowAllContractActiveContract.IsChecked = false;
            }
        }

        private void UC_ShowAllContractcs_Load(object sender, EventArgs e)
        {
            WhoIsIt = 0;
            rayan_sportDataSet.membershipDataTable dataTable = new rayan_sportDataSet.membershipDataTable();
            rayan_sportDataSetTableAdapters.membershipTableAdapter adapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
            adapter.Fill(dataTable);
            dgv_UcShowAllContractShowContract.DataSource = dataTable;
        }

    

        private void btn_UcShowAllContractFilter_Click(object sender, EventArgs e)
        {

            WhoIsIt = 0;
            if(WhoIsIt ==0)
            {

            


            if (endDate1 != "" && endDate2 != "" && Name != "")
            {
                rayan_sportDataSet.membershipDataTable membershipDataTable = new rayan_sportDataSet.membershipDataTable();
                rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
                membershipTableAdapter.FillBySelectDateAndName(membershipDataTable, Name, endDate1, endDate2);
                dgv_UcShowAllContractShowContract.DataSource = membershipDataTable;
            }



            Name = "";
            if (endDate1 != "" && endDate2 != "" && Name == "")
            {
                rayan_sportDataSet.membershipDataTable membershipDataTable = new rayan_sportDataSet.membershipDataTable();
                rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
                membershipTableAdapter.FillBySelectByDate(membershipDataTable, endDate1, endDate2);
                dgv_UcShowAllContractShowContract.DataSource = membershipDataTable;
            }

            endDate1 = "";
            endDate2 = "";
            if (endDate1 == "" && endDate2 == "" && Name != "")

            {

                rayan_sportDataSet.membershipDataTable membershipDataTable = new rayan_sportDataSet.membershipDataTable();
                rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
                membershipTableAdapter.FillBySelectByName(membershipDataTable, Name);
                dgv_UcShowAllContractShowContract.DataSource = membershipDataTable;
            }

            if(rdb_UcShowAllContractEnded.IsChecked)
            {
                todeyDate = getDateShamsi(DateTime.Now.ToString("M/d/yyyy"));
               

                rayan_sportDataSet.membershipDataTable membershipDataTable = new rayan_sportDataSet.membershipDataTable();
                rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
                membershipTableAdapter.FillBySelectByEndedDate(membershipDataTable, todeyDate);
                dgv_UcShowAllContractShowContract.DataSource = membershipDataTable;


            }
            
            if(rdb_UcShowAllContractAllContarct.IsChecked)
            {
                rayan_sportDataSet.membershipDataTable dataTable = new rayan_sportDataSet.membershipDataTable();
                rayan_sportDataSetTableAdapters.membershipTableAdapter adapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
                adapter.Fill(dataTable);
                dgv_UcShowAllContractShowContract.DataSource = dataTable;
            }

            if(rdb_UcShowAllContractTodayExpired.IsChecked)
            {
                todeyDate = getDateShamsi(DateTime.Now.ToString("M/d/yyyy"));
                

                rayan_sportDataSet.membershipDataTable membershipDataTable = new rayan_sportDataSet.membershipDataTable();
                rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
                membershipTableAdapter.FillBySelectByTodayExpired(membershipDataTable, todeyDate);
                dgv_UcShowAllContractShowContract.DataSource = membershipDataTable;
            }

            if(rdb_UcShowAllContractEnding.IsChecked)
            {

                todeyDate = getDateShamsi(DateTime.Now.ToString("M/d/yyyy"));

                DateTime inSevenDays = DateTime.Today.AddDays(7);
                String sevenDay = getDateShamsi(inSevenDays.ToString());
              

                rayan_sportDataSet.membershipDataTable membershipDataTable = new rayan_sportDataSet.membershipDataTable();
                rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
                membershipTableAdapter.FillBySelectByEndingContract(membershipDataTable, todeyDate , sevenDay);
                dgv_UcShowAllContractShowContract.DataSource = membershipDataTable;


            }
            if(rdb_UcShowAllContractActiveContract.IsChecked)
                {

                    rayan_sportDataSet.membershipDataTable membershipDataTable = new rayan_sportDataSet.membershipDataTable();
                    rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
                    membershipTableAdapter.FillBySelectByActiveStatus(membershipDataTable, status);
                    dgv_UcShowAllContractShowContract.DataSource = membershipDataTable;
                }

            }



        }

        public string getDateShamsi(string date)
        {


            DateTime d = DateTime.Parse(date);
            PersianCalendar pc = new PersianCalendar();
            return string.Format("{0}/{1:00}/{2:00}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d));//---> miladi to shamsi*/

        }

        private void dts_UcShowAllContractDateSelectorFrom_ValueChanged(object sender, EventArgs e)
        {
           endDate1 = dts_UcShowAllContractDateSelectorFrom.Value.Value.ToString("M/d/yyyy");
           endDate1 = getDateShamsi(endDate1);
         
           
        }

        private void dts_UcShowAllContractDateSelectorUntil_ValueChanged(object sender, EventArgs e)
        {
            endDate2 = dts_UcShowAllContractDateSelectorUntil.Value.Value.ToString("M/d/yyyy");
            endDate2 = getDateShamsi(endDate2);
        }

        private void txb_UcShowAllContractName_TextChanged(object sender, EventArgs e)
        {
            Name = txb_UcShowAllContractName.Text;
           
            //rayan_sportDataSet.membershipDataTable membershipDataTable = new rayan_sportDataSet.membershipDataTable();
            //rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
            //membershipTableAdapter.FillBySelectByDateAndName(membershipDataTable,);
            //dgv_UcShowAllContractShowContract.DataSource = membershipDataTable;
        }

        private void swb_UcShowAllContractByContractEnable_ValueChanged(object sender, EventArgs e)
        {
            if(swb_UcShowAllContractByContractEnable.Value == false)
            {
                rdb_UcShowAllContractEnding.IsChecked = false;
                rdb_UcShowAllContractAllContarct.IsChecked = false;
                rdb_UcShowAllContractEnded.IsChecked = false;
                rdb_UcShowAllContractTodayExpired.IsChecked = false;
                rdb_UcShowAllContractActiveContract.IsChecked = false;
                rdb_UcShowAllContractAllContarct.Enabled = false;
                rdb_UcShowAllContractEnded.Enabled = false;
                rdb_UcShowAllContractEnding.Enabled = false;
                rdb_UcShowAllContractTodayExpired.Enabled = false;
                rdb_UcShowAllContractActiveContract.Enabled = false;
                lbl_UcShowAllContractDateFrom.Enabled = true;
                dts_UcShowAllContractDateSelectorFrom.Enabled = true;
                lbl_UcShowAllContractDateUntil.Enabled = true;
                dts_UcShowAllContractDateSelectorUntil.Enabled = true;
                lbl_UcShowAllContractName.Enabled = true;
                txb_UcShowAllContractName.Enabled = true;

            }
            else
            {
                endDate1 = "";
                endDate2 = "";
                Name = "";
                
                lbl_UcShowAllContractDateFrom.Enabled = false;
                dts_UcShowAllContractDateSelectorFrom.Enabled = false;
                lbl_UcShowAllContractDateUntil.Enabled = false;
                dts_UcShowAllContractDateSelectorUntil.Enabled = false;
                lbl_UcShowAllContractName.Enabled = false;
                txb_UcShowAllContractName.Enabled = false;
                rdb_UcShowAllContractAllContarct.Enabled = true;
                rdb_UcShowAllContractEnded.Enabled = true;
                rdb_UcShowAllContractEnding.Enabled = true;
                rdb_UcShowAllContractTodayExpired.Enabled = true;
                rdb_UcShowAllContractActiveContract.Enabled = true;


            }
        }

        private void rdb_UcShowAllContractActiveContract_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (rdb_UcShowAllContractActiveContract.IsChecked)
            {
                rdb_UcShowAllContractEnded.IsChecked = false;
                rdb_UcShowAllContractEnding.IsChecked = false;
                rdb_UcShowAllContractTodayExpired.IsChecked = false;
                rdb_UcShowAllContractAllContarct.IsChecked = false;
            }
        }
    }
}

