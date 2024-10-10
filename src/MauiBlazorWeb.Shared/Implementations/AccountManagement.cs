using MauiBlazorWeb.Shared.Identity.Models;
using MauiBlazorWeb.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBlazorWeb.Shared.Implementations
{
    public class AccountManagement : IAccountManagement
    {
        public Task<bool> CheckAuthenticatedAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FormResult> LoginAsync(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task LogoutAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FormResult> RegisterAsync(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
