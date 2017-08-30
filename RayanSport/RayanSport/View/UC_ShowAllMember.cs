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
    public partial class UC_ShowAllMember : UserControl
    {
        Member member = new Member();
        bool form_MemberIsOpen = false;
        public UC_ShowAllMember()
        {
            InitializeComponent();
        
            rayan_sportDataSet.memberDataTable memberDataTable = new rayan_sportDataSet.memberDataTable();
            rayan_sportDataSetTableAdapters.memberTableAdapter memberTableAdapter = new rayan_sportDataSetTableAdapters.memberTableAdapter();
            memberTableAdapter.Fill(memberDataTable);
            dgv_UcShowAllMemberShowDgv.DataSource = memberDataTable;
            dgv_UcShowAllMemberShowDgv.Columns["member_blood"].IsVisible = false;
            dgv_UcShowAllMemberShowDgv.Columns["member_sick"].IsVisible = false;
            dgv_UcShowAllMemberShowDgv.Columns["member_image"].IsVisible = false;
            dgv_UcShowAllMemberShowDgv.Columns["member_address"].IsVisible = false;
            dgv_UcShowAllMemberShowDgv.Columns["member_nationalCode"].IsVisible = false;
            dgv_UcShowAllMemberShowDgv.Columns["member_charge"].IsVisible = false;

        }

        private void dgv_UcShowAllMemberShowDgv_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                member.member_id = int.Parse(dgv_UcShowAllMemberShowDgv.Rows[e.RowIndex].Cells["member_id"].Value.ToString());
                member.member_nationalCode = dgv_UcShowAllMemberShowDgv.Rows[e.RowIndex].Cells["member_nationalCode"].Value.ToString();
                member.member_name = dgv_UcShowAllMemberShowDgv.Rows[e.RowIndex].Cells["member_name"].Value.ToString();
                member.member_gender = dgv_UcShowAllMemberShowDgv.Rows[e.RowIndex].Cells["member_gender"].Value.ToString();
                member.member_tel = dgv_UcShowAllMemberShowDgv.Rows[e.RowIndex].Cells["member_tel"].Value.ToString();
                member.member_sick = dgv_UcShowAllMemberShowDgv.Rows[e.RowIndex].Cells["member_sick"].Value.ToString();
                member.member_blood = dgv_UcShowAllMemberShowDgv.Rows[e.RowIndex].Cells["member_blood"].Value.ToString();
                member.member_address = dgv_UcShowAllMemberShowDgv.Rows[e.RowIndex].Cells["member_address"].Value.ToString();
                //member.member_charge = long.Parse(dgv_UcShowAllMemberShowDgv.Rows[e.RowIndex].Cells["member_charge"].Value.ToString());
            }
        }

        private void btn_UcShowAllMemberAddMember_Click(object sender, EventArgs e)
        {
            Member member2 = new Member();
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if(frm is Form_ShowMember)
                {
                    form_MemberIsOpen = true;
                    int jooo = (frm as Form_ShowMember).setDataForUcShowMemberInfo(member2);
                   // (frm as Form_ShowMember).WindowState = FormWindowState.Minimized;
                    (frm as Form_ShowMember).Hide();
                    (frm as Form_ShowMember).Show();
                    //(frm as Form_ShowMember).WindowState = FormWindowState.Normal;
                    //MessageBox.Show(jooo+ "");
                }
                else
                {
                    form_MemberIsOpen = false;
                }
            }

            if (form_MemberIsOpen == false)
            {
                Form_ShowMember form_showMember = new Form_ShowMember();
                form_showMember.Show();
            }
            
        }

        private void btn_UcShowAllMemberSearch_Click(object sender, EventArgs e)
        {

        }

        private void btn_UcShowAllMemberShowMemberInfo_Click(object sender, EventArgs e)
        {
            if (member.member_name != null)
            {
                FormCollection fc = Application.OpenForms;
                foreach (Form frm in fc)
                {
                    if (frm is Form_ShowMember)
                    {
                        form_MemberIsOpen = true;
                        int jooo = (frm as Form_ShowMember).setDataForUcShowMemberInfo(member);
                        (frm as Form_ShowMember).Hide();
                        (frm as Form_ShowMember).Show();

                    }
                    else
                    {
                        form_MemberIsOpen = false;
                    }
                }

                if (form_MemberIsOpen == false)
                {
                    Form_ShowMember form_showMember = new Form_ShowMember();
                    form_showMember.setDataForUcShowMemberInfo(member);
                    form_showMember.Show();
                }
            }
        }
    }
}