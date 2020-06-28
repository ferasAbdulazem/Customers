using CustomerBL.Models;
using CustomerBL.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customers
{
    public partial class OrderItemFrm : Form
    {
        public VMOrder Order { get; set; }
        public List<Product> Products { get; set; }

        public delegate void OnSubmit( OrderItem orderItem, int amount );
        public OnSubmit OnSubmitCallback;

        public OrderItem newOrderItem { get; set; }

        public OrderItemFrm()
        {
            InitializeComponent();

        }

        private void OrderItemFrm_Load( object sender, EventArgs e )
        {
            newOrderItem = (OrderItem)bsOrderItems.AddNew();

            bsProducts.DataSource = Products;

            newOrderItem.OrderID = Order.OrderID;
            newOrderItem.DeliveryDate = Order.OrderDate;
            dtpDeliveryDate.Value = Order.OrderDate;

            bsProducts_CurrentChanged(null, null);
        }
        private void btnSave_Click( object sender, EventArgs e )
        {
            newOrderItem.ProductID = ((Product)bsProducts.Current).ProductID;

            OnSubmitCallback(newOrderItem, decimal.ToInt32(nudAmount.Value));
        }

        private void bsProducts_CurrentChanged( object sender, EventArgs e )
        {
            float discount = Order.Discount != 0 ? Order.Discount : ((Product)((ComboBox)sender).SelectedItem).Discount;

            newOrderItem.Price = ((Product)(bsProducts.Current)).Price;
            newOrderItem.Discount = discount;

            nudPrice.Value = ((Product)(bsProducts.Current)).Price;
            nudDiscount.Value = (decimal)discount;
        }
    }
}
