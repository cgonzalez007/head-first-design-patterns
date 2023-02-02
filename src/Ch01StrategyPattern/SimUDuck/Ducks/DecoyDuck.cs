using System;
using SimUDuck.FlyBehaviors;
using SimUDuck.QuackBehaviors;

namespace SimUDuck.Ducks;

public sealed class DecoyDuck : Duck
{
    public DecoyDuck()
    {
        FlyBehavior = new FlyNoWay();
        QuackBehavior = new MuteQuack();
    }

    public override void Display()
        => Console.WriteLine("I look like a decoy duck");
}
