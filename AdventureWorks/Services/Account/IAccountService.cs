using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventureWorks.Services.Account
{
    public interface IAccountService
    {
        Task<bool> Register(IdentityUser user, string password);
        Task<string> Login(string userName, string password);
    }
}
