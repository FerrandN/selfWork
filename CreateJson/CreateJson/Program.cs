using CreateJson;
using System.Text.Json;

Pokemon nymphali = new Pokemon();
nymphali.Name = "Nymphali";
nymphali.PrimaryType = "Fée";
nymphali.SecondaryType = null;
nymphali.PokemonId = 700;

string text = JsonSerializer.Serialize<Pokemon>(nymphali);

string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

path = Path.Combine(path, "output.json");

Console.WriteLine(path);

File.WriteAllText("C:\\Users\\Stagiaire\\Desktop\\output.json", text);