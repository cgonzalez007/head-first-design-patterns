using System;

namespace PizzaAbstractFactory.Ingredients.Sauce;

public class PlumTomatoSauce : ISauce
{
    public PlumTomatoSauce()
    {
        Name = "Tomato Sauce With Plum Tomatoes";
    }

    public string Name { get; }
}
