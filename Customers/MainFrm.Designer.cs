namespace Customers
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label fNameLabel;
            System.Windows.Forms.Label lNameLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label currencyLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label discountLabel1;
            System.Windows.Forms.Label isActiveLabel;
            System.Windows.Forms.Label isPartialLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label orderDateLabel1;
            this.bsCustomerNames = new System.Windows.Forms.BindingSource(this.components);
            this.cbCustomerNames = new System.Windows.Forms.ComboBox();
            this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.bsCurrency = new System.Windows.Forms.BindingSource(this.components);
            this.bsGenders = new System.Windows.Forms.BindingSource(this.components);
            this.vMGendersComboBox = new System.Windows.Forms.ComboBox();
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.bsCustomerOrders = new System.Windows.Forms.BindingSource(this.components);
            this.vMOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPartialDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deliveryAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingAddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOrderItems = new System.Windows.Forms.BindingSource(this.components);
            this.vMOrderItemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.bsOrder = new System.Windows.Forms.BindingSource(this.components);
            this.nudOrderDiscount = new System.Windows.Forms.NumericUpDown();
            this.isActiveCheckBox1 = new System.Windows.Forms.CheckBox();
            this.isPartialCheckBox = new System.Windows.Forms.CheckBox();
            this.bsDeliveryAdd = new System.Windows.Forms.BindingSource(this.components);
            this.bsBillingAdd = new System.Windows.Forms.BindingSource(this.components);
            this.submitOrder = new System.Windows.Forms.Button();
            this.gbOrderFrm = new System.Windows.Forms.GroupBox();
            this.cbOrderCurrency = new System.Windows.Forms.ComboBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.vMAddressListComboBox2 = new System.Windows.Forms.ComboBox();
            this.vMAddressListComboBox3 = new System.Windows.Forms.ComboBox();
            this.orderDateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            birthDateLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            fNameLabel = new System.Windows.Forms.Label();
            lNameLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            currencyLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            discountLabel1 = new System.Windows.Forms.Label();
            isActiveLabel = new System.Windows.Forms.Label();
            isPartialLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            orderDateLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomerNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGenders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomerOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMOrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMOrderItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrderDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeliveryAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBillingAdd)).BeginInit();
            this.gbOrderFrm.SuspendLayout();
            this.SuspendLayout();
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new System.Drawing.Point(438, 18);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(85, 20);
            birthDateLabel.TabIndex = 1;
            birthDateLabel.Text = "Birth Date:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(447, 196);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(76, 20);
            discountLabel.TabIndex = 5;
            discountLabel.Text = "Discount:";
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.Location = new System.Drawing.Point(458, 60);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new System.Drawing.Size(65, 20);
            fNameLabel.TabIndex = 7;
            fNameLabel.Text = "FName:";
            // 
            // lNameLabel
            // 
            lNameLabel.AutoSize = true;
            lNameLabel.Location = new System.Drawing.Point(459, 105);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new System.Drawing.Size(64, 20);
            lNameLabel.TabIndex = 11;
            lNameLabel.Text = "LName:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(481, 149);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(42, 20);
            titleLabel.TabIndex = 13;
            titleLabel.Text = "Title:";
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Location = new System.Drawing.Point(765, 108);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new System.Drawing.Size(76, 20);
            currencyLabel.TabIndex = 14;
            currencyLabel.Text = "Currency:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(774, 57);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(67, 20);
            genderLabel.TabIndex = 15;
            genderLabel.Text = "Gender:";
            // 
            // discountLabel1
            // 
            discountLabel1.AutoSize = true;
            discountLabel1.Location = new System.Drawing.Point(14, 59);
            discountLabel1.Name = "discountLabel1";
            discountLabel1.Size = new System.Drawing.Size(76, 20);
            discountLabel1.TabIndex = 21;
            discountLabel1.Text = "Discount:";
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new System.Drawing.Point(568, 107);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new System.Drawing.Size(73, 20);
            isActiveLabel.TabIndex = 23;
            isActiveLabel.Text = "Is Active:";
            // 
            // isPartialLabel
            // 
            isPartialLabel.AutoSize = true;
            isPartialLabel.Location = new System.Drawing.Point(570, 145);
            isPartialLabel.Name = "isPartialLabel";
            isPartialLabel.Size = new System.Drawing.Size(74, 20);
            isPartialLabel.TabIndex = 25;
            isPartialLabel.Text = "Is Partial:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 113);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(131, 20);
            label1.TabIndex = 31;
            label1.Text = "Delivery Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 148);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(117, 20);
            label2.TabIndex = 32;
            label2.Text = "Billing Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 207);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 20);
            label3.TabIndex = 35;
            label3.Text = "Currency:";
            // 
            // bsCustomerNames
            // 
            this.bsCustomerNames.DataSource = typeof(CustomerBL.ViewModels.VMCustomerNames);
            // 
            // cbCustomerNames
            // 
            this.cbCustomerNames.DataSource = this.bsCustomerNames;
            this.cbCustomerNames.DisplayMember = "FullName";
            this.cbCustomerNames.FormattingEnabled = true;
            this.cbCustomerNames.Location = new System.Drawing.Point(12, 12);
            this.cbCustomerNames.Name = "cbCustomerNames";
            this.cbCustomerNames.Size = new System.Drawing.Size(300, 28);
            this.cbCustomerNames.TabIndex = 0;
            this.cbCustomerNames.ValueMember = "CustomerID";
            this.cbCustomerNames.SelectionChangeCommitted += new System.EventHandler(this.cbCustomerNames_SelectionChangeCommitted);
            // 
            // bsCustomer
            // 
            this.bsCustomer.DataSource = typeof(CustomerBL.Models.Customer);
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsCustomer, "BirthDate", true));
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(529, 14);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.birthDateDateTimePicker.TabIndex = 2;
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "Discount", true));
            this.discountTextBox.Location = new System.Drawing.Point(529, 190);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(100, 26);
            this.discountTextBox.TabIndex = 6;
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "FName", true));
            this.fNameTextBox.Location = new System.Drawing.Point(529, 57);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.fNameTextBox.TabIndex = 8;
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsCustomer, "IsActive", true));
            this.isActiveCheckBox.Location = new System.Drawing.Point(862, 18);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isActiveCheckBox.TabIndex = 10;
            this.isActiveCheckBox.Text = "IsActive";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "LName", true));
            this.lNameTextBox.Location = new System.Drawing.Point(529, 102);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.lNameTextBox.TabIndex = 12;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCustomer, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(529, 146);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 26);
            this.titleTextBox.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(925, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 63);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(925, 260);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(135, 63);
            this.btnNew.TabIndex = 18;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // bsCurrency
            // 
            this.bsCurrency.DataSource = typeof(CustomerBL.ViewModels.VMCurrency);
            // 
            // bsGenders
            // 
            this.bsGenders.DataSource = typeof(CustomerBL.ViewModels.VMGenders);
            // 
            // vMGendersComboBox
            // 
            this.vMGendersComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsCustomer, "GenderID", true));
            this.vMGendersComboBox.DataSource = this.bsGenders;
            this.vMGendersComboBox.DisplayMember = "Titel";
            this.vMGendersComboBox.FormattingEnabled = true;
            this.vMGendersComboBox.Location = new System.Drawing.Point(862, 55);
            this.vMGendersComboBox.Name = "vMGendersComboBox";
            this.vMGendersComboBox.Size = new System.Drawing.Size(198, 28);
            this.vMGendersComboBox.TabIndex = 18;
            this.vMGendersComboBox.ValueMember = "GenderID";
            // 
            // cbCurrency
            // 
            this.cbCurrency.BackColor = System.Drawing.Color.White;
            this.cbCurrency.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsCustomer, "CurrencyID", true));
            this.cbCurrency.DataSource = this.bsCurrency;
            this.cbCurrency.DisplayMember = "Currency";
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Location = new System.Drawing.Point(862, 105);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(198, 28);
            this.cbCurrency.TabIndex = 18;
            this.cbCurrency.ValueMember = "CurrencyID";
            // 
            // bsCustomerOrders
            // 
            this.bsCustomerOrders.DataSource = typeof(CustomerBL.ViewModels.VMOrder);
            this.bsCustomerOrders.CurrentChanged += new System.EventHandler(this.bsCustomerOrders_CurrentChanged);
            // 
            // vMOrderDataGridView
            // 
            this.vMOrderDataGridView.AutoGenerateColumns = false;
            this.vMOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vMOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn,
            this.isPartialDataGridViewCheckBoxColumn,
            this.deliveryAddDataGridViewTextBoxColumn,
            this.billingAddDataGridViewTextBoxColumn,
            this.totalSumDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn});
            this.vMOrderDataGridView.DataSource = this.bsCustomerOrders;
            this.vMOrderDataGridView.Location = new System.Drawing.Point(26, 369);
            this.vMOrderDataGridView.Name = "vMOrderDataGridView";
            this.vMOrderDataGridView.RowTemplate.Height = 28;
            this.vMOrderDataGridView.Size = new System.Drawing.Size(955, 202);
            this.vMOrderDataGridView.TabIndex = 18;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "Currency";
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            // 
            // isPartialDataGridViewCheckBoxColumn
            // 
            this.isPartialDataGridViewCheckBoxColumn.DataPropertyName = "IsPartial";
            this.isPartialDataGridViewCheckBoxColumn.HeaderText = "IsPartial";
            this.isPartialDataGridViewCheckBoxColumn.Name = "isPartialDataGridViewCheckBoxColumn";
            // 
            // deliveryAddDataGridViewTextBoxColumn
            // 
            this.deliveryAddDataGridViewTextBoxColumn.DataPropertyName = "DeliveryAdd";
            this.deliveryAddDataGridViewTextBoxColumn.HeaderText = "DeliveryAdd";
            this.deliveryAddDataGridViewTextBoxColumn.Name = "deliveryAddDataGridViewTextBoxColumn";
            // 
            // billingAddDataGridViewTextBoxColumn
            // 
            this.billingAddDataGridViewTextBoxColumn.DataPropertyName = "BillingAdd";
            this.billingAddDataGridViewTextBoxColumn.HeaderText = "BillingAdd";
            this.billingAddDataGridViewTextBoxColumn.Name = "billingAddDataGridViewTextBoxColumn";
            // 
            // totalSumDataGridViewTextBoxColumn
            // 
            this.totalSumDataGridViewTextBoxColumn.DataPropertyName = "TotalSum";
            this.totalSumDataGridViewTextBoxColumn.HeaderText = "TotalSum";
            this.totalSumDataGridViewTextBoxColumn.Name = "totalSumDataGridViewTextBoxColumn";
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            // 
            // bsOrderItems
            // 
            this.bsOrderItems.DataSource = typeof(CustomerBL.ViewModels.VMOrderItem);
            // 
            // vMOrderItemDataGridView
            // 
            this.vMOrderItemDataGridView.AutoGenerateColumns = false;
            this.vMOrderItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vMOrderItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewTextBoxColumn14});
            this.vMOrderItemDataGridView.DataSource = this.bsOrderItems;
            this.vMOrderItemDataGridView.Location = new System.Drawing.Point(26, 598);
            this.vMOrderItemDataGridView.Name = "vMOrderItemDataGridView";
            this.vMOrderItemDataGridView.RowTemplate.Height = 28;
            this.vMOrderItemDataGridView.Size = new System.Drawing.Size(955, 220);
            this.vMOrderItemDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn8.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ItemNumber";
            this.dataGridViewTextBoxColumn9.HeaderText = "ItemNumber";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Product";
            this.dataGridViewTextBoxColumn10.HeaderText = "Product";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "DeliveryDate";
            this.dataGridViewTextBoxColumn11.HeaderText = "DeliveryDate";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn12.HeaderText = "Price";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn13.HeaderText = "Discount";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "IsPartial";
            this.dataGridViewCheckBoxColumn3.HeaderText = "IsPartial";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Sum";
            this.dataGridViewTextBoxColumn14.HeaderText = "Sum";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(1023, 369);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(135, 63);
            this.btnAddOrder.TabIndex = 20;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // bsOrder
            // 
            this.bsOrder.DataSource = typeof(CustomerBL.Models.Order);
            // 
            // nudOrderDiscount
            // 
            this.nudOrderDiscount.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsOrder, "Discount", true));
            this.nudOrderDiscount.Location = new System.Drawing.Point(96, 59);
            this.nudOrderDiscount.Name = "nudOrderDiscount";
            this.nudOrderDiscount.Size = new System.Drawing.Size(120, 26);
            this.nudOrderDiscount.TabIndex = 22;
            // 
            // isActiveCheckBox1
            // 
            this.isActiveCheckBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsOrder, "IsActive", true));
            this.isActiveCheckBox1.Location = new System.Drawing.Point(647, 102);
            this.isActiveCheckBox1.Name = "isActiveCheckBox1";
            this.isActiveCheckBox1.Size = new System.Drawing.Size(104, 24);
            this.isActiveCheckBox1.TabIndex = 24;
            this.isActiveCheckBox1.UseVisualStyleBackColor = true;
            // 
            // isPartialCheckBox
            // 
            this.isPartialCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsOrder, "IsPartial", true));
            this.isPartialCheckBox.Location = new System.Drawing.Point(650, 140);
            this.isPartialCheckBox.Name = "isPartialCheckBox";
            this.isPartialCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isPartialCheckBox.TabIndex = 26;
            this.isPartialCheckBox.UseVisualStyleBackColor = true;
            // 
            // bsDeliveryAdd
            // 
            this.bsDeliveryAdd.DataSource = typeof(CustomerBL.ViewModels.VMAddressList);
            // 
            // bsBillingAdd
            // 
            this.bsBillingAdd.DataSource = typeof(CustomerBL.ViewModels.VMAddressList);
            // 
            // submitOrder
            // 
            this.submitOrder.Location = new System.Drawing.Point(572, 245);
            this.submitOrder.Name = "submitOrder";
            this.submitOrder.Size = new System.Drawing.Size(135, 63);
            this.submitOrder.TabIndex = 33;
            this.submitOrder.Text = "Save";
            this.submitOrder.UseVisualStyleBackColor = true;
            this.submitOrder.Click += new System.EventHandler(this.submitOrder_Click);
            // 
            // gbOrderFrm
            // 
            this.gbOrderFrm.Controls.Add(orderDateLabel1);
            this.gbOrderFrm.Controls.Add(this.orderDateDateTimePicker1);
            this.gbOrderFrm.Controls.Add(this.vMAddressListComboBox3);
            this.gbOrderFrm.Controls.Add(this.vMAddressListComboBox2);
            this.gbOrderFrm.Controls.Add(label3);
            this.gbOrderFrm.Controls.Add(this.cbOrderCurrency);
            this.gbOrderFrm.Controls.Add(this.nudOrderDiscount);
            this.gbOrderFrm.Controls.Add(this.submitOrder);
            this.gbOrderFrm.Controls.Add(discountLabel1);
            this.gbOrderFrm.Controls.Add(label2);
            this.gbOrderFrm.Controls.Add(isPartialLabel);
            this.gbOrderFrm.Controls.Add(label1);
            this.gbOrderFrm.Controls.Add(this.isPartialCheckBox);
            this.gbOrderFrm.Controls.Add(isActiveLabel);
            this.gbOrderFrm.Controls.Add(this.isActiveCheckBox1);
            this.gbOrderFrm.Location = new System.Drawing.Point(1023, 460);
            this.gbOrderFrm.Name = "gbOrderFrm";
            this.gbOrderFrm.Size = new System.Drawing.Size(774, 334);
            this.gbOrderFrm.TabIndex = 34;
            this.gbOrderFrm.TabStop = false;
            this.gbOrderFrm.Text = "Order Form";
            this.gbOrderFrm.Visible = false;
            // 
            // cbOrderCurrency
            // 
            this.cbOrderCurrency.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsOrder, "CurrencyID", true));
            this.cbOrderCurrency.DataSource = this.bsCurrency;
            this.cbOrderCurrency.DisplayMember = "Currency";
            this.cbOrderCurrency.FormattingEnabled = true;
            this.cbOrderCurrency.Location = new System.Drawing.Point(151, 199);
            this.cbOrderCurrency.Name = "cbOrderCurrency";
            this.cbOrderCurrency.Size = new System.Drawing.Size(300, 28);
            this.cbOrderCurrency.TabIndex = 34;
            this.cbOrderCurrency.ValueMember = "CurrencyID";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(26, 838);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(135, 63);
            this.btnAddItem.TabIndex = 35;
            this.btnAddItem.Text = "AddItem";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // vMAddressListComboBox2
            // 
            this.vMAddressListComboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsOrder, "DeliveryAddID", true));
            this.vMAddressListComboBox2.DataSource = this.bsDeliveryAdd;
            this.vMAddressListComboBox2.DisplayMember = "FullAddress";
            this.vMAddressListComboBox2.FormattingEnabled = true;
            this.vMAddressListComboBox2.Location = new System.Drawing.Point(151, 110);
            this.vMAddressListComboBox2.Name = "vMAddressListComboBox2";
            this.vMAddressListComboBox2.Size = new System.Drawing.Size(352, 28);
            this.vMAddressListComboBox2.TabIndex = 35;
            this.vMAddressListComboBox2.ValueMember = "AddressID";
            // 
            // vMAddressListComboBox3
            // 
            this.vMAddressListComboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsOrder, "BillingAddID", true));
            this.vMAddressListComboBox3.DataSource = this.bsBillingAdd;
            this.vMAddressListComboBox3.DisplayMember = "FullAddress";
            this.vMAddressListComboBox3.FormattingEnabled = true;
            this.vMAddressListComboBox3.Location = new System.Drawing.Point(151, 148);
            this.vMAddressListComboBox3.Name = "vMAddressListComboBox3";
            this.vMAddressListComboBox3.Size = new System.Drawing.Size(352, 28);
            this.vMAddressListComboBox3.TabIndex = 35;
            this.vMAddressListComboBox3.ValueMember = "AddressID";
            // 
            // orderDateLabel1
            // 
            orderDateLabel1.AutoSize = true;
            orderDateLabel1.Location = new System.Drawing.Point(380, 61);
            orderDateLabel1.Name = "orderDateLabel1";
            orderDateLabel1.Size = new System.Drawing.Size(92, 20);
            orderDateLabel1.TabIndex = 35;
            orderDateLabel1.Text = "Order Date:";
            // 
            // orderDateDateTimePicker1
            // 
            this.orderDateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsOrder, "OrderDate", true));
            this.orderDateDateTimePicker1.Location = new System.Drawing.Point(478, 57);
            this.orderDateDateTimePicker1.Name = "orderDateDateTimePicker1";
            this.orderDateDateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.orderDateDateTimePicker1.TabIndex = 36;
            // 
            // MainFrm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1797, 973);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.gbOrderFrm);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.vMOrderItemDataGridView);
            this.Controls.Add(this.vMOrderDataGridView);
            this.Controls.Add(this.vMGendersComboBox);
            this.Controls.Add(this.cbCurrency);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(genderLabel);
            this.Controls.Add(currencyLabel);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(lNameLabel);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(fNameLabel);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(discountLabel);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(this.cbCustomerNames);
            this.Name = "MainFrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomerNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGenders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomerOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMOrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vMOrderItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrderDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDeliveryAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBillingAdd)).EndInit();
            this.gbOrderFrm.ResumeLayout(false);
            this.gbOrderFrm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsCustomerNames;
        private System.Windows.Forms.ComboBox cbCustomerNames;
        private System.Windows.Forms.BindingSource bsCustomer;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.BindingSource bsCurrency;
        private System.Windows.Forms.BindingSource bsGenders;
        private System.Windows.Forms.ComboBox vMGendersComboBox;
        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.BindingSource bsCustomerOrders;
        private System.Windows.Forms.DataGridView vMOrderDataGridView;
        private System.Windows.Forms.BindingSource bsOrderItems;
        private System.Windows.Forms.DataGridView vMOrderItemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.BindingSource bsOrder;
        private System.Windows.Forms.NumericUpDown nudOrderDiscount;
        private System.Windows.Forms.CheckBox isActiveCheckBox1;
        private System.Windows.Forms.CheckBox isPartialCheckBox;
        private System.Windows.Forms.BindingSource bsDeliveryAdd;
        private System.Windows.Forms.BindingSource bsBillingAdd;
        private System.Windows.Forms.Button submitOrder;
        private System.Windows.Forms.GroupBox gbOrderFrm;
        private System.Windows.Forms.ComboBox cbOrderCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isPartialDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryAddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingAddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ComboBox vMAddressListComboBox2;
        private System.Windows.Forms.ComboBox vMAddressListComboBox3;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker1;
    }
}

