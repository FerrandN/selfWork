using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
public class cards
{
    public string Name { get; set; }
    public int Cost { get; set; }
    public string Effects { get; set; }
}
public class DisplayJson
{
    public static void Main()
    {
        var Cards = new cards()
        {
            Name = "Ursula",
            Cost = 4,
            Effects = "Break monk"
        };
        string fileName = "Ursula.json";
        string jsonString = JsonSerializer.Serialize(Cards);

        File.WriteAllText(fileName, jsonString);
        Console.WriteLine(File.ReadAllText(fileName));
    }
}