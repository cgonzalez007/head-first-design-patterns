using System;

namespace PizzaAbstractFactory.Ingredients.Veggies;

public class BlackOlives : IVeggies
{
    public BlackOlives()
    {
        Name = "Black Olives";
    }

    public string Name { get; }
}