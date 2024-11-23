using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace academyems.dbcontext.Entities
{
    [Table(name: "user_detail")]
    public class UserDetail : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("user_code")]
        public string UserCode { get; set; }

        [Column("user_typeid")]
        public int UserTypeId { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

        [Column("date_of_birth")]
        public DateTime DateOfBirth { get; set; }

        [Column("identity_id")]
        public string IdentityId { get; set; }

        [Column("identity_type")]
        public string IdentityType { get; set; }

        [Column("mobile_no")]
        public int MobileNo { get; set; }

        [Column("email")]
        public string EMail { get; set; }

        [Column("hashed_password")]
        public string HashedPassword { get; set; }


        [ForeignKey("UserTypeId")]
        public UserType UserType { get; set; }

        // Navigation property for the dependent entity
        public ICollection<Batch> Batches { get; set; }


    }
}