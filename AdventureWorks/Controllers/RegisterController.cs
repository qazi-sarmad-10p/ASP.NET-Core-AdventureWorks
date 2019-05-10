using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AdventureWorks.Dtos;
using AdventureWorks.Services.Account;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AdventureWorks.Controllers
{
    [Route("api/[controller]")]
    public class RegisterController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAccountService _accountService;

        public RegisterController(
            IMapper mapper,
            IAccountService accountService)
        {
            _mapper = mapper;
            _accountService = accountService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(RegisterDto form)
        {
            var user = _mapper.Map<RegisterDto, IdentityUser>(form);
            var success = await _accountService.Register(user, form.Password);

            if (!success)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError);
            }

            return Ok();
        }
    }
}
