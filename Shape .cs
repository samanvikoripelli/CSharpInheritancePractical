using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Shape
{
    public virtual double CalculateArea()
    {
        return 0;
    }
}
class Rectangle : Shape
{
    private double width, height;
    public Rectangle(double w, double h)
    {
        width = w;
        height = h;
    }
    public override double CalculateArea()
    {
        return width * height;
    }
}
class Circle : Shape
{
    private double radius;
    public Circle(double r)
    {
        radius = r;
    }
    public override double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}