using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Pizzas;

public abstract class Pizza
{
    public abstract string Name { get; }

    public abstract string Dough { get; }

    public abstract string Sauce { get; }

    public virtual List<string> Toppings { get; } = new List<string>();

    public virtual void Prepare()
        => Console.WriteLine($"Preparing {Name}");

    public virtual void Bake()
        => Console.WriteLine($"Baking {Name}...");

    public virtual void Cut()
        => Console.WriteLine($"Cutting {Name}...");

    public virtual void Box()
        => Console.WriteLine($"Boxing {Name}...");

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
