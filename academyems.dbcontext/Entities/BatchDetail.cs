using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academyems.dbcontext.Entities
{
    [Table(name: "batch_detail")]
    public class BatchDetail : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("batch_id")]
        public int BatchId { get; set; }

        [Column("student_id")]
        public int StudentId { get; set; }


        [Column("enrollment_date")]
        public DateTime EnrollmentDate { get; set; }


        // Navigation property for the dependent entity
        [ForeignKey("BatchId")]
        public Batch Batch { get; set; }


        [ForeignKey("StudentId")]
        public UserDetail UserDetail { get; set; }

        //todo : payment is pending.
    }
}
