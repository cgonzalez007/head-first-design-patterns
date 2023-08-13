using System;

namespace PizzaAbstractFactory.Ingredients.Dough;
public class ThickCrustDough : IDough
{
    public ThickCrustDough()
    {
        Name = "Thick Crust Style Extra Thick Crust Dough";
    }

    public string Name { get; }
}
