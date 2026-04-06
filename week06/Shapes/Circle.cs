using System;

public class Circle : Shape
{
    private double _radius = 0;

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return 3.14 * _radius * _radius;
    }
}