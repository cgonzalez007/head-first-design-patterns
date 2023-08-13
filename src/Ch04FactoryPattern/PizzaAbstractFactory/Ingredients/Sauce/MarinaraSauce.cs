using System;

namespace PizzaAbstractFactory.Ingredients.Sauce;

public class MarinaraSauce : ISauce
{
    public MarinaraSauce()
    {
        Name = "Marinara Sauce";
    }

    public string Name { get; }
}
