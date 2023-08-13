using System;

namespace PizzaAbstractFactory.Ingredients.Veggies;

public class Onions : IVeggies
{
    public Onions()
    {
        Name = "Onions";
    }

    public string Name { get; }
}
