namespace Lecture_7_softwareDesign_5_10_2023_exercises_Pizza_decorator_exercise;

abstract class ToppingDecorator : Pizza
{
    private readonly Pizza _original;

    protected ToppingDecorator(Pizza original)
    {
        _original = original;
    }

    public override string GetDescription()
    {
        return _original.GetDescription();
    }

    public override double GetPrice()
    {
        return _original.GetPrice();
    }
    
}