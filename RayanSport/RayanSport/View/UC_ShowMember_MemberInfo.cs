﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.IO;

namespace RayanSport.View
{
    public partial class UC_ShowMember_MemberInfo : UserControl
    {
        Member member;

        #region constructors

        public UC_ShowMember_MemberInfo()
        {
            InitializeComponent();
            pbx_UcShowMemberMemberInfoMemberPicture.SizeMode = PictureBoxSizeMode.Zoom;
            btn_UcShowMemberMemberInfoChangeMember.Enabled = false;
            btn_UcShowMemberMemberInfoDeleteMember.Enabled = false;
            btn_UcShowMemberMemberInfoAddMember.Enabled = true;
        }
        
        public int UC_ShowMember_MemberInfoCon(Member member2)
        {
            if (member2.member_name != null)
            {
                member = member2;

                string path;
                path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\member_image\";
                if (File.Exists(path + member.member_id + ".Jpeg"))
                {
                    pbx_UcShowMemberMemberInfoMemberPicture.Image = Image.FromFile(path + member.member_id + ".Jpeg");  
                    btn_UcShowMemberMemberInfoMemberAddPicture.Text = "تغییر عکس";
                }
                pbx_UcShowMemberMemberInfoMemberPicture.SizeMode = PictureBoxSizeMode.Zoom;


                txb_UcShowMemberMemberInfoMemberId.Text = member.member_id.ToString();
                txb_UcShowMemberMemberInfoMemberName.Text = member.member_name;
                txb_UcShowMemberMemberInfoMemberNationalCode.Text = member.member_nationalCode;
                txb_UcShowMemberMemberInfoMemberAddress.Text = member.member_address;
                txb_UcShowMemberMemberInfoMemberSick.Text = member.member_sick;
                txb_UcShowMemberMemberInfoMemberTel.Text = member.member_tel;
                cmb_UcShowMemberMemberInfoMemberGender.Text = member.member_gender;
                cmb_UcShowMemberMemberInfoMemberBlood.Text = member.member_blood;

                btn_UcShowMemberMemberInfoAddMember.Enabled = false;
                btn_UcShowMemberMemberInfoChangeMember.Enabled = true;
                btn_UcShowMemberMemberInfoDeleteMember.Enabled = true;
            }
            return 1;
        }
        //public UC_ShowMember_MemberInfoConstructor()
        //{
        //    pbx_UcShowMemberMemberInfoMemberPicture.SizeMode = PictureBoxSizeMode.Zoom;
        //}
        #endregion

        #region enter and leave focus * textBoxes
        private void txb_UcShowMemberMemberInfoMemberName_Enter(object sender, EventArgs e)
        {
            txb_UcShowMemberMemberInfoMemberName.BackColor = SystemColors.Window;
        }

        private void txb_UcShowMemberMemberInfoMemberName_Leave(object sender, EventArgs e)
        {
            if (txb_UcShowMemberMemberInfoMemberName.Text == "")
                txb_UcShowMemberMemberInfoMemberName.BackColor = Color.MistyRose;
        }

        private void cmb_UcShowMemberMemberInfoMemberGender_Enter(object sender, EventArgs e)
        {
            cmb_UcShowMemberMemberInfoMemberGender.BackColor = SystemColors.Window;
        }

        private void cmb_UcShowMemberMemberInfoMemberGender_Leave(object sender, EventArgs e)
        {
            if (cmb_UcShowMemberMemberInfoMemberGender.Text == "")
                cmb_UcShowMemberMemberInfoMemberGender.BackColor = Color.MistyRose;
        }
        #endregion

        #region button clicks
        private void btn_UcShowMemberMemberInfoMemberAddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbx_UcShowMemberMemberInfoMemberPicture.Image = new Bitmap(open.FileName);
                pbx_UcShowMemberMemberInfoMemberPicture.SizeMode = PictureBoxSizeMode.Zoom;
                btn_UcShowMemberMemberInfoMemberAddPicture.Text = "تغییر عکس";
            }
        }

        private void btn_UcShowMemberMemberInfoAddMember_Click(object sender, EventArgs e)
        {
            if (txb_UcShowMemberMemberInfoMemberName.Text == "")
            {
                Alert alert = new Alert("نام و نام خانوادگی ورزشکار را وارد کنید", "darkred");
                txb_UcShowMemberMemberInfoMemberName.BackColor = Color.MistyRose;
            }
            else if (cmb_UcShowMemberMemberInfoMemberGender.Text == "")
            {
                Alert alert = new Alert("جنسیت ورزشکار را وارد کنید", "darkred");
                cmb_UcShowMemberMemberInfoMemberGender.BackColor = Color.MistyRose;

            }
            else
            {
                try
                {
                    rayan_sportDataSetTableAdapters.memberTableAdapter memberTableAdapter = new rayan_sportDataSetTableAdapters.memberTableAdapter();
                    rayan_sportDataSetTableAdapters.logTableAdapter logTableAdapter = new rayan_sportDataSetTableAdapters.logTableAdapter();

                    int addMemberWorks = memberTableAdapter.Insert(txb_UcShowMemberMemberInfoMemberName.Text, txb_UcShowMemberMemberInfoMemberNationalCode.Text,
                             txb_UcShowMemberMemberInfoMemberTel.Text, null, cmb_UcShowMemberMemberInfoMemberGender.Text, cmb_UcShowMemberMemberInfoMemberBlood.Text,
                             txb_UcShowMemberMemberInfoMemberSick.Text, txb_UcShowMemberMemberInfoMemberAddress.Text, null);
                    if (addMemberWorks == 1)
                    {
                        logTableAdapter.Insert("افزودن ورزشکار با نام " + txb_UcShowMemberMemberInfoMemberName.Text + "", "member", "admin", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());

                        txb_UcShowMemberMemberInfoMemberId.Text = Convert.ToString(memberTableAdapter.getMemberIdQuery(txb_UcShowMemberMemberInfoMemberName.Text, txb_UcShowMemberMemberInfoMemberNationalCode.Text,
                                txb_UcShowMemberMemberInfoMemberTel.Text, cmb_UcShowMemberMemberInfoMemberGender.Text, cmb_UcShowMemberMemberInfoMemberBlood.Text,
                                txb_UcShowMemberMemberInfoMemberSick.Text, txb_UcShowMemberMemberInfoMemberAddress.Text));

                        string path;
                        path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\member_image\";
                        if (btn_UcShowMemberMemberInfoMemberAddPicture.Text != "افزودن عکس")
                        {
                            pbx_UcShowMemberMemberInfoMemberPicture.Image.Save(path + txb_UcShowMemberMemberInfoMemberId.Text + ".Jpeg", ImageFormat.Jpeg);
                        }
                        member = new Member();
                        member.member_id = int.Parse(txb_UcShowMemberMemberInfoMemberId.Text);
                        member.member_name = txb_UcShowMemberMemberInfoMemberName.Text;
                        member.member_nationalCode = txb_UcShowMemberMemberInfoMemberNationalCode.Text;
                        member.member_address = txb_UcShowMemberMemberInfoMemberAddress.Text;
                        member.member_sick = txb_UcShowMemberMemberInfoMemberSick.Text;
                        member.member_tel = txb_UcShowMemberMemberInfoMemberTel.Text;
                        member.member_gender = cmb_UcShowMemberMemberInfoMemberGender.Text;
                        member.member_blood = cmb_UcShowMemberMemberInfoMemberBlood.Text;

                        btn_UcShowMemberMemberInfoAddMember.Enabled = false;
                        btn_UcShowMemberMemberInfoChangeMember.Enabled = true;
                        btn_UcShowMemberMemberInfoDeleteMember.Enabled = true;

                        FormCollection fc = Application.OpenForms;
                        foreach (Form frm in fc)
                        {
                            if (frm is Form_ShowMember)
                            {
                                (frm as Form_ShowMember).changeContractEnabled(true,member);
                            }
                        }
                        Alert alert = new Alert("ورزشکار جدید با کد عضویت " + txb_UcShowMemberMemberInfoMemberId.Text + " افزوده شد", "green");
                    }
                }
                catch (Exception)
                {
                    Alert alert = new Alert("خطا در افزودن ورزشکار", "darkred");
                }
            }
        }
    

        private void btn_UcShowMemberMemberInfoChangeMember_Click(object sender, EventArgs e)
        {
            if (txb_UcShowMemberMemberInfoMemberName.Text == "")
            {
                Alert alert = new Alert("نام و نام خانوادگی ورزشکار را وارد کنید", "darkred");
                txb_UcShowMemberMemberInfoMemberName.BackColor = Color.MistyRose;
            }
            else if (cmb_UcShowMemberMemberInfoMemberGender.Text == "")
            {
                Alert alert = new Alert("جنسیت ورزشکار را وارد کنید", "darkred");
                cmb_UcShowMemberMemberInfoMemberGender.BackColor = Color.MistyRose;

            }
            else
            {
                try
                {
                    rayan_sportDataSetTableAdapters.memberTableAdapter memberTableAdapter = new rayan_sportDataSetTableAdapters.memberTableAdapter();
                    rayan_sportDataSetTableAdapters.logTableAdapter logTableAdapter = new rayan_sportDataSetTableAdapters.logTableAdapter();
                    rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter = new rayan_sportDataSetTableAdapters.membershipTableAdapter();

                    memberTableAdapter.UpdateMember(txb_UcShowMemberMemberInfoMemberName.Text, txb_UcShowMemberMemberInfoMemberNationalCode.Text,
                            txb_UcShowMemberMemberInfoMemberTel.Text, cmb_UcShowMemberMemberInfoMemberGender.Text, cmb_UcShowMemberMemberInfoMemberBlood.Text,
                            txb_UcShowMemberMemberInfoMemberSick.Text, txb_UcShowMemberMemberInfoMemberAddress.Text,int.Parse(txb_UcShowMemberMemberInfoMemberId.Text));

                    membershipTableAdapter.UpdateMemberNameByMemberIdInMembership(txb_UcShowMemberMemberInfoMemberName.Text, int.Parse(txb_UcShowMemberMemberInfoMemberId.Text));

                    logTableAdapter.Insert("تغییر ورزشکار با نام " + txb_UcShowMemberMemberInfoMemberName.Text + "", "member", "admin", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());

                    string path;
                    path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\member_image\";
                    if (btn_UcShowMemberMemberInfoMemberAddPicture.Text != "افزودن عکس")
                    {
                        pbx_UcShowMemberMemberInfoMemberPicture.Image.Save(path + txb_UcShowMemberMemberInfoMemberId.Text + ".Jpeg", ImageFormat.Jpeg);
                    }
                    Alert alert = new Alert("اطلاعات ورزشکار با کد عضویت " + txb_UcShowMemberMemberInfoMemberId.Text + " تغییر یافت", "green");
                }
                catch (Exception)
                {
                    Alert alert = new Alert("خطا در تغییر اطلاعات ورزشکار", "darkred");
                }
            }
        }

        private void btn_UcShowMemberMemberInfoDeleteMember_Click(object sender, EventArgs e)
        {
            try
            {
                rayan_sportDataSetTableAdapters.memberTableAdapter memberTableAdapter = new rayan_sportDataSetTableAdapters.memberTableAdapter();
                rayan_sportDataSetTableAdapters.logTableAdapter logTableAdapter = new rayan_sportDataSetTableAdapters.logTableAdapter();

                memberTableAdapter.DeleteQuery(int.Parse(txb_UcShowMemberMemberInfoMemberId.Text));

                logTableAdapter.Insert("حذف ورزشکار با نام " + member.member_name + "", "member", "admin", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());

                string path;
                path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\member_image\";
                if (File.Exists(path+txb_UcShowMemberMemberInfoMemberId.Text+".Jpeg"))
                {
                    File.GetAccessControl(path + txb_UcShowMemberMemberInfoMemberId.Text + ".Jpeg");
                    File.Delete(path + txb_UcShowMemberMemberInfoMemberId.Text + ".Jpeg");
                }

                Alert alert = new Alert("اطلاعات ورزشکار با کد عضویت " + txb_UcShowMemberMemberInfoMemberId.Text + "حذف شد", "green");
                btn_UcShowMemberMemberInfoClear.PerformClick();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                Alert alert = new Alert("خطا در افزودن ورزشکار", "darkred");
            }
        }

        private void btn_UcShowMemberMemberInfoClear_Click(object sender, EventArgs e)
        {
            member = new Member();
            txb_UcShowMemberMemberInfoMemberId.Text = "";
            txb_UcShowMemberMemberInfoMemberName.Text = "";
            txb_UcShowMemberMemberInfoMemberNationalCode.Text = "";
            txb_UcShowMemberMemberInfoMemberAddress.Text = "";
            txb_UcShowMemberMemberInfoMemberSick.Text = "";
            txb_UcShowMemberMemberInfoMemberTel.Text = "";
            cmb_UcShowMemberMemberInfoMemberGender.SelectedIndex = -1;
            cmb_UcShowMemberMemberInfoMemberBlood.SelectedIndex = -1;

            pbx_UcShowMemberMemberInfoMemberPicture.Image = RayanSport.Properties.Resources.no_image;
            btn_UcShowMemberMemberInfoMemberAddPicture.Text = "افزودن عکس";

            btn_UcShowMemberMemberInfoDeleteMember.Enabled = false;
            btn_UcShowMemberMemberInfoChangeMember.Enabled = false;
            btn_UcShowMemberMemberInfoAddMember.Enabled = true;
        }

        #endregion


    }
}
