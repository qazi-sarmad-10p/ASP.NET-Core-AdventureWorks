using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdventureWorks.Data.Entities;
using AdventureWorks.Dtos;
using AdventureWorks.Services.Order;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorks.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IOrderService _orderService;

        public OrderController(
            IMapper mapper,
            IOrderService orderService)
        {
            _mapper = mapper;
            _orderService = orderService;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<OrderDto> Get()
        {
            var result = _orderService.GetOrders();
            return _mapper.Map<IEnumerable<SalesOrders>, IEnumerable<OrderDto>>(result);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public OrderDto Get(int id)
        {
            var result = _orderService.GetOrder(id);
            return _mapper.Map<SalesOrders, OrderDto>(result);
        }

        // POST api/<controller>
        [HttpPost]
        [Authorize]
        public int Post([FromBody]OrderDto form)
        {
            var order = _mapper.Map<OrderDto, SalesOrders>(form);
            return _orderService.AddOrder(order);
        }
    }
}
