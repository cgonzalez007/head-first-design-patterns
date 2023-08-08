using System;

namespace SimpleFactory.Pizzas;

public class ClamPizza : Pizza
{
    public ClamPizza()
    {
        Name = "Clam Pizza";
        Dough = "Thin Crust";
        Sauce = "White Garlic Sauce";
        Toppings.Add("Clams");
        Toppings.Add("Grated parmesan cheese");
    }

    public override string Name { get; }

    public override string Dough { get; }

    public override string Sauce { get; }
}
