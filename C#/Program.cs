

Console.Write("Enter string: ");
string input = Console.ReadLine() ?? "";

var obj = new StringProcessor(input);

Console.WriteLine("Original string: " + obj.GetString());
Console.WriteLine("Length: " + obj.GetLength());

obj.SortAscending();

Console.WriteLine("Sorted string: " + obj.GetString());