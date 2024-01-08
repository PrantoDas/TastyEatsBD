using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Infrastructure.Data.EntityConfigurations;

public class ItemConfiguration : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        // RestaurantID - Foreign Key to Restaurant
        builder.HasIndex(i => i.RestaurantID).HasDatabaseName("IDX_Item_RestaurantID");

        // ItemName - Need to make it full text searchable later on using a migration script
        //builder.HasIndex(i => i.ItemName).HasDatabaseName("IDX_Item_ItemName");

        builder.HasData(GetItemSeedData());
    }

    private IEnumerable<Item> GetItemSeedData()
    {
        var items = new List<Item>();

        items.AddRange(new List<Item>
        {
            new Item { ID = 1, RestaurantID = 1, Name = "Biryani", Description = "Aromatic rice dish with marinated chicken and spices", Price = 350 },
            new Item { ID = 2, RestaurantID = 1, Name = "Haleem", Description = "Rich stew of lentils, wheat, and tender beef", Price = 220 },
            new Item { ID = 3, RestaurantID = 1, Name = "Fuchka", Description = "Crispy shells filled with tangy tamarind and chickpeas", Price = 120 },
            new Item { ID = 4, RestaurantID = 1, Name = "Bhuna Khichuri", Description = "Mixed rice dish with lentils and aromatic spices", Price = 280 },
            new Item { ID = 5, RestaurantID = 1, Name = "Pitha", Description = "Traditional rice cake, a sweet delight", Price = 150 },
            new Item { ID = 6, RestaurantID = 1, Name = "Roshogolla", Description = "Soft, spongy cheese balls in syrup", Price = 100 },
            new Item { ID = 7, RestaurantID = 1, Name = "Chingri Malai Curry", Description = "Creamy coconut shrimp curry", Price = 400 },
            new Item { ID = 8, RestaurantID = 1, Name = "Beef Kala Bhuna", Description = "Slow-cooked spiced beef, a Chittagong specialty", Price = 320 },
            new Item { ID = 9, RestaurantID = 1, Name = "Mishti Doi", Description = "Sweetened yogurt dessert", Price = 150 },
            new Item { ID = 10, RestaurantID = 1, Name = "Mughlai Paratha", Description = "Stuffed bread with egg and minced meat", Price = 180 }
        });

        items.AddRange(new List<Item>
        {
            new Item { ID = 11, RestaurantID = 2, Name = "Chicken Tikka", Description = "Spiced, grilled chicken chunks", Price = 320 },
            new Item { ID = 12, RestaurantID = 2, Name = "Dal Puri", Description = "Fried bread stuffed with spicy lentils", Price = 130 },
            new Item { ID = 13, RestaurantID = 2, Name = "Aloo Bhorta", Description = "Mashed potatoes with mustard oil and spices", Price = 90 },
            new Item { ID = 14, RestaurantID = 2, Name = "Sorshe Ilish", Description = "Hilsa fish in mustard sauce", Price = 450 },
            new Item { ID = 15, RestaurantID = 2, Name = "Nihari", Description = "Slow-cooked beef stew", Price = 300 },
            new Item { ID = 16, RestaurantID = 2, Name = "Kacchi Biryani", Description = "Layered rice and goat meat dish", Price = 380 },
            new Item { ID = 17, RestaurantID = 2, Name = "Patishapta", Description = "Crepes with coconut and jaggery filling", Price = 160 },
            new Item { ID = 18, RestaurantID = 2, Name = "Luchi", Description = "Deep-fried flatbread", Price = 70 },
            new Item { ID = 19, RestaurantID = 2, Name = "Paneer Butter Masala", Description = "Cottage cheese in creamy tomato sauce", Price = 350 },
            new Item { ID = 20, RestaurantID = 2, Name = "Mango Lassi", Description = "Refreshing yogurt-based mango drink", Price = 180 }
        });

        items.AddRange(new List<Item>
        {
            new Item { ID = 21, RestaurantID = 3, Name = "Shahi Tukra", Description = "Bread pudding with nuts and cream", Price = 200 },
            new Item { ID = 22, RestaurantID = 3, Name = "Lamb Bhuna", Description = "Spicy lamb curry with a thick gravy", Price = 370 },
            new Item { ID = 23, RestaurantID = 3, Name = "Achari Chicken", Description = "Chicken curry with pickling spices", Price = 340 },
            new Item { ID = 24, RestaurantID = 3, Name = "Sabzi Khichuri", Description = "Mixed rice with vegetables and lentils", Price = 260 },
            new Item { ID = 25, RestaurantID = 3, Name = "Doi Maach", Description = "Fish in a yogurt-based curry", Price = 310 },
            new Item { ID = 26, RestaurantID = 3, Name = "Shorshe Bata Diye Macher Jhol", Description = "Fish curry with mustard paste", Price = 330 },
            new Item { ID = 27, RestaurantID = 3, Name = "Kalojam", Description = "Dark, syrupy sweet made from milk solids", Price = 110 },
            new Item { ID = 28, RestaurantID = 3, Name = "Shemai", Description = "Sweet vermicelli dessert", Price = 140 },
            new Item { ID = 29, RestaurantID = 3, Name = "Mutton Korma", Description = "Mutton in a rich, creamy sauce", Price = 390 },
            new Item { ID = 30, RestaurantID = 3, Name = "Paneer Jalfrezi", Description = "Stir-fried cottage cheese with vegetables", Price = 320 }
        });

        items.AddRange(new List<Item>
        {
            new Item { ID = 31, RestaurantID = 4, Name = "Chicken Jalfrezi", Description = "Spicy chicken stir-fry with vegetables", Price = 330 },
            new Item { ID = 32, RestaurantID = 4, Name = "Vegetable Samosa", Description = "Crispy pastry filled with spiced vegetables", Price = 80 },
            new Item { ID = 33, RestaurantID = 4, Name = "Palak Paneer", Description = "Cottage cheese in a spiced spinach gravy", Price = 310 },
            new Item { ID = 34, RestaurantID = 4, Name = "Ras Malai", Description = "Creamy dessert of paneer balls in milk syrup", Price = 190 },
            new Item { ID = 35, RestaurantID = 4, Name = "Goat Rezala", Description = "Mild goat curry with yogurt and cashew nuts", Price = 380 },
            new Item { ID = 36, RestaurantID = 4, Name = "Baingan Bharta", Description = "Mashed eggplant with onions and tomatoes", Price = 200 },
            new Item { ID = 37, RestaurantID = 4, Name = "Chicken Biryani", Description = "Flavorful rice dish with chicken and spices", Price = 360 },
            new Item { ID = 38, RestaurantID = 4, Name = "Dahi Vada", Description = "Fried lentil balls soaked in yogurt", Price = 170 },
            new Item { ID = 39, RestaurantID = 4, Name = "Tandoori Chicken", Description = "Yogurt and spice-marinated chicken, grilled", Price = 350 },
            new Item { ID = 40, RestaurantID = 4, Name = "Kulfi", Description = "Traditional Indian ice cream", Price = 150 }
        });

        items.AddRange(new List<Item>
        {
            new Item { ID = 41, RestaurantID = 5, Name = "Fish Bharta", Description = "Mashed fish with mustard oil and spices", Price = 300 },
            new Item { ID = 42, RestaurantID = 5, Name = "Beguni", Description = "Eggplant slices in a chickpea flour batter", Price = 100 },
            new Item { ID = 43, RestaurantID = 5, Name = "Mutton Biryani", Description = "Layered rice and mutton cooked with aromatic spices", Price = 380 },
            new Item { ID = 44, RestaurantID = 5, Name = "Chotpoti", Description = "Tangy tamarind and chickpea snack", Price = 120 },
            new Item { ID = 45, RestaurantID = 5, Name = "Chicken Roast", Description = "Roasted chicken in a flavorful gravy", Price = 350 },
            new Item { ID = 46, RestaurantID = 5, Name = "Lau Ghonto", Description = "Bottle gourd cooked with lentils", Price = 180 },
            new Item { ID = 47, RestaurantID = 5, Name = "Misti Kumra", Description = "Sweet pumpkin curry", Price = 210 },
            new Item { ID = 48, RestaurantID = 5, Name = "Prawn Malai Curry", Description = "Prawns in a creamy coconut milk sauce", Price = 420 },
            new Item { ID = 49, RestaurantID = 5, Name = "Kalo Bhuna", Description = "Spicy black beef curry", Price = 370 },
            new Item { ID = 50, RestaurantID = 5, Name = "Tehari", Description = "Spiced rice with beef", Price = 340 }
        });

        items.AddRange(new List<Item>
        {
            new Item { ID = 51, RestaurantID = 6, Name = "Daal Puri", Description = "Lentil-stuffed fried bread", Price = 110 },
            new Item { ID = 52, RestaurantID = 6, Name = "Chicken Handi", Description = "Creamy chicken curry cooked in a handi", Price = 320 },
            new Item { ID = 53, RestaurantID = 6, Name = "Vegetable Pakora", Description = "Mixed vegetable fritters", Price = 90 },
            new Item { ID = 54, RestaurantID = 6, Name = "Beef Tehari", Description = "Aromatic rice with tender beef pieces", Price = 360 },
            new Item { ID = 55, RestaurantID = 6, Name = "Shahi Halim", Description = "Rich and hearty lentil and meat stew", Price = 250 },
            new Item { ID = 56, RestaurantID = 6, Name = "Mango Firni", Description = "Mango flavored rice pudding", Price = 150 },
            new Item { ID = 57, RestaurantID = 6, Name = "Fish Kofta Curry", Description = "Fish balls in a spicy gravy", Price = 330 },
            new Item { ID = 58, RestaurantID = 6, Name = "Mutton Rezala", Description = "Mild yogurt-based mutton curry", Price = 390 },
            new Item { ID = 59, RestaurantID = 6, Name = "Palak Chicken", Description = "Chicken cooked with spinach and spices", Price = 310 },
            new Item { ID = 60, RestaurantID = 6, Name = "Vegetable Khichuri", Description = "Rice and lentil mix with assorted vegetables", Price = 260 }
        });

        items.AddRange(new List<Item>
        {
            new Item { ID = 61, RestaurantID = 7, Name = "Paneer Tikka", Description = "Grilled paneer with spices", Price = 280 },
            new Item { ID = 62, RestaurantID = 7, Name = "Mutton Chaap", Description = "Spicy grilled mutton ribs", Price = 400 },
            new Item { ID = 63, RestaurantID = 7, Name = "Vegetable Jalfrezi", Description = "Stir-fried vegetables with Indian spices", Price = 220 },
            new Item { ID = 64, RestaurantID = 7, Name = "Chicken Korma", Description = "Chicken in a creamy almond sauce", Price = 340 },
            new Item { ID = 65, RestaurantID = 7, Name = "Bhapa Ilish", Description = "Steamed hilsa fish with mustard", Price = 450 },
            new Item { ID = 66, RestaurantID = 7, Name = "Shahi Paneer", Description = "Cottage cheese in a rich tomato gravy", Price = 310 },
            new Item { ID = 67, RestaurantID = 7, Name = "Chicken Biriyani", Description = "Fragrant rice with marinated chicken", Price = 360 },
            new Item { ID = 68, RestaurantID = 7, Name = "Moong Dal", Description = "Lentil soup with spices", Price = 150 },
            new Item { ID = 69, RestaurantID = 7, Name = "Fish Fry", Description = "Crispy fried seasoned fish", Price = 320 },
            new Item { ID = 70, RestaurantID = 7, Name = "Dhokar Dalna", Description = "Lentil cakes in a spicy gravy", Price = 210 }
        });

        items.AddRange(new List<Item>
        {
            new Item { ID = 71, RestaurantID = 8, Name = "Beef Boti Kebab", Description = "Spicy beef skewers", Price = 380 },
            new Item { ID = 72, RestaurantID = 8, Name = "Chingri Bhorta", Description = "Mashed spiced shrimp", Price = 340 },
            new Item { ID = 73, RestaurantID = 8, Name = "Samosa Chat", Description = "Crushed samosa with chickpea and tamarind", Price = 120 },
            new Item { ID = 74, RestaurantID = 8, Name = "Butter Chicken", Description = "Chicken in a creamy buttery tomato sauce", Price = 360 },
            new Item { ID = 75, RestaurantID = 8, Name = "Mixed Vegetable Curry", Description = "Assorted vegetables in a spicy gravy", Price = 230 },
            new Item { ID = 76, RestaurantID = 8, Name = "Egg Korma", Description = "Hard-boiled eggs in a creamy sauce", Price = 250 },
            new Item { ID = 77, RestaurantID = 8, Name = "Lamb Vindaloo", Description = "Spicy lamb curry with a vinegar tang", Price = 390 },
            new Item { ID = 78, RestaurantID = 8, Name = "Aloo Gobi", Description = "Cauliflower and potatoes cooked with Indian spices", Price = 210 },
            new Item { ID = 79, RestaurantID = 8, Name = "Chicken Do Pyaza", Description = "Chicken curry with a double onion base", Price = 320 },
            new Item { ID = 80, RestaurantID = 8, Name = "Rasmalai", Description = "Cheese dumplings in a creamy milk sauce", Price = 180 }
        });

        items.AddRange(new List<Item>
        {
            new Item { ID = 81, RestaurantID = 9, Name = "Lamb Rogan Josh", Description = "Tender lamb cooked in a rich, aromatic sauce", Price = 410 },
            new Item { ID = 82, RestaurantID = 9, Name = "Shrimp Bhuna", Description = "Spicy and tangy shrimp curry", Price = 360 },
            new Item { ID = 83, RestaurantID = 9, Name = "Aloo Paratha", Description = "Flatbread stuffed with spiced potatoes", Price = 150 },
            new Item { ID = 84, RestaurantID = 9, Name = "Vegetable Biryani", Description = "Fragrant rice cooked with mixed vegetables", Price = 320 },
            new Item { ID = 85, RestaurantID = 9, Name = "Butter Naan", Description = "Soft and buttery flatbread", Price = 50 },
            new Item { ID = 86, RestaurantID = 9, Name = "Paneer Masala", Description = "Paneer in a spicy tomato-based sauce", Price = 330 },
            new Item { ID = 87, RestaurantID = 9, Name = "Chicken Masala", Description = "Chicken in a rich and spicy curry", Price = 350 },
            new Item { ID = 88, RestaurantID = 9, Name = "Gulab Jamun", Description = "Soft milk-solid balls soaked in rose-scented syrup", Price = 120 },
            new Item { ID = 89, RestaurantID = 9, Name = "Keema Matar", Description = "Minced meat cooked with peas and spices", Price = 340 },
            new Item { ID = 90, RestaurantID = 9, Name = "Dal Makhani", Description = "Creamy black lentils cooked with butter and spices", Price = 250 }
        });

        items.AddRange(new List<Item>
        {
            new Item { ID = 91, RestaurantID = 10, Name = "Chicken Tikka Masala", Description = "Grilled chicken chunks in a spicy sauce", Price = 360 },
            new Item { ID = 92, RestaurantID = 10, Name = "Kulcha", Description = "Leavened bread made from maida flour", Price = 60 },
            new Item { ID = 93, RestaurantID = 10, Name = "Fish Tikka", Description = "Spiced and grilled boneless fish pieces", Price = 380 },
            new Item { ID = 94, RestaurantID = 10, Name = "Mughlai Chicken", Description = "Chicken curry made in Mughlai style", Price = 370 },
            new Item { ID = 95, RestaurantID = 10, Name = "Paneer Tikka", Description = "Marinated paneer grilled to perfection", Price = 310 },
            new Item { ID = 96, RestaurantID = 10, Name = "Beef Sheek Kebab", Description = "Spiced minced beef grilled on skewers", Price = 400 },
            new Item { ID = 97, RestaurantID = 10, Name = "Vegetable Curry", Description = "Assorted vegetables cooked in a flavorful curry", Price = 270 },
            new Item { ID = 98, RestaurantID = 10, Name = "Aloo Tikki", Description = "Spiced potato patties", Price = 110 },
            new Item { ID = 99, RestaurantID = 10, Name = "Chana Masala", Description = "Spicy chickpeas curry", Price = 240 },
            new Item { ID = 100, RestaurantID = 10, Name = "Lassi", Description = "Traditional yogurt-based drink", Price = 150 }
        });


        return items;
    }
}
