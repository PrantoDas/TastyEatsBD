using TastyEatsBD.Core.Entities;

namespace TastyEatsBD.Core.DTOs;

public class RestaurantInfo
{
    public List<Item> Items { get; set; }
    public Restaurant Restaurant { get; set; }
    public Account Account { get; set; }
}