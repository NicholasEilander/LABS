public class VehicleRecord
{
    public VehicleType Type { get; set; }

    public double EngineVolume { get; set; }

    public bool Electric { get; set; }

    public VehicleRecord(
        VehicleType type,
        double engineVolume,
        bool electric)
    {
        Type = type;
        EngineVolume = engineVolume;
        Electric = electric;
    }

    public override string ToString()
    {
        return $"{Type,-12} {EngineVolume,-10} {Electric}";
    }
}