using System;
using PizzaFactory.Pizzas;

namespace PizzaFactory.Stores;

public abstract class PizzaStore
{
    public abstract Pizza CreatePizza(string type);

    public virtual Pizza OrderPizza(string type)
    {
        var pizza = CreatePizza(type);

        Console.WriteLine($"--- Making a {pizza.Name} ---");

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}
