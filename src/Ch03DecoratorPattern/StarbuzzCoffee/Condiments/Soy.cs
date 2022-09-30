using System;
using StarbuzzCoffee.Beverages;

namespace StarbuzzCoffee.Condiments;

public class Soy : CondimentDecorator
{
    private const string CondimentDescription = "Soy";
    private const decimal CondimentCostTall = 0.10M;
    private const decimal CondimentCostGrande = 0.15M;
    private const decimal CondimentCostVenti = 0.20M;

    private readonly Beverage _beverage;

    public Soy(Beverage beverage)
        : base(beverage)
        => _beverage = beverage ?? throw new ArgumentNullException(nameof(beverage));

    public override string Description
        => $"{_beverage.Description}, {CondimentDescription}";

    public override decimal Cost
    {
        get
        {
            switch (Size)
            {
                case BeverageSize.Tall:
                    return _beverage.Cost + CondimentCostTall;
                case BeverageSize.Grande:
                    return _beverage.Cost + CondimentCostGrande;
                case BeverageSize.Venti:
                    return _beverage.Cost + CondimentCostVenti;
                default:
                    return _beverage.Cost;
            }
        }
    }
}
