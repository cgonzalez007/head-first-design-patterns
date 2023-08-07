using SimpleFactory.Pizzas;
using SimpleFactory;

var factory = new SimplePizzaFactory();
var store = new PizzaStore(factory);

var pizza = store.OrderPizza("cheese");

Console.WriteLine($"We ordered a {pizza.Name}\n");

pizza = store.OrderPizza("pepperoni");

Console.WriteLine($"We ordered a {pizza.Name}\n");