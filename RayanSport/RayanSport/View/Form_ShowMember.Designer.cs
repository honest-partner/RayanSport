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
        private void InitializeComponent(Member member , bool formIsOpen)
        {
            this.uC_ShowMember_MemberInfo1 = new RayanSport.View.UC_ShowMember_MemberInfo(member,formIsOpen);
            this.SuspendLayout();
            // 
            // uC_ShowMember_MemberInfo1
            // 
            this.uC_ShowMember_MemberInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_ShowMember_MemberInfo1.Location = new System.Drawing.Point(0, 0);
            this.uC_ShowMember_MemberInfo1.Name = "uC_ShowMember_MemberInfo1";
            this.uC_ShowMember_MemberInfo1.Size = new System.Drawing.Size(934, 274);
            this.uC_ShowMember_MemberInfo1.TabIndex = 0;
            // 
            // Form_ShowMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 586);
            this.Controls.Add(this.uC_ShowMember_MemberInfo1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_ShowMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ShowMember";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_ShowMember_MemberInfo uC_ShowMember_MemberInfo1;
    }
}