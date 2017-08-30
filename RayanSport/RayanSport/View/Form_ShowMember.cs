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
    public partial class Form_ShowMember : Form
    {
       
        public Form_ShowMember(Member member)
        {
            
            InitializeComponent(member);
        }
    }
}
