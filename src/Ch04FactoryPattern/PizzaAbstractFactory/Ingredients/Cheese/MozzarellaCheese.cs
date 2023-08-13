using System;

namespace PizzaAbstractFactory.Ingredients.Cheese;

public class MozzarellaCheese : ICheese
{
    public MozzarellaCheese()
    {
        Name = "Shredded Mozzarella";
    }

    public string Name { get; }
}
