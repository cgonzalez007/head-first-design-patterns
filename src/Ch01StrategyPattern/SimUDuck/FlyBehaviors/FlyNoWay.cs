namespace SimUDuck.FlyBehaviors;

public sealed class FlyNoWay : IFlyBehavior
{
    public void Fly()
        => Console.WriteLine("I can't fly");
}
