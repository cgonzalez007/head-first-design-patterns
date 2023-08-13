using System;

namespace PizzaAbstractFactory.Ingredients.Veggies;

public class RedPepper : IVeggies
{
    public RedPepper()
    {
        Name = "Red Pepper";
    }

    public string Name { get; }
}
