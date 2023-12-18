namespace TastyEatsBD.Core.Entities;

public class Customer
{
    public int ID { get; set; }
    public int AccountID { get; set; }
    public DateTime CreatedOn { get; set; }
    public string CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public string ModifiedBy { get; set; }
}
