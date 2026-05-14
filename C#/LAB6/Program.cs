using System;

class Program
{
    static void Main()
    {
        // Створення контейнера
        TextContainer text = new TextContainer();

        // Додавання рядків
        text.AddLine(new TextLine("Hello world"));
        text.AddLine(new TextLine("C# programming"));
        text.AddLine(new TextLine("World of OOP"));

        Console.WriteLine("Original text:");
        text.ShowText();

        Console.WriteLine();

        // Кількість символів
        Console.WriteLine("Total characters: "
                          + text.GetTotalCharacters());

        // Пошук рядків
        Console.WriteLine("Lines with 'world': "
                          + text.FindLines("world"));

        Console.WriteLine();

        // Заміна символів
        text.Replace('o', '*');

        Console.WriteLine("After replace:");
        text.ShowText();

        Console.ReadLine();
    }
}