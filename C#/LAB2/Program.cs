using ConsoleApp4;

Console.Write("Введіть: ");
string input = Console.ReadLine() ?? "";

var obj = new StringProcessor(input);

Console.WriteLine("Оригінал: " + obj.GetString());
Console.WriteLine("Довжина: " + obj.GetLength());

obj.SortDescending();

Console.WriteLine("Результат: " + obj.GetString());