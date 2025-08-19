using Contract.IntergrationEvents;
using MediatR;

namespace Comsumer.API.UseCases.Events
{
    public class SendSmsEventConsumerHandler : IRequestHandler<DomainEvent.SmsNotificationEvent>
    {

        private readonly ILogger<SendSmsEventConsumerHandler> _logger;

        public SendSmsEventConsumerHandler(ILogger<SendSmsEventConsumerHandler> logger)
        {
            _logger = logger;
        }

        public async Task Handle(DomainEvent.SmsNotificationEvent request, CancellationToken cancellationToken)
        {
           _logger.LogInformation("SMS Notification Event Received: {@SmsNotificationEvent}", request);
        }
    }
}
