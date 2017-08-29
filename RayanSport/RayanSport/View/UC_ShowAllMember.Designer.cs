namespace RayanSport.View
{
    partial class UC_ShowAllMember
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_UcShowAllMemberShowDgv = new Telerik.WinControls.UI.RadGridView();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rayan_sportDataSet = new RayanSport.rayan_sportDataSet();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gpb_lbl_UcShowAllMemberSearch = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_UcShowAllMemberMemberGender = new System.Windows.Forms.Label();
            this.btn_UcShowAllMemberSearch = new System.Windows.Forms.Button();
            this.swb_UcShowAllMemberMemberGender = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.lbl_UcShowAllMemberMemberName = new System.Windows.Forms.Label();
            this.lbl_UcShowAllMemberMemberId = new System.Windows.Forms.Label();
            this.txb_UcShowAllMemberMemberId = new System.Windows.Forms.TextBox();
            this.txb_UcShowAllMemberMemberName = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_UcShowAllMemberAddMember = new System.Windows.Forms.Button();
            this.btn_UcShowAllMemberShowMemberInfo = new System.Windows.Forms.Button();
            this.memberTableAdapter = new RayanSport.rayan_sportDataSetTableAdapters.memberTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UcShowAllMemberShowDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UcShowAllMemberShowDgv.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rayan_sportDataSet)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.gpb_lbl_UcShowAllMemberSearch.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_UcShowAllMemberShowDgv, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.77165F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.99213F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.03937F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 508);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_UcShowAllMemberShowDgv
            // 
            this.dgv_UcShowAllMemberShowDgv.AutoScroll = true;
            this.dgv_UcShowAllMemberShowDgv.AutoSizeRows = true;
            this.dgv_UcShowAllMemberShowDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_UcShowAllMemberShowDgv.EnableGestures = false;
            this.dgv_UcShowAllMemberShowDgv.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgv_UcShowAllMemberShowDgv.Location = new System.Drawing.Point(3, 139);
            // 
            // 
            // 
            this.dgv_UcShowAllMemberShowDgv.MasterTemplate.AllowAddNewRow = false;
            this.dgv_UcShowAllMemberShowDgv.MasterTemplate.AllowColumnChooser = false;
            this.dgv_UcShowAllMemberShowDgv.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.dgv_UcShowAllMemberShowDgv.MasterTemplate.AllowColumnReorder = false;
            this.dgv_UcShowAllMemberShowDgv.MasterTemplate.AllowDeleteRow = false;
            this.dgv_UcShowAllMemberShowDgv.MasterTemplate.AllowEditRow = false;
            this.dgv_UcShowAllMemberShowDgv.MasterTemplate.AllowRowHeaderContextMenu = false;
            this.dgv_UcShowAllMemberShowDgv.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "member_id";
            gridViewDecimalColumn2.HeaderText = "کد عضویت";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "member_id";
            gridViewDecimalColumn2.ReadOnly = true;
            gridViewDecimalColumn2.Width = 200;
            gridViewTextBoxColumn4.FieldName = "member_name";
            gridViewTextBoxColumn4.HeaderText = "نام و نام خانوادگی";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "member_name";
            gridViewTextBoxColumn4.Width = 200;
            gridViewTextBoxColumn5.FieldName = "member_gender";
            gridViewTextBoxColumn5.HeaderText = "جنسیت";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "member_gender";
            gridViewTextBoxColumn5.Width = 200;
            gridViewTextBoxColumn6.FieldName = "member_tel";
            gridViewTextBoxColumn6.HeaderText = "تلفن";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "member_tel";
            gridViewTextBoxColumn6.Width = 200;
            this.dgv_UcShowAllMemberShowDgv.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.dgv_UcShowAllMemberShowDgv.MasterTemplate.DataSource = this.memberBindingSource;
            this.dgv_UcShowAllMemberShowDgv.MasterTemplate.EnableGrouping = false;
            this.dgv_UcShowAllMemberShowDgv.MasterTemplate.EnablePaging = true;
            this.dgv_UcShowAllMemberShowDgv.MasterTemplate.PageSize = 10;
            this.dgv_UcShowAllMemberShowDgv.MasterTemplate.ShowRowHeaderColumn = false;
            this.dgv_UcShowAllMemberShowDgv.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.dgv_UcShowAllMemberShowDgv.Name = "dgv_UcShowAllMemberShowDgv";
            this.dgv_UcShowAllMemberShowDgv.NewRowEnterKeyMode = Telerik.WinControls.UI.RadGridViewNewRowEnterKeyMode.None;
            this.dgv_UcShowAllMemberShowDgv.PrintStyle.PrintAllPages = true;
            this.dgv_UcShowAllMemberShowDgv.ReadOnly = true;
            this.dgv_UcShowAllMemberShowDgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.dgv_UcShowAllMemberShowDgv.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            this.dgv_UcShowAllMemberShowDgv.Size = new System.Drawing.Size(798, 314);
            this.dgv_UcShowAllMemberShowDgv.TabIndex = 0;
            this.dgv_UcShowAllMemberShowDgv.Text = "radGridView1";
            this.dgv_UcShowAllMemberShowDgv.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgv_UcShowAllMemberShowDgv_CellClick);
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "member";
            this.memberBindingSource.DataSource = this.rayan_sportDataSet;
            // 
            // rayan_sportDataSet
            // 
            this.rayan_sportDataSet.DataSetName = "rayan_sportDataSet";
            this.rayan_sportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.gpb_lbl_UcShowAllMemberSearch, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(798, 130);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // gpb_lbl_UcShowAllMemberSearch
            // 
            this.gpb_lbl_UcShowAllMemberSearch.BackColor = System.Drawing.Color.Transparent;
            this.gpb_lbl_UcShowAllMemberSearch.CanvasColor = System.Drawing.Color.Transparent;
            this.gpb_lbl_UcShowAllMemberSearch.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpb_lbl_UcShowAllMemberSearch.Controls.Add(this.tableLayoutPanel3);
            this.gpb_lbl_UcShowAllMemberSearch.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpb_lbl_UcShowAllMemberSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb_lbl_UcShowAllMemberSearch.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpb_lbl_UcShowAllMemberSearch.Location = new System.Drawing.Point(3, 3);
            this.gpb_lbl_UcShowAllMemberSearch.Name = "gpb_lbl_UcShowAllMemberSearch";
            this.gpb_lbl_UcShowAllMemberSearch.Size = new System.Drawing.Size(792, 124);
            // 
            // 
            // 
            this.gpb_lbl_UcShowAllMemberSearch.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.gpb_lbl_UcShowAllMemberSearch.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.gpb_lbl_UcShowAllMemberSearch.Style.BackColorGradientAngle = 90;
            this.gpb_lbl_UcShowAllMemberSearch.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpb_lbl_UcShowAllMemberSearch.Style.BorderBottomWidth = 2;
            this.gpb_lbl_UcShowAllMemberSearch.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.gpb_lbl_UcShowAllMemberSearch.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpb_lbl_UcShowAllMemberSearch.Style.BorderLeftWidth = 2;
            this.gpb_lbl_UcShowAllMemberSearch.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpb_lbl_UcShowAllMemberSearch.Style.BorderRightWidth = 2;
            this.gpb_lbl_UcShowAllMemberSearch.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpb_lbl_UcShowAllMemberSearch.Style.BorderTopWidth = 2;
            this.gpb_lbl_UcShowAllMemberSearch.Style.CornerDiameter = 15;
            this.gpb_lbl_UcShowAllMemberSearch.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpb_lbl_UcShowAllMemberSearch.Style.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpb_lbl_UcShowAllMemberSearch.Style.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpb_lbl_UcShowAllMemberSearch.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpb_lbl_UcShowAllMemberSearch.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemDesignTimeBorder;
            this.gpb_lbl_UcShowAllMemberSearch.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpb_lbl_UcShowAllMemberSearch.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpb_lbl_UcShowAllMemberSearch.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpb_lbl_UcShowAllMemberSearch.TabIndex = 0;
            this.gpb_lbl_UcShowAllMemberSearch.Text = "جست و جو";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Controls.Add(this.lbl_UcShowAllMemberMemberGender, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_UcShowAllMemberSearch, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.swb_UcShowAllMemberMemberGender, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_UcShowAllMemberMemberName, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_UcShowAllMemberMemberId, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.txb_UcShowAllMemberMemberId, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.txb_UcShowAllMemberMemberName, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(776, 95);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lbl_UcShowAllMemberMemberGender
            // 
            this.lbl_UcShowAllMemberMemberGender.AutoSize = true;
            this.lbl_UcShowAllMemberMemberGender.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_UcShowAllMemberMemberGender.Location = new System.Drawing.Point(298, 10);
            this.lbl_UcShowAllMemberMemberGender.Name = "lbl_UcShowAllMemberMemberGender";
            this.lbl_UcShowAllMemberMemberGender.Size = new System.Drawing.Size(67, 42);
            this.lbl_UcShowAllMemberMemberGender.TabIndex = 5;
            this.lbl_UcShowAllMemberMemberGender.Text = "جنسیت";
            this.lbl_UcShowAllMemberMemberGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_UcShowAllMemberSearch
            // 
            this.btn_UcShowAllMemberSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.btn_UcShowAllMemberSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_UcShowAllMemberSearch.ForeColor = System.Drawing.Color.White;
            this.btn_UcShowAllMemberSearch.Location = new System.Drawing.Point(43, 55);
            this.btn_UcShowAllMemberSearch.Name = "btn_UcShowAllMemberSearch";
            this.btn_UcShowAllMemberSearch.Size = new System.Drawing.Size(158, 37);
            this.btn_UcShowAllMemberSearch.TabIndex = 1;
            this.btn_UcShowAllMemberSearch.Text = "جست و جو";
            this.btn_UcShowAllMemberSearch.UseVisualStyleBackColor = false;
            this.btn_UcShowAllMemberSearch.Click += new System.EventHandler(this.btn_UcShowAllMemberSearch_Click);
            // 
            // swb_UcShowAllMemberMemberGender
            // 
            // 
            // 
            // 
            this.swb_UcShowAllMemberMemberGender.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.swb_UcShowAllMemberMemberGender.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swb_UcShowAllMemberMemberGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swb_UcShowAllMemberMemberGender.Location = new System.Drawing.Point(43, 13);
            this.swb_UcShowAllMemberMemberGender.Name = "swb_UcShowAllMemberMemberGender";
            this.swb_UcShowAllMemberMemberGender.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.swb_UcShowAllMemberMemberGender.OffText = "مرد";
            this.swb_UcShowAllMemberMemberGender.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.swb_UcShowAllMemberMemberGender.OnText = "زن";
            this.swb_UcShowAllMemberMemberGender.ReadOnlyMarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.swb_UcShowAllMemberMemberGender.Size = new System.Drawing.Size(158, 36);
            this.swb_UcShowAllMemberMemberGender.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swb_UcShowAllMemberMemberGender.SwitchBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.swb_UcShowAllMemberMemberGender.SwitchBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.swb_UcShowAllMemberMemberGender.SwitchFont = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.swb_UcShowAllMemberMemberGender.TabIndex = 4;
            this.swb_UcShowAllMemberMemberGender.ValueFalse = "مرد";
            this.swb_UcShowAllMemberMemberGender.ValueObject = "مرد";
            this.swb_UcShowAllMemberMemberGender.ValueTrue = "زن";
            // 
            // lbl_UcShowAllMemberMemberName
            // 
            this.lbl_UcShowAllMemberMemberName.AutoSize = true;
            this.lbl_UcShowAllMemberMemberName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_UcShowAllMemberMemberName.Location = new System.Drawing.Point(599, 10);
            this.lbl_UcShowAllMemberMemberName.Name = "lbl_UcShowAllMemberMemberName";
            this.lbl_UcShowAllMemberMemberName.Size = new System.Drawing.Size(134, 42);
            this.lbl_UcShowAllMemberMemberName.TabIndex = 2;
            this.lbl_UcShowAllMemberMemberName.Text = "نام و نام خانوادگی";
            this.lbl_UcShowAllMemberMemberName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_UcShowAllMemberMemberId
            // 
            this.lbl_UcShowAllMemberMemberId.AutoSize = true;
            this.lbl_UcShowAllMemberMemberId.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_UcShowAllMemberMemberId.Location = new System.Drawing.Point(645, 52);
            this.lbl_UcShowAllMemberMemberId.Name = "lbl_UcShowAllMemberMemberId";
            this.lbl_UcShowAllMemberMemberId.Size = new System.Drawing.Size(88, 43);
            this.lbl_UcShowAllMemberMemberId.TabIndex = 3;
            this.lbl_UcShowAllMemberMemberId.Text = "کد عضویت";
            this.lbl_UcShowAllMemberMemberId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txb_UcShowAllMemberMemberId
            // 
            this.txb_UcShowAllMemberMemberId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_UcShowAllMemberMemberId.Location = new System.Drawing.Point(411, 55);
            this.txb_UcShowAllMemberMemberId.Name = "txb_UcShowAllMemberMemberId";
            this.txb_UcShowAllMemberMemberId.Size = new System.Drawing.Size(158, 36);
            this.txb_UcShowAllMemberMemberId.TabIndex = 0;
            // 
            // txb_UcShowAllMemberMemberName
            // 
            this.txb_UcShowAllMemberMemberName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_UcShowAllMemberMemberName.Location = new System.Drawing.Point(411, 13);
            this.txb_UcShowAllMemberMemberName.Name = "txb_UcShowAllMemberMemberName";
            this.txb_UcShowAllMemberMemberName.Size = new System.Drawing.Size(158, 36);
            this.txb_UcShowAllMemberMemberName.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel4.Controls.Add(this.btn_UcShowAllMemberAddMember, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_UcShowAllMemberShowMemberInfo, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 459);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(798, 46);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btn_UcShowAllMemberAddMember
            // 
            this.btn_UcShowAllMemberAddMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.btn_UcShowAllMemberAddMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_UcShowAllMemberAddMember.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_UcShowAllMemberAddMember.ForeColor = System.Drawing.Color.White;
            this.btn_UcShowAllMemberAddMember.Location = new System.Drawing.Point(421, 3);
            this.btn_UcShowAllMemberAddMember.Name = "btn_UcShowAllMemberAddMember";
            this.btn_UcShowAllMemberAddMember.Size = new System.Drawing.Size(159, 40);
            this.btn_UcShowAllMemberAddMember.TabIndex = 2;
            this.btn_UcShowAllMemberAddMember.Text = "افزودن ورزشکار";
            this.btn_UcShowAllMemberAddMember.UseVisualStyleBackColor = false;
            this.btn_UcShowAllMemberAddMember.Click += new System.EventHandler(this.btn_UcShowAllMemberAddMember_Click);
            // 
            // btn_UcShowAllMemberShowMemberInfo
            // 
            this.btn_UcShowAllMemberShowMemberInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.btn_UcShowAllMemberShowMemberInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_UcShowAllMemberShowMemberInfo.Font = new System.Drawing.Font("B Yekan", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_UcShowAllMemberShowMemberInfo.ForeColor = System.Drawing.Color.White;
            this.btn_UcShowAllMemberShowMemberInfo.Location = new System.Drawing.Point(216, 3);
            this.btn_UcShowAllMemberShowMemberInfo.Name = "btn_UcShowAllMemberShowMemberInfo";
            this.btn_UcShowAllMemberShowMemberInfo.Size = new System.Drawing.Size(159, 40);
            this.btn_UcShowAllMemberShowMemberInfo.TabIndex = 1;
            this.btn_UcShowAllMemberShowMemberInfo.Text = "نمایش اطلاعات";
            this.btn_UcShowAllMemberShowMemberInfo.UseVisualStyleBackColor = false;
            this.btn_UcShowAllMemberShowMemberInfo.Click += new System.EventHandler(this.btn_UcShowAllMemberShowMemberInfo_Click);
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // UC_ShowAllMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "UC_ShowAllMember";
            this.Size = new System.Drawing.Size(804, 508);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UcShowAllMemberShowDgv.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UcShowAllMemberShowDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rayan_sportDataSet)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gpb_lbl_UcShowAllMemberSearch.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private rayan_sportDataSet rayan_sportDataSet;
        private rayan_sportDataSetTableAdapters.memberTableAdapter memberTableAdapter;
        private DevComponents.DotNetBar.Controls.GroupPanel gpb_lbl_UcShowAllMemberSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txb_UcShowAllMemberMemberId;
        private System.Windows.Forms.MaskedTextBox txb_UcShowAllMemberMemberName;
        private System.Windows.Forms.Label lbl_UcShowAllMemberMemberName;
        private System.Windows.Forms.Label lbl_UcShowAllMemberMemberId;
        private DevComponents.DotNetBar.Controls.SwitchButton swb_UcShowAllMemberMemberGender;
        private System.Windows.Forms.Label lbl_UcShowAllMemberMemberGender;
        private System.Windows.Forms.Button btn_UcShowAllMemberSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_UcShowAllMemberShowMemberInfo;
        private System.Windows.Forms.Button btn_UcShowAllMemberAddMember;
        private Telerik.WinControls.UI.RadGridView dgv_UcShowAllMemberShowDgv;
    }
}
