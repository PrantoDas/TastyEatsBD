using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TastyEatsBD.Core.Entities;

public class EntityBase
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Display(Name = "ID")]
    public int ID { get; set; }

    [Required(ErrorMessage = "Creator name is required")]
    [StringLength(50, ErrorMessage = "Creator name must be less than {1} characters")]
    [Display(Name = "Created By")]
    public string CreatedBy { get; set; } = "TastyEatsBD_WebApp";

    [Required(ErrorMessage = "Creation date is required")]
    [Display(Name = "Created On")]
    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

    [StringLength(50, ErrorMessage = "Modifier name must be less than {1} characters")]
    [Display(Name = "Modified By")]
    public string? ModifiedBy { get; set; } = "TastyEatsBD_WebApp";

    [DataType(DataType.DateTime)]
    [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
    [Display(Name = "Modified On")]
    public DateTime? ModifiedOn { get; set; } = DateTime.UtcNow;
}
