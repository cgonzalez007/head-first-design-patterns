using PizzaAbstractFactory.Ingredients.Cheese;
using PizzaAbstractFactory.Ingredients.Clams;
using PizzaAbstractFactory.Ingredients.Dough;
using PizzaAbstractFactory.Ingredients.Pepperoni;
using PizzaAbstractFactory.Ingredients.Sauce;
using PizzaAbstractFactory.Ingredients.Veggies;

namespace PizzaAbstractFactory.Factories;

public class NyPizzaIngredientFactory : IPizzaIngredientFactory
{
    public IDough CreateDough()
        => new ThinCrustDough();

    public ISauce CreateSauce()
        => new MarinaraSauce();

    public ICheese CreateCheese()
        => new ReggianoCheese();

    public IVeggies[] CreateVeggies()
        => new IVeggies[] { new Garlic(), new Onions(), new Mushrooms(), new RedPepper() };

    public IPepperoni CreatePepperoni()
        => new SlicedPepperoni();

    public IClams CreateClams()
        => new FreshClams();
}