using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academyems.CoreDbContext.Entities
{
    [Table(name: "course_type")]
    public class CourseType : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("type")]
        public string Type { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        // Navigation property for the dependent entity
        public ICollection<Course> Courses { get; set; }
    }
}
