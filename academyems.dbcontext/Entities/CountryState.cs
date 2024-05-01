using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace academyems.dbcontext.Entities;

[Table(name: "country_state")]
public class CountryState
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [ForeignKey("id")]
    [Column("country_id")]
    public int CountryId { get; set; }

    public virtual Country Country { get; set; }

    [Column("state_name")]
    public string StateName { get; set; }
}
