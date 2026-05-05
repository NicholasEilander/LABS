using System;

public class Figure
{
    protected double x1, y1, x2, y2;

    // Конструктор з параметрами
    public Figure(double x1, double y1, double x2, double y2)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    // Метод обчислення довжини сторони
    public double GetSideLength()
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}