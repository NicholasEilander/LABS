using System;

Square sq = new Square(0, 0, 4, 0);

Console.WriteLine("Square:");
Console.WriteLine("Coordinates: " + sq.GetInfo());

Console.WriteLine("Side length: " + sq.GetSideLength());
Console.WriteLine("Area: " + sq.GetArea());
Console.WriteLine("Perimeter: " + sq.GetPerimeter());
Console.ReadLine();