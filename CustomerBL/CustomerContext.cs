namespace CustomerBL
{
    using CustomerBL.Models;
    using System.Data.Entity;
    using System.Data.Entity.SqlServer;

    [DbConfigurationType(typeof(DbContextConfiguration))]
    public class CustomerContext : DbContext
    {
        // Your context has been configured to use a 'CustomerContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CustomerBL.CustomerContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CustomerContext' 
        // connection string in the application configuration file.
        public CustomerContext()
            : base("name=CustomerCon")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; }
        public virtual DbSet<OrderItemAmount> OrderItemAmounts { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating( DbModelBuilder modelBuilder )
        {
            modelBuilder.Entity<Customer>()
                .HasRequired(e => e.Gender)
                .WithMany(e => e.Custtomers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasRequired(e => e.Currency)
                .WithMany(e => e.Customers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Addresses)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasRequired(e => e.Customer)
                .WithMany(e => e.Orders)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
              .HasRequired(e => e.BillingAdd)
              .WithMany(e => e.DeliveryOrders)
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
               .HasRequired(e => e.Currency)
               .WithMany(e => e.Orders)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasRequired(f => f.City)
                .WithMany(e => e.Addresses)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasRequired(e => e.DeliveryAdd)
                .WithMany(e => e.DeliveryOrders)
                .HasForeignKey(e => e.DeliveryAddID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
               .HasRequired(e => e.BillingAdd)
               .WithMany(e => e.BillingOrders)
               .HasForeignKey(e => e.BillingAddID)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<Address>()
                .HasRequired(f => f.Customer)
                .WithMany(e => e.Addresses)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderItem>()
            .HasRequired(f => f.Product)
            .WithMany(e => e.OrderItems)
            .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderItem>()
                .HasRequired(f => f.Order)
                .WithMany(e => e.OrderItems)
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<OrderStatus>()
                .HasMany(e => e.OrderItemAmounts)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderItemAmount>()
             .HasRequired(f => f.OrderItem)
             .WithMany(e => e.OrderItemAmounts)
             .WillCascadeOnDelete(true);
        }
    }

    internal class DbContextConfiguration : DbConfiguration
    {
        public DbContextConfiguration()
        {
            SetProviderServices("System.Data.SqlClient", SqlProviderServices.Instance);
        }
    }
}