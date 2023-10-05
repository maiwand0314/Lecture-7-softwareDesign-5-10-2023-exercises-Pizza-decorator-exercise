namespace Lecture_7_softwareDesign_5_10_2023_exercises_Pizza_decorator_exercise
{

    public abstract class Pizza
    {
        protected double _price;
        protected string _description = "";
        
        public Pizza(double price =  0, string description = "")
        {
            _price = price;
            _description = description;
        }
        public string Name { get; set; } = "";
        public abstract double GetPrice();
        public abstract string GetDescription();
    }
}