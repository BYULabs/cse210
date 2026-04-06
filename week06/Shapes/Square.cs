using System;

public class Square : Shape
{
    private double _side = 0;

    public void SetSide(double side)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}