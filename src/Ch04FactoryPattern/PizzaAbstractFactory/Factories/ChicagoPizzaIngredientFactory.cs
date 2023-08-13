using PizzaAbstractFactory.Ingredients.Cheese;
using PizzaAbstractFactory.Ingredients.Clams;
using PizzaAbstractFactory.Ingredients.Dough;
using PizzaAbstractFactory.Ingredients.Pepperoni;
using PizzaAbstractFactory.Ingredients.Sauce;
using PizzaAbstractFactory.Ingredients.Veggies;

namespace PizzaAbstractFactory.Factories;

public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
{
    public IDough CreateDough()
        => new ThickCrustDough();

    public ISauce CreateSauce()
        => new PlumTomatoSauce();

    public ICheese CreateCheese()
        => new MozzarellaCheese();

    public IVeggies[] CreateVeggies()
        => new IVeggies[] { new BlackOlives(), new Spinach(), new Eggplant() };

    public IPepperoni CreatePepperoni()
        => new SlicedPepperoni();

    public IClams CreateClams()
        => new FrozenClams();
}