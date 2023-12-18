namespace TastyEatsBD.Core.Entities;

public class DeliveryOrder
{
    public int ID { get; set; }
    public int OrderID { get; set; }
    public int RestaurantID { get; set; }
    public int RiderID { get; set; }
    public DateTime PickupTime { get; set; }
    public DateTime DeliveryTime { get; set; }
    public DateTime CreatedOn { get; set; }
    public string CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public string ModifiedBy { get; set; }
}
