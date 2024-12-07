using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademyEMS.CoreDbContext.Entities
{
    [Table(name: "batch")]
    public class Batch : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("course_id")]
        public int CourseId { get; set; }

        [Column("instructor_id")]
        public int InstructorId { get; set; }

        [Column("address_id")]
        public int AddressId { get; set; }

        [Column("type")]
        public string Type { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Column("duration")]
        public int Duration { get; set; }

        [Column("start_date")]
        public DateTime StartDate { get; set; }

        [Column("end_date")]
        public DateTime EndDate { get; set; }

        [Column("time")]
        public DateTime Time { get; set; }
        
        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("fees")]
        public double Fees { get; set; }

        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        [ForeignKey("InstructorId")]
        public UserDetail UserDetail { get; set; }

        [ForeignKey("AddressId")]
        public Address Address { get; set; }


        // Navigation property for the dependent entity
        public ICollection<BatchDetail> BatchDetails { get; set; }
    }
}
