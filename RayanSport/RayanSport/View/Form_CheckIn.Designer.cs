namespace RayanSport.View
{
    partial class Form_CheckIn
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
            this.uC_CheckIn_Info1 = new RayanSport.View.UC_CheckIn_Info();
            this.SuspendLayout();
            // 
            // uC_CheckIn_Info1
            // 
            this.uC_CheckIn_Info1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_CheckIn_Info1.Location = new System.Drawing.Point(2, 0);
            this.uC_CheckIn_Info1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uC_CheckIn_Info1.Name = "uC_CheckIn_Info1";
            this.uC_CheckIn_Info1.Size = new System.Drawing.Size(689, 429);
            this.uC_CheckIn_Info1.TabIndex = 0;
            // 
            // Form_CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 432);
            this.Controls.Add(this.uC_CheckIn_Info1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_CheckIn";
            this.Text = "Form_CheckIn";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_CheckIn_Info uC_CheckIn_Info1;
    }
}