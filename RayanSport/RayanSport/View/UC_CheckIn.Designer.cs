﻿namespace RayanSport.View
{
    partial class UC_CheckIn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_UcCheckInCommode = new System.Windows.Forms.Label();
            this.txb_UcCheckInCommode = new System.Windows.Forms.TextBox();
            this.txb_UcCheckInPrice = new System.Windows.Forms.TextBox();
            this.lbl_UcCheckInPrice = new System.Windows.Forms.Label();
            this.btn_UcCheckInCheck = new System.Windows.Forms.Button();
            this.btn_UcCheckInClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_UcCheckInCommode
            // 
            this.lbl_UcCheckInCommode.AutoSize = true;
            this.lbl_UcCheckInCommode.Font = new System.Drawing.Font("B Yekan+", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UcCheckInCommode.Location = new System.Drawing.Point(767, 107);
            this.lbl_UcCheckInCommode.Name = "lbl_UcCheckInCommode";
            this.lbl_UcCheckInCommode.Size = new System.Drawing.Size(89, 28);
            this.lbl_UcCheckInCommode.TabIndex = 4;
            this.lbl_UcCheckInCommode.Text = "شماره کمد";
            // 
            // txb_UcCheckInCommode
            // 
            this.txb_UcCheckInCommode.Font = new System.Drawing.Font("B Yekan+", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_UcCheckInCommode.Location = new System.Drawing.Point(382, 104);
            this.txb_UcCheckInCommode.Name = "txb_UcCheckInCommode";
            this.txb_UcCheckInCommode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txb_UcCheckInCommode.Size = new System.Drawing.Size(247, 36);
            this.txb_UcCheckInCommode.TabIndex = 3;
            this.txb_UcCheckInCommode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_UcCheckInPrice_KeyPress);
            // 
            // txb_UcCheckInPrice
            // 
            this.txb_UcCheckInPrice.Font = new System.Drawing.Font("B Yekan+", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_UcCheckInPrice.Location = new System.Drawing.Point(382, 54);
            this.txb_UcCheckInPrice.Name = "txb_UcCheckInPrice";
            this.txb_UcCheckInPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txb_UcCheckInPrice.Size = new System.Drawing.Size(247, 36);
            this.txb_UcCheckInPrice.TabIndex = 3;
            this.txb_UcCheckInPrice.TextChanged += new System.EventHandler(this.txb_UcCheckInPrice_TextChanged);
            this.txb_UcCheckInPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_UcCheckInPrice_KeyPress);
            // 
            // lbl_UcCheckInPrice
            // 
            this.lbl_UcCheckInPrice.AutoSize = true;
            this.lbl_UcCheckInPrice.Font = new System.Drawing.Font("B Yekan+", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UcCheckInPrice.Location = new System.Drawing.Point(809, 57);
            this.lbl_UcCheckInPrice.Name = "lbl_UcCheckInPrice";
            this.lbl_UcCheckInPrice.Size = new System.Drawing.Size(54, 28);
            this.lbl_UcCheckInPrice.TabIndex = 4;
            this.lbl_UcCheckInPrice.Text = "قیمت";
            // 
            // btn_UcCheckInCheck
            // 
            this.btn_UcCheckInCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.btn_UcCheckInCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_UcCheckInCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UcCheckInCheck.Font = new System.Drawing.Font("B Yekan+", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UcCheckInCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_UcCheckInCheck.Location = new System.Drawing.Point(37, 100);
            this.btn_UcCheckInCheck.Name = "btn_UcCheckInCheck";
            this.btn_UcCheckInCheck.Size = new System.Drawing.Size(223, 44);
            this.btn_UcCheckInCheck.TabIndex = 5;
            this.btn_UcCheckInCheck.Text = "تایید";
            this.btn_UcCheckInCheck.UseVisualStyleBackColor = false;
            this.btn_UcCheckInCheck.Click += new System.EventHandler(this.btn_UcCheckInCheck_Click);
            // 
            // btn_UcCheckInClear
            // 
            this.btn_UcCheckInClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.btn_UcCheckInClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_UcCheckInClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UcCheckInClear.Font = new System.Drawing.Font("B Yekan+", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UcCheckInClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_UcCheckInClear.Location = new System.Drawing.Point(37, 50);
            this.btn_UcCheckInClear.Name = "btn_UcCheckInClear";
            this.btn_UcCheckInClear.Size = new System.Drawing.Size(223, 44);
            this.btn_UcCheckInClear.TabIndex = 6;
            this.btn_UcCheckInClear.Text = "پاک کردن";
            this.btn_UcCheckInClear.UseVisualStyleBackColor = false;
            this.btn_UcCheckInClear.Click += new System.EventHandler(this.btn_UcCheckInClear_Click);
            // 
            // UC_CheckIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btn_UcCheckInCheck);
            this.Controls.Add(this.btn_UcCheckInClear);
            this.Controls.Add(this.lbl_UcCheckInPrice);
            this.Controls.Add(this.lbl_UcCheckInCommode);
            this.Controls.Add(this.txb_UcCheckInPrice);
            this.Controls.Add(this.txb_UcCheckInCommode);
            this.Font = new System.Drawing.Font("B Yekan+", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_CheckIn";
            this.Size = new System.Drawing.Size(910, 174);
            this.Load += new System.EventHandler(this.UC_CheckIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_UcCheckInCommode;
        private System.Windows.Forms.TextBox txb_UcCheckInCommode;
        private System.Windows.Forms.TextBox txb_UcCheckInPrice;
        private System.Windows.Forms.Label lbl_UcCheckInPrice;
        private System.Windows.Forms.Button btn_UcCheckInCheck;
        private System.Windows.Forms.Button btn_UcCheckInClear;
    }
}
