using CustomerBL;
using CustomerBL.Models;
using System;
using System.Windows.Forms;
using CustomerBL.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Customers
{
    public partial class MainFrm : Form
    {
        private CustomerUoW customerUoW;

        private Customer newCus;

        private Customer customer { get; set; }

        private Order newOrder;

        private IList<VMCurrency> currencies { get; set; }

        public MainFrm()
        {
            InitializeComponent();
            customerUoW = new CustomerUoW();
        }

        private void MainFrm_Load( object sender, EventArgs e )
        {
            bsCustomerNames.DataSource = customerUoW.CustomerRepo.GetCustomerNames();

            currencies = customerUoW.FinanceRepo.GetCurrencies();
            bsCurrency.DataSource = currencies;

            bsGenders.DataSource = customerUoW.CustomerRepo.GetGenders();

            cbCustomerNames_SelectionChangeCommitted(null, null);
        }

        private void cbCustomerNames_SelectionChangeCommitted( object sender, EventArgs e )
        {
            int customerId = (int)cbCustomerNames.SelectedValue;

            customer = customerUoW.CustomerRepo.GetCustomer(customerId);
            bsCustomer.DataSource = customer;
            bsCustomerOrders.DataSource = customerUoW.OrderRepo.GetCustomerOrders(customerId);
            IList<VMAddressList> addressList = customerUoW.CustomerRepo.GetAddressList(customerId);

            bsBillingAdd.DataSource = addressList;
            bsDeliveryAdd.DataSource = addressList;
        }

        private void btnSave_Click( object sender, EventArgs e )
        {
            if (newCus != null) {
                customerUoW.CustomerRepo.Add(newCus);
                bsCustomerNames.DataSource = customerUoW.CustomerRepo.GetCustomerNames();
                cbCustomerNames.SelectedValue = newCus.CustomerID;
                cbCustomerNames_SelectionChangeCommitted(null, null);

                newCus = null;
            }

            customerUoW.Commit();
        }

        private void btnNew_Click( object sender, EventArgs e )
        {
            newCus = (Customer)bsCustomer.AddNew();
        }

        private void bsCustomerOrders_CurrentChanged( object sender, EventArgs e )
        {
            int orderId = ((VMOrder)((BindingSource)sender).Current).OrderID;
            bsOrderItems.DataSource = customerUoW.OrderRepo.GetOrderItems(orderId);
        }

        private void btnAddOrder_Click( object sender, EventArgs e )
        {
            newOrder = (Order)bsOrder.AddNew();

            gbOrderFrm.Visible = true;

            newOrder.CustomerID = customer.CustomerID;
            newOrder.CurrencyID = customer.CurrencyID;
            newOrder.Discount = customer.Discount;
            newOrder.OrderDate = DateTime.Today;

            cbOrderCurrency.SelectedValue = customer.CurrencyID;
            nudOrderDiscount.Value = (decimal)customer.Discount;
        }

        private void submitOrder_Click( object sender, EventArgs e )
        {
            customerUoW.OrderRepo.Add(newOrder);
            customerUoW.Commit();

            bsCustomerOrders.DataSource = customerUoW.OrderRepo.GetCustomerOrders(customer.CustomerID);
        }

        private void btnAddItem_Click( object sender, EventArgs e )
        {
            OrderItemFrm.OnSubmit onSubmit = new OrderItemFrm.OnSubmit(onCreateOrderItem);

            OrderItemFrm orderItemFrm = new OrderItemFrm {
                Products = (List<Product>)customerUoW.OrderRepo.GetProducts(),
                Order = (VMOrder)bsCustomerOrders.Current,
                OnSubmitCallback = onSubmit
            };


            orderItemFrm.ShowDialog();
        }

        private void onCreateOrderItem( OrderItem item, int amount )
        {
            customerUoW.OrderRepo.AddOrderItem(item, amount);

            bsCustomerOrders.DataSource = customerUoW.OrderRepo.GetCustomerOrders(customer.CustomerID);
            bsOrderItems.DataSource = customerUoW.OrderRepo.GetOrderItems(((VMOrder)bsCustomerOrders.Current).OrderID);
        }
    }
}
