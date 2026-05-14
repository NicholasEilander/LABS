using System;

public class ExpressionCalculator
{
    // Поля
    private double a;
    private double b;
    private double c;
    private double d;

    // Конструктор
    public ExpressionCalculator(
        double a,
        double b,
        double c,
        double d)
    {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
    }

    // Властивості тільки для читання
    public double A => a;
    public double B => b;
    public double C => c;
    public double D => d;

    // Метод обчислення виразу
    public double Calculate()
    {
        try
        {
            // Чисельник
            double numerator = a * b / 4 - 1;

            // Вираз під коренем
            double rootExpression =
                41 - d - b * a + c;

            // Виклик окремого класу
            double denominator =
                MathHelper.CalculateSqrt(rootExpression);

            // Перевірка ділення на нуль
            if (denominator == 0)
            {
                throw new DivideByZeroException(
                    "Denominator equals zero!"
                );
            }

            return numerator / denominator;
        }
        catch (Exception)
        {
            throw;
        }
    }
}