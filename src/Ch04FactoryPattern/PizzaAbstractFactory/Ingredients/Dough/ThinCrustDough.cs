using System;

namespace PizzaAbstractFactory.Ingredients.Dough;
public class ThinCrustDough : IDough
{
    public ThinCrustDough()
    {
        Name = "Thin Crust Dough";
    }

    public string Name { get; }
}
