using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TastyEatsBD.Core.Enums;

namespace TastyEatsBD.Core.Entities;

public class Order : EntityBase
{
    [Required(ErrorMessage = "Customer ID is required")]
    [Display(Name = "Customer ID")]
    public int CustomerID { get; set; }

    [Required(ErrorMessage = "Delivery Location ID is required")]
    [Display(Name = "Delivery Location ID")]
    public int DeliveryLocationID { get; set; }

    [Required(ErrorMessage = "Total price is required")]
    [Column(TypeName = "decimal(10, 4)")]
    [Display(Name = "Total Price")]
    [DataType(DataType.Currency)]
    public decimal TotalPrice { get; set; }

    [Column(TypeName = "decimal(10, 4)")]
    [Range(0, int.MaxValue, ErrorMessage = "Discount must be between {1} and Total Price")]
    [Display(Name = "Discount")]
    public decimal? Discount { get; set; }

    [Required(ErrorMessage = "Order status is required")]
    [Display(Name = "Status")]
    public OrderStatus Status { get; set; }

    [Required(ErrorMessage = "Payment method is required")]
    [Display(Name = "Payment Method")]
    public PaymentMethod PaymentMethod { get; set; }

    [Required(ErrorMessage = "Payment status is required")]
    [Display(Name = "Payment Status")]
    public PaymentStatus PaymentStatus { get; set; }

    [Range(0, 5, ErrorMessage = "Rating must be between {1} and {2}")]
    [Column(TypeName = "decimal(2, 1)")]
    [Display(Name = "Rating")]
    public decimal? Rating { get; set; }
}