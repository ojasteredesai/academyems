using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academyems.CoreDbContext.Entities
{
    [Table(name: "batch_detail")]
    public class BatchDetail : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("batch_id")]
        public int BatchId { get; set; }

        [Column("batch_statusid")]
        public int BatchStatusId { get; set; }

        [Column("student_id")]
        public int StudentId { get; set; }


        [Column("enrollment_date")]
        public DateTime EnrollmentDate { get; set; }


        [ForeignKey("BatchId")]
        public Batch Batch { get; set; }

        [ForeignKey("BatchStatusId")]
        public BatchStatus BatchStatus { get; set; }


        [ForeignKey("StudentId")]
        public UserDetail UserDetail { get; set; }

        //todo : payment is pending.
    }
}
