namespace SimUDuck.QuackBehaviors;

public sealed class MuteQuack : IQuackBehavior
{
    public void Quack()
        => Console.WriteLine("<< Silence >>");
}
