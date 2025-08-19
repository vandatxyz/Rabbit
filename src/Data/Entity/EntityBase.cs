using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entity
{
    public class EntityBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public DateTime CreatedDate { set; get; }

        public DateTime ModifiedDate { set; get; }

        public Guid? CreatedBy { set; get; }

        public Guid? ModifiedBy { set; get; }

        public int? Status { get; set; }

        public bool IsDeleted { get; set; }
    }
}
