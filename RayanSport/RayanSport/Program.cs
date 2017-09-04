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
            //Form_ShowMember member = new Form_ShowMember();
            //member.Member = new Member(107, "", "", "", "", "", "", "", 0);
            // Application.Run(Form_Main());
            //Application.Run(new Form_Main());
            Application.Run(new Form_Main());
        }
    }
}
