using System;

namespace StarbuzzCoffee.Beverages;

public class DarkRoast : Beverage
{
    private const string BeverageDescription = "Dark Roast Coffee";
    private const decimal BeverageCost = 0.99M;

    public override string Description => BeverageDescription;

    public override decimal Cost => BeverageCost;
}
