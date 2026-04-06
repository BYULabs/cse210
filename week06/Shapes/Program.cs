using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Square aSquare = new Square("blue", 5);
        Rectangle aRectangle = new Rectangle("red", 5, 4);
        Circle aCircle = new Circle("pink", 5);

        List<Shape> shapes = new List<Shape> ();
        shapes.Add(aSquare);
        shapes.Add(aRectangle);
        shapes.Add(aCircle);

        foreach (Shape sh in shapes)
        {
            string color = sh.GetColor();
            double area = sh.GetArea();
            Console.WriteLine($"The shape with {color} has an area of {area}");

        }

    }
}