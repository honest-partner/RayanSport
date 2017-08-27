using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RayanSport.View;
namespace RayanSport
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           //  Member member = new Member(184, "حسن قبیتی", "", "", "مرد", "", "", "", 0);
           // Member member = new Member();

            Application.Run(new Form_ShowMember(member));
        }
    }
}
