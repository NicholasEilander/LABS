using System;

public class Strings
{
    protected string value;

    // Конструктор
    public Strings(string str)
    {
        value = str;
    }

    // Віртуальна функція довжини
    public virtual int GetLength()
    {
        return value.Length;
    }

    // Віртуальна функція підрахунку символів
    public virtual int CountSymbol()
    {
        return 0;
    }

    // Метод отримання рядка
    public virtual string GetString()
    {
        return value;
    }
}