using System;
using PizzaFactory.Pizzas;

namespace PizzaFactory.Stores;

public class DependentPizzaStore
{
    public Pizza CreatePizza(string style, string type)
    {
        if (string.IsNullOrEmpty(style))
            throw new ArgumentException($"Parameter {nameof(style)} cannot be null or empty.");

        if (string.IsNullOrEmpty(type))
            throw new ArgumentException($"Parameter {nameof(type)} cannot be null or empty.");

        Pizza? pizza = null;

        if (style.Equals("NY", StringComparison.OrdinalIgnoreCase))
        {
            if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
                pizza = new NyStyleCheesePizza();

            if (type.Equals("veggie", StringComparison.OrdinalIgnoreCase))
                pizza = new NyStyleVeggiePizza();

            if (type.Equals("clam", StringComparison.OrdinalIgnoreCase))
                pizza = new NyStyleClamPizza();

            if (type.Equals("pepperoni", StringComparison.OrdinalIgnoreCase))
                pizza = new NyStylePepperoniPizza();
        }

        if (style.Equals("Chicago", StringComparison.OrdinalIgnoreCase))
        {
            if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
                pizza = new ChicagoStyleCheesePizza();

            if (type.Equals("veggie", StringComparison.OrdinalIgnoreCase))
                pizza = new ChicagoStyleVeggiePizza();

            if (type.Equals("clam", StringComparison.OrdinalIgnoreCase))
                pizza = new ChicagoStyleClamPizza();

            if (type.Equals("pepperoni", StringComparison.OrdinalIgnoreCase))
                pizza = new ChicagoStylePepperoniPizza();
        }

        if (pizza is null)
            throw new ArgumentException($"Could not find Pizza implementation for style '{style}' and type '{type}'.");

        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}
