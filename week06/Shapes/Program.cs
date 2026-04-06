using System;

class Program
{
    static void Main(string[] args)
    {
        Square aSquare = new Square();
        aSquare.SetSide(5);

        Rectangle aRectangle = new Rectangle();
        aRectangle.SetLength(5);
        aRectangle.SetWidth(4);

        Circle aCircle = new Circle();
        aCircle.SetRadius(5);

        DisplayShapeArea(aSquare);
        DisplayShapeArea(aRectangle);
        DisplayShapeArea(aCircle);

        List<Shape> shapes = new List<Shape> ();
        shapes.Add(aSquare);
        shapes.Add(aRectangle);
        shapes.Add(aCircle);

        foreach (Shape sh in shapes)
        {
            double area = sh.GetArea();
            Console.WriteLine(area);

        }

    }

    public static void DisplayShapeArea(Shape shape)
    {
        double area = shape.GetArea();
        Console.WriteLine($"{area}");
    }
}