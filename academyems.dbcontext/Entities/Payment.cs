using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademyEMS.CoreDbContext.Entities
{

    //    id number,
    //batch_enrollment_id fk int batch_enrollment,
    //payment_status_id fk int payment_status,
    //payment_difference double,
    //	created_date,
    //	modified_date,
    //	created_by int,
    //	modified_by int
    public class Payment
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }


        [Column("batch_enrollment_id")]
        public int BatchEnrollmentId { get; set; }

        [Column("payment_typeid")]
        public int PaymentTypeId { get; set; }

        [Column("payment_statusid")]
        public int PaymentStatusId { get; set; }

        [Column("payment_difference")]
        public double PaymentDifference { get; set; }

        [ForeignKey("PaymentTypeId")]
        public PaymentType PaymentType { get; set; }

        [ForeignKey("PaymentStatusId")]
        public PaymentStatus PaymentStatus { get; set; }

    }
}
