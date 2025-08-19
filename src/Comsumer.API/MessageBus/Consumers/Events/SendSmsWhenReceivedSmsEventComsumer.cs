using Contract.IntergrationEvents;
using MediatR;
using Producers.API.Abtractions.Messages;

namespace Comsumer.API.MessageBus.Consumers.Events
{
    public class SendSmsWhenReceivedSmsEventComsumer : Consumer<DomainEvent.SmsNotificationEvent>
    {
        public SendSmsWhenReceivedSmsEventComsumer(ISender sender) : base(sender)
        {
        }
    }
}
