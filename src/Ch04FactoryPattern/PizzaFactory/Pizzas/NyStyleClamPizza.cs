using System;

namespace PizzaFactory.Pizzas;

public class NyStyleClamPizza : Pizza
{
    public NyStyleClamPizza()
    {
        Name = "NY Style Clam Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";

        Toppings.Add("Grated Reggiano Cheese");
        Toppings.Add("Fresh Clams from Long Island");
    }

    public override string Name { get; }

    public override string Dough { get; }

    public override string Sauce { get; }
}
