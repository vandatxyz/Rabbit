using Contract.IntergrationEvents;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProducersController : ControllerBase
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public ProducersController(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        [HttpPost("sms", Name = "publish-sms-notification")]
        public async Task<ActionResult> PublishSmsNotificationEvent()
        {
            await _publishEndpoint.Publish(new DomainEvent.SmsNotificationEvent()
            {
                Id = Guid.NewGuid(),
                Description = "sms dec",
                Name = "sms notification",
                Type = Contract.Enum.EnumType.Sms,
                TimeStamp = DateTime.Now,
                TransactionId = Guid.NewGuid(),
            });
            return Accepted();
        }

        [HttpPost("email", Name = "publish-email-notification")]
        public async Task<ActionResult> PublishEmailNotificationEvent()
        {
            await _publishEndpoint.Publish(new DomainEvent.EmailNotificationEvent()
            {
                Id = Guid.NewGuid(),
                Description = "Email dec",
                Name = "Email notification",
                TimeStamp = DateTime.Now,
                Type = Contract.Enum.EnumType.Email,
                TransactionId = Guid.NewGuid(),
            });
            return Accepted();
        }
    }
}
