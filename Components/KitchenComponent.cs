using RestaurantKitchen.Mediator;
namespace RestaurantKitchen.Components;
public abstract class KitchenComponent
{
    protected IKitchenMediator? _mediator;
    public void SetMediator(IKitchenMediator mediator)
        => _mediator = mediator;
    public abstract string Name { get; }
}