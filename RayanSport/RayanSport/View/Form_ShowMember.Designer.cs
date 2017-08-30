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
        private void InitializeComponent(Member member)
        {
            this.uC_ShowMember_ContractInfo1 = new RayanSport.View.UC_ShowMember_ContractInfo();
            this.uC_ShowMember_ContractInfo1.Member = member;
            this.SuspendLayout();
            // 
            // uC_ShowMember_ContractInfo1
            // 
            this.uC_ShowMember_ContractInfo1.Font = new System.Drawing.Font("B Yekan+", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_ShowMember_ContractInfo1.Location = new System.Drawing.Point(5, -2);
            this.uC_ShowMember_ContractInfo1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uC_ShowMember_ContractInfo1.Member = null;
            this.uC_ShowMember_ContractInfo1.Name = "uC_ShowMember_ContractInfo1";
            this.uC_ShowMember_ContractInfo1.Size = new System.Drawing.Size(1370, 626);
            this.uC_ShowMember_ContractInfo1.TabIndex = 0;
            // 
            // Form_ShowMember
            // 
            this.ClientSize = new System.Drawing.Size(1381, 639);
            this.Controls.Add(this.uC_ShowMember_ContractInfo1);
            this.Name = "Form_ShowMember";
            this.ResumeLayout(false);

        }

        private UC_ShowMember_ContractInfo uC_ShowMember_ContractInfo1;

        #endregion

        //private UC_ShowMember_MemberInfo uC_ShowMember_MemberInfo1;
    }
}