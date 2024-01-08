using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TastyEatsBD.Core.Entities;
using TastyEatsBD.Core.Enums;

namespace TastyEatsBD.Infrastructure.Data.EntityConfigurations;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.HasData(GetAccountSeedData());
    }

    private IEnumerable<Account> GetAccountSeedData()
    {
        var accounts = new List<Account>
        {
            // 1 Default Admin Account
            new Account { ID = 1, AccountType = AccountType.Administrator, Name = "Admin User", Email = "daspranto82@gmail.com" },

            // 10 Default Restaurants
            new Account { ID = 2, AccountType = AccountType.Restaurant, Name = "Dhaka Delights", Email = "contact@dhakadelights.com" },
            new Account { ID = 3, AccountType = AccountType.Restaurant, Name = "Chittagong Eats", Email = "info@chittagongeats.com" },
            new Account { ID = 4, AccountType = AccountType.Restaurant, Name = "Sylhet Spices", Email = "contact@sylhetspices.com" },
            new Account { ID = 5, AccountType = AccountType.Restaurant, Name = "Rajshahi Recipes", Email = "hello@rajshahirecipes.com" },
            new Account { ID = 6, AccountType = AccountType.Restaurant, Name = "Khulna Kitchen", Email = "info@khulnakitchen.com" },
            new Account { ID = 7, AccountType = AccountType.Restaurant, Name = "Barisal Bites", Email = "support@barisalbites.com" },
            new Account { ID = 8, AccountType = AccountType.Restaurant, Name = "Rangpur Relish", Email = "contact@rangpurrelish.com" },
            new Account { ID = 9, AccountType = AccountType.Restaurant, Name = "Mymensingh Munch", Email = "info@mymensinghmunch.com" },
            new Account { ID = 10, AccountType = AccountType.Restaurant, Name = "Comilla Cuisine", Email = "hello@comillacuisine.com" },
            new Account { ID = 11, AccountType = AccountType.Restaurant, Name = "Gazipur Gourmet", Email = "support@gazipurgourmet.com" },

            // 10 Default Riders
            new Account { ID = 12, AccountType = AccountType.Rider, Name = "Aminul Islam", Email = "aminul.islam@tastyeats.com" },
            new Account { ID = 13, AccountType = AccountType.Rider, Name = "Bishal Ray", Email = "bishal.ray@tastyeats.com" },
            new Account { ID = 14, AccountType = AccountType.Rider, Name = "Chayan Das", Email = "chayan.das@tastyeats.com" },
            new Account { ID = 15, AccountType = AccountType.Rider, Name = "Dipu Chandra", Email = "dipu.chandra@tastyeats.com" },
            new Account { ID = 16, AccountType = AccountType.Rider, Name = "Emon Hossain", Email = "emon.hossain@tastyeats.com" },
            new Account { ID = 17, AccountType = AccountType.Rider, Name = "Fahim Molla", Email = "fahim.molla@tastyeats.com" },
            new Account { ID = 18, AccountType = AccountType.Rider, Name = "Gias Uddin", Email = "gias.uddin@tastyeats.com" },
            new Account { ID = 19, AccountType = AccountType.Rider, Name = "Habib Rahman", Email = "habib.rahman@tastyeats.com" },
            new Account { ID = 20, AccountType = AccountType.Rider, Name = "Irfan Ali", Email = "irfan.ali@tastyeats.com" },
            new Account { ID = 21, AccountType = AccountType.Rider, Name = "Joy Barua", Email = "joy.barua@tastyeats.com" }
        };
        return accounts;
    }

}