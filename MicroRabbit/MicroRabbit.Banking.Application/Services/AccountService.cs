using MicroRabbbit.Banking.Domain.Commands;
using MicroRabbbit.Banking.Domain.Interfaces;
using MicroRabbbit.Banking.Domain.Models;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Models;
using MicroRabbit.Domain.Core.Bus;
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
        private readonly IEventBus eventBus;

        public AccountService(IAccountRepositery accountRepositery,IEventBus eventBus)
        {
            this.accountRepositery = accountRepositery;
            this.eventBus= eventBus;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return accountRepositery.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var creatTransfercommand = new CreatTransfornCommand(accountTransfer.FromAccount, accountTransfer.ToAccount, accountTransfer.TransferAmount);

            this.eventBus.SendCommand(creatTransfercommand);
            

        }
    }
}
