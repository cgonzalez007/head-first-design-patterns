using PizzaAbstractFactory.Pizzas;
using PizzaAbstractFactory.Factories;

namespace PizzaAbstractFactory.Stores;

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string? type)
    {
        if (type is null)
            throw new ArgumentNullException(nameof(type));

        Pizza? pizza = null;

        var ingredientFactory =
            new ChicagoPizzaIngredientFactory();

        if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new CheesePizza(ingredientFactory);
            pizza.Name = "Chicago Style Cheese Pizza";
        }
        else if (type.Equals("veggie", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new VeggiePizza(ingredientFactory);
            pizza.Name = "Chicago Style Veggie Pizza";
        }
        else if (type.Equals("clam", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new ClamPizza(ingredientFactory);
            pizza.Name = "Chicago Style Clam Pizza";
        }
        else if (type.Equals("pepperoni", StringComparison.OrdinalIgnoreCase))
        {
            pizza = new PepperoniPizza(ingredientFactory);
            pizza.Name = "Chicago Style Pepperoni Pizza";
        }

        if (pizza is null)
            throw new ArgumentException($"Could not find Pizza implementation for '{type}'.");

        return pizza;
    }
}