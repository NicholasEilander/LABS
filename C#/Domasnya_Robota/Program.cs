using System;

class Program
{
    static void Main()
    {
        char[,] data =
        {
            { 'A', '1', 'B' },
            { '2', 'C', '3' },
            { 'D', 'E', '4' }
        };
        
        CharMatrix obj = new CharMatrix(data);
        Console.WriteLine("Матриця:");
        obj.ShowMatrix();

        Console.WriteLine();
        Console.WriteLine("Стовбчик 0: " + obj[0]);
        Console.WriteLine("Стовбчик 1: " + obj[1]);
        Console.WriteLine("Ствобчик 2: " + obj[2]);

        Console.WriteLine();
        Console.WriteLine(
            "Рахунок чисел: " + obj.DigitCount
        );

        Console.ReadLine();
    }
}