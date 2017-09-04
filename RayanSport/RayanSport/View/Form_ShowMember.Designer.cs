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
            this.uC_Log1 = new RayanSport.View.UC_Log();
            this.SuspendLayout();
            // 
            // uC_Log1
            // 
            this.uC_Log1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Log1.Location = new System.Drawing.Point(0, 0);
            this.uC_Log1.Name = "uC_Log1";
            this.uC_Log1.Size = new System.Drawing.Size(1280, 719);
            this.uC_Log1.TabIndex = 0;
            // 
            // Form_ShowMember
            // 
            this.ClientSize = new System.Drawing.Size(1280, 719);
            this.Controls.Add(this.uC_Log1);
            this.Name = "Form_ShowMember";
            this.ResumeLayout(false);

        }

        private UC_Log uC_Log1;
    }

    #endregion

}