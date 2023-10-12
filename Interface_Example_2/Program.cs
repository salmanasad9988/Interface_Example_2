    using System;

    // Define the IShape interface
    public interface IShape
    {
        double CalculateArea();
        double CalculatePerimeter();
    }

    // Create a Circle class that implements the IShape interface
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    // Create a Rectangle class that implements the IShape interface
    public class Rectangle : IShape
    {
        public double Length { get; }
        public double Width { get; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double CalculateArea()
        {
            return Length * Width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }

    // Create a Triangle class that implements the IShape interface
    public class Triangle : IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            // Implement area calculation using Heron's formula
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of different shapes
            IShape circle = new Circle(5);
            IShape rectangle = new Rectangle(4, 6);
            IShape triangle = new Triangle(3, 4, 5);

            // Calculate and display the area and perimeter of each shape
            Console.WriteLine("Circle - Area: " + circle.CalculateArea() + " Perimeter: " + circle.CalculatePerimeter());
            Console.WriteLine("Rectangle - Area: " + rectangle.CalculateArea() + " Perimeter: " + rectangle.CalculatePerimeter());
            Console.WriteLine("Triangle - Area: " + triangle.CalculateArea() + " Perimeter: " + triangle.CalculatePerimeter());
        }
    }
