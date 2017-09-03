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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gpb_UcCheckInMember = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_UcShowMemberContractInfoContracts = new Telerik.WinControls.UI.RadGridView();
            this.logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rayan_sportDataSet = new RayanSport.rayan_sportDataSet();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_UcLogStartDate = new System.Windows.Forms.Label();
            this.dts_UcLogStartDate = new Atf.UI.DateTimeSelector();
            this.lbl_UcLogEndDate = new System.Windows.Forms.Label();
            this.dts_UcLogEndDate = new Atf.UI.DateTimeSelector();
            this.btn_UcLogSearchDate = new System.Windows.Forms.Button();
            this.logTableAdapter = new RayanSport.rayan_sportDataSetTableAdapters.logTableAdapter();
            this.gpb_UcCheckInMember.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UcShowMemberContractInfoContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UcShowMemberContractInfoContracts.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rayan_sportDataSet)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_UcCheckInMember
            // 
            this.gpb_UcCheckInMember.BackColor = System.Drawing.Color.Transparent;
            this.gpb_UcCheckInMember.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpb_UcCheckInMember.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpb_UcCheckInMember.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Yellow;
            this.gpb_UcCheckInMember.Controls.Add(this.tableLayoutPanel1);
            this.gpb_UcCheckInMember.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpb_UcCheckInMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb_UcCheckInMember.Font = new System.Drawing.Font("B Yekan+", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_UcCheckInMember.Location = new System.Drawing.Point(0, 0);
            this.gpb_UcCheckInMember.Name = "gpb_UcCheckInMember";
            this.gpb_UcCheckInMember.Size = new System.Drawing.Size(1322, 745);
            // 
            // 
            // 
            this.gpb_UcCheckInMember.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.gpb_UcCheckInMember.Style.BackColor2 = System.Drawing.Color.Transparent;
            this.gpb_UcCheckInMember.Style.BackColorGradientAngle = 90;
            this.gpb_UcCheckInMember.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpb_UcCheckInMember.Style.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.gpb_UcCheckInMember.Style.BorderBottomWidth = 2;
            this.gpb_UcCheckInMember.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.gpb_UcCheckInMember.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpb_UcCheckInMember.Style.BorderLeftWidth = 2;
            this.gpb_UcCheckInMember.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpb_UcCheckInMember.Style.BorderRightWidth = 2;
            this.gpb_UcCheckInMember.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpb_UcCheckInMember.Style.BorderTopWidth = 2;
            this.gpb_UcCheckInMember.Style.CornerDiameter = 10;
            this.gpb_UcCheckInMember.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpb_UcCheckInMember.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpb_UcCheckInMember.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(0)))));
            this.gpb_UcCheckInMember.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpb_UcCheckInMember.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpb_UcCheckInMember.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpb_UcCheckInMember.TabIndex = 3;
            this.gpb_UcCheckInMember.Text = "log";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_UcShowMemberContractInfoContracts, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1310, 702);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_UcShowMemberContractInfoContracts
            // 
            this.dgv_UcShowMemberContractInfoContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_UcShowMemberContractInfoContracts.Location = new System.Drawing.Point(3, 73);
            // 
            // 
            // 
            this.dgv_UcShowMemberContractInfoContracts.MasterTemplate.AllowAddNewRow = false;
            this.dgv_UcShowMemberContractInfoContracts.MasterTemplate.AllowColumnChooser = false;
            this.dgv_UcShowMemberContractInfoContracts.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.dgv_UcShowMemberContractInfoContracts.MasterTemplate.AllowColumnReorder = false;
            this.dgv_UcShowMemberContractInfoContracts.MasterTemplate.AllowDeleteRow = false;
            this.dgv_UcShowMemberContractInfoContracts.MasterTemplate.AllowDragToGroup = false;
            this.dgv_UcShowMemberContractInfoContracts.MasterTemplate.AllowEditRow = false;
            this.dgv_UcShowMemberContractInfoContracts.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.dgv_UcShowMemberContractInfoContracts.MasterTemplate.ClipboardCopyMode = Telerik.WinControls.UI.GridViewClipboardCopyMode.Disable;
            this.dgv_UcShowMemberContractInfoContracts.MasterTemplate.ClipboardCutMode = Telerik.WinControls.UI.GridViewClipboardCutMode.Disable;
            gridViewDecimalColumn2.DataType = typeof(long);
            gridViewDecimalColumn2.FieldName = "log_id";
            gridViewDecimalColumn2.HeaderText = "شماره";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "log_id";
            gridViewDecimalColumn2.ReadOnly = true;
            gridViewDecimalColumn2.Width = 215;
            gridViewTextBoxColumn6.FieldName = "log_description";
            gridViewTextBoxColumn6.HeaderText = "توضیحات";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "log_description";
            gridViewTextBoxColumn6.Width = 215;
            gridViewTextBoxColumn7.FieldName = "log_targetTable";
            gridViewTextBoxColumn7.HeaderText = "نام جدول";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "log_targetTable";
            gridViewTextBoxColumn7.Width = 215;
            gridViewTextBoxColumn8.FieldName = "log_username";
            gridViewTextBoxColumn8.HeaderText = "کد کاربری";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.Name = "log_username";
            gridViewTextBoxColumn8.Width = 215;
            gridViewTextBoxColumn9.FieldName = "log_date";
            gridViewTextBoxColumn9.HeaderText = "تاریخ";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "log_date";
            gridViewTextBoxColumn9.Width = 215;
            gridViewTextBoxColumn10.FieldName = "log_time";
            gridViewTextBoxColumn10.HeaderText = "ساعت";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.Name = "log_time";
            gridViewTextBoxColumn10.Width = 213;
            this.dgv_UcShowMemberContractInfoContracts.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10});
            this.dgv_UcShowMemberContractInfoContracts.MasterTemplate.DataSource = this.logBindingSource;
            this.dgv_UcShowMemberContractInfoContracts.MasterTemplate.EnableGrouping = false;
            this.dgv_UcShowMemberContractInfoContracts.MasterTemplate.EnablePaging = true;
            this.dgv_UcShowMemberContractInfoContracts.MasterTemplate.PageSize = 5;
            this.dgv_UcShowMemberContractInfoContracts.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.dgv_UcShowMemberContractInfoContracts.Name = "dgv_UcShowMemberContractInfoContracts";
            this.dgv_UcShowMemberContractInfoContracts.ReadOnly = true;
            this.dgv_UcShowMemberContractInfoContracts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_UcShowMemberContractInfoContracts.Size = new System.Drawing.Size(1304, 626);
            this.dgv_UcShowMemberContractInfoContracts.TabIndex = 1;
            // 
            // logBindingSource
            // 
            this.logBindingSource.DataMember = "log";
            this.logBindingSource.DataSource = this.rayan_sportDataSet;
            // 
            // rayan_sportDataSet
            // 
            this.rayan_sportDataSet.DataSetName = "rayan_sportDataSet";
            this.rayan_sportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_UcLogStartDate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dts_UcLogStartDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_UcLogEndDate, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dts_UcLogEndDate, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_UcLogSearchDate, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1304, 64);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbl_UcLogStartDate
            // 
            this.lbl_UcLogStartDate.AutoSize = true;
            this.lbl_UcLogStartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_UcLogStartDate.Location = new System.Drawing.Point(1112, 0);
            this.lbl_UcLogStartDate.Name = "lbl_UcLogStartDate";
            this.lbl_UcLogStartDate.Size = new System.Drawing.Size(189, 64);
            this.lbl_UcLogStartDate.TabIndex = 0;
            this.lbl_UcLogStartDate.Text = "از تاریخ";
            this.lbl_UcLogStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dts_UcLogStartDate
            // 
            this.dts_UcLogStartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dts_UcLogStartDate.Location = new System.Drawing.Point(852, 3);
            this.dts_UcLogStartDate.Name = "dts_UcLogStartDate";
            this.dts_UcLogStartDate.Size = new System.Drawing.Size(254, 37);
            this.dts_UcLogStartDate.TabIndex = 1;
            this.dts_UcLogStartDate.UsePersianFormat = true;
            // 
            // lbl_UcLogEndDate
            // 
            this.lbl_UcLogEndDate.AutoSize = true;
            this.lbl_UcLogEndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_UcLogEndDate.Location = new System.Drawing.Point(657, 0);
            this.lbl_UcLogEndDate.Name = "lbl_UcLogEndDate";
            this.lbl_UcLogEndDate.Size = new System.Drawing.Size(189, 64);
            this.lbl_UcLogEndDate.TabIndex = 2;
            this.lbl_UcLogEndDate.Text = "تا تاریخ";
            this.lbl_UcLogEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dts_UcLogEndDate
            // 
            this.dts_UcLogEndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dts_UcLogEndDate.Location = new System.Drawing.Point(397, 3);
            this.dts_UcLogEndDate.Name = "dts_UcLogEndDate";
            this.dts_UcLogEndDate.Size = new System.Drawing.Size(254, 37);
            this.dts_UcLogEndDate.TabIndex = 3;
            this.dts_UcLogEndDate.UsePersianFormat = true;
            // 
            // btn_UcLogSearchDate
            // 
            this.btn_UcLogSearchDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.btn_UcLogSearchDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_UcLogSearchDate.FlatAppearance.BorderSize = 0;
            this.btn_UcLogSearchDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UcLogSearchDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btn_UcLogSearchDate.Location = new System.Drawing.Point(137, 3);
            this.btn_UcLogSearchDate.Name = "btn_UcLogSearchDate";
            this.btn_UcLogSearchDate.Size = new System.Drawing.Size(254, 58);
            this.btn_UcLogSearchDate.TabIndex = 4;
            this.btn_UcLogSearchDate.Text = "جست و جو";
            this.btn_UcLogSearchDate.UseVisualStyleBackColor = false;
            this.btn_UcLogSearchDate.Click += new System.EventHandler(this.btn_UcLogSearchDate_Click);
            // 
            // logTableAdapter
            // 
            this.logTableAdapter.ClearBeforeFill = true;
            // 
            // UC_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpb_UcCheckInMember);
            this.Name = "UC_Log";
            this.Size = new System.Drawing.Size(1322, 745);
            this.gpb_UcCheckInMember.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UcShowMemberContractInfoContracts.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UcShowMemberContractInfoContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rayan_sportDataSet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel gpb_UcCheckInMember;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbl_UcLogStartDate;
        private Atf.UI.DateTimeSelector dts_UcLogStartDate;
        private System.Windows.Forms.Label lbl_UcLogEndDate;
        private Atf.UI.DateTimeSelector dts_UcLogEndDate;
        private System.Windows.Forms.Button btn_UcLogSearchDate;
        private Telerik.WinControls.UI.RadGridView dgv_UcShowMemberContractInfoContracts;
        private System.Windows.Forms.BindingSource logBindingSource;
        private rayan_sportDataSet rayan_sportDataSet;
        private rayan_sportDataSetTableAdapters.logTableAdapter logTableAdapter;
    }
}
