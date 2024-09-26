using Yta_kalkylator;

namespace Yta_kalkylator
{
    public class Circle : Shape
    { 
        public double Radius { get; set; }
        
        public Circle(double radius) 
        { 
            Radius = radius;
        }

        // Here i Override the abstract method to calculate the area of a circle

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}


