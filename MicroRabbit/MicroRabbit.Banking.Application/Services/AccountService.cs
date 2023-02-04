using MicroRabbbit.Banking.Domain.Interfaces;
using MicroRabbbit.Banking.Domain.Models;
using MicroRabbit.Banking.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepositery accountRepositery;

        public AccountService(IAccountRepositery accountRepositery)
        {
            this.accountRepositery = accountRepositery;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return accountRepositery.GetAccounts();
        }
    }
}
