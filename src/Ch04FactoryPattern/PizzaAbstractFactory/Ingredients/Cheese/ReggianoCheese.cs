using System;

namespace PizzaAbstractFactory.Ingredients.Cheese;

public class ReggianoCheese : ICheese
{
    public ReggianoCheese()
    {
        Name = "Reggiano Cheese";
    }

    public string Name { get; }
}
