using MicroRabbbit.Banking.Domain.Interfaces;
using MicroRabbbit.Banking.Domain.Models;
using MicroRabbit.Banking.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Banking.Data.Repositery
{
    public class AccountRepositery : IAccountRepositery
    {
        private readonly BankingDbContext bankingDbContext;

        public AccountRepositery(BankingDbContext bankingDbContext)
        {
            this.bankingDbContext = bankingDbContext;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return bankingDbContext.Accounts; 
        }
    }
}
