using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TastyEatsBD.Core.Entities;

public class ItemOrder : EntityBase
{
    [Required(ErrorMessage = "Order ID is required")]
    [Display(Name = "Order ID")]
    public int OrderID { get; set; }

    [Required(ErrorMessage = "Item ID is required")]
    [Display(Name = "Item ID")]
    public int ItemID { get; set; }

    [Required(ErrorMessage = "Quantity is required")]
    [Range(1, int.MaxValue, ErrorMessage = "Minimum Quantity should be {1}")]
    [Display(Name = "Quantity")]
    public int Quantity { get; set; }

    [Required(ErrorMessage = "Total Price is required")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Total Price must be greater than or equal to {1}")]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    [Display(Name = "Total Price")]
    public decimal TotalPrice { get; set; }
}
