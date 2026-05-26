namespace RestaurantKitchen.Mediator;
public interface IKitchenMediator
{
    void Notify(KitchenComponent sender, string kitchenEvent);
}