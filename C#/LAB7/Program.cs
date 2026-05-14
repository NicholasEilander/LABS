using System;

class Program
{
    static void Main()
    {
        try
        {
            // Масив об’єктів
            ExpressionCalculator[] objects =
            {
                new ExpressionCalculator(2, 4, 3, 1),

                new ExpressionCalculator(5, 2, 1, 40),

                new ExpressionCalculator(10, 10, -100, 5)
            };

            // Обчислення для кожного об’єкта
            foreach (ExpressionCalculator obj in objects)
            {
                try
                {
                    Console.WriteLine(
                        $"a={obj.A}, b={obj.B}, c={obj.C}, d={obj.D}"
                    );

                    double result = obj.Calculate();

                    Console.WriteLine(
                        "Result: " + result
                    );
                }
                catch (Exception ex)
                {
                    Console.WriteLine(
                        "Error: " + ex.Message
                    );
                }

                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(
                "Global error: " + ex.Message
            );
        }

        Console.ReadLine();
    }
}