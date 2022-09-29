// Chapter 1 - Strategy Pattern - SimUDuck
// Pg 24: The strategy pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable.
// Strategy lets the algorithm vary independently from clients that use it.

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

