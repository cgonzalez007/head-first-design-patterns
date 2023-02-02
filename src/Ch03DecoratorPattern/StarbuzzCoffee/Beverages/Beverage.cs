namespace StarbuzzCoffee.Beverages;

public abstract class Beverage
{
    private const string DefaultDescription = "Unknown Beverage";

    public virtual BeverageSize Size { get; set; } = BeverageSize.Tall;

    public virtual string Description => DefaultDescription;

    public abstract decimal Cost { get; }
}