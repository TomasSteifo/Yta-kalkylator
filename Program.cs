using Yta_kalkylator;

namespace Yta_kalkylator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here i have a display menu for shape selection
            Console.WriteLine("Choose a shape to calcualte area");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Square");

            string choice = Console.ReadLine();
            Shape shape = null; // Here i have a shape variable to store any kind of shape object

            // Here i give the options depending on user's choice, create the appropriate shape
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Whats the radius for the circle");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    shape = new Circle(radius);
                    break;

                case "2":
                    Console.WriteLine("Whats the width of the rectangle");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Whats the height of the rectangle");
                    double height = Convert.ToDouble(Console.ReadLine());
                    shape = new Rectangle(width, height);
                    break;

                case "3":
                    Console.WriteLine("Whats the lenght of the square");
                    double side = Convert.ToDouble(Console.ReadLine());
                    shape = new Square(side);
                    break;

                default:
                    Console.WriteLine("Not chooseable.");
                    return; // Exit the program if invalid input
        }

                    // Calculate and display the area using polymorphism
            if (shape != null)
            {
                        double area = shape.CalculateArea();
                        Console.WriteLine($"Arean är: {area}");
            }
        }
    }
}



