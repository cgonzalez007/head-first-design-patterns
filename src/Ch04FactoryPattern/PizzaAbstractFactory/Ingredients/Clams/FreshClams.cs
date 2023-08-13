using System;

namespace PizzaAbstractFactory.Ingredients.Clams;

public class FreshClams : IClams
{
    public FreshClams()
    {
        Name = "Fresh Clams From Long Island";
    }

    public string Name { get; }
}
