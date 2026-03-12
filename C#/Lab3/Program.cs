using ConsoleApp4;

Triangle T1 = new Triangle();
Triangle T2 = new Triangle(0, 0, 4, 0, 0, 3);
Triangle T3 = new Triangle(T2);

T3 = T3 * 2;
T1 = T3 + T2;

Console.WriteLine("T2: " + T2.GetInfo());
Console.WriteLine("T2 Площа: " + T2.GetArea());
Console.WriteLine("T2 Периметр: " + T2.GetPerimeter());
Console.WriteLine();

Console.WriteLine("T3 after * 2: " + T3.GetInfo());
Console.WriteLine("T3 Площа: " + T3.GetArea());
Console.WriteLine("T3 Периметр: " + T3.GetPerimeter());
Console.WriteLine();

Console.WriteLine("T1 = T3 + T2: " + T1.GetInfo());
Console.WriteLine("T1 Площа: " + T1.GetArea());
Console.WriteLine("T1 Периметр: " + T1.GetPerimeter());