using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
