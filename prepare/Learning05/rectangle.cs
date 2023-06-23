using System;


public class Rectangle : Shape
{
    //añadir dos campos
    public double _length;
    public double _width;

    public Rectangle(string color , double length , double width) : base (color)

    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}