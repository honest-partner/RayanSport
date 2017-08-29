namespace RayanSport.View
{
    partial class UC_ShowMember_ContractInfo
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
            this.dgv_UcShowMemberContractInfoContracts = new System.Windows.Forms.DataGridView();
            this.membership_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipstartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipendDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershiptypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipremainingSessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipreceiptNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershippaymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershippriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershippaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rayan_sportDataSet = new RayanSport.rayan_sportDataSet();
            this.membershipTableAdapter = new RayanSport.rayan_sportDataSetTableAdapters.membershipTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_UcShowMemberContractInfoAddContract = new System.Windows.Forms.Button();
            this.btn_UcShowMemberContractInfoExpireContract = new System.Windows.Forms.Button();
            this.btn_UcShowMemberContractInfoDeleteContract = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cmb_UcShowMemberContractInfoExpireContractPaymentType = new System.Windows.Forms.ComboBox();
            this.lbl_UcShowMemberContractInfoExpireContractPrice = new System.Windows.Forms.Label();
            this.lbl_UcShowMemberContractInfoExpireContractType = new System.Windows.Forms.Label();
            this.cmb_UcShowMemberContractInfoContractType = new System.Windows.Forms.ComboBox();
            this.txb_UcShowMemberContractInfoExpireContractPrice = new System.Windows.Forms.TextBox();
            this.lbl_UcShowMemberContractInfoExpireContractPaymentType = new System.Windows.Forms.Label();
            this.lbl_UcShowMemberContractInfoPayment = new System.Windows.Forms.Label();
            this.cmb_UcShowMemberContractInfoPayment = new System.Windows.Forms.TextBox();
            this.lbl_UcShowMemberContractInfoReciptNum = new System.Windows.Forms.Label();
            this.txb_UcShowMemberContractInfoReciptNum = new System.Windows.Forms.TextBox();
            this.lbl_UcShowMemberContractInfoRemainingSession = new System.Windows.Forms.Label();
            this.txb_UcShowMemberContractInfoRemainingSession = new System.Windows.Forms.TextBox();
            this.lbl_UcShowMemberContractInfoStartDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UcShowMemberContractInfoContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rayan_sportDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_UcShowMemberContractInfoContracts
            // 
            this.dgv_UcShowMemberContractInfoContracts.AllowUserToAddRows = false;
            this.dgv_UcShowMemberContractInfoContracts.AllowUserToDeleteRows = false;
            this.dgv_UcShowMemberContractInfoContracts.AutoGenerateColumns = false;
            this.dgv_UcShowMemberContractInfoContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_UcShowMemberContractInfoContracts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_UcShowMemberContractInfoContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UcShowMemberContractInfoContracts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.membership_id,
            this.membershipstartDateDataGridViewTextBoxColumn,
            this.membershipendDateDataGridViewTextBoxColumn,
            this.membershiptypeDataGridViewTextBoxColumn,
            this.membershipremainingSessionDataGridViewTextBoxColumn,
            this.membershipreceiptNumberDataGridViewTextBoxColumn,
            this.membershippaymentTypeDataGridViewTextBoxColumn,
            this.membershippriceDataGridViewTextBoxColumn,
            this.membershippaymentDataGridViewTextBoxColumn,
            this.membershipdescriptionDataGridViewTextBoxColumn,
            this.membershipstatusDataGridViewTextBoxColumn});
            this.dgv_UcShowMemberContractInfoContracts.DataSource = this.membershipBindingSource;
            this.dgv_UcShowMemberContractInfoContracts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_UcShowMemberContractInfoContracts.Location = new System.Drawing.Point(5, 68);
            this.dgv_UcShowMemberContractInfoContracts.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgv_UcShowMemberContractInfoContracts.Name = "dgv_UcShowMemberContractInfoContracts";
            this.dgv_UcShowMemberContractInfoContracts.ReadOnly = true;
            this.dgv_UcShowMemberContractInfoContracts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_UcShowMemberContractInfoContracts.RowTemplate.Height = 24;
            this.dgv_UcShowMemberContractInfoContracts.Size = new System.Drawing.Size(1360, 238);
            this.dgv_UcShowMemberContractInfoContracts.TabIndex = 0;
            this.dgv_UcShowMemberContractInfoContracts.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_UcShowMemberContractInfoContracts_CellContentDoubleClick);
            // 
            // membership_id
            // 
            this.membership_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.membership_id.DataPropertyName = "membership_id";
            this.membership_id.HeaderText = "شماره";
            this.membership_id.Name = "membership_id";
            this.membership_id.ReadOnly = true;
            this.membership_id.Width = 85;
            // 
            // membershipstartDateDataGridViewTextBoxColumn
            // 
            this.membershipstartDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.membershipstartDateDataGridViewTextBoxColumn.DataPropertyName = "membership_startDate";
            this.membershipstartDateDataGridViewTextBoxColumn.HeaderText = "تاریخ شروع";
            this.membershipstartDateDataGridViewTextBoxColumn.Name = "membershipstartDateDataGridViewTextBoxColumn";
            this.membershipstartDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.membershipstartDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // membershipendDateDataGridViewTextBoxColumn
            // 
            this.membershipendDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.membershipendDateDataGridViewTextBoxColumn.DataPropertyName = "membership_endDate";
            this.membershipendDateDataGridViewTextBoxColumn.HeaderText = "تاریخ اتمام";
            this.membershipendDateDataGridViewTextBoxColumn.Name = "membershipendDateDataGridViewTextBoxColumn";
            this.membershipendDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.membershipendDateDataGridViewTextBoxColumn.Width = 122;
            // 
            // membershiptypeDataGridViewTextBoxColumn
            // 
            this.membershiptypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.membershiptypeDataGridViewTextBoxColumn.DataPropertyName = "membership_type";
            this.membershiptypeDataGridViewTextBoxColumn.HeaderText = "نوع";
            this.membershiptypeDataGridViewTextBoxColumn.Name = "membershiptypeDataGridViewTextBoxColumn";
            this.membershiptypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.membershiptypeDataGridViewTextBoxColumn.Width = 67;
            // 
            // membershipremainingSessionDataGridViewTextBoxColumn
            // 
            this.membershipremainingSessionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.membershipremainingSessionDataGridViewTextBoxColumn.DataPropertyName = "membership_remainingSession";
            this.membershipremainingSessionDataGridViewTextBoxColumn.HeaderText = "جلسات باقی مانده";
            this.membershipremainingSessionDataGridViewTextBoxColumn.Name = "membershipremainingSessionDataGridViewTextBoxColumn";
            this.membershipremainingSessionDataGridViewTextBoxColumn.ReadOnly = true;
            this.membershipremainingSessionDataGridViewTextBoxColumn.Width = 178;
            // 
            // membershipreceiptNumberDataGridViewTextBoxColumn
            // 
            this.membershipreceiptNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.membershipreceiptNumberDataGridViewTextBoxColumn.DataPropertyName = "membership_receiptNumber";
            this.membershipreceiptNumberDataGridViewTextBoxColumn.HeaderText = "شماره پیگیری";
            this.membershipreceiptNumberDataGridViewTextBoxColumn.Name = "membershipreceiptNumberDataGridViewTextBoxColumn";
            this.membershipreceiptNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.membershipreceiptNumberDataGridViewTextBoxColumn.Width = 140;
            // 
            // membershippaymentTypeDataGridViewTextBoxColumn
            // 
            this.membershippaymentTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.membershippaymentTypeDataGridViewTextBoxColumn.DataPropertyName = "membership_paymentType";
            this.membershippaymentTypeDataGridViewTextBoxColumn.HeaderText = "نوع پرداخت";
            this.membershippaymentTypeDataGridViewTextBoxColumn.Name = "membershippaymentTypeDataGridViewTextBoxColumn";
            this.membershippaymentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.membershippaymentTypeDataGridViewTextBoxColumn.Width = 128;
            // 
            // membershippriceDataGridViewTextBoxColumn
            // 
            this.membershippriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.membershippriceDataGridViewTextBoxColumn.DataPropertyName = "membership_price";
            this.membershippriceDataGridViewTextBoxColumn.HeaderText = "قیمت";
            this.membershippriceDataGridViewTextBoxColumn.Name = "membershippriceDataGridViewTextBoxColumn";
            this.membershippriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.membershippriceDataGridViewTextBoxColumn.Width = 83;
            // 
            // membershippaymentDataGridViewTextBoxColumn
            // 
            this.membershippaymentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.membershippaymentDataGridViewTextBoxColumn.DataPropertyName = "membership_payment";
            this.membershippaymentDataGridViewTextBoxColumn.HeaderText = "پرداختی";
            this.membershippaymentDataGridViewTextBoxColumn.Name = "membershippaymentDataGridViewTextBoxColumn";
            this.membershippaymentDataGridViewTextBoxColumn.ReadOnly = true;
            this.membershippaymentDataGridViewTextBoxColumn.Width = 101;
            // 
            // membershipdescriptionDataGridViewTextBoxColumn
            // 
            this.membershipdescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.membershipdescriptionDataGridViewTextBoxColumn.DataPropertyName = "membership_description";
            this.membershipdescriptionDataGridViewTextBoxColumn.HeaderText = "توضیحات";
            this.membershipdescriptionDataGridViewTextBoxColumn.Name = "membershipdescriptionDataGridViewTextBoxColumn";
            this.membershipdescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.membershipdescriptionDataGridViewTextBoxColumn.Width = 111;
            // 
            // membershipstatusDataGridViewTextBoxColumn
            // 
            this.membershipstatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.membershipstatusDataGridViewTextBoxColumn.DataPropertyName = "membership_status";
            this.membershipstatusDataGridViewTextBoxColumn.HeaderText = "وضعیت";
            this.membershipstatusDataGridViewTextBoxColumn.Name = "membershipstatusDataGridViewTextBoxColumn";
            this.membershipstatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.membershipstatusDataGridViewTextBoxColumn.Width = 97;
            // 
            // membershipBindingSource
            // 
            this.membershipBindingSource.DataMember = "membership";
            this.membershipBindingSource.DataSource = this.rayan_sportDataSet;
            // 
            // rayan_sportDataSet
            // 
            this.rayan_sportDataSet.DataSetName = "rayan_sportDataSet";
            this.rayan_sportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membershipTableAdapter
            // 
            this.membershipTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11086F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11086F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.10975F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66853F));
            this.tableLayoutPanel1.Controls.Add(this.btn_UcShowMemberContractInfoAddContract, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_UcShowMemberContractInfoExpireContract, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_UcShowMemberContractInfoDeleteContract, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1364, 56);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btn_UcShowMemberContractInfoAddContract
            // 
            this.btn_UcShowMemberContractInfoAddContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_UcShowMemberContractInfoAddContract.Location = new System.Drawing.Point(1216, 3);
            this.btn_UcShowMemberContractInfoAddContract.Name = "btn_UcShowMemberContractInfoAddContract";
            this.btn_UcShowMemberContractInfoAddContract.Size = new System.Drawing.Size(145, 50);
            this.btn_UcShowMemberContractInfoAddContract.TabIndex = 0;
            this.btn_UcShowMemberContractInfoAddContract.Text = "اضافه کردن قرارداد";
            this.btn_UcShowMemberContractInfoAddContract.UseVisualStyleBackColor = true;
            this.btn_UcShowMemberContractInfoAddContract.Click += new System.EventHandler(this.btn_UcShowMemberContractInfoAddContract_Click);
            // 
            // btn_UcShowMemberContractInfoExpireContract
            // 
            this.btn_UcShowMemberContractInfoExpireContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_UcShowMemberContractInfoExpireContract.Enabled = false;
            this.btn_UcShowMemberContractInfoExpireContract.Location = new System.Drawing.Point(1065, 3);
            this.btn_UcShowMemberContractInfoExpireContract.Name = "btn_UcShowMemberContractInfoExpireContract";
            this.btn_UcShowMemberContractInfoExpireContract.Size = new System.Drawing.Size(145, 50);
            this.btn_UcShowMemberContractInfoExpireContract.TabIndex = 1;
            this.btn_UcShowMemberContractInfoExpireContract.Text = "اتمام قرارداد";
            this.btn_UcShowMemberContractInfoExpireContract.UseVisualStyleBackColor = true;
            // 
            // btn_UcShowMemberContractInfoDeleteContract
            // 
            this.btn_UcShowMemberContractInfoDeleteContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_UcShowMemberContractInfoDeleteContract.Enabled = false;
            this.btn_UcShowMemberContractInfoDeleteContract.Location = new System.Drawing.Point(914, 3);
            this.btn_UcShowMemberContractInfoDeleteContract.Name = "btn_UcShowMemberContractInfoDeleteContract";
            this.btn_UcShowMemberContractInfoDeleteContract.Size = new System.Drawing.Size(145, 50);
            this.btn_UcShowMemberContractInfoDeleteContract.TabIndex = 2;
            this.btn_UcShowMemberContractInfoDeleteContract.Text = "حذف قرارداد";
            this.btn_UcShowMemberContractInfoDeleteContract.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgv_UcShowMemberContractInfoContracts, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1370, 626);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0015F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.33183F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0015F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.33183F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0015F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.33183F));
            this.tableLayoutPanel3.Controls.Add(this.cmb_UcShowMemberContractInfoExpireContractPaymentType, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_UcShowMemberContractInfoExpireContractPrice, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_UcShowMemberContractInfoExpireContractType, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmb_UcShowMemberContractInfoContractType, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txb_UcShowMemberContractInfoExpireContractPrice, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_UcShowMemberContractInfoExpireContractPaymentType, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_UcShowMemberContractInfoPayment, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cmb_UcShowMemberContractInfoPayment, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_UcShowMemberContractInfoReciptNum, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.txb_UcShowMemberContractInfoReciptNum, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_UcShowMemberContractInfoRemainingSession, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.txb_UcShowMemberContractInfoRemainingSession, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_UcShowMemberContractInfoStartDate, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 315);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1364, 308);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // cmb_UcShowMemberContractInfoExpireContractPaymentType
            // 
            this.cmb_UcShowMemberContractInfoExpireContractPaymentType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_UcShowMemberContractInfoExpireContractPaymentType.FormattingEnabled = true;
            this.cmb_UcShowMemberContractInfoExpireContractPaymentType.Items.AddRange(new object[] {
            "نقد",
            "کارت"});
            this.cmb_UcShowMemberContractInfoExpireContractPaymentType.Location = new System.Drawing.Point(3, 3);
            this.cmb_UcShowMemberContractInfoExpireContractPaymentType.Name = "cmb_UcShowMemberContractInfoExpireContractPaymentType";
            this.cmb_UcShowMemberContractInfoExpireContractPaymentType.Size = new System.Drawing.Size(246, 36);
            this.cmb_UcShowMemberContractInfoExpireContractPaymentType.TabIndex = 11;
            // 
            // lbl_UcShowMemberContractInfoExpireContractPrice
            // 
            this.lbl_UcShowMemberContractInfoExpireContractPrice.AutoSize = true;
            this.lbl_UcShowMemberContractInfoExpireContractPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_UcShowMemberContractInfoExpireContractPrice.Location = new System.Drawing.Point(709, 0);
            this.lbl_UcShowMemberContractInfoExpireContractPrice.Name = "lbl_UcShowMemberContractInfoExpireContractPrice";
            this.lbl_UcShowMemberContractInfoExpireContractPrice.Size = new System.Drawing.Size(198, 102);
            this.lbl_UcShowMemberContractInfoExpireContractPrice.TabIndex = 2;
            this.lbl_UcShowMemberContractInfoExpireContractPrice.Text = "مبلغ قرارداد";
            this.lbl_UcShowMemberContractInfoExpireContractPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_UcShowMemberContractInfoExpireContractType
            // 
            this.lbl_UcShowMemberContractInfoExpireContractType.AutoSize = true;
            this.lbl_UcShowMemberContractInfoExpireContractType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_UcShowMemberContractInfoExpireContractType.Location = new System.Drawing.Point(1163, 0);
            this.lbl_UcShowMemberContractInfoExpireContractType.Name = "lbl_UcShowMemberContractInfoExpireContractType";
            this.lbl_UcShowMemberContractInfoExpireContractType.Size = new System.Drawing.Size(198, 102);
            this.lbl_UcShowMemberContractInfoExpireContractType.TabIndex = 0;
            this.lbl_UcShowMemberContractInfoExpireContractType.Text = "نوع قرارداد";
            this.lbl_UcShowMemberContractInfoExpireContractType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_UcShowMemberContractInfoContractType
            // 
            this.cmb_UcShowMemberContractInfoContractType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_UcShowMemberContractInfoContractType.FormattingEnabled = true;
            this.cmb_UcShowMemberContractInfoContractType.Location = new System.Drawing.Point(913, 3);
            this.cmb_UcShowMemberContractInfoContractType.Name = "cmb_UcShowMemberContractInfoContractType";
            this.cmb_UcShowMemberContractInfoContractType.Size = new System.Drawing.Size(244, 36);
            this.cmb_UcShowMemberContractInfoContractType.TabIndex = 1;
            this.cmb_UcShowMemberContractInfoContractType.SelectedValueChanged += new System.EventHandler(this.cmb_UcShowMemberContractInfoContractType_SelectedValueChanged);
            // 
            // txb_UcShowMemberContractInfoExpireContractPrice
            // 
            this.txb_UcShowMemberContractInfoExpireContractPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_UcShowMemberContractInfoExpireContractPrice.Location = new System.Drawing.Point(459, 3);
            this.txb_UcShowMemberContractInfoExpireContractPrice.Name = "txb_UcShowMemberContractInfoExpireContractPrice";
            this.txb_UcShowMemberContractInfoExpireContractPrice.Size = new System.Drawing.Size(244, 36);
            this.txb_UcShowMemberContractInfoExpireContractPrice.TabIndex = 3;
            // 
            // lbl_UcShowMemberContractInfoExpireContractPaymentType
            // 
            this.lbl_UcShowMemberContractInfoExpireContractPaymentType.AutoSize = true;
            this.lbl_UcShowMemberContractInfoExpireContractPaymentType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_UcShowMemberContractInfoExpireContractPaymentType.Location = new System.Drawing.Point(255, 0);
            this.lbl_UcShowMemberContractInfoExpireContractPaymentType.Name = "lbl_UcShowMemberContractInfoExpireContractPaymentType";
            this.lbl_UcShowMemberContractInfoExpireContractPaymentType.Size = new System.Drawing.Size(198, 102);
            this.lbl_UcShowMemberContractInfoExpireContractPaymentType.TabIndex = 4;
            this.lbl_UcShowMemberContractInfoExpireContractPaymentType.Text = "نوع پرداخت";
            this.lbl_UcShowMemberContractInfoExpireContractPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_UcShowMemberContractInfoPayment
            // 
            this.lbl_UcShowMemberContractInfoPayment.AutoSize = true;
            this.lbl_UcShowMemberContractInfoPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_UcShowMemberContractInfoPayment.Location = new System.Drawing.Point(1163, 102);
            this.lbl_UcShowMemberContractInfoPayment.Name = "lbl_UcShowMemberContractInfoPayment";
            this.lbl_UcShowMemberContractInfoPayment.Size = new System.Drawing.Size(198, 102);
            this.lbl_UcShowMemberContractInfoPayment.TabIndex = 6;
            this.lbl_UcShowMemberContractInfoPayment.Text = "هزینه پرداخت شده";
            this.lbl_UcShowMemberContractInfoPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_UcShowMemberContractInfoPayment
            // 
            this.cmb_UcShowMemberContractInfoPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_UcShowMemberContractInfoPayment.Location = new System.Drawing.Point(913, 105);
            this.cmb_UcShowMemberContractInfoPayment.Name = "cmb_UcShowMemberContractInfoPayment";
            this.cmb_UcShowMemberContractInfoPayment.Size = new System.Drawing.Size(244, 36);
            this.cmb_UcShowMemberContractInfoPayment.TabIndex = 7;
            // 
            // lbl_UcShowMemberContractInfoReciptNum
            // 
            this.lbl_UcShowMemberContractInfoReciptNum.AutoSize = true;
            this.lbl_UcShowMemberContractInfoReciptNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_UcShowMemberContractInfoReciptNum.Location = new System.Drawing.Point(709, 102);
            this.lbl_UcShowMemberContractInfoReciptNum.Name = "lbl_UcShowMemberContractInfoReciptNum";
            this.lbl_UcShowMemberContractInfoReciptNum.Size = new System.Drawing.Size(198, 102);
            this.lbl_UcShowMemberContractInfoReciptNum.TabIndex = 9;
            this.lbl_UcShowMemberContractInfoReciptNum.Text = "شماره پیگیری";
            this.lbl_UcShowMemberContractInfoReciptNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txb_UcShowMemberContractInfoReciptNum
            // 
            this.txb_UcShowMemberContractInfoReciptNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_UcShowMemberContractInfoReciptNum.Location = new System.Drawing.Point(459, 105);
            this.txb_UcShowMemberContractInfoReciptNum.Name = "txb_UcShowMemberContractInfoReciptNum";
            this.txb_UcShowMemberContractInfoReciptNum.Size = new System.Drawing.Size(244, 36);
            this.txb_UcShowMemberContractInfoReciptNum.TabIndex = 12;
            // 
            // lbl_UcShowMemberContractInfoRemainingSession
            // 
            this.lbl_UcShowMemberContractInfoRemainingSession.AutoSize = true;
            this.lbl_UcShowMemberContractInfoRemainingSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_UcShowMemberContractInfoRemainingSession.Location = new System.Drawing.Point(255, 102);
            this.lbl_UcShowMemberContractInfoRemainingSession.Name = "lbl_UcShowMemberContractInfoRemainingSession";
            this.lbl_UcShowMemberContractInfoRemainingSession.Size = new System.Drawing.Size(198, 102);
            this.lbl_UcShowMemberContractInfoRemainingSession.TabIndex = 13;
            this.lbl_UcShowMemberContractInfoRemainingSession.Text = "جلسات باقی مانده";
            this.lbl_UcShowMemberContractInfoRemainingSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txb_UcShowMemberContractInfoRemainingSession
            // 
            this.txb_UcShowMemberContractInfoRemainingSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_UcShowMemberContractInfoRemainingSession.Location = new System.Drawing.Point(3, 105);
            this.txb_UcShowMemberContractInfoRemainingSession.Name = "txb_UcShowMemberContractInfoRemainingSession";
            this.txb_UcShowMemberContractInfoRemainingSession.Size = new System.Drawing.Size(246, 36);
            this.txb_UcShowMemberContractInfoRemainingSession.TabIndex = 14;
            // 
            // lbl_UcShowMemberContractInfoStartDate
            // 
            this.lbl_UcShowMemberContractInfoStartDate.AutoSize = true;
            this.lbl_UcShowMemberContractInfoStartDate.Location = new System.Drawing.Point(1207, 204);
            this.lbl_UcShowMemberContractInfoStartDate.Name = "lbl_UcShowMemberContractInfoStartDate";
            this.lbl_UcShowMemberContractInfoStartDate.Size = new System.Drawing.Size(154, 28);
            this.lbl_UcShowMemberContractInfoStartDate.TabIndex = 15;
            this.lbl_UcShowMemberContractInfoStartDate.Text = "تاریخ شروع قرارداد";
            // 
            // UC_ShowMember_ContractInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("B Yekan+", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UC_ShowMember_ContractInfo";
            this.Size = new System.Drawing.Size(1370, 626);
            this.Load += new System.EventHandler(this.UC_ShowMember_ContractInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UcShowMemberContractInfoContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rayan_sportDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_UcShowMemberContractInfoContracts;
        private System.Windows.Forms.BindingSource membershipBindingSource;
        private rayan_sportDataSet rayan_sportDataSet;
        private rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn membership_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipstartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipendDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershiptypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipremainingSessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipreceiptNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershippaymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershippriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershippaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_UcShowMemberContractInfoAddContract;
        private System.Windows.Forms.Button btn_UcShowMemberContractInfoExpireContract;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_UcShowMemberContractInfoDeleteContract;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cmb_UcShowMemberContractInfoExpireContractPaymentType;
        private System.Windows.Forms.Label lbl_UcShowMemberContractInfoExpireContractPrice;
        private System.Windows.Forms.Label lbl_UcShowMemberContractInfoExpireContractType;
        private System.Windows.Forms.ComboBox cmb_UcShowMemberContractInfoContractType;
        private System.Windows.Forms.TextBox txb_UcShowMemberContractInfoExpireContractPrice;
        private System.Windows.Forms.Label lbl_UcShowMemberContractInfoExpireContractPaymentType;
        private System.Windows.Forms.Label lbl_UcShowMemberContractInfoPayment;
        private System.Windows.Forms.TextBox cmb_UcShowMemberContractInfoPayment;
        private System.Windows.Forms.Label lbl_UcShowMemberContractInfoReciptNum;
        private System.Windows.Forms.TextBox txb_UcShowMemberContractInfoReciptNum;
        private System.Windows.Forms.Label lbl_UcShowMemberContractInfoRemainingSession;
        private System.Windows.Forms.TextBox txb_UcShowMemberContractInfoRemainingSession;
        private System.Windows.Forms.Label lbl_UcShowMemberContractInfoStartDate;
    }
}
