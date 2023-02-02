using System;

namespace StarbuzzCoffee.Beverages;

public class HouseBlend : Beverage
{
    private const string BeverageDescription = "House Blend Coffee";
    private const decimal BeverageCost = 0.89M;

    public override string Description => BeverageDescription;

    public override decimal Cost => BeverageCost;
}
