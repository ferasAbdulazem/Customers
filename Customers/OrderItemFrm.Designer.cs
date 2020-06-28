namespace Customers
{
    partial class OrderItemFrm
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
            System.Windows.Forms.Label deliveryDateLabel;
            System.Windows.Forms.Label priceLabel1;
            System.Windows.Forms.Label discountLabel1;
            System.Windows.Forms.Label label2;
            this.bsProducts = new System.Windows.Forms.BindingSource(this.components);
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bsOrderItems = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            deliveryDateLabel = new System.Windows.Forms.Label();
            priceLabel1 = new System.Windows.Forms.Label();
            discountLabel1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // deliveryDateLabel
            // 
            deliveryDateLabel.AutoSize = true;
            deliveryDateLabel.Location = new System.Drawing.Point(476, 10);
            deliveryDateLabel.Name = "deliveryDateLabel";
            deliveryDateLabel.Size = new System.Drawing.Size(107, 20);
            deliveryDateLabel.TabIndex = 2;
            deliveryDateLabel.Text = "Delivery Date:";
            // 
            // priceLabel1
            // 
            priceLabel1.AutoSize = true;
            priceLabel1.Location = new System.Drawing.Point(46, 62);
            priceLabel1.Name = "priceLabel1";
            priceLabel1.Size = new System.Drawing.Size(48, 20);
            priceLabel1.TabIndex = 9;
            priceLabel1.Text = "Price:";
            // 
            // discountLabel1
            // 
            discountLabel1.AutoSize = true;
            discountLabel1.Location = new System.Drawing.Point(46, 107);
            discountLabel1.Name = "discountLabel1";
            discountLabel1.Size = new System.Drawing.Size(76, 20);
            discountLabel1.TabIndex = 10;
            discountLabel1.Text = "Discount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(363, 107);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 20);
            label2.TabIndex = 12;
            label2.Text = "Amount:";
            // 
            // bsProducts
            // 
            this.bsProducts.DataSource = typeof(CustomerBL.Models.Product);
            this.bsProducts.CurrentChanged += new System.EventHandler(this.bsProducts_CurrentChanged);
            // 
            // productComboBox
            // 
            this.productComboBox.DataSource = this.bsProducts;
            this.productComboBox.DisplayMember = "Title";
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(91, 12);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(300, 28);
            this.productComboBox.TabIndex = 1;
            this.productComboBox.ValueMember = "Discount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product";
            // 
            // bsOrderItems
            // 
            this.bsOrderItems.DataSource = typeof(CustomerBL.Models.OrderItem);
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsOrderItems, "DeliveryDate", true));
            this.dtpDeliveryDate.Location = new System.Drawing.Point(589, 6);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(200, 26);
            this.dtpDeliveryDate.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(617, 343);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(159, 72);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nudPrice
            // 
            this.nudPrice.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsOrderItems, "Price", true));
            this.nudPrice.Location = new System.Drawing.Point(100, 62);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(120, 26);
            this.nudPrice.TabIndex = 10;
            // 
            // nudDiscount
            // 
            this.nudDiscount.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsOrderItems, "Discount", true));
            this.nudDiscount.Location = new System.Drawing.Point(128, 107);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(120, 26);
            this.nudDiscount.TabIndex = 11;
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(445, 107);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(120, 26);
            this.nudAmount.TabIndex = 13;
            // 
            // OrderItemFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(label2);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(discountLabel1);
            this.Controls.Add(this.nudDiscount);
            this.Controls.Add(priceLabel1);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(deliveryDateLabel);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productComboBox);
            this.Name = "OrderItemFrm";
            this.Text = "OrderItemFrm";
            this.Load += new System.EventHandler(this.OrderItemFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsProducts;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsOrderItems;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.NumericUpDown nudAmount;
    }
}