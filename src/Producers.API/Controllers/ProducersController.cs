using Contract.IntergrationEvents;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Data;
using Data.Entity.Commons;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProducersController : ControllerBase
    {
        private readonly IPublishEndpoint _publishEndpoint;
        private readonly ApplicationContext _dbContext;

        public ProducersController(IPublishEndpoint publishEndpoint, ApplicationContext dbContext)
        {
            _publishEndpoint = publishEndpoint;
            _dbContext = dbContext;
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

        [HttpPost("outbox-test", Name = "publish-with-outbox-transaction")]
        public async Task<ActionResult> PublishWithOutboxTransaction(CancellationToken cancellationToken)
        {
            await using var transaction = await _dbContext.Database.BeginTransactionAsync(cancellationToken);

            var unit = new Unit
            {
                Id = Guid.NewGuid(),
                Name = $"unit-{Guid.NewGuid():N}".Substring(0, 16),
                Description = "demo outbox",
                IsDefault = false,
                IsBales = false,
                CreatedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow,
                Status = 1,
                IsDeleted = false,
            };

            _dbContext.Units.Add(unit);

            await _publishEndpoint.Publish(new DomainEvent.EmailNotificationEvent
            {
                Id = Guid.NewGuid(),
                Description = "Email via outbox",
                Name = "Outbox email",
                TimeStamp = DateTime.UtcNow,
                Type = Contract.Enum.EnumType.Email,
                TransactionId = Guid.NewGuid(),
            }, cancellationToken);

            await _dbContext.SaveChangesAsync(cancellationToken);
            await transaction.CommitAsync(cancellationToken);

            return Accepted(new { unitId = unit.Id });
        }
    }
}
