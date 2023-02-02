namespace StarbuzzCoffee.Beverages;

public class Espresso : Beverage
{
    private const string BeverageDescription = "Espresso";
    private const decimal BeverageCost = 1.99M;

    public override string Description => BeverageDescription;

    public override decimal Cost => BeverageCost;
}