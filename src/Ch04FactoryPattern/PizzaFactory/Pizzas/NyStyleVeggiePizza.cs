using System;

namespace PizzaFactory.Pizzas;

public class NyStyleVeggiePizza : Pizza
{
    public NyStyleVeggiePizza()
    {
        Name = "NY Style Veggie Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";

        Toppings.Add("Grated Reggiano Cheese");
        Toppings.Add("Garlic");
        Toppings.Add("Onion");
        Toppings.Add("Mushrooms");
        Toppings.Add("Red Pepper");
    }

    public override string Name { get; }

    public override string Dough { get; }

    public override string Sauce { get; }
}
