namespace SimUDuck.FlyBehaviors;

public sealed class FlyRockedPowered : IFlyBehavior
{
    public void Fly()
        => Console.WriteLine("I'm flying with a rocket!");
}
