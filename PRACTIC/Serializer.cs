using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public static class Serializer
{
    public static void Save(
        List<VehicleRecord> data,
        string file)
    {
        string json =
            JsonSerializer.Serialize(
                data,
                new JsonSerializerOptions
                {
                    WriteIndented = true
                });

        File.WriteAllText(file, json);
    }

    public static List<VehicleRecord> Load(
        string file)
    {
        string json =
            File.ReadAllText(file);

        return JsonSerializer.Deserialize<
            List<VehicleRecord>>(json);
    }
}