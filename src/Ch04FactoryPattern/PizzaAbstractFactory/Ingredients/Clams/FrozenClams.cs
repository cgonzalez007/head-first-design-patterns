using System;

namespace PizzaAbstractFactory.Ingredients.Clams;

public class FrozenClams : IClams
{
    public FrozenClams()
    {
        Name = "Frozen Clams From Chesapeake Bay";
    }

    public string Name { get; }
}
