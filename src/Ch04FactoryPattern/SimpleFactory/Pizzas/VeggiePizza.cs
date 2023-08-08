using System;

namespace SimpleFactory.Pizzas;

public class VeggiePizza : Pizza
{
    public VeggiePizza()
    {
        Name = "Veggie Pizza";
        Dough = "Crust";
        Sauce = "Marinara Sauce";
        Toppings.Add("Shredded mozzarella");
        Toppings.Add("Grated parmesan");
        Toppings.Add("Diced onion");
        Toppings.Add("Sliced mushrooms");
        Toppings.Add("Sliced red pepper");
        Toppings.Add("Sliced black olives");
    }

    public override string Name { get; }

    public override string Dough { get; }

    public override string Sauce { get; }
}
