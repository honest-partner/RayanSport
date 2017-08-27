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
            this.uC_CheckIn1 = new RayanSport.View.UC_CheckIn();
            this.uC_CheckIn_Info1 = new RayanSport.View.UC_CheckIn_Info();
            this.SuspendLayout();
            // 
            // uC_CheckIn1
            // 
            this.uC_CheckIn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_CheckIn1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uC_CheckIn1.Location = new System.Drawing.Point(0, 523);
            this.uC_CheckIn1.Name = "uC_CheckIn1";
            this.uC_CheckIn1.Size = new System.Drawing.Size(972, 217);
            this.uC_CheckIn1.TabIndex = 1;
            // 
            // uC_CheckIn_Info1
            // 
            this.uC_CheckIn_Info1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uC_CheckIn_Info1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_CheckIn_Info1.Location = new System.Drawing.Point(0, 0);
            this.uC_CheckIn_Info1.Name = "uC_CheckIn_Info1";
            this.uC_CheckIn_Info1.Size = new System.Drawing.Size(972, 522);
            this.uC_CheckIn_Info1.TabIndex = 0;
            // 
            // Form_CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 740);
            this.Controls.Add(this.uC_CheckIn1);
            this.Controls.Add(this.uC_CheckIn_Info1);
            this.DoubleBuffered = true;
            this.Name = "Form_CheckIn";
            this.Text = "Form_CheckIn";
            this.ResumeLayout(false);

        }

        #endregion

        private UC_CheckIn_Info uC_CheckIn_Info1;
        private UC_CheckIn uC_CheckIn1;
    }
}