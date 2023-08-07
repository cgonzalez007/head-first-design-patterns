using System;

namespace SimpleFactory.Pizzas;

public class ClamPizza : Pizza
{
    public ClamPizza()
    {
        Toppings.Add("Clams");
        Toppings.Add("Grated parmesan cheese");
    }

    public override string Name => "Clam Pizza";

    public override string Dough => "Thin Crust";

    public override string Sauce => "White Garlic Sauce";
}
