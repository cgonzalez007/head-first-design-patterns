//Chapter 1 - Strategy Pattern - SimUDuck

using SimUDuck.Ducks;
using SimUDuck.FlyBehaviors;
using SimUDuck.QuackBehaviors;

Duck mallard = new MallardDuck();

mallard.Display();
mallard.PerformQuack();
mallard.PerformFly();

mallard.FlyBehavior = new FlyRockedPowered();

mallard.PerformFly();

Duck model = new ModelDuck();

model.Display();
model.PerformQuack();
model.PerformFly();

model.FlyBehavior = new FlyRockedPowered();

mallard.PerformFly();