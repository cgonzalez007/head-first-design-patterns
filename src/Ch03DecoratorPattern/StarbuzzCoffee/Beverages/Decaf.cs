using System;

namespace StarbuzzCoffee.Beverages;

public class Decaf : Beverage
{
    private const string BeverageDescription = "Decaf Coffee";
    private const decimal BeverageCost = 1.05M;

    public override string Description => BeverageDescription;

    public override decimal Cost => BeverageCost;
}
