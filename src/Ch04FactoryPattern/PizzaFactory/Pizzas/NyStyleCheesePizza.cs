using System;

namespace PizzaFactory.Pizzas;

public class NyStyleCheesePizza : Pizza
{
    public NyStyleCheesePizza()
    {
        Name = "NY Style Sauce and Cheese Pizza";
        Dough = "Thin Crust Dough";
        Sauce = "Marinara Sauce";
        Toppings.Add("Grated Reggiano Cheese");
    }

    public override string Name { get; }

    public override string Dough { get; }

    public override string Sauce { get; }
}
