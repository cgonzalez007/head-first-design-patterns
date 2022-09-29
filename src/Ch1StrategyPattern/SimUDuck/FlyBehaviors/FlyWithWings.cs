namespace SimUDuck.FlyBehaviors;

public sealed class FlyWithWings : IFlyBehavior
{
    public void Fly()
        => Console.WriteLine("I'm flying!!");
}
