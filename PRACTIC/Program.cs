using System;

class Program
{
    static void Main()
    {
        DoublyLinkedList list =
            new DoublyLinkedList();

        list.AddAtPosition(
            new VehicleRecord(
                VehicleType.Hybrid,
                1.8,
                true),
            0);

        list.AddAtPosition(
            new VehicleRecord(
                VehicleType.Car,
                2.5,
                false),
            1);

        list.AddAtPosition(
            new VehicleRecord(
                VehicleType.Electric,
                0,
                true),
            2);

        PrintList(list);

        Console.WriteLine(
            "\nSearch result:");

        foreach (var vehicle in list.Search())
            Console.WriteLine(vehicle);

        list.RemoveFirst();

        Console.WriteLine(
            "\nAfter remove:");

        PrintList(list);

        list.Reverse();

        Console.WriteLine(
            "\nAfter reverse:");

        PrintList(list);

        Serializer.Save(
            list.ToList(),
            "vehicles.json");

        Console.WriteLine(
            "\nSaved to vehicles.json");
    }

    static void PrintList(
        DoublyLinkedList list)
    {
        Console.WriteLine(
            "Type         Engine     Electric");

        VehicleRecord current =
            list.GetFirst();

        while (current != null)
        {
            Console.WriteLine(current);

            current = list.GetNext();
        }

        Console.WriteLine(
            $"Length: {list.Length}");
    }
}