using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AdventureWorks.Data.Repositories.Customer
{
    public interface ICustomerRepository
    {
        IEnumerable<Entities.Customer> GetCustomers();
        Entities.Customer GetCustomerById(int id);
        void AddCustomer(Entities.Customer customer);
    }
}
