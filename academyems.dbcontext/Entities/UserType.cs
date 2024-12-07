using AcademyEMS.CoreDbContext.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademyEMS.CoreDbContext.Entities
{
    [Table(name: "user_type")]
    public class UserType : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("type")]
        public string Type { get; set; }

        [Column("description")]
        public string? Description { get; set; }


        // Navigation property for the dependent entity
        public ICollection<UserDetail> UserDetails { get; set; }
    }
}