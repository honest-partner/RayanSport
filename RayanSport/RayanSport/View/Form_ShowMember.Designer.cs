namespace RayanSport.View
{
    partial class Form_ShowMember
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
            this.uC_ShowMember_MemberInfo1 = new RayanSport.View.UC_ShowMember_MemberInfo();
            this.SuspendLayout();
            // 
            // uC_ShowMember_MemberInfo1
            // 
            this.uC_ShowMember_MemberInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.uC_ShowMember_MemberInfo1.Location = new System.Drawing.Point(12, 12);
            this.uC_ShowMember_MemberInfo1.Name = "uC_ShowMember_MemberInfo1";
            this.uC_ShowMember_MemberInfo1.Size = new System.Drawing.Size(1005, 326);
            this.uC_ShowMember_MemberInfo1.TabIndex = 0;
            // 
            // Form_ShowMember
            // 
            this.ClientSize = new System.Drawing.Size(1029, 492);
            this.Controls.Add(this.uC_ShowMember_MemberInfo1);
            this.Name = "Form_ShowMember";
            this.ResumeLayout(false);

        }

        private UC_ShowMember_MemberInfo uC_ShowMember_MemberInfo1;
    }

    #endregion

}