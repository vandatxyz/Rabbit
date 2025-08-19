
namespace Data.Entity.Commons
{
    public class CarType : EntityBase
    {
        public string Name { get; set; }
        public bool IsSystem { get; set; }
        public int? SortOrder { get; set; }
    }
}
