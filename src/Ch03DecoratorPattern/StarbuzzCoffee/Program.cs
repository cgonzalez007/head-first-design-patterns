// Chapter 3 - Decorator Pattern - Starbuzz Coffee
// Pg 93: The decorator pattern attaches additional responsibility to an object dynamically.
// Decorators provide a flexible alternative to subclassing for extending functionality.

using StarbuzzCoffee.Beverages;
using StarbuzzCoffee.Condiments;

Beverage beverage = new Espresso();

Console.WriteLine($"{beverage.Description} ${beverage.Cost} {beverage.Size}");

Beverage beverage2 = new DarkRoast();

beverage2 = new Mocha(beverage2);
beverage2 = new Mocha(beverage2);
beverage2 = new Whip(beverage2);

Console.WriteLine($"{beverage2.Description} ${beverage2.Cost} {beverage2.Size}");

Beverage beverage3 = new HouseBlend();

beverage3 = new Soy(beverage3);
beverage3 = new Mocha(beverage3);
beverage3 = new Whip(beverage3);

Console.WriteLine($"{beverage3.Description} ${beverage3.Cost} {beverage3.Size}");

//Change to Venti
beverage3.Size = BeverageSize.Venti;

Console.WriteLine($"{beverage3.Description} ${beverage3.Cost} {beverage3.Size}");

