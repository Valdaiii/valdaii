using System;

public class Point {
  public double x { get; set; }
  public double y { get; set; }
  public string name { get; set; }

  public Point(double x, double y, string name) {
    this.x = x;
    this.y = y;
    this.name = name;
  }

  public override string ToString() {
    return $"{name} ({x}, {y})";
  }
}

public abstract class Figure {
  protected Point[] points;

  public Figure(Point[] points) {
    this.points = points;
  }

  public abstract double GetSideLength(Point A, Point B);
  public abstract void CalculatePerimeter();
}

class Program {
  static void Main(string[] args) {
    Point[] points = new Point[] {
      new Point(1, 2, "A"),
      new Point(3, 4, "B"),
      new Point(5, 6, "C"),
      new Point(7, 8, "D"),
      new Point(9, 10, "E"),
    };

    Figure figure = new Triangle(points);

    Console.WriteLine("Назва багатокутника: {0}", figure.GetType().Name);
    Console.WriteLine("Периметр багатокутника: {0}", figure.CalculatePerimeter());

    Console.ReadKey();
  }
}
