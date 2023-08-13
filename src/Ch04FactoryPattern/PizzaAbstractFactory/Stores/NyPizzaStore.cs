using PizzaAbstractFactory.Pizzas;
using PizzaAbstractFactory.Factories;

namespace PizzaAbstractFactory.Stores;

public class NyPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string? type)
    {
        if (type is null)
            throw new ArgumentNullException(nameof(type));

        Pizza? pizza = null;

        var ingredientFactory =
            new NyPizzaIngredientFactory();

        if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new CheesePizza(ingredientFactory);
            pizza.Name = "New York Style Cheese Pizza";
        }
        else if (type.Equals("veggie", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new VeggiePizza(ingredientFactory);
            pizza.Name = "New York Style Veggie Pizza";
        }
        else if (type.Equals("clam", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new ClamPizza(ingredientFactory);
            pizza.Name = "New York Style Clam Pizza";
        }
        else if (type.Equals("pepperoni", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new PepperoniPizza(ingredientFactory);
            pizza.Name = "New York Style Pepperoni Pizza";
        }

        if (pizza is null)
            throw new ArgumentException($"Could not find Pizza implementation for '{type}'.");

        return pizza;
    }
}