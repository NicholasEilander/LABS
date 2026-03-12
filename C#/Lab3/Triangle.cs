using System;

namespace ConsoleApp4;

public class Triangle
{
    private double x1, y1, x2, y2, x3, y3;

    public Triangle()
    {
        x1 = 0; y1 = 0;
        x2 = 1; y2 = 0;
        x3 = 0; y3 = 1;
    }

    public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
        this.x3 = x3;
        this.y3 = y3;
    }

    public Triangle(Triangle other)
    {
        x1 = other.x1;
        y1 = other.y1;
        x2 = other.x2;
        y2 = other.y2;
        x3 = other.x3;
        y3 = other.y3;
    }

    private double Distance(double ax, double ay, double bx, double by)
    {
        return Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
    }

    public double GetPerimeter()
    {
        double ab = Distance(x1, y1, x2, y2);
        double bc = Distance(x2, y2, x3, y3);
        double ca = Distance(x3, y3, x1, y1);

        return ab + bc + ca;
    }

    public double GetArea()
    {
        return Math.Abs(
            x1 * (y2 - y3) +
            x2 * (y3 - y1) +
            x3 * (y1 - y2)
        ) / 2.0;
    }

    public string GetInfo()
    {
        return $"A({x1}, {y1}), B({x2}, {y2}), C({x3}, {y3})";
    }

    public static Triangle operator +(Triangle a, Triangle b)
    {
        return new Triangle(
            a.x1 + b.x1, a.y1 + b.y1,
            a.x2 + b.x2, a.y2 + b.y2,
            a.x3 + b.x3, a.y3 + b.y3
        );
    }

    public static Triangle operator *(Triangle t, double factor)
    {
        return new Triangle(
            t.x1 * factor, t.y1 * factor,
            t.x2 * factor, t.y2 * factor,
            t.x3 * factor, t.y3 * factor
        );
    }
}