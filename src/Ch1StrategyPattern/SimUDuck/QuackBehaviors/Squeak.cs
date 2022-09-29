namespace SimUDuck.QuackBehaviors;

public sealed class Squeak : IQuackBehavior
{
    public void Quack()
        => Console.WriteLine("Squeak");
}
