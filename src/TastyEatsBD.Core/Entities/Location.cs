using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TastyEatsBD.Core.Entities;

public class Location : EntityBase
{
    [Column(TypeName = "decimal(7, 7)")]
    [Display(Name = "Latitude")]
    [Range(-90.0, 90.0, ErrorMessage = "Latitude must be between {1} and {2}")]
    public decimal Latitude { get; set; }

    [Column(TypeName = "decimal(7, 7)")]
    [Display(Name = "Longitude")]
    [Range(-180.0, 180.0, ErrorMessage = "Longitude must be between {1} and {2}")]
    public decimal Longitude { get; set; }

    [StringLength(100, ErrorMessage = "Street address must be under {1} characters")]
    [Display(Name = "Street Address")]
    public string? StreetAddress { get; set; }

    [StringLength(50, ErrorMessage = "Area must be under {1} characters")]
    [Display(Name = "Area")]
    public string? Area { get; set; }

    [StringLength(50, ErrorMessage = "City must be under {1} characters")]
    [Display(Name = "City")]
    public string? City { get; set; }

    [StringLength(20, ErrorMessage = "Zip code must be under {1} characters")]
    [Display(Name = "Zip Code")]
    [DataType(DataType.PostalCode)]
    public string? ZipCode { get; set; }
}
