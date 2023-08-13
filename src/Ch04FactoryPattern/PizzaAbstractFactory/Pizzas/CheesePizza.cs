

using PizzaAbstractFactory.Factories;

namespace PizzaAbstractFactory.Pizzas;

public class CheesePizza : Pizza
{
    private readonly  IPizzaIngredientFactory _ingredientFactory;
    
    public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
    {
        _ingredientFactory = pizzaIngredientFactory;
    }
    
    public override void Prepare()
    {
        Console.WriteLine("Preparing " + Name);
        
        Dough = _ingredientFactory.CreateDough();
        Sauce = _ingredientFactory.CreateSauce();
        Cheese = _ingredientFactory.CreateCheese();
    }
}