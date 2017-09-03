using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayanSport.View
{
    public partial class Form_CheckIn : Form
    {
        public string user_name{ get; set; }
        public Form_CheckIn(string user_name)
        {
            InitializeComponent(user_name);
            this.user_name = user_name;
        }

       
    }
}
