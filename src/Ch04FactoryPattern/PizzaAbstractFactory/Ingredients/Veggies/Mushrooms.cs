using System;

namespace PizzaAbstractFactory.Ingredients.Veggies;

public class Mushrooms : IVeggies
{
    public Mushrooms()
    {
        Name = "Mushrooms";
    }

    public string Name { get; }
}
