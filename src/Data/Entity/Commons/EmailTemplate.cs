using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity.Commons
{
    public class EmailTemplate : EntityBase
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string EmailContent { get; set; }
        public bool IsSystem { get; set; }
    }
}
