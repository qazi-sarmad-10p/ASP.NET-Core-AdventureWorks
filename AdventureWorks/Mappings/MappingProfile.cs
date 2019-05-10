using AdventureWorks.Data.Entities;
using AdventureWorks.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterDto, IdentityUser>();
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
            CreateMap<SalesOrders, OrderDto>();
            CreateMap<OrderDto, SalesOrders>();
        }
    }
}
