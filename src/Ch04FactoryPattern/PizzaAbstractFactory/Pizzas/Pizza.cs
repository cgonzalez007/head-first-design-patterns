using PizzaAbstractFactory.Ingredients.Cheese;
using PizzaAbstractFactory.Ingredients.Clams;
using PizzaAbstractFactory.Ingredients.Dough;
using PizzaAbstractFactory.Ingredients.Pepperoni;
using PizzaAbstractFactory.Ingredients.Sauce;
using PizzaAbstractFactory.Ingredients.Veggies;
using System.Text;

namespace PizzaAbstractFactory.Pizzas;

public abstract class Pizza
{
    public IDough? Dough { get; protected set; }

    public ISauce? Sauce { get; protected set; }

    public IVeggies[]? Veggies { get; protected set; }

    public ICheese? Cheese { get; protected set; }

    public IPepperoni? Pepperoni { get; protected set; }

    public IClams? Clams { get; protected set; }

    public string? Name { get; set; }

    public abstract void Prepare();

    //TODO: abstract baking
    public virtual void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }

    //TODO: abstract cutting technique
    public virtual void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    public virtual void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }

    public override string ToString()
    {
        StringBuilder result = new();

        result.AppendLine("---- " + Name + " ----");

        if (Dough is not null)
            result.AppendLine(Dough.Name);

        if (Sauce is not null)
            result.AppendLine(Sauce.Name);

        if (Cheese is not null)
            result.AppendLine(Cheese.Name);

        if (Veggies is not null)
            result.AppendLine(string.Join(", ", Veggies.Select(v => v.Name)));

        if (Clams is not null)
            result.AppendLine(Clams.Name);

        if (Pepperoni is not null)
            result.AppendLine(Pepperoni.Name);

        return result.ToString();
    }
}
