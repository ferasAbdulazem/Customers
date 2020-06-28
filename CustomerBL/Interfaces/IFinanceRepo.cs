using CustomerBL.ViewModels;
using System.Collections.Generic;

namespace CustomerBL.Interfaces
{
    public interface IFinanceRepo
    {
        IList<VMCurrency> GetCurrencies();
    }
}
