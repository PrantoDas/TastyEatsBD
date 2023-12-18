namespace TastyEatsBD.Core.Entities;

public class ItemOrder
{
    public int ID { get; set; }
    public int OrderID { get; set; }
    public int ItemID { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime CreatedOn { get; set; }
    public string CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public string ModifiedBy { get; set; }
}
