using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity.Commons
{
    public class CarBrand : EntityBase
    {
        public string Name { get; set; }
        public bool IsSystem { get; set; }
        public int? SortOrder { get; set; }
    }
}
