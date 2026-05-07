using System;

public class Symbols : Strings
{
    // Конструктор
    public Symbols(string str) : base(str)
    {
    }

    // Перевизначення довжини
    public override int GetLength()
    {
        return value.Length;
    }

    // Підрахунок символу *
    public override int CountSymbol()
    {
        int count = 0;

        foreach (char c in value)
        {
            if (c == '*')
            {
                count++;
            }
        }

        return count;
    }

    // Оброблений рядок
    public override string GetString()
    {
        return $"Symbols class: {value}";
    }
}