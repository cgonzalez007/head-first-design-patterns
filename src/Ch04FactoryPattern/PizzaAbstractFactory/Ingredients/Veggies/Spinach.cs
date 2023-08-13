using System;

namespace PizzaAbstractFactory.Ingredients.Veggies;

public class Spinach : IVeggies
{
    public Spinach()
    {
        Name = "Spinach";
    }

    public string Name { get; }
}
