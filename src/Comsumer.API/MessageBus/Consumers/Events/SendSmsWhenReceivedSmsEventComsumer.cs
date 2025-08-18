using Contract.IntergrationEvents;
using Producers.API.Abtractions.Messages;

namespace Comsumer.API.MessageBus.Consumers.Events
{
    public class SendSmsWhenReceivedSmsEventComsumer : Consumer<DomainEvent.SmsNotificationEvent>
    {
        public SendSmsWhenReceivedSmsEventComsumer()
        {

        }
    }
}
