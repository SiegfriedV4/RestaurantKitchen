namespace RestaurantKitchen.Components;
public class Cashier : KitchenComponent
{
    public override string Name => "Cashier";
    private readonly Dictionary<string, decimal> _menu = new()
    {
        { "Burger", 85.00m },
        { "Pasta", 110.00m },
        { "Salad", 65.00m },
        { "Steak", 220.00m }
    };
    public void GenerateBill(string dish)
    {
        var price = _menu.TryGetValue(dish, out var p) ? p : 0m;
        Console.WriteLine($"[{Name}] Bill generated: {dish} = R{price:F2}");
    }
}