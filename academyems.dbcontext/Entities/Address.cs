using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademyEMS.CoreDbContext.Entities
{
    [Table(name: "address")]
    public class Address : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("address_line1")]
        public string AddressLine1 { get; set; }

        [Column("address_line2")]
        public string? AddressLine2 { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("pincode")]
        public int PinCode { get; set; }

        // Navigation property for the dependent entity
        public ICollection<Batch> Batches { get; set; }
       // Navigation property for the dependent entity
        public ICollection<UserDetail> UserDetails { get; set; }
    }
}
