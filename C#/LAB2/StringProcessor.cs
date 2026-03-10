using System;
using System.Linq;

namespace ConsoleApp4;

public class StringProcessor
{
    private string value;

    public StringProcessor()              
    {
        value = "";
    }

    public StringProcessor(string str)    
    {
        value = str;
    }

    ~StringProcessor()                    
    {
        // Деструктор
    }

    public int GetLength()
    {
        return value.Length;
    }

    public string GetString()
    {
        return value;
    }

    public void SortDescending()          
    {
        value = new string(value.OrderByDescending(c => c).ToArray());
    }
}