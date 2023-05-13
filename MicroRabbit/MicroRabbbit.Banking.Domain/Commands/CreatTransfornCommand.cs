using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbbit.Banking.Domain.Commands
{
    public class CreatTransfornCommand : TransferCommand
    {
        public CreatTransfornCommand(int from, int to, decimal amount)
        {
            From= from;
            To= to;
            Amount= amount;
        }
    }
}
