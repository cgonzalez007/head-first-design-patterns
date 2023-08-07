using System;

namespace SimpleFactory.Pizzas;

public class CheesePizza : Pizza
{
    public CheesePizza()
    {
        Toppings.Add("Fresh Mozzarella");
        Toppings.Add("Parmesan");
    }

    public override string Name => "Cheese Pizza";

    public override string Dough => "Regular Crust";

    public override string Sauce => "Marinara Pizza Sauce";
}
