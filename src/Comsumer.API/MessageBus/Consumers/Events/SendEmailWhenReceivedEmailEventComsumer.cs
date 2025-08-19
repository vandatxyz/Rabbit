using Contract.IntergrationEvents;
using MediatR;
using Producers.API.Abtractions.Messages;

namespace Comsumer.API.MessageBus.Consumers.Events
{
    public class SendEmailWhenReceivedEmailEventComsumer : Consumer<DomainEvent.EmailNotificationEvent>
    {
        public SendEmailWhenReceivedEmailEventComsumer(ISender sender) : base(sender)
        {
        }
    }
}
