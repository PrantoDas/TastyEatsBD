namespace TastyEatsBD.Core.Entities;

public class Ledger
{
    public int ID { get; set; }
    public int AccountID { get; set; }
    public decimal Amount { get; set; }
    public DateTime CreatedOn { get; set; }
    public string TransactionType { get; set; }
    public int ReferenceID { get; set; }
    public string Description { get; set; }
}
