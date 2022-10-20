using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Info.Bus;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MicroRabbit.Infra.IOC
{
    public class DependencyContainer
    {
       
        public static void Register(IServiceCollection services)
        {

            services.AddTransient<IEventBus, RabbitMqBus>();

        }
    }
}
