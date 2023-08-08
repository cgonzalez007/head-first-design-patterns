// Chapter 4 - Factory Pattern - SimpleFactory
// Pg 119: The Simple Factory isn't actually a Design Pattern; it's more of a programming idiom. But it is
// commonly used, so we'll give it a Head First Pattern Honorable Mention. 

using SimpleFactory.Pizzas;
using SimpleFactory;

var factory = new SimplePizzaFactory();
var store = new PizzaStore(factory);

var pizza = store.OrderPizza("cheese");

Console.WriteLine($"We ordered a {pizza.Name}\n");

pizza = store.OrderPizza("pepperoni");

Console.WriteLine($"We ordered a {pizza.Name}\n");