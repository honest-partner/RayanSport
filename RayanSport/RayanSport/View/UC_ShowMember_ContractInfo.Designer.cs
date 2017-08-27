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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rayan_sportDataSet = new RayanSport.rayan_sportDataSet();
            this.membershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membershipTableAdapter = new RayanSport.rayan_sportDataSetTableAdapters.membershipTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rayan_sportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
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
            this.dataGridView1.DataSource = this.membershipBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 102);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1370, 524);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(725, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 36);
            this.textBox1.TabIndex = 1;
            // 
            // rayan_sportDataSet
            // 
            this.rayan_sportDataSet.DataSetName = "rayan_sportDataSet";
            this.rayan_sportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membershipBindingSource
            // 
            this.membershipBindingSource.DataMember = "membership";
            this.membershipBindingSource.DataSource = this.rayan_sportDataSet;
            // 
            // membershipTableAdapter
            // 
            this.membershipTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "membership_id";
            this.Column1.HeaderText = "شماره قرارداد";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // membershipstartDateDataGridViewTextBoxColumn
            // 
            this.membershipstartDateDataGridViewTextBoxColumn.DataPropertyName = "membership_startDate";
            this.membershipstartDateDataGridViewTextBoxColumn.HeaderText = "تاریخ شروع قرار داد";
            this.membershipstartDateDataGridViewTextBoxColumn.Name = "membershipstartDateDataGridViewTextBoxColumn";
            // 
            // membershipendDateDataGridViewTextBoxColumn
            // 
            this.membershipendDateDataGridViewTextBoxColumn.DataPropertyName = "membership_endDate";
            this.membershipendDateDataGridViewTextBoxColumn.HeaderText = "تاریخ اتمام قرارداد";
            this.membershipendDateDataGridViewTextBoxColumn.Name = "membershipendDateDataGridViewTextBoxColumn";
            // 
            // membershiptypeDataGridViewTextBoxColumn
            // 
            this.membershiptypeDataGridViewTextBoxColumn.DataPropertyName = "membership_type";
            this.membershiptypeDataGridViewTextBoxColumn.HeaderText = "نوع قرارداد";
            this.membershiptypeDataGridViewTextBoxColumn.Name = "membershiptypeDataGridViewTextBoxColumn";
            // 
            // membershipremainingSessionDataGridViewTextBoxColumn
            // 
            this.membershipremainingSessionDataGridViewTextBoxColumn.DataPropertyName = "membership_remainingSession";
            this.membershipremainingSessionDataGridViewTextBoxColumn.HeaderText = "تعداد جلسات باقی مانده";
            this.membershipremainingSessionDataGridViewTextBoxColumn.Name = "membershipremainingSessionDataGridViewTextBoxColumn";
            // 
            // membershipreceiptNumberDataGridViewTextBoxColumn
            // 
            this.membershipreceiptNumberDataGridViewTextBoxColumn.DataPropertyName = "membership_receiptNumber";
            this.membershipreceiptNumberDataGridViewTextBoxColumn.HeaderText = "شماره پیگیری";
            this.membershipreceiptNumberDataGridViewTextBoxColumn.Name = "membershipreceiptNumberDataGridViewTextBoxColumn";
            // 
            // membershippaymentTypeDataGridViewTextBoxColumn
            // 
            this.membershippaymentTypeDataGridViewTextBoxColumn.DataPropertyName = "membership_paymentType";
            this.membershippaymentTypeDataGridViewTextBoxColumn.HeaderText = "نوع پرداخت";
            this.membershippaymentTypeDataGridViewTextBoxColumn.Name = "membershippaymentTypeDataGridViewTextBoxColumn";
            // 
            // membershippriceDataGridViewTextBoxColumn
            // 
            this.membershippriceDataGridViewTextBoxColumn.DataPropertyName = "membership_price";
            this.membershippriceDataGridViewTextBoxColumn.HeaderText = "قیمت";
            this.membershippriceDataGridViewTextBoxColumn.Name = "membershippriceDataGridViewTextBoxColumn";
            // 
            // membershippaymentDataGridViewTextBoxColumn
            // 
            this.membershippaymentDataGridViewTextBoxColumn.DataPropertyName = "membership_payment";
            this.membershippaymentDataGridViewTextBoxColumn.HeaderText = "هزینه پرداخت شده";
            this.membershippaymentDataGridViewTextBoxColumn.Name = "membershippaymentDataGridViewTextBoxColumn";
            // 
            // membershipdescriptionDataGridViewTextBoxColumn
            // 
            this.membershipdescriptionDataGridViewTextBoxColumn.DataPropertyName = "membership_description";
            this.membershipdescriptionDataGridViewTextBoxColumn.HeaderText = "توضیحات";
            this.membershipdescriptionDataGridViewTextBoxColumn.Name = "membershipdescriptionDataGridViewTextBoxColumn";
            // 
            // membershipstatusDataGridViewTextBoxColumn
            // 
            this.membershipstatusDataGridViewTextBoxColumn.DataPropertyName = "membership_status";
            this.membershipstatusDataGridViewTextBoxColumn.HeaderText = "وضعیت";
            this.membershipstatusDataGridViewTextBoxColumn.Name = "membershipstatusDataGridViewTextBoxColumn";
            // 
            // UC_ShowMember_ContractInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("B Yekan+", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UC_ShowMember_ContractInfo";
            this.Size = new System.Drawing.Size(1370, 626);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rayan_sportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
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
        private System.Windows.Forms.BindingSource membershipBindingSource;
        private rayan_sportDataSet rayan_sportDataSet;
        private System.Windows.Forms.TextBox textBox1;
        private rayan_sportDataSetTableAdapters.membershipTableAdapter membershipTableAdapter;
    }
}
