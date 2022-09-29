using SimUDuck.FlyBehaviors;
using SimUDuck.QuackBehaviors;

namespace SimUDuck.Ducks;

public sealed class RubberDuck : Duck
{
    public RubberDuck()
    {
        FlyBehavior = new FlyNoWay();
        QuackBehavior = new Squeak();
    }

    public override void Display()
        => Console.WriteLine("I look like a rubber duck");
}
