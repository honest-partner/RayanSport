namespace RayanSport.View
{
    partial class Form_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_loginMinimize = new System.Windows.Forms.Panel();
            this.pnl_loginClose = new System.Windows.Forms.Panel();
            this.txb_loginUsername = new Telerik.WinControls.UI.RadTextBoxControl();
            this.txb_loginPassword = new Telerik.WinControls.UI.RadTextBoxControl();
            this.btn_login = new Telerik.WinControls.UI.RadButton();
            this.pnl_loginUsername = new System.Windows.Forms.Panel();
            this.pnl_loginPassword = new System.Windows.Forms.Panel();
            this.lbl_loginRayan = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txb_loginUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_loginPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_loginRayan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_loginMinimize
            // 
            this.pnl_loginMinimize.BackColor = System.Drawing.Color.Transparent;
            this.pnl_loginMinimize.BackgroundImage = global::RayanSport.Properties.Resources.minus;
            this.pnl_loginMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_loginMinimize.Location = new System.Drawing.Point(713, 11);
            this.pnl_loginMinimize.Name = "pnl_loginMinimize";
            this.pnl_loginMinimize.Size = new System.Drawing.Size(30, 30);
            this.pnl_loginMinimize.TabIndex = 0;
            this.pnl_loginMinimize.Click += new System.EventHandler(this.pnl_loginMinimize_Click);
            this.pnl_loginMinimize.MouseEnter += new System.EventHandler(this.pnl_loginMinimize_MouseEnter);
            this.pnl_loginMinimize.MouseLeave += new System.EventHandler(this.pnl_loginMinimize_MouseLeave);
            // 
            // pnl_loginClose
            // 
            this.pnl_loginClose.BackColor = System.Drawing.Color.Transparent;
            this.pnl_loginClose.BackgroundImage = global::RayanSport.Properties.Resources.cancel__1_;
            this.pnl_loginClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_loginClose.Location = new System.Drawing.Point(752, 11);
            this.pnl_loginClose.Name = "pnl_loginClose";
            this.pnl_loginClose.Size = new System.Drawing.Size(30, 30);
            this.pnl_loginClose.TabIndex = 1;
            this.pnl_loginClose.Click += new System.EventHandler(this.pnl_loginClose_Click);
            this.pnl_loginClose.MouseEnter += new System.EventHandler(this.pnl_loginClose_MouseEnter);
            this.pnl_loginClose.MouseLeave += new System.EventHandler(this.pnl_loginClose_MouseLeave);
            // 
            // txb_loginUsername
            // 
            this.txb_loginUsername.BackColor = System.Drawing.Color.Transparent;
            this.txb_loginUsername.Font = new System.Drawing.Font("B Yekan+", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_loginUsername.ForeColor = System.Drawing.Color.Gray;
            this.txb_loginUsername.Location = new System.Drawing.Point(255, 195);
            this.txb_loginUsername.MaxLength = 15;
            this.txb_loginUsername.Name = "txb_loginUsername";
            this.txb_loginUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txb_loginUsername.Size = new System.Drawing.Size(285, 30);
            this.txb_loginUsername.TabIndex = 2;
            this.txb_loginUsername.Text = "کاربری نام";
            this.txb_loginUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_loginUsername.Enter += new System.EventHandler(this.txb_loginUsername_Enter);
            this.txb_loginUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_loginUsername_KeyPress);
            this.txb_loginUsername.Leave += new System.EventHandler(this.txb_loginUsername_Leave);
            // 
            // txb_loginPassword
            // 
            this.txb_loginPassword.BackColor = System.Drawing.Color.Transparent;
            this.txb_loginPassword.Font = new System.Drawing.Font("B Yekan+", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_loginPassword.ForeColor = System.Drawing.Color.Gray;
            this.txb_loginPassword.Location = new System.Drawing.Point(255, 234);
            this.txb_loginPassword.MaxLength = 15;
            this.txb_loginPassword.Name = "txb_loginPassword";
            this.txb_loginPassword.Size = new System.Drawing.Size(285, 30);
            this.txb_loginPassword.TabIndex = 3;
            this.txb_loginPassword.Text = "عبور کلمه";
            this.txb_loginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txb_loginPassword.Enter += new System.EventHandler(this.txb_loginPassword_Enter);
            this.txb_loginPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_loginPassword_KeyPress);
            this.txb_loginPassword.Leave += new System.EventHandler(this.txb_loginPassword_Leave);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Green;
            this.btn_login.Font = new System.Drawing.Font("B Yekan+", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(255, 277);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(285, 30);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "ورود";
            this.btn_login.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pnl_loginUsername
            // 
            this.pnl_loginUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_loginUsername.BackColor = System.Drawing.Color.Transparent;
            this.pnl_loginUsername.BackgroundImage = global::RayanSport.Properties.Resources.user__3_;
            this.pnl_loginUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_loginUsername.Location = new System.Drawing.Point(509, 198);
            this.pnl_loginUsername.Name = "pnl_loginUsername";
            this.pnl_loginUsername.Size = new System.Drawing.Size(25, 25);
            this.pnl_loginUsername.TabIndex = 5;
            // 
            // pnl_loginPassword
            // 
            this.pnl_loginPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_loginPassword.BackColor = System.Drawing.Color.Transparent;
            this.pnl_loginPassword.BackgroundImage = global::RayanSport.Properties.Resources.lock__1_;
            this.pnl_loginPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_loginPassword.Location = new System.Drawing.Point(509, 237);
            this.pnl_loginPassword.Name = "pnl_loginPassword";
            this.pnl_loginPassword.Size = new System.Drawing.Size(25, 25);
            this.pnl_loginPassword.TabIndex = 6;
            this.pnl_loginPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_loginPassword_MouseDown);
            this.pnl_loginPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_loginPassword_MouseUp);
            // 
            // lbl_loginRayan
            // 
            this.lbl_loginRayan.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loginRayan.Font = new System.Drawing.Font("B Yekan+", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginRayan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_loginRayan.Location = new System.Drawing.Point(193, 367);
            this.lbl_loginRayan.Name = "lbl_loginRayan";
            this.lbl_loginRayan.Size = new System.Drawing.Size(402, 21);
            this.lbl_loginRayan.TabIndex = 7;
            this.lbl_loginRayan.Text = "تمامی حقوق مادی و معنوی این نرم افزار متعلق به گروه نرم افزاری رایان پردازش می با" +
    "شد ";
            // 
            // Form_Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::RayanSport.Properties.Resources.loginFinal1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.lbl_loginRayan);
            this.Controls.Add(this.pnl_loginPassword);
            this.Controls.Add(this.pnl_loginUsername);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txb_loginPassword);
            this.Controls.Add(this.txb_loginUsername);
            this.Controls.Add(this.pnl_loginClose);
            this.Controls.Add(this.pnl_loginMinimize);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Login";
            this.TransparencyKey = System.Drawing.Color.Gold;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_Login_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.txb_loginUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txb_loginPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_loginRayan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_loginMinimize;
        private System.Windows.Forms.Panel pnl_loginClose;
        private Telerik.WinControls.UI.RadTextBoxControl txb_loginUsername;
        private Telerik.WinControls.UI.RadTextBoxControl txb_loginPassword;
        private Telerik.WinControls.UI.RadButton btn_login;
        private System.Windows.Forms.Panel pnl_loginUsername;
        private System.Windows.Forms.Panel pnl_loginPassword;
        private Telerik.WinControls.UI.RadLabel lbl_loginRayan;
    }
}