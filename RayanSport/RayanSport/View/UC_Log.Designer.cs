namespace RayanSport.View
{
    partial class UC_Log
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gpb_UcShowAllContractByName = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gpb_UcShowAllContractByName, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(633, 428);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gpb_UcShowAllContractByName
            // 
            this.gpb_UcShowAllContractByName.BackColor = System.Drawing.Color.Transparent;
            this.gpb_UcShowAllContractByName.CanvasColor = System.Drawing.Color.Transparent;
            this.gpb_UcShowAllContractByName.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpb_UcShowAllContractByName.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpb_UcShowAllContractByName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb_UcShowAllContractByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpb_UcShowAllContractByName.Location = new System.Drawing.Point(2, 216);
            this.gpb_UcShowAllContractByName.Margin = new System.Windows.Forms.Padding(2);
            this.gpb_UcShowAllContractByName.Name = "gpb_UcShowAllContractByName";
            this.gpb_UcShowAllContractByName.Size = new System.Drawing.Size(312, 210);
            // 
            // 
            // 
            this.gpb_UcShowAllContractByName.Style.BackColor = System.Drawing.Color.Transparent;
            this.gpb_UcShowAllContractByName.Style.BackColor2 = System.Drawing.Color.Transparent;
            this.gpb_UcShowAllContractByName.Style.BackColorGradientAngle = 90;
            this.gpb_UcShowAllContractByName.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpb_UcShowAllContractByName.Style.BorderBottomWidth = 2;
            this.gpb_UcShowAllContractByName.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.gpb_UcShowAllContractByName.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpb_UcShowAllContractByName.Style.BorderLeftWidth = 2;
            this.gpb_UcShowAllContractByName.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpb_UcShowAllContractByName.Style.BorderRightWidth = 2;
            this.gpb_UcShowAllContractByName.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpb_UcShowAllContractByName.Style.BorderTopWidth = 2;
            this.gpb_UcShowAllContractByName.Style.CornerDiameter = 10;
            this.gpb_UcShowAllContractByName.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpb_UcShowAllContractByName.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpb_UcShowAllContractByName.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpb_UcShowAllContractByName.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpb_UcShowAllContractByName.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpb_UcShowAllContractByName.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpb_UcShowAllContractByName.TabIndex = 75;
            this.gpb_UcShowAllContractByName.Text = "بر اساس نام و نام خانوادگی";
            // 
            // UC_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_Log";
            this.Size = new System.Drawing.Size(633, 428);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel gpb_UcShowAllContractByName;
    }
}
