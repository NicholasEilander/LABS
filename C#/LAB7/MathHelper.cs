using System;

public class MathHelper
{
    // Метод обчислення кореня
    public static double CalculateSqrt(double value)
    {
        // Перевірка на від’ємне число
        if (value < 0)
        {
            throw new ArgumentException(
                "Negative value under square root!"
            );
        }

        return Math.Sqrt(value);
    }
}