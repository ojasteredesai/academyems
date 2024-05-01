using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace academyems.dbcontext.Entities
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

        [ForeignKey("Country")]
        [Column("country_id")]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        [ForeignKey("CountryState")]
        [Column("state_id")]
        public int StateId { get; set; }

        public virtual CountryState CountryState { get; set; }

        [Column("pincode")]
        public int PinCode { get; set; }
    }
}
