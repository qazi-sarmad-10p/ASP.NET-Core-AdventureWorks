using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureWorks.Data.Entities;

namespace AdventureWorks.Data.Repositories.Customer
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CustomerRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Entities.Customer> GetCustomers()
        {
            return _dbContext.Customers;
        }

        public Entities.Customer GetCustomerById(int id)
        {
            return _dbContext.Customers.SingleOrDefault(x => x.CustomerId == id);
        }

        public void AddCustomer(Entities.Customer customer)
        {
            _dbContext.Customers.Add(customer);
        }
    }
}
