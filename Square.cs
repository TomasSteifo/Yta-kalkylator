using Yta_kalkylator;

namespace Yta_kalkylator
{
    public class Square : Shape 
    { 
        public double Side { get; set; }

        public Square(double side) 
        { 
            Side = side;
        }

        // Here I override the abstract method to calculate the area of a square
        public override double CalculateArea()
        {
           return Side * Side;
        }
    }
}

