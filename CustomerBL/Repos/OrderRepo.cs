using CustomerBL.Interfaces;
using CustomerBL.Models;
using CustomerBL.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerBL.Repos
{
    public class OrderRepo : IOrderRepo
    {
        private CustomerContext dbCtx { get; set; }

        public OrderRepo( CustomerContext DbCtx )
        {
            dbCtx = DbCtx;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");

        }

        public IList<VMOrder> GetCustomerOrders( int customerId )
        {
            var query = (from ord in dbCtx.Orders
                         orderby ord.OrderDate
                         where ord.CustomerID == customerId
                         select new VMOrder {
                             OrderID = ord.OrderID,
                             OrderDate = ord.OrderDate,
                             DeliveryAdd = ord.DeliveryAdd.Zip + ", " + ord.DeliveryAdd.Street + " " + ord.DeliveryAdd.StreetNr,
                             BillingAdd = ord.BillingAdd.Zip + ", " + ord.BillingAdd.Street + " " + ord.BillingAdd.StreetNr,
                             Currency = ord.Currency.Name + " (" + ord.Currency.CurrencySymbol + ")",
                             Discount = ord.Discount,
                             IsActive = ord.IsActive,
                             IsPartial = ord.IsPartial,
                             TotalSum = 0
                         }).AsEnumerable().Select(order =>
                         {
                             var orderItems = dbCtx.Orders.Find(order.OrderID).OrderItems;

                             if (orderItems != null) {
                                 order.TotalSum = getOrderSum(orderItems.ToList());
                                 order.TotalAmount = getOrderTotalAmount(orderItems.ToList());
                             }


                             return order;
                         })
                        ;

            return query.ToList();
        }

        private int getOrderTotalAmount( List<OrderItem> items )
        {
            // early exit if no items
            if (items.Count == 0) {
                return 0;
            }

            return items.Aggregate(0, ( acc, curr ) =>
            {
                acc += curr.OrderItemAmounts.Where(am => am.StatusID == 1).ToList()[0].Amount;

                return acc;
            });
        }

        private decimal getOrderSum( List<OrderItem> items )
        {
            if (items.Count == 0) {
                return 0;
            }

            return items.Aggregate(0M, ( acc, curr ) =>
           {
               acc += getOrderItemSum(curr);

               return acc;
           });
        }

        private decimal getOrderItemSum( OrderItem orderItem )
        {
            // the initial/total amount of the item is stored in the first status (initial)
            int totalAmount = orderItem.OrderItemAmounts.Where(am => am.StatusID == 1).ToList()[0].Amount;

            decimal totalSum = orderItem.Price * totalAmount;

            decimal discountedSum = (totalSum * (decimal)(100 - orderItem.Discount)) / 100;

            return Decimal.Round(discountedSum, 2);
        }

        public Order GetOrder( int orderId )
        {
            throw new NotImplementedException();
        }

        public IList<VMOrderItem> GetOrderItems( int orderId )
        {
            var query = (from oitm in dbCtx.OrderItems
                         where oitm.OrderID == orderId
                         select new VMOrderItem {
                             OrderID = oitm.OrderID,
                             ItemNumber = oitm.ItemNumber,
                             Discount = oitm.Discount,
                             Price = oitm.Price,
                             Product = oitm.Product.Title,
                             IsPartial = oitm.IsPartial,
                             DeliveryDate = oitm.DeliveryDate,
                             Sum = 0,
                         }).AsEnumerable().Select(item =>
                         {
                             OrderItem orderItem = dbCtx.OrderItems.Find(item.OrderID, item.ItemNumber);

                             item.Sum = getOrderItemSum(orderItem);

                             return item;
                         });

            return query.ToList();
        }

        public void Add( Order order )
        {
            dbCtx.Orders.Add(order);
        }

        public void AddOrderItem( OrderItem item, int amount )
        {

            dbCtx.Database.ExecuteSqlCommand("insertOrderItem  @orderId, @productId, @delivaryDate, @price, @discount, @isPartial, @amount",
                new SqlParameter("@orderId", item.OrderID),
                new SqlParameter("@productId", item.ProductID),
                new SqlParameter("@delivaryDate", item.DeliveryDate),
                new SqlParameter("@price", item.Price),
                new SqlParameter("@discount", item.Discount),
                new SqlParameter("@isPartial", item.IsPartial),
                new SqlParameter("@amount", amount)
                );
        }

        public IList<Product> GetProducts()
        {
            return dbCtx.Products.ToList();
        }
    }
}