using System;
using System.Collections.Generic;

public class DoublyLinkedList
{
    private Node head;
    private Node tail;

    private Node iterator;

    public int Length { get; private set; }

    public void AddAtPosition(
        VehicleRecord record,
        int position)
    {
        if (position < 0 || position > Length)
            throw new IndexOutOfRangeException();

        Node newNode = new Node(record);

        if (Length == 0)
        {
            head = tail = newNode;
        }
        else if (position == 0)
        {
            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }
        else if (position == Length)
        {
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }
        else
        {
            Node current = GetNode(position);

            newNode.Next = current;
            newNode.Prev = current.Prev;

            current.Prev.Next = newNode;
            current.Prev = newNode;
        }

        Length++;
    }

    public void RemoveFirst()
    {
        if (head == null)
            throw new InvalidOperationException(
                "List is empty");

        head = head.Next;

        if (head != null)
            head.Prev = null;
        else
            tail = null;

        Length--;
    }

    private Node GetNode(int index)
    {
        if (index < 0 || index >= Length)
            throw new IndexOutOfRangeException();

        Node current = head;

        for (int i = 0; i < index; i++)
            current = current.Next;

        return current;
    }

    public VehicleRecord this[int index]
    {
        get
        {
            return GetNode(index).Data;
        }

        set
        {
            GetNode(index).Data = value;
        }
    }

    public VehicleRecord GetFirst()
    {
        iterator = head;

        return iterator?.Data;
    }

    public VehicleRecord GetNext()
    {
        if (iterator == null)
            return null;

        iterator = iterator.Next;

        return iterator?.Data;
    }

    public void Reverse()
    {
        Node current = head;

        while (current != null)
        {
            Node temp = current.Next;

            current.Next = current.Prev;
            current.Prev = temp;

            current = temp;
        }

        Node swap = head;
        head = tail;
        tail = swap;
    }

    public List<VehicleRecord> Search()
    {
        List<VehicleRecord> result =
            new List<VehicleRecord>();

        Node current = head;

        while (current != null)
        {
            if (current.Data.Electric &&
                current.Data.EngineVolume < 2.0)
            {
                result.Add(current.Data);
            }

            current = current.Next;
        }

        return result;
    }

    public List<VehicleRecord> ToList()
    {
        List<VehicleRecord> result =
            new List<VehicleRecord>();

        Node current = head;

        while (current != null)
        {
            result.Add(current.Data);
            current = current.Next;
        }

        return result;
    }
}