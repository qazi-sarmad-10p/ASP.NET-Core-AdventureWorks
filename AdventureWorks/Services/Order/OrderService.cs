using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureWorks.Data.Entities;
using AdventureWorks.Data.Repositories;

namespace AdventureWorks.Services.Order
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<SalesOrders> GetOrders()
        {
            return _unitOfWork.OrderRepository.GetOrders();
        }

        public SalesOrders GetOrder(int id)
        {
            return _unitOfWork.OrderRepository.GetOrder(id);
        }

        public int AddOrder(SalesOrders order)
        {
            _unitOfWork.OrderRepository.AddOrder(order);
            _unitOfWork.Save();

            return order.SalesOrdersId;
        }
    }
}
