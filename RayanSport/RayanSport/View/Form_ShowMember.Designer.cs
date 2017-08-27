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
            this.uC_ShowMember_ContractInfo1 = new RayanSport.View.UC_ShowMember_ContractInfo(new Member(100,"", "", "", "", "", "", "",0));
            this.SuspendLayout();
            // 
            // uC_ShowMember_ContractInfo1
            // 
            this.uC_ShowMember_ContractInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_ShowMember_ContractInfo1.Font = new System.Drawing.Font("B Yekan+", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_ShowMember_ContractInfo1.Location = new System.Drawing.Point(0, 0);
            this.uC_ShowMember_ContractInfo1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uC_ShowMember_ContractInfo1.Name = "uC_ShowMember_ContractInfo1";
            this.uC_ShowMember_ContractInfo1.Size = new System.Drawing.Size(1374, 721);
            this.uC_ShowMember_ContractInfo1.TabIndex = 0;
            // 
            // Form_ShowMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 721);
            this.Controls.Add(this.uC_ShowMember_ContractInfo1);
            this.DoubleBuffered = true;
            this.Name = "Form_ShowMember";
            this.Text = "Form_ShowMember";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_ShowMember_ContractInfo uC_ShowMember_ContractInfo1;
    }
}