using System;

namespace PizzaAbstractFactory.Ingredients.Veggies;

public class Garlic : IVeggies
{
    public Garlic()
    {
        Name = "Garlic";
    }

    public string Name { get; }
}
