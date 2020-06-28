namespace CustomerBL.Migrations
{
    using CustomerBL.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CustomerBL.CustomerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed( CustomerBL.CustomerContext context )
        {
            context.Currencies.AddOrUpdate(( currency ) => currency.CurrencyID,
            new Currency { CurrencyID = "EUR", CurrencySymbol = "€", Name = "Euro" },
            new Currency { CurrencyID = "USD", CurrencySymbol = "$", Name = "US Doller" },
            new Currency { CurrencyID = "CHF", CurrencySymbol = "CHF", Name = "Swiss Franc" }
                );

            context.Genders.AddOrUpdate(
                ( gender ) => gender.GenderID,
                new Gender { GenderID = "m", Titel = "mähnnlich", Notes = null },
                new Gender { GenderID = "w", Titel = "weiblich", Notes = null },
                new Gender { GenderID = "d", Titel = "divers", Notes = null }

                );
            context.SaveChanges();

            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Customers ON");

            context.Customers.AddOrUpdate(
                ( customer ) => customer.CustomerID,
                new Customer { CustomerID = 1, FName = "Feras", LName = "Abdulazem", GenderID = "m", IsActive = true, BirthDate = DateTime.Parse("1997-03-27"), CurrencyID = "EUR", Created = DateTime.Today },
                new Customer { CustomerID = 2, FName = "Sandra", LName = "Musterfrau", GenderID = "w", IsActive = true, BirthDate = DateTime.Parse("1987-03-27"), CurrencyID = "USD", Created = DateTime.Today }
                );

            context.SaveChanges();

            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Customers OFF");

            context.Currencies.AddOrUpdate(
                ( currency ) => currency.CurrencyID,
                new Currency {
                    CurrencyID = "EUR",
                    Name = "Euro",
                    CurrencySymbol = "€"
                },

                new Currency {
                    CurrencyID = "USD",
                    Name = "US Dollar",
                    CurrencySymbol = "$"
                },

                new Currency {
                    CurrencyID = "CHF",
                    Name = "Swiss Franc",
                    CurrencySymbol = "CHF"
                }
                );

            context.Countries.AddOrUpdate(

                ( country ) => country.CountryID
                ,
                new Country {
                    CountryID = "AT",
                    IntName = "Austria",
                    LocalName = "Österreich",
                    ShortName = "AUT"
                },

                new Country {
                    CountryID = "DE",
                    IntName = "Germany",
                    LocalName = "Deutschland",
                    ShortName = "DEU"
                }
                );

            context.Cities.AddOrUpdate(
                ( city ) => new { city.CountryID, city.Zip },
                new City {
                    CountryID = "AT",
                    Zip = "6020",
                    LocalName = "Innsbruck",
                    IntName = "Innsbruck"
                },

                new City {
                    CountryID = "DE",
                    Zip = "80331",
                    LocalName = "München",
                    IntName = "Munich"
                }
                );
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Customers ON");

            context.Addresses.AddOrUpdate(
                ( add ) => add.AddressID,
                new Address {
                    AddressID = 1,
                    CountryID = "AT",
                    Zip = "6020",
                    CustomerID = 1,
                    Street = "Adamgasse",
                    StreetNr = "11b"
                },

                new Address {
                    AddressID = 2,
                    CountryID = "AT",
                    Zip = "6020",
                    CustomerID = 1,
                    Street = "Maria-Theresien-Str.",
                    StreetNr = "111"
                },

                new Address {
                    AddressID = 3,
                    CountryID = "DE",
                    Zip = "80331",
                    CustomerID = 2,
                    Street = "Musterstraße",
                    StreetNr = "111"
                }
                );
            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Customers OFF");


            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Customers ON");

            context.Products.AddOrUpdate(
                ( p ) => p.ProductID,
            new Product {
                ProductID = 1,
                Price = 5.6M,
                Title = "Kabelbinder"
            },

             new Product {
                 ProductID = 2,
                 Price = 50M,
                 Title = "Microcontroller"
             },

             new Product {
                 ProductID = 3,
                 Price = 80.66M,
                 Discount = 5.6F,
                 Title = "Tastatur"
             }
            );

            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Customers OFF");

            context.SaveChanges();

            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Customers ON");

            context.Orders.AddOrUpdate(
                ( o ) => o.OrderID,
                new Order {
                    OrderID = 1,
                    OrderDate = DateTime.Parse("2020-05-27"),
                    CurrencyID = "EUR",
                    Discount = 5.5F,
                    CustomerID = 1,
                    IsActive = true,
                    IsPartial = true,
                    DeliveryAddID = 1,
                    BillingAddID = 2
                },
                new Order {
                    OrderID = 2,
                    OrderDate = DateTime.Parse("2020-06-22"),
                    CurrencyID = "USD",
                    Discount = 0,
                    CustomerID = 2,
                    IsActive = true,
                    IsPartial = false,
                    DeliveryAddID = 3,
                    BillingAddID = 3
                }
                );

            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Customers OFF");


            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Customers ON");

            context.OrderStatuses.AddOrUpdate(
                ( s ) => s.StatusID,
                new OrderStatus {
                    StatusID = 1,
                    Title = "initial"
                },
                new OrderStatus {
                    StatusID = 2,
                    Title = "in work"
                },
                new OrderStatus {
                    StatusID = 3,
                    Title = "in delivery"
                },
                new OrderStatus {
                    StatusID = 4,
                    Title = "delivered"
                }
                );

            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Customers OFF");

            context.OrderItems.AddOrUpdate(
                (oi => new { oi.OrderID, oi.ItemNumber }),
                new OrderItem {
                    OrderID = 1,
                    ItemNumber = 1,
                    ProductID = 2,
                    Price = 50M,
                    Discount = 5.5F,
                    IsPartial = true

                },

                new OrderItem {
                    OrderID = 1,
                    ItemNumber = 2,
                    ProductID = 3,
                    Price = 80.66M,
                    Discount = 5.6F,
                    IsPartial = true

                },

                new OrderItem {
                    OrderID = 2,
                    ItemNumber = 1,
                    ProductID = 1,
                    Price = 5.6M,
                    Discount = 0,
                    IsPartial = false
                }
                );

            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Customers ON");

            context.OrderItemAmounts.AddOrUpdate(
                ( oia ) => oia.AmountID,
                new OrderItemAmount {
                    AmountID = 1,
                    OrderID = 1,
                    OrderItemNumber = 1,
                    StatusID = 1,
                    Amount = 10
                },
                new OrderItemAmount {
                    AmountID = 2,
                    OrderID = 1,
                    OrderItemNumber = 1,
                    StatusID = 2,
                    Amount = 5
                },
                new OrderItemAmount {
                    AmountID = 3,
                    OrderID = 1,
                    OrderItemNumber = 1,
                    StatusID = 3,
                    Amount = 5
                },

                new OrderItemAmount {
                    AmountID = 4,
                    OrderID = 1,
                    OrderItemNumber = 2,
                    StatusID = 1,
                    Amount = 5
                },

                new OrderItemAmount {
                    AmountID = 5,
                    OrderID = 1,
                    OrderItemNumber = 2,
                    StatusID = 2,
                    Amount = 5
                },

                new OrderItemAmount {
                    AmountID = 6,
                    OrderID = 2,
                    OrderItemNumber = 1,
                    StatusID = 1,
                    Amount = 20
                }
                );

            context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT Customers OFF");


            context.SaveChanges();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
