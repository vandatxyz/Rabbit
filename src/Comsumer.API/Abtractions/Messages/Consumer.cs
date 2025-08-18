using Contract.Abtractions.Messages;
using MassTransit;

namespace Producers.API.Abtractions.Messages
{
    public abstract class Consumer<TMessage> : IConsumer<TMessage>
        where TMessage : class, INotificationEvent
    {
        public async Task Consume(ConsumeContext<TMessage> context)
        {
            throw new NotImplementedException();
        }
    }
}
