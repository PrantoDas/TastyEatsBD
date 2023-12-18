namespace TastyEatsBD.Core.Entities;

public class Item
{
    public int ID { get; set; }
    public int RestaurantID { get; set; }
    public string ItemName { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public decimal? Discount { get; set; }
    public bool IsAvailable { get; set; }
    public int? PreparationTime { get; set; }
    public string PhotoURL { get; set; }
    public DateTime CreatedOn { get; set; }
    public string CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public string ModifiedBy { get; set; }
}
