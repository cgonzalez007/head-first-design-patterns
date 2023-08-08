using System;

namespace PizzaFactory.Pizzas;

public class ChicagoStyleVeggiePizza : Pizza
{
    public ChicagoStyleVeggiePizza()
    {
        Name = "Chicago Deep Dish Veggie Pizza";
        Dough = "Extra Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";

        Toppings.Add("Shredded Mozzarella Cheese");
        Toppings.Add("Black Olives");
        Toppings.Add("Spinach");
        Toppings.Add("Eggplant");
    }

    public override string Name { get; }

    public override string Dough { get; }

    public override string Sauce { get; }

    public override void Cut()
        => Console.WriteLine("Cutting the pizza into square slices");
}
