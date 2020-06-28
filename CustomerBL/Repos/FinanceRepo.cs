using CustomerBL.Interfaces;
using CustomerBL.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace CustomerBL.Repos
{
    class FinanceRepo : IFinanceRepo
    {
        private readonly CustomerContext dbCtx;

        public FinanceRepo( CustomerContext DbCtx )
        {
            dbCtx = DbCtx;
        }

        public IList<VMCurrency> GetCurrencies()
        {
            var query = from cur in dbCtx.Currencies
                        select new VMCurrency() {
                            CurrencyID = cur.CurrencyID,
                            Currency = cur.Name + " " + "(" + cur.CurrencySymbol + ")"
                        };

            return query.ToList();
        }
    }
}
