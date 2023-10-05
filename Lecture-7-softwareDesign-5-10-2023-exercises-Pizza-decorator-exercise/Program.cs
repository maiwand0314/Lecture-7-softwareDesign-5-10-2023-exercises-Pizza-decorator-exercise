// See https://aka.ms/new-console-template for more information

using Lecture_7_softwareDesign_5_10_2023_exercises_Pizza_decorator_exercise;
public class Program
{
    public static void Main()
    {

        Pizza ham = new HamPizza(180);

        PrintCarInformation(ham);

    }

    private static void PrintCarInformation(Pizza pizza)
    {
        Console.WriteLine($"Type Pizza: {pizza.Name}");
        Console.WriteLine($"Pizzaen koster: {pizza.GetPrice()}");
        Console.WriteLine($"Toppinger: {pizza.GetDescription()}");

    }
    
}
