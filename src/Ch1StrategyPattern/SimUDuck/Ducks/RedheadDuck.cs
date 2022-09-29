using SimUDuck.FlyBehaviors;
using SimUDuck.QuackBehaviors;

namespace SimUDuck.Ducks;

public sealed class RedheadDuck : Duck
{
    public RedheadDuck()
    {
        FlyBehavior = new FlyWithWings();
        QuackBehavior = new NormalQuack();
    }

    public override void Display()
        => Console.WriteLine("I look like a redhead");
}
