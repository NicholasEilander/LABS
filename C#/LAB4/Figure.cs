using System;

public class Square : Figure
{
    // Конструктор з параметрами
    public Square(double x1, double y1, double x2, double y2)
        : base(x1, y1, x2, y2)
    {
    }

    // Площа
    public double GetArea()
    {
        double side = GetSideLength();
        return side * side;
    }

    // Периметр
    public double GetPerimeter()
    {
        double side = GetSideLength();
        return 4 * side;
    }

    // Метод отримання даних
    public string GetInfo()
    {
        return $"A({x1}, {y1}), B({x2}, {y2})";
    }
}