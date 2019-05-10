using AdventureWorks.Data.Repositories.Customer;
using AdventureWorks.Data.Repositories.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks.Data.Repositories
{
    public interface IUnitOfWork
    {
        ICustomerRepository CustomerRepository { get; }
        IOrderRepository OrderRepository { get; }

        void Save();
    }
}
