using CustomerBL.Interfaces;
using CustomerBL.Models;
using CustomerBL.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace CustomerBL.Repos
{
    class CustomerRepo : ICustomerRepo
    {
        private readonly CustomerContext dbCtx;

        public CustomerRepo( CustomerContext ctx )
        {
            dbCtx = ctx;
        }
        public Customer GetCustomer( int customerId )
        {
            Customer customer = dbCtx.Customers.Find(customerId);
            return customer;
        }

        public IList<VMCustomerNames> GetCustomerNames()
        {
            var query = from c in dbCtx.Customers
                        orderby c.LName, c.FName
                        select new VMCustomerNames() {
                            CustomerID = c.CustomerID,
                            FullName = c.FName + " " + c.LName
                        };

            return query.ToList();
        }

        public IList<VMGenders> GetGenders()
        {
            var query = from g in dbCtx.Genders
                        select new VMGenders() {
                            GenderID = g.GenderID,
                            Titel = g.Titel
                        };

            return query.ToList();
        }

        public void Add( Customer newCustomer )
        {
            dbCtx.Customers.Add(newCustomer);
        }

        public IList<VMAddressList> GetAddressList( int customerId )
        {
            var query = from add in dbCtx.Addresses
                        where add.CustomerID == customerId
                        select new VMAddressList {
                            AddressID = add.AddressID,
                            FullAddress = add.City.IntName + ", " + add.Street + " " + add.StreetNr
                        };

            return query.ToList();
        }
    }
}
