using System;

namespace PizzaAbstractFactory.Ingredients.Veggies;

public class Eggplant : IVeggies
{
    public Eggplant()
    {
        Name = "Eggplant";
    }

    public string Name { get; }
}
