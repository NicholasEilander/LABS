using System;

public class CapitalLetters : Strings
{
    // Конструктор
    public CapitalLetters(string str) : base(str)
    {
    }

    // Перевизначення довжини
    public override int GetLength()
    {
        return value.Length;
    }

    // Підрахунок символу B
    public override int CountSymbol()
    {
        int count = 0;

        foreach (char c in value)
        {
            if (c == 'B')
            {
                count++;
            }
        }

        return count;
    }

    // Оброблений рядок
    public override string GetString()
    {
        return $"CapitalLetters class: {value.ToUpper()}";
    }
}