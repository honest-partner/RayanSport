using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayanSport.View
{
    public partial class UC_ShowMember_ContractInfo : UserControl
    {
        Member member;
        List<TrainOption> train_list;
        public UC_ShowMember_ContractInfo(Member member)
        {
            this.member = member;
            InitializeComponent();
        }

        rayan_sportDataSet.membershipDataTable membershipDataTable = new rayan_sportDataSet.membershipDataTable();
        rayan_sportDataSetTableAdapters.membershipTableAdapter tableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
        private void UC_ShowMember_ContractInfo_Load(object sender, EventArgs e)
        {
            rayan_sportDataSet.membershipDataTable membershipDataTable = new rayan_sportDataSet.membershipDataTable();
            rayan_sportDataSetTableAdapters.membershipTableAdapter tableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();
            tableAdapter.FillBySelectById(membershipDataTable,100);
            dgv_UcShowMemberContractInfoContracts.DataSource=membershipDataTable;
        }

        private void dgv_UcShowMemberContractInfoContracts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            changeButtonsEnabled(true);

        }

        private void changeButtonsEnabled(bool state)
        {
            
            btn_UcShowMemberContractInfoDeleteContract.Enabled = state;
            btn_UcShowMemberContractInfoExpireContract.Enabled = state;
        }

        private void btn_UcShowMemberContractInfoAddContract_Click(object sender, EventArgs e)
        {
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
        }

        private void cmb_UcShowMemberContractInfoContractType_SelectedValueChanged(object sender, EventArgs e)
        {
            rayan_sportDataSet.trainOptionDataTable trainOptionDataTable = new rayan_sportDataSet.trainOptionDataTable();
            rayan_sportDataSetTableAdapters.trainOptionTableAdapter trainOptionTableAdapter = new rayan_sportDataSetTableAdapters.trainOptionTableAdapter();
            int row = trainOptionTableAdapter.FillBygetPriceByName(trainOptionDataTable,cmb_UcShowMemberContractInfoContractType.Text);
            if (row == 1)
                txb_UcShowMemberContractInfoExpireContractPrice.Text = trainOptionDataTable[0].trainOption_price+""; 
        }
    }
}
