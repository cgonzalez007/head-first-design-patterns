using System;
using StarbuzzCoffee.Beverages;

namespace StarbuzzCoffee.Condiments;

public class Mocha : CondimentDecorator
{
    private const string CondimentDescription = "Mocha";
    private const decimal CondimentCost = 0.20M;

    private readonly Beverage _beverage;

    public Mocha(Beverage beverage)
        : base(beverage)
        => _beverage = beverage ?? throw new ArgumentNullException(nameof(beverage));

    public override string Description
        => $"{_beverage.Description}, {CondimentDescription}";

    public override decimal Cost
        => _beverage.Cost + CondimentCost;
}
