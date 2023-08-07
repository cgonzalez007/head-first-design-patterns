using System;

namespace SimpleFactory.Pizzas;

public class PepperoniPizza : Pizza
{
    public PepperoniPizza()
    {
        Toppings.Add("Sliced Pepperoni");
        Toppings.Add("Sliced Onion");
        Toppings.Add("Grated parmesan cheese");
    }

    public override string Name => "Pepperoni Pizza";

    public override string Dough => "Crust";

    public override string Sauce => "Marinara Sauce";
}
