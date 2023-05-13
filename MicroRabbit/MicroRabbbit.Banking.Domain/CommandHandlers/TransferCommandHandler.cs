using MediatR;
using MicroRabbbit.Banking.Domain.Commands;
using MicroRabbbit.Banking.Domain.Events;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbbit.Banking.Domain.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreatTransfornCommand, bool>
    {
        private readonly IEventBus eventBus;

        public TransferCommandHandler(IEventBus eventBus)
        {
            this.eventBus = eventBus;
        }

        Task<bool> Handle(CreatTransfornCommand request, CancellationToken cancellationToken)
        {
           return Task.FromResult(true);
        }

        Task<bool> IRequestHandler<CreatTransfornCommand, bool>.Handle(CreatTransfornCommand request, CancellationToken cancellationToken)
        {

            eventBus.Publish(new TransferCreatedEvent(request.From, request.To, request.Amount));
          return Task<bool>.FromResult(true);
        }
    }
}
