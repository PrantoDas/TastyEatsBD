using System.Security;

namespace TastyEatsBD.Core.Entities;

public class Account
{
    public int ID { get; set; }
    public string AccountType { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public SecureString Password { get; set; }
    public decimal? Rating { get; set; }
    public string ProfileImageUrl { get; set; }
    public DateTime CreatedOn { get; set; }
    public string CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public string ModifiedBy { get; set; }
}

