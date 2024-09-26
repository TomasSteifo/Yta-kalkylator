using Yta_kalkylator;

namespace Yta_kalkylator
{
    public class Rectangle : Shape 
    { 
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Here I Override the abstract method to calculate the area of a rectangle

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}

