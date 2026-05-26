namespace RestaurantKitchen.Components;
public class Chef : KitchenComponent
{
    public override string Name => "Chef";
    public void PrepareFood(string dish)
    {
        Console.WriteLine($"[{Name}] Preparing: {dish}...");
        Console.WriteLine($"[{Name}] {dish} is ready!");
        _mediator!.Notify(this, $"FoodReady:{dish}");
    }
}