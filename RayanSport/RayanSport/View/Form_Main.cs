using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayanSport
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string context = "نام کاربری یا رمز عبور اشتباه است";
            Alert alert = new Alert(context, "darkred", 5);
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
         
        }
    }
}
