using Contract.IntergrationEvents;
using MediatR;
using Producers.API.Abtractions.Messages;

namespace Comsumer.API.MessageBus.Consumers.Events
{
    public class ReceivedEmail(ISender sender) : Consumer<DomainEvent.EmailNotificationEvent>(sender)
    {
    }
}
