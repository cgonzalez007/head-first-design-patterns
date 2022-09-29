namespace SimUDuck.QuackBehaviors;

public sealed class NormalQuack : IQuackBehavior
{
    public void Quack()
        => Console.WriteLine("Quack");
}
