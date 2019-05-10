using AdventureWorks.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks.Services.Order
{
    public interface IOrderService
    {
        IEnumerable<SalesOrders> GetOrders();
        SalesOrders GetOrder(int id);
        int AddOrder(SalesOrders order);
    }
}
