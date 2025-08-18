using Contract.Enum;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Abtractions.Messages
{
    [ExcludeFromTopology]
    public interface IMessage
    {
        public Guid Id { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public EnumType Type { get; set; }
        public Guid TransactionId { get; set; }
    }
}
