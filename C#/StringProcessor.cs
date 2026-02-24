using System.Linq;

public class StringProcessor
{
    private string value;

    public StringProcessor(string str)
    {
        value = str;
    }

    public int GetLength()
    {
        return value.Length;
    }

    public string GetString()
    {
        return value;
    }

    public void SortAscending()
    {
        value = new string(value.OrderBy(c => c).ToArray());
    }
}