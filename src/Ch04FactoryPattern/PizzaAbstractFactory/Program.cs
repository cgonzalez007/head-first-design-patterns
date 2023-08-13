// Chapter 4 - Factory Pattern - AbstractPizzaFactory
// Pg 158: The abstract factory pattern provides an interface for creating families of related or 
// dependent objects without specifying their concrete classes. 

using PizzaAbstractFactory.Stores;

var nyStore = new NyPizzaStore();
var chicagoStore = new ChicagoPizzaStore();

var pizza = nyStore.OrderPizza("cheese");

Console.WriteLine("\nEthan ordered a\n" + pizza + "\n");


pizza = chicagoStore.OrderPizza("cheese");

Console.WriteLine("\nJoel ordered a\n" + pizza + "\n");


pizza = nyStore.OrderPizza("clam");

Console.WriteLine("\nEthan ordered a\n" + pizza + "\n");


pizza = chicagoStore.OrderPizza("clam");

Console.WriteLine("\nJoel ordered a\n" + pizza + "\n");


pizza = nyStore.OrderPizza("pepperoni");

Console.WriteLine("\nEthan ordered a\n" + pizza + "\n");

pizza = chicagoStore.OrderPizza("pepperoni");

Console.WriteLine("\nJoel ordered a\n" + pizza + "\n");


pizza = nyStore.OrderPizza("veggie");

Console.WriteLine("\nEthan ordered a\n" + pizza + "\n");

pizza = chicagoStore.OrderPizza("veggie");

Console.WriteLine("\nJoel ordered a\n" + pizza + "\n");

