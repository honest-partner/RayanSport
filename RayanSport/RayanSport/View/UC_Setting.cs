using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Globalization;

namespace RayanSport.View
{
    public partial class UC_Setting : UserControl
    {

        public string username;
        public string oldPassword;
        public string newPassword;
        public string confirmPassword;
        public string hashNewPassword;
        public string log_username;
        public string date;
        public string time;
        public string targetTable;       
       
        public long id;
        public UC_Setting()
        {
            InitializeComponent();
            //username = user;
        }

        private void btn_UcSettingConfirm_Click(object sender, EventArgs e)
        {
            date = getDateShamsi(DateTime.Now.ToString("M/d/yyyy"));
            time = DateTime.Now.ToShortTimeString().ToString();
            targetTable = "log";


            rayan_sportDataSet.logDataTable logDataTable = new rayan_sportDataSet.logDataTable();
            rayan_sportDataSetTableAdapters.logTableAdapter logTableAdapter = new rayan_sportDataSetTableAdapters.logTableAdapter();
            logTableAdapter.InsertChengePassLog("Chenge Pass From"+ oldPassword +"To"+ newPassword , targetTable , username , date ,time );
          





            oldPassword = txb_UcSettingOldPass.Text;
            newPassword = txb_UcSettingnewPass.Text;
            confirmPassword = txb_UcSettingrepeatPass.Text;

            if (txb_UcSettingOldPass.Text == "" || txb_UcSettingnewPass.Text == "" || txb_UcSettingrepeatPass.Text == "")
            {

                Alert alert2 = new Alert("اطلاعات را به صورت کامل وارد کنید ", "red");
            }
            else if (txb_UcSettingOldPass.Text != "" && txb_UcSettingnewPass.Text != "" && txb_UcSettingrepeatPass.Text != "")
            {
                oldPassword = txb_UcSettingOldPass.Text;
                newPassword = txb_UcSettingnewPass.Text;
                confirmPassword = txb_UcSettingrepeatPass.Text;


                oldPassword = hashPass(oldPassword);
                hashNewPassword = hashPass(newPassword);



                rayan_sportDataSet.userDataTable dataTable = new rayan_sportDataSet.userDataTable();
                rayan_sportDataSetTableAdapters.userTableAdapter adapter = new rayan_sportDataSetTableAdapters.userTableAdapter();
                adapter.UpdatePassword(newPassword, hashNewPassword, oldPassword);

                Alert alert = new Alert("گذرواژه با موفقیت تغییر یافت", "blue");



                



                //SqlConnection conn = new SqlConnection("Data Source = 169.254.92.252; " +
                //                                           "Initial Catalog=rayan_Attendance;" +
                //                                           "User id=test; " +
                //                                           "Password=HoseinNima1234;");

                //conn.Open();
                //SqlCommand sc = new SqlCommand();
                //sc.CommandType = CommandType.Text;
                //sc.Connection = conn;
                //SqlDataReader reader;

                //SqlTransaction transaction;
                //transaction = conn.BeginTransaction("new");
                //sc.Transaction = transaction;


                //try
                //{

                //    sc.CommandText = "SELECT id FROM Users WHERE username = '" + username + "' AND password = '" + oldPassword + "'";

                //    sc.ExecuteNonQuery();
                //    reader = sc.ExecuteReader();
                //    if (reader.HasRows)
                //    {
                //        reader.Read();
                //        id = reader.GetInt64(0);
                //    }
                //    reader.Close();
                //    if (newPassword == confirmPassword)
                //    {
                //        sc.CommandText = "UPDATE Users  SET password = '" + hashNewPassword + "'";
                //        sc.ExecuteNonQuery();
                //        MessageBox.Show("تغییر گذرواژه انجام شد");
                //    }
                //    else
                //    {
                //        MessageBox.Show("گذرواژه و تایید گذرواژه یکسان نیست");
                //    }


                //    transaction.Commit();


                //}

                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
        }
        
        
        

            public string hashPass(string password2)
        {
            string password = password2;

            // byte array representation of that string
            byte[] encodedPassword = new UTF8Encoding().GetBytes(password);

            // need MD5 to calculate the hash
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

            // string representation (similar to UNIX format)
            string encoded = BitConverter.ToString(hash)
               // without dashes
               .Replace("0", string.Empty).Replace("-", string.Empty)
               // make lowercase
               .ToLower();

            return encoded;
        }

        private void btn_UcSettingClear_Click(object sender, EventArgs e)
        {
            txb_UcSettingnewPass.Clear();
            txb_UcSettingOldPass.Clear();
            txb_UcSettingrepeatPass.Clear();
        }

        public string getDateShamsi(string date)
        {


            DateTime d = DateTime.Parse(date);
            PersianCalendar pc = new PersianCalendar();
            return string.Format("{0}/{1:00}/{2:00}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d));//---> miladi to shamsi*/

        }



        //public string getDateHijri2(string date)
        //{


        //    DateTime d = DateTime.Parse(date);
        //    PersianCalendar pc = new PersianCalendar();
        //    string longDate = string.Format("{0}/{1:00}/{2:00}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfMonth(d));//---> miladi to shamsi*/
        //    longDate = longDate + "  " + DateTime.Now.ToLongTimeString();
        //    return longDate;

        //}


    }
    }

