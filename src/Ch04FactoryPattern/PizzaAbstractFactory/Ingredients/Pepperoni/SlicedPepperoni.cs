using System;

namespace PizzaAbstractFactory.Ingredients.Pepperoni;

public class SlicedPepperoni : IPepperoni
{
    public SlicedPepperoni()
    {
        Name = "Sliced Pepperoni";
    }

    public string Name { get; }
}
