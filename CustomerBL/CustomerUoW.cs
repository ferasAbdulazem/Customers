using CustomerBL.Interfaces;
using CustomerBL.Repos;

namespace CustomerBL
{
    public class CustomerUoW
    {
        private readonly CustomerContext DbCtx;

        private ICustomerRepo customerRepo;
        public ICustomerRepo CustomerRepo
        {
            get
            {

                if (customerRepo == null) {
                    customerRepo = new CustomerRepo(DbCtx);
                }

                return customerRepo;
            }
        }

        private IFinanceRepo financeRepo;
        public IFinanceRepo FinanceRepo
        {
            get
            {
                if (financeRepo == null) {
                    financeRepo = new FinanceRepo(DbCtx);
                }

                return financeRepo;
            }
            set { financeRepo = value; }
        }


        private IOrderRepo orderRepo;

        public IOrderRepo OrderRepo
        {
            get
            {

                if (orderRepo == null) {
                    orderRepo = new OrderRepo(DbCtx);
                }

                return orderRepo;

            }

            set { orderRepo = value; }
        }


        public CustomerUoW()
        {
            DbCtx = new CustomerContext();
        }

        public void Commit()
        {
            DbCtx.SaveChanges();
        }
    }
}
