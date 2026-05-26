using RestaurantKitchen.Mediator;
namespace RestaurantKitchen.Components;
public class Waiter : KitchenComponent
{
    public override string Name => "Waiter";
    public void TakeOrder(string dish)
    {
        Console.WriteLine($"\n[{Name}] Order taken: {dish}");
        _mediator!.Notify(this, $"OrderPlaced:{dish}");
    }    public void ServeFood(string dish)
    {
        Console.WriteLine($"[{Name}] Serving '{dish}' to the table.");
    }
}