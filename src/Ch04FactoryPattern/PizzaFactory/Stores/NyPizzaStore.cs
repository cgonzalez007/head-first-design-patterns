using System;
using PizzaFactory.Pizzas;

namespace PizzaFactory.Stores;

public class NyPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {
        if (string.IsNullOrEmpty(type))
            throw new ArgumentException($"Parameter {nameof(type)} cannot be null or empty.");

        if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
            return new NyStyleCheesePizza();

        if (type.Equals("veggie", StringComparison.OrdinalIgnoreCase))
            return new NyStyleVeggiePizza();

        if (type.Equals("clam", StringComparison.OrdinalIgnoreCase))
            return new NyStyleClamPizza();

        if (type.Equals("pepperoni", StringComparison.OrdinalIgnoreCase))
            return new NyStylePepperoniPizza();

        throw new ArgumentException($"Could not find Pizza implementation for '{type}'.");
    }
}
