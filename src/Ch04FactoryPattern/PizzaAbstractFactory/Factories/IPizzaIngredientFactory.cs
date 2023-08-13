using PizzaAbstractFactory.Ingredients.Cheese;
using PizzaAbstractFactory.Ingredients.Dough;
using PizzaAbstractFactory.Ingredients.Sauce;
using PizzaAbstractFactory.Ingredients.Veggies;
using PizzaAbstractFactory.Ingredients.Pepperoni;
using PizzaAbstractFactory.Ingredients.Clams;

namespace PizzaAbstractFactory.Factories;

public interface IPizzaIngredientFactory
{
    IDough CreateDough();

    ISauce CreateSauce();

    ICheese CreateCheese();

    IVeggies[] CreateVeggies();

    IPepperoni CreatePepperoni();

    IClams CreateClams();
}