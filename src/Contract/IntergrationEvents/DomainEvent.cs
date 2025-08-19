using Contract.Abtractions.Messages;
using Contract.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.IntergrationEvents
{
    public static class DomainEvent
    {
        public record class EmailNotificationEvent() : INotificationEvent
        {
            public Guid Id { get; set; }
            public DateTimeOffset TimeStamp { get; set; }
            public string Name { get ; set ; }
            public string Description { get ; set ; }
            public EnumType Type { get; set; }
            public Guid TransactionId { get ; set ; }
        }

        public record class SmsNotificationEvent() : INotificationEvent
        {
            public Guid Id { get; set; }
            public DateTimeOffset TimeStamp { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public EnumType Type { get; set; }
            public Guid TransactionId { get; set; }
        }
    }
}
