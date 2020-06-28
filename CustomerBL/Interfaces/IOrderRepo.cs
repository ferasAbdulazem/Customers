using CustomerBL.Models;
using CustomerBL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBL.Interfaces
{
    public interface IOrderRepo
    {
        IList<VMOrder> GetCustomerOrders( int customerId );

        Order GetOrder( int orderId );

        IList<VMOrderItem> GetOrderItems( int orderId );

        void Add( Order order );

        void AddOrderItem( OrderItem item, int amount );

        IList<Product> GetProducts();
    }
}
