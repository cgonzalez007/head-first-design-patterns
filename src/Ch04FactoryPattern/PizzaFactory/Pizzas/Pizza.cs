using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory.Pizzas;

public abstract class Pizza
{
    public abstract string Name { get; }

    public abstract string Dough { get; }

    public abstract string Sauce { get; }

    public virtual List<string> Toppings { get; } = new List<string>();

    public virtual void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
        Console.WriteLine("Tossing dough...");
        Console.WriteLine("Adding Sauce...");
        Console.WriteLine($"Adding Toppings: {string.Join(", ", Toppings)}");
    }

    public virtual void Bake()
        => Console.WriteLine($"Bake for 25 minutes at 350...");

    public virtual void Cut()
        => Console.WriteLine($"Cutting the pizza into diagnol slices...");

    public virtual void Box()
        => Console.WriteLine($"Place pizza in official PizzaStore box...");

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine("---- " + Name + " ----");
        builder.AppendLine(Dough);
        builder.AppendLine(Sauce);

        foreach (var topping in Toppings)
            builder.AppendLine(topping);

        return builder.ToString();
    }
}
