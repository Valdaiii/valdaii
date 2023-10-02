using System;

public class Rectangle
{
    public double side1 { get; set; }
    public double side2 { get; set; }

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public double CalculateArea()
    {
        return side1 * side2;
    }

    public double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }

    public double Area
    {
        get
        {
            return CalculateArea();
        }
    }

    public double Perimeter
    {
        get
        {
            return CalculatePerimeter();
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        double side1, side2;

        Console.WriteLine("Введіть довжину першої сторони: ");
        Console.ReadLine();
        side1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть довжину другої сторони: ");
        Console.ReadLine();
        side2 = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(side1, side2);

        Console.WriteLine("Площа прямокутника: {0}", rectangle.Area);
        Console.WriteLine("Периметр прямокутника: {0}", rectangle.Perimeter);

        Console.ReadKey();
    }
}
