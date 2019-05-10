using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureWorks.Data.Entities;

namespace AdventureWorks.Data.Repositories.Order
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public OrderRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<SalesOrders> GetOrders()
        {
            return _dbContext.SalesOrders;
        }

        public SalesOrders GetOrder(int id)
        {
            return _dbContext.SalesOrders.SingleOrDefault(x => x.SalesOrdersId == id);
        }

        public void AddOrder(SalesOrders order)
        {
            _dbContext.SalesOrders.Add(order);
        }
    }
}
