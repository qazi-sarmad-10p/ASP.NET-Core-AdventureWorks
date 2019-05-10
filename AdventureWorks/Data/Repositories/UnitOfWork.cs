using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureWorks.Data.Repositories.Customer;
using AdventureWorks.Data.Repositories.Order;

namespace AdventureWorks.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ICustomerRepository _customerRepository;
        private readonly IOrderRepository _orderRepository;

        public ICustomerRepository CustomerRepository
        {
            get
            {
                return _customerRepository;
            }
        }

        public IOrderRepository OrderRepository
        {
            get
            {
                return _orderRepository;
            }
        }

        public UnitOfWork(
            ApplicationDbContext dbContext,
            ICustomerRepository customerRepository,
            IOrderRepository orderRepository)
        {
            _dbContext = dbContext;
            _customerRepository = customerRepository;
            _orderRepository = orderRepository;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
