using Contract.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contract.Abtractions.Messages
{
    public interface INotificationEvent : IMessage
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public EnumType Type { get; set; }
        public Guid TransactionId { get; set; }
    }
}
