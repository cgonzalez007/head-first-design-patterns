using System;

namespace SimpleFactory.Pizzas;

public class CheesePizza : Pizza
{
    public CheesePizza()
    {
        Name = "Cheese Pizza";
        Dough = "Regular Crust";
        Sauce = "Marinara Pizza Sauce";
        Toppings.Add("Fresh Mozzarella");
        Toppings.Add("Parmesan");
    }

    public override string Name { get; }

    public override string Dough { get; }

    public override string Sauce { get; }
}
