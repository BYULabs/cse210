using System;

public class Rectangle : Shape
{
    private double _length = 0;
    private double _width = 0;

    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    public void SetLength(double length)
    {
        _length = length;
    }

        public void SetWidth(double width)
    {
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}