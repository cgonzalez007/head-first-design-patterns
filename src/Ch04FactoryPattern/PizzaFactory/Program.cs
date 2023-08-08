// Chapter 4 - Factory Pattern - PizzaFactory
// Pg 136: The factory method pattern defines an interface for creating an object, but lets subclasses 
// decide which class to instantiate. Factory method lets a class defer instantiation to subclass.

using PizzaFactory.Pizzas;
using PizzaFactory.Stores;

var nyStore = new NyPizzaStore();
var chicagoStore = new ChicagoPizzaStore();

var pizza = nyStore.OrderPizza("cheese");
Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

pizza = chicagoStore.OrderPizza("cheese");
Console.WriteLine($"Joel ordered a {pizza.Name}\n");

pizza = nyStore.OrderPizza("clam");
Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

pizza = chicagoStore.OrderPizza("clam");
Console.WriteLine($"Joel ordered a {pizza.Name}\n");

pizza = nyStore.OrderPizza("pepperoni");
Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

pizza = chicagoStore.OrderPizza("pepperoni");
Console.WriteLine($"Joel ordered a {pizza.Name}\n");

pizza = nyStore.OrderPizza("veggie");
Console.WriteLine($"Ethan ordered a {pizza.Name}\n");

pizza = chicagoStore.OrderPizza("veggie");
Console.WriteLine($"Joel ordered a {pizza.Name}\n");