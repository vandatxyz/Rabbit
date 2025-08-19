using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity.Commons
{
    public class District : EntityBase
    {
        public string Code { get; set; }

        /// <summary>
        /// Tên quận/huyện
        /// </summary>
        public string Name { get; set; }

        public string Prefix { get; set; }

        public Guid CityId { get; set; }

        public virtual City City { get; set; }
    }
}
