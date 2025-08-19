using Contract.IntergrationEvents;
using MediatR;
using Producers.API.Abtractions.Messages;

namespace Comsumer.API.MessageBus.Consumers.Events
{
    public class SendSmsWhenReceivedSmsEventComsumer(ISender sender) : Consumer<DomainEvent.SmsNotificationEvent>(sender)
    {
    }
}
