using MicroRabbbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbbit.Banking.Domain.Interfaces
{
    public interface IAccountRepositery
    {
        IEnumerable<Account> GetAccounts();
    }
}
