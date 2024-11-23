using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academyems.CoreDbContext.Entities
{
    public class BatchStatus : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        // Navigation property for the dependent entity
        public ICollection<BatchDetail> BatchDetails { get; set; }
    }
}
