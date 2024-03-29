﻿using MediatR;
using MicroRabbbit.Banking.Domain.CommandHandlers;
using MicroRabbbit.Banking.Domain.Commands;
using MicroRabbbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repositery;
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

            services.AddTransient<IRequestHandler<CreatTransfornCommand, bool>, TransferCommandHandler>();

            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IAccountRepositery, AccountRepositery>();
            services.AddTransient<BankingDbContext>();

        }
    }
}
