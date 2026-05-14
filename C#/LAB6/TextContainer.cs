using System;
using System.Collections.Generic;

public class TextContainer : IReplaceable
{
    private List<TextLine> lines;

    // Конструктор
    public TextContainer()
    {
        lines = new List<TextLine>();
    }

    // Додавання рядка
    public void AddLine(TextLine line)
    {
        lines.Add(line);
    }

    // Видалення рядка
    public void RemoveLine(int index)
    {
        if (index >= 0 && index < lines.Count)
        {
            lines.RemoveAt(index);
        }
    }

    // Очищення тексту
    public void Clear()
    {
        lines.Clear();
    }

    // Загальна кількість символів
    public int GetTotalCharacters()
    {
        int total = 0;

        foreach (TextLine line in lines)
        {
            total += line.GetLength();
        }

        return total;
    }

    // Пошук рядків
    public int FindLines(string text)
    {
        int count = 0;

        foreach (TextLine line in lines)
        {
            if (line.Contains(text))
            {
                count++;
            }
        }

        return count;
    }

    // Заміна символів
    public void Replace(char oldChar, char newChar)
    {
        foreach (TextLine line in lines)
        {
            line.Replace(oldChar, newChar);
        }
    }

    // Вивід тексту
    public void ShowText()
    {
        foreach (TextLine line in lines)
        {
            Console.WriteLine(line.Value);
        }
    }
}