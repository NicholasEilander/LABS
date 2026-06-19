public class Node
{
    public VehicleRecord Data { get; set; }

    public Node Next { get; set; }

    public Node Prev { get; set; }

    public Node(VehicleRecord data)
    {
        Data = data;
    }
}