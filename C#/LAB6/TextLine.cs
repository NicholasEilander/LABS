using System;

public class TextLine : IReplaceable
{
    private string value;

    // Конструктор
    public TextLine(string text)
    {
        value = text;
    }

    // Властивість тільки для читання
    public string Value
    {
        get { return value; }
    }

    // Кількість символів
    public int GetLength()
    {
        return value.Length;
    }

    // Пошук підрядка
    public bool Contains(string text)
    {
        return value.Contains(text);
    }

    // Заміна символів
    public void Replace(char oldChar, char newChar)
    {
        value = value.Replace(oldChar, newChar);
    }
}