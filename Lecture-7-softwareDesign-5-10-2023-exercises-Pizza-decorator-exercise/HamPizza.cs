namespace Lecture_7_softwareDesign_5_10_2023_exercises_Pizza_decorator_exercise;

public class HamPizza : Pizza
{
    public HamPizza(double price)
    {
        Name = "Ham Pizza";
        _description = "Tomato sauce, mozzarella, oregano, ham";
        _price = price;
    }

// This method returns the price of the pizza object with all toppings.
    public override double GetPrice()
    {
        return _price;
    }

// This method returns the description of the pizza object with all toppings.
    public override string GetDescription()
    {
        return _description;
    }
}
