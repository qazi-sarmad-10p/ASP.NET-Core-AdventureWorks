using AdventureWorks.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks.Data.Repositories.Order
{
    public interface IOrderRepository
    {
        IEnumerable<SalesOrders> GetOrders();
        SalesOrders GetOrder(int id);
        void AddOrder(SalesOrders order);
    }
}
