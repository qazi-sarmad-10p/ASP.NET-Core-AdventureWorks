using AdventureWorks.Data.Entities;
using AdventureWorks.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks.Services.Customer
{
    public class CustomerService : ICustomerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Data.Entities.Customer> GetCustomers()
        {
            return _unitOfWork.CustomerRepository.GetCustomers();
        }

        public Data.Entities.Customer GetCustomerById(int id)
        {
            return _unitOfWork.CustomerRepository.GetCustomerById(id);
        }

        public int AddCustomer(Data.Entities.Customer customer)
        {
            _unitOfWork.CustomerRepository.AddCustomer(customer);
            _unitOfWork.Save();

            return customer.CustomerId;
        }
    }
}
