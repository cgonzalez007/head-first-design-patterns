using System;

namespace PizzaFactory.Pizzas;

public class ChicagoStyleCheesePizza : Pizza
{
    public ChicagoStyleCheesePizza()
    {
        Name = "Chicago Style Deep Dish Cheese Pizza";
        Dough = "Extra Thick Crust Dough";
        Sauce = "Plum Tomato Sauce";
        Toppings.Add("Shredded Mozzarella Cheese");
    }

    public override string Name { get; }

    public override string Dough { get; }

    public override string Sauce { get; }

    public override void Cut()
        => Console.WriteLine("Cutting the pizza into square slices");
}
