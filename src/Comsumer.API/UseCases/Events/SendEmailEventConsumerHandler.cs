using Contract.IntergrationEvents;
using MediatR;

namespace Comsumer.API.UseCases.Events
{
    public class SendEmailEventConsumerHandler : IRequestHandler<DomainEvent.EmailNotificationEvent>
    {

        private readonly ILogger<SendEmailEventConsumerHandler> _logger;

        public SendEmailEventConsumerHandler(ILogger<SendEmailEventConsumerHandler> logger)
        {
            _logger = logger;
        }

        public async Task Handle(DomainEvent.EmailNotificationEvent request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Email Sender Event Received: {@EmailEvent}", request);
        }
    }
}
