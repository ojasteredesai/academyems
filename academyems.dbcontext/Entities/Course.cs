using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademyEMS.CoreDbContext.Entities
{
    [Table(name: "course")]
    public class Course : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }


        [Column("course_typeid")]
        public int CourseTypeId { get; set; }

        [Column("course_name")]
        public string CourseName { get; set; }

        [Column("course_description")]
        public string? CourseDescription { get; set; }


        [ForeignKey("CourseTypeId")]
        public CourseType CourseType { get; set; }


        //Navigation property for the dependent entity
        public ICollection<Batch> Batches { get; set; }
    }
}
