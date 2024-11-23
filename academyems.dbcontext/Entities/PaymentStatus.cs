using academyems.dbcontext.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace academyems.dbcontext
{
    [Table(name: "payment_status")]
    public class PaymentStatus : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("status")]
        public string Status { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        // Navigation property for the dependent entity
        public ICollection<Payment> Payments { get; set; }
    }
}
