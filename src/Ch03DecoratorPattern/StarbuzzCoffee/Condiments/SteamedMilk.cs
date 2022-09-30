using System;
using StarbuzzCoffee.Beverages;

namespace StarbuzzCoffee.Condiments;

public class SteamedMilk : CondimentDecorator
{
    private const string CondimentDescription = "Steamed Milk";
    private const decimal CondimentCost = 0.10M;

    private readonly Beverage _beverage;

    public SteamedMilk(Beverage beverage)
        : base(beverage)
        => _beverage = beverage ?? throw new ArgumentNullException(nameof(beverage));

    public override string Description
        => $"{_beverage.Description}, {CondimentDescription}";

    public override decimal Cost
        => _beverage.Cost + CondimentCost;
}
