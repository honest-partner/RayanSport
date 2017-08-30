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
    public partial class UC_ShowMember_ContractInfo : UserControl
    {
        long currnet_membership_id;
        Member member;
        List<TrainOption> train_list;
        public UC_ShowMember_ContractInfo() {
            InitializeComponent();
        }
        public Member Member { get; set; }
        

        rayan_sportDataSet.membershipDataTable membershipDataTable = new rayan_sportDataSet.membershipDataTable();
        rayan_sportDataSetTableAdapters.membershipTableAdapter tableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
        private void UC_ShowMember_ContractInfo_Load(object sender, EventArgs e)
        {
            rayan_sportDataSet.membershipDataTable membershipDataTable = new rayan_sportDataSet.membershipDataTable();
            rayan_sportDataSetTableAdapters.membershipTableAdapter tableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
            tableAdapter.FillBySelectById(membershipDataTable,100);
            dgv_UcShowMemberContractInfoContracts.DataSource=membershipDataTable;
            btn_UcShowMemberContractInfoDeleteContract.Enabled = false;
            btn_UcShowMemberContractInfoExpireContract.Enabled = false;
            btn_UcShowMemberContractInfoAddContract.Enabled = true;
            tableLayoutPanel3.Enabled = false;
            
        }

        

        private void dgv_UcShowMemberContractInfoContracts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //var cellindex = dgv_UcShowMemberContractInfoContracts.SelectedCells[0].RowIndex;
            //var cellcollection = dgv_UcShowMemberContractInfoContracts.Rows[cellindex].Cells[0];
            
        }

        private void btn_UcShowMemberContractInfoAddContract_Click(object sender, EventArgs e)
        {
            btn_UcShowMemberContractInfoDeleteContract.Enabled = false;
            btn_UcShowMemberContractInfoExpireContract.Enabled = false;
            tableLayoutPanel3.Enabled = true;
            txb_UcShowMemberContractInfoRemainingSession.Enabled = false;
            train_list = new List<TrainOption>();
            List<String> train_names = new List<string>();
            rayan_sportDataSet.trainOptionDataTable trainOptionDataTable = new rayan_sportDataSet.trainOptionDataTable();
            rayan_sportDataSetTableAdapters.trainOptionTableAdapter trainOptionTableAdapter = new rayan_sportDataSetTableAdapters.trainOptionTableAdapter();
            trainOptionTableAdapter.Fill(trainOptionDataTable);
            foreach (rayan_sportDataSet.trainOptionRow nem in trainOptionDataTable)
            {
                train_list.Add(new TrainOption(nem.trainOption_name,nem.trainOption_price,nem.trainOption_id));
            }
            foreach (TrainOption train in train_list)
            {
                train_names.Add(train.trainOption_name);
            }
            cmb_UcShowMemberContractInfoContractType.DataSource = train_names;
            
            
            
            cmb_UcShowMemberContractInfoExpireContractPaymentType.SelectedIndex = 0;
        }

        private void cmb_UcShowMemberContractInfoContractType_SelectedValueChanged(object sender, EventArgs e)
        {
            rayan_sportDataSet.trainOptionDataTable trainOptionDataTable = new rayan_sportDataSet.trainOptionDataTable();
            rayan_sportDataSetTableAdapters.trainOptionTableAdapter trainOptionTableAdapter = new rayan_sportDataSetTableAdapters.trainOptionTableAdapter();
            int row = trainOptionTableAdapter.FillBygetPriceByName(trainOptionDataTable,cmb_UcShowMemberContractInfoContractType.Text);
            if (row == 1) {
                txb_UcShowMemberContractInfoExpireContractPrice.Text = trainOptionDataTable[0].trainOption_price + "";
                txb_UcShowMemberContractInfoPayment.Text = trainOptionDataTable[0].trainOption_price + "";
            }
            if (cmb_UcShowMemberContractInfoContractType.SelectedIndex == 0 || cmb_UcShowMemberContractInfoContractType.SelectedIndex == 1)
                txb_UcShowMemberContractInfoRemainingSession.Text = 31 + "";
            else
                txb_UcShowMemberContractInfoRemainingSession.Text = 16 + "";
        }

        private void txb_UcShowMemberContractInfoExpireContractPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void cmb_UcShowMemberContractInfoExpireContractPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_UcShowMemberContractInfoExpireContractPaymentType.Text.Equals("نقد"))
                txb_UcShowMemberContractInfoReciptNum.Enabled = false;
            else if(cmb_UcShowMemberContractInfoExpireContractPaymentType.Text.Equals("کارت"))
                txb_UcShowMemberContractInfoReciptNum.Enabled = true;
        }

        private void dts_UcShowMemberContractInfoStartDate_DropDownClosed(object sender, EventArgs e)
        {
            //string date = dts_UcShowMemberContractInfoStartDate.Value.Value.ToString("M/d/yyy");
            //string date = dts_UcShowMemberContractInfoStartDate.Value.Value.ToString("M/d/yyyy");
            //MessageBox.Show(date+"");
        }
        public string getDateHijri(string date)
        {


            DateTime d = DateTime.Parse(date);
            PersianCalendar pc = new PersianCalendar();
            return string.Format("{0}/{1:00}/{2:00}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d));//---> miladi to shamsi*/


        }

        private void dts_UcShowMemberContractInfoStartDate_ValueChanged(object sender, EventArgs e)
        {
            try {
                string date = dts_UcShowMemberContractInfoStartDate.Value.Value.ToString("M/d/yyyy");
                date = getDateHijri(date);
                string[] dates = new string[3];
                int year, month, day;
                string  month1, day1;

                dates = date.Split('/');
                year = Convert.ToInt32(dates[0]);
                month = Convert.ToInt32(dates[1]);
                day = Convert.ToInt32(dates[2]);
                if (month == 12)
                {
                    year++;
                    month = 1;
                }
                else
                {
                    month++;
                }
                date = year + "/";
                if (month < 10)
                {
                    date = date +"0" + month;
                }
                else {
                    date = date + month+"/";
                }
                if (day < 10)
                {
                    date = date + "0"+day;
                }
                else {
                    date = date + day;
                }

                
                
                txb_UcShowMemberContractInfoEndDate.Text = date;
            }
            catch (Exception ex) { }


                
            
        }

        private void btn_UcShowMemberContractInfoExpireContract_Click(object sender, EventArgs e)
        {
            try {
                rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
                membershipTableAdapter.UpdateStatusById("غیر فعال", currnet_membership_id, currnet_membership_id);
                MessageBox.Show("قرارداد با موفقیت غیرفعال شد");
                FillData();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_UcShowMemberContractInfoClear_Click(object sender, EventArgs e)
        {
            btn_UcShowMemberContractInfoDeleteContract.Enabled = true;
            btn_UcShowMemberContractInfoExpireContract.Enabled = true;
            btn_UcShowMemberContractInfoAddContract.Enabled = true;
            foreach (var txb in tableLayoutPanel3.Controls)
            {
                if (txb is TextBox)
                    (txb as TextBox).Clear();
                if (txb is ComboBox)
                    (txb as ComboBox).Text = "";
            }
            dts_UcShowMemberContractInfoStartDate.ResetText();
            
            tableLayoutPanel3.Enabled = false;
        }

        private void btn_UcShowMemberContractInfoSave_Click(object sender, EventArgs e)
        {
            long? reciptnum;
            if (cmb_UcShowMemberContractInfoExpireContractPaymentType.Text.Equals(""))
            {
                MessageBox.Show("نوع پرداخت را وارد نمایید");
                cmb_UcShowMemberContractInfoExpireContractPaymentType.Focus();
            } else{
                try {
                    string startDate = dts_UcShowMemberContractInfoStartDate.Value.Value.ToString("M/d/yyyy");
                    startDate = getDateHijri(startDate);
                    
                    if (cmb_UcShowMemberContractInfoExpireContractPaymentType.Text.Equals("نقد"))
                        reciptnum = null;
                    else
                        reciptnum = Convert.ToInt64(txb_UcShowMemberContractInfoReciptNum.Text);
                    rayan_sportDataSet.membershipDataTable memberShipDataTable = new rayan_sportDataSet.membershipDataTable();
                    rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
                    int sucsses = membershipTableAdapter.Insert(member.member_id, member.member_name, startDate, txb_UcShowMemberContractInfoEndDate.Text, cmb_UcShowMemberContractInfoContractType.Text, Convert.ToInt32(txb_UcShowMemberContractInfoRemainingSession.Text),
                        reciptnum, cmb_UcShowMemberContractInfoExpireContractPaymentType.Text, Convert.ToInt64(txb_UcShowMemberContractInfoExpireContractPrice.Text),
                        Convert.ToInt64(txb_UcShowMemberContractInfoPayment.Text), txb_UcShowMemberContractInfoDes.Text, "فعال"
                        );
                    if (sucsses == 1)
                    {
                        MessageBox.Show("قرارداد با موفقیت اضافه شد");
                        FillData();
                    }
                }
                catch (Exception ex) {
                    //MessageBox.Show("تاریخ شروع قرارداد را وارد نمایید");
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

           
            

        }

        private void FillData()
        {
            rayan_sportDataSet.membershipDataTable membershipDatatable = new rayan_sportDataSet.membershipDataTable();
            rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
           membershipTableAdapter.FillBySelectById(membershipDatatable,member.member_id);
            dgv_UcShowMemberContractInfoContracts.DataSource = membershipDatatable;
        }

        private void btn_UcShowMemberContractInfoDeleteContract_Click(object sender, EventArgs e)
        {
            rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
            int sucsses = membershipTableAdapter.DeleteById(currnet_membership_id);
            if (sucsses == 1) {
                MessageBox.Show("حذف با موفقیت انجام شد");
                FillData();
            }
        }

        private void dgv_UcShowMemberContractInfoContracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currnet_membership_id = Convert.ToInt64(dgv_UcShowMemberContractInfoContracts.Rows[e.RowIndex].Cells["membership_id"].Value.ToString());
            btn_UcShowMemberContractInfoDeleteContract.Enabled = true;
            btn_UcShowMemberContractInfoExpireContract.Enabled = true;
            btn_UcShowMemberContractInfoAddContract.Enabled = true;
            foreach (var txb in tableLayoutPanel3.Controls)
            {
                if (txb is TextBox)
                    (txb as TextBox).Clear();
                if (txb is ComboBox)
                    (txb as ComboBox).Text = "";
            }
            dts_UcShowMemberContractInfoStartDate.ResetText();
            tableLayoutPanel3.Enabled = false;
        }
    }
}
