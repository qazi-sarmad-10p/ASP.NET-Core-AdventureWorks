using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureWorks.Data.Entities;
using AdventureWorks.Dtos;
using AdventureWorks.Services.Customer;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorks.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICustomerService _customerService;

        public CustomerController(
            IMapper mapper,
            ICustomerService customerService)
        {
            _mapper = mapper;
            _customerService = customerService;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<CustomerDto> Get()
        {
            var result = _customerService.GetCustomers();
            return _mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerDto>>(result);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public CustomerDto Get(int id)
        {
            var result = _customerService.GetCustomerById(id);
            return _mapper.Map<Customer, CustomerDto>(result);
        }

        // POST api/<controller>
        [HttpPost]
        [Authorize]
        public int Post([FromBody]CustomerDto form)
        {
            var customer = _mapper.Map<CustomerDto, Customer>(form);
            return _customerService.AddCustomer(customer);
        }
    }
}
