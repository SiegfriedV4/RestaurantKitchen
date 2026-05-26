using RestaurantKitchen.Components;
namespace RestaurantKitchen.Mediator;
public class KitchenMediator : IKitchenMediator
{
    private readonly Waiter _waiter;
    private readonly Chef _chef;
    private readonly Cashier _cashier;
    public KitchenMediator(Waiter waiter, Chef chef, Cashier cashier)
    {
        _waiter  = waiter;
        _chef    = chef;
        _cashier = cashier;
        _waiter.SetMediator(this);
        _chef.SetMediator(this);
        _cashier.SetMediator(this);
    }
    public void Notify(KitchenComponent sender, string kitchenEvent)
    {
        Console.WriteLine($" Mediator received: [{kitchenEvent}] from {sender.Name}");
        var parts = kitchenEvent.Split(':', 2);
        var eventName = parts[0];
        var payload = parts.Length > 1 ? parts[1] : string.Empty; // this is the dish name in our case
        switch (eventName)
        {
            case "OrderPlaced":
                _chef.PrepareFood(payload);
                break;
            case "FoodReady":
                _cashier.GenerateBill(payload);
                _waiter.ServeFood(payload);
                break;
            default:
                Console.WriteLine($" Mediator: unknown event '{eventName}'");
                break;
        }
    }
}