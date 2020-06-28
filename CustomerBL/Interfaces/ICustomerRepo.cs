using CustomerBL.Models;
using CustomerBL.ViewModels;
using System.Collections.Generic;

namespace CustomerBL.Interfaces
{
    public interface ICustomerRepo
    {
        IList<VMCustomerNames> GetCustomerNames();

        Customer GetCustomer( int customerId );

        IList<VMGenders> GetGenders();

        void Add( Customer customer );

        IList<VMAddressList> GetAddressList( int customerId );
    }
}
