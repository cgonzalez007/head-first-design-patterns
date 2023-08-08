using System;

namespace PizzaFactory.Pizzas;

public class NyStylePepperoniPizza : Pizza
{
    public NyStylePepperoniPizza()
    {
        Name = "NY Style Pepperoni Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";

        Toppings.Add("Grated Reggiano Cheese");
        Toppings.Add("Sliced Pepperoni");
        Toppings.Add("Garlic");
        Toppings.Add("Onion");
        Toppings.Add("Mushrooms");
        Toppings.Add("Red Pepper");
    }

    public override string Name { get; }

    public override string Dough { get; }

    public override string Sauce { get; }
}
