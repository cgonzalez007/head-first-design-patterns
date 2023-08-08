using System;
using PizzaFactory.Pizzas;

namespace PizzaFactory.Stores;

public class ChicagoPizzaStore : PizzaStore
{
    public override Pizza CreatePizza(string type)
    {
        if (string.IsNullOrEmpty(type))
            throw new ArgumentException($"Parameter {nameof(type)} cannot be null or empty.");

        if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
            return new ChicagoStyleCheesePizza();

        if (type.Equals("veggie", StringComparison.OrdinalIgnoreCase))
            return new ChicagoStyleVeggiePizza();

        if (type.Equals("clam", StringComparison.OrdinalIgnoreCase))
            return new ChicagoStyleClamPizza();

        if (type.Equals("pepperoni", StringComparison.OrdinalIgnoreCase))
            return new ChicagoStylePepperoniPizza();

        throw new ArgumentException($"Could not find Pizza implementation for '{type}'.");
    }
}
