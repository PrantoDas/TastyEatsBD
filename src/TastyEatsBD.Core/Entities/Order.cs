namespace TastyEatsBD.Core.Entities;

public class Order
{
    public int ID { get; set; }
    public int CustomerID { get; set; }
    public int DeliveryLocationID { get; set; }
    public decimal TotalPrice { get; set; }
    public decimal? Discount { get; set; }
    public string Status { get; set; }
    public string PaymentMethod { get; set; }
    public string PaymentStatus { get; set; }
    public DateTime CreatedOn { get; set; }
    public string CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public string ModifiedBy { get; set; }
}
