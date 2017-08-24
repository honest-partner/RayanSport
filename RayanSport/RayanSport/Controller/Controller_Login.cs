using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayanSport.Controller
{
    class Controller_Login
    {
        #region focus in and out
        public void textFocusIn(Telerik.WinControls.UI.RadTextBoxControl textBox, string text)
        {
            if (textBox.Text == text)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
        public void textFocusOut(Telerik.WinControls.UI.RadTextBoxControl textBox, string text)
        {
            if (textBox.Text == "")
            {
                textBox.Text = text;
                textBox.ForeColor = Color.Gray;
            }
        }
        public void passwordFocusIn(Telerik.WinControls.UI.RadTextBoxControl textBox, string text)
        {
            if (textBox.Text == text)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                textBox.PasswordChar = '•';
            }
        }

        public void passwordFocusOut(Telerik.WinControls.UI.RadTextBoxControl textBox, string text)
        {
            if (textBox.Text == "")
            {
                textBox.PasswordChar = '\0';
                textBox.Text = text;
                textBox.ForeColor = Color.Gray;
            }
        }
        #endregion

        #region authenticator
        public User authenticator (string username , string password)
        {
            User user = new User("","","",false,"");

            SqlConnection conn = new SqlConnection();
            SqlCommand sc = new SqlCommand();
           
            conn.ConnectionString = "Data Source= 169.254.92.252;" +
            "Initial Catalog=rayan_sport;" +
            "User id=test; " +
            "Password=HoseinNima1234;";
            sc.Connection = conn;
            SqlDataReader reader;
            sc.CommandText = "SELECT * FROM userTable WHERE user_username = '" + username + "' AND user_password = '" + password + "'";
            sc.CommandType = CommandType.Text;
            sc.Connection = conn;
            conn.Open();
            reader = sc.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                user.user_username = reader["user_username"].ToString();
                user.user_password = reader["user_password"].ToString();
                user.user_name = reader["user_name"].ToString();
                user.user_gender = reader["user_gender"].ToString();
                user.user_isAdmin = bool.Parse(reader["user_isAdmin"].ToString());
                MessageBox.Show("yes");
                return user;
            }
            else
            {
                MessageBox.Show("no");
                return null;
            }
        }
        #endregion
    }
}
