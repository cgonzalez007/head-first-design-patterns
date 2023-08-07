using System;

namespace SimpleFactory.Pizzas;

public class VeggiePizza : Pizza
{
    public VeggiePizza()
    {
        Toppings.Add("Shredded mozzarella");
        Toppings.Add("Grated parmesan");
        Toppings.Add("Diced onion");
        Toppings.Add("Sliced mushrooms");
        Toppings.Add("Sliced red pepper");
        Toppings.Add("Sliced black olives");
    }

    public override string Name => "Veggie Pizza";

    public override string Dough => "Crust";

    public override string Sauce => "Marinara Sauce";
}
