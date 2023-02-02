using System;
using StarbuzzCoffee.Beverages;

namespace StarbuzzCoffee;

public abstract class CondimentDecorator : Beverage
{
    private readonly Beverage _beverage;

    protected CondimentDecorator(Beverage beverage)
        => _beverage = beverage ?? throw new ArgumentNullException(nameof(beverage));

    public override BeverageSize Size
    {
        get => _beverage.Size;
        set => _beverage.Size = value;
    }

    public abstract override string Description { get; }
}

