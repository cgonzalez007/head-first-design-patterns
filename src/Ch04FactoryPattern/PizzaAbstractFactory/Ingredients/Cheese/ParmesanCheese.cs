using System;

namespace PizzaAbstractFactory.Ingredients.Cheese;

public class ParmesanCheese : ICheese
{
    public ParmesanCheese()
    {
        Name = "Shredded Parmesan";
    }

    public string Name { get; }
}
