using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entity.Commons
{
    public class City : EntityBase
    {
        /// <summary>
        /// Order for sort
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Mã tỉnh thành
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Tên tỉnh thành
        /// </summary>
        public string Name { get; set; }

        public virtual ICollection<District> Districts { get; set; }
    }
}
