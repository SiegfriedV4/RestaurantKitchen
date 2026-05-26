using RestaurantKitchen.Components;
using RestaurantKitchen.Mediator;
Console.WriteLine("=== Restaurant Kitchen — Mediator Pattern ===\n");

var waiter  = new Waiter();
var chef = new Chef();
var cashier = new Cashier();

var kitchen = new KitchenMediator(waiter, chef, cashier);

Console.WriteLine("--- Table 1 Orders ---");
waiter.TakeOrder("Burger");
Console.WriteLine("\n--- Table 2 Orders ---");
waiter.TakeOrder("Steak");
Console.WriteLine("\n--- Table 3 Orders ---");
waiter.TakeOrder("Pasta");