using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RayanSport.Controller;

namespace RayanSport.View
{
    public partial class Form_Login : Form
    {
        Controller_Login controller_login = new Controller_Login();

        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        public Form_Login()
        {
            InitializeComponent();
        }

        #region close and minimize pannel
        private void pnl_loginClose_MouseEnter(object sender, EventArgs e)
        {
            pnl_loginClose.Size = new Size(33, 33);
        }

        private void pnl_loginClose_MouseLeave(object sender, EventArgs e)
        {
            pnl_loginClose.Size = new Size(30, 30);
        }

        private void pnl_loginMinimize_MouseEnter(object sender, EventArgs e)
        {
            pnl_loginMinimize.Size = new Size(33, 33);
        }

        private void pnl_loginMinimize_MouseLeave(object sender, EventArgs e)
        {
            pnl_loginMinimize.Size = new Size(30, 30);
        }

        private void pnl_loginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnl_loginMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region place holder of username and password
        private void txb_loginUsername_Enter(object sender, EventArgs e)
        {
            controller_login.textFocusIn(txb_loginUsername, "کاربری نام");
        }

        private void txb_loginUsername_Leave(object sender, EventArgs e)
        {
            controller_login.textFocusOut(txb_loginUsername, "کاربری نام");
        }

        private void txb_loginPassword_Leave(object sender, EventArgs e)
        {
            controller_login.passwordFocusOut(txb_loginPassword, "عبور کلمه");
        }

        private void txb_loginPassword_Enter(object sender, EventArgs e)
        {
            controller_login.passwordFocusIn(txb_loginPassword, "عبور کلمه");
        }
        #endregion

        #region drag and drop
        private void Form_Login_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void Form_Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void Form_Login_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        #endregion

        #region show pass
        private void pnl_loginPassword_MouseDown(object sender, MouseEventArgs e)
        {
            if (txb_loginPassword.Text != "عبور کلمه")
            {
                txb_loginPassword.PasswordChar = '\0';
                txb_loginPassword.SelectionStart = txb_loginPassword.Text.Length;// add some logic if length is 0
                txb_loginPassword.SelectionLength = 0;
            }

        }

        private void pnl_loginPassword_MouseUp(object sender, MouseEventArgs e)
        {
            if (txb_loginPassword.Text != "عبور کلمه")
            {
                txb_loginPassword.PasswordChar = '•';
                txb_loginPassword.SelectionStart = txb_loginPassword.Text.Length;// add some logic if length is 0
                txb_loginPassword.SelectionLength = 0;
            }
        }

        #endregion

        private void btn_login_Click(object sender, EventArgs e)
        {
            User user = new User("","","",false,"");
            user = controller_login.authenticator(txb_loginUsername.Text, txb_loginPassword.Text);
            Form_Main form_main = new Form_Main();
            this.Hide();
            form_main.Show();
        }

        private void txb_loginUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_login.PerformClick();
            }
        }

        private void txb_loginPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_login.PerformClick();
            }
        }
    }
}
