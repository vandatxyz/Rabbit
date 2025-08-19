using Contract.IntergrationEvents;
using MediatR;
using Producers.API.Abtractions.Messages;

namespace Comsumer.API.MessageBus.Consumers.Events
{
    public class SendEmailWhenReceivedEmailEventComsumer(ISender sender) : Consumer<DomainEvent.EmailNotificationEvent>(sender)
    {
    }
}
