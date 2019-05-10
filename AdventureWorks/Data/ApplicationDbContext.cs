using AdventureWorks.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SalesOrders> SalesOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var seededCustomers = new List<Customer>
            {
                new Customer
                {
                    CustomerId = 1,
                    Title = "Mr.",
                    FirstName = "Faisal",
                    LastName = "Khanani"
                },
                new Customer
                {
                    CustomerId = 2,
                    Title = "Mr.",
                    FirstName = "Khurram",
                    LastName = "Rafi"
                },
                new Customer
                {
                    CustomerId = 3,
                    Title = "Ms.",
                    FirstName = "Sona",
                    LastName = "Kanwal"
                },
            };

            var seededOrders = new List<SalesOrders>
            {
                new SalesOrders
                {
                    SalesOrdersId = 1,
                    CustomerId = 1,
                    Amount = 5,
                    OrderDate = new DateTime(2019, 1, 1)
                },
                new SalesOrders
                {
                    SalesOrdersId = 2,
                    CustomerId = 2,
                    Amount = 10,
                    OrderDate = new DateTime(2019, 1, 1)
                },
                new SalesOrders
                {
                    SalesOrdersId = 3,
                    CustomerId = 3,
                    Amount = 15,
                    OrderDate = new DateTime(2019, 1, 1)
                }
            };

            builder.Entity<Customer>().HasData(seededCustomers);
            builder.Entity<SalesOrders>().HasData(seededOrders);
        }
    }
}
