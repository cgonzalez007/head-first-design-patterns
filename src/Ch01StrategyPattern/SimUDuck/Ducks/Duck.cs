using System;
using SimUDuck.FlyBehaviors;
using SimUDuck.QuackBehaviors;

namespace SimUDuck.Ducks;

public abstract class Duck : IDuck
{
    protected Duck() { }

    public virtual IFlyBehavior? FlyBehavior { get; set; }

    public virtual IQuackBehavior? QuackBehavior { get; set; }

    public abstract void Display();

    public virtual void PerformFly()
        => FlyBehavior?.Fly();

    public virtual void PerformQuack()
        => QuackBehavior?.Quack();

    public virtual void Swim()
        => Console.WriteLine("All ducks float, even decoys!");
}
