using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entity.Commons
{
    public class Unit : EntityBase
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsDefault { get; set; }

        /// <summary>
        /// Dùng tính phí tạm ứng hàng kiện
        /// </summary>
        public bool IsBales { get; set; }
    }
}
