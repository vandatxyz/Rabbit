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
        [HttpPost(Name = "publish-sms-notification")]
        public async Task<ActionResult> PublishSmsNotificationEvent()
        {
            await _publishEndpoint.Publish(new DomainEvent.SmsNotificationEvent()
            {
                Id = Guid.NewGuid(),
                Description = "sms dec",
                Name = "sms notification",
                TimeStamp = DateTime.Now,
                TransactionId = Guid.NewGuid(),
            });
            return Accepted();
        }
    }
}
