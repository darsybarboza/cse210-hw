using System;


public class Rectangle
{
    //añadir dos campos
    public double _basis;
    public double _height;

    public double Area()
    {
        double area = this._basis  * this._height;
        return area;
    }
}