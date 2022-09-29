using SimUDuck.FlyBehaviors;
using SimUDuck.QuackBehaviors;

namespace SimUDuck.Ducks;

public sealed class ModelDuck : Duck
{
    public ModelDuck()
    {
        FlyBehavior = new FlyNoWay();
        QuackBehavior = new NormalQuack();
    }

    public override void Display()
        => Console.WriteLine("I'm a model duck");
}
