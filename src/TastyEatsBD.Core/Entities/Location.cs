namespace TastyEatsBD.Core.Entities;

public class Location
{
    public int ID { get; set; }
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
    public string StreetAddress { get; set; }
    public string Area { get; set; }
    public string City { get; set; }
    public string ZipCode { get; set; }
    public DateTime CreatedOn { get; set; }
    public string CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public string ModifiedBy { get; set; }
}
