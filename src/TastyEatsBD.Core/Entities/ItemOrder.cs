using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TastyEatsBD.Core.Entities;

public class ItemOrder : EntityBase
{
    [Required(ErrorMessage = "Order Id is required")]
    [Display(Name = "Order Id")]
    public int OrderId { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Order? Order { get; set; }

    [Required(ErrorMessage = "Item Id is required")]
    [Display(Name = "Item Id")]
    public int ItemId { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Item? Item { get; set; }

    [Required(ErrorMessage = "Quantity is required")]
    [Range(1, int.MaxValue, ErrorMessage = "Minimum Quantity should be {1}")]
    [Display(Name = "Quantity")]
    public int Quantity { get; set; }

    [Required(ErrorMessage = "Total Price is required")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Total Price must be greater than or equal to {1}")]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    [Display(Name = "Total Price")]
    public double TotalPrice { get; set; }
}
