using System;
using SimpleFactory.Pizzas;

namespace SimpleFactory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            if (type is null) throw new ArgumentNullException(nameof(type));

            if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
                return new CheesePizza();

            if (type.Equals("pepperoni", StringComparison.OrdinalIgnoreCase))
                return new PepperoniPizza();

            if (type.Equals("clam", StringComparison.OrdinalIgnoreCase))
                return new ClamPizza();

            if (type.Equals("veggie", StringComparison.OrdinalIgnoreCase))
                return new VeggiePizza();

            throw new ArgumentException($"Could not determine Pizza implementation to use for '{type}'.");
        }
    }
}
