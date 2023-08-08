using System;

namespace SimpleFactory.Pizzas;

public class PepperoniPizza : Pizza
{
    public PepperoniPizza()
    {
        Name = "Pepperoni Pizza";
        Dough = "Crust";
        Sauce = "Marinara Sauce";
        Toppings.Add("Sliced Pepperoni");
        Toppings.Add("Sliced Onion");
        Toppings.Add("Grated parmesan cheese");
    }

    public override string Name { get; }

    public override string Dough { get; }

    public override string Sauce { get; }
}
