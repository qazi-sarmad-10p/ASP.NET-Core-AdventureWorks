using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks.Services.Customer
{
    public interface ICustomerService
    {
        IEnumerable<Data.Entities.Customer> GetCustomers();
        Data.Entities.Customer GetCustomerById(int id);
        int AddCustomer(Data.Entities.Customer customer);
    }
}
