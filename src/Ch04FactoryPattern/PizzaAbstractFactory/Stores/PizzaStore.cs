using System.Diagnostics.CodeAnalysis;
using PizzaAbstractFactory.Pizzas;

namespace PizzaAbstractFactory.Stores;

public abstract class PizzaStore
{
    protected abstract Pizza CreatePizza(string? type);

    public Pizza OrderPizza(string? type)
    {
        if(type is null)
            throw new ArgumentNullException(nameof(type));
        
        var pizza = CreatePizza(type);

        Console.WriteLine("--- Making a " + pizza.Name + " ---");

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}