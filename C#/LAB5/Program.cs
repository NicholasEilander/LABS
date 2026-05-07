using System;

class Program
{
    static void Main()
    {
        // Масив базового типу
        Strings[] objects =
        {
            new Symbols("ab*c**de"),
            new CapitalLetters("GIGA CHEDDER")
        };

        // Поліморфізм
        foreach (Strings obj in objects)
        {
            Console.WriteLine(obj.GetString());

            Console.WriteLine("Length: " + obj.GetLength());

            Console.WriteLine("Count: " + obj.CountSymbol());

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}