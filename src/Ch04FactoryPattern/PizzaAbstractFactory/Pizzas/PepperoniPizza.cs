using PizzaAbstractFactory.Factories;

namespace PizzaAbstractFactory.Pizzas;

public class PepperoniPizza : Pizza
{
    private readonly IPizzaIngredientFactory _ingredientFactory;

    public PepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory)
    {
        _ingredientFactory = pizzaIngredientFactory;
    }

    public override void Prepare()
    {
        Console.WriteLine("Preparing " + Name);

        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
        Veggies = _ingredientFactory.CreateVeggies();
        Pepperoni = _ingredientFactory.CreatePepperoni();
    }
}