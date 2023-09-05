using System.Xml.Serialization;

List<string> personne = new List<string>();

personne.Add("Rodolphe");
personne.Add("David");
personne.Add("Gatien");
personne.Add("Johny");
personne.Add("Thomas");
personne.Add("Angelo");
personne.Add("Nicolas");
personne.Add("Gerard");

Random rand = new Random();
Console.WriteLine("Entrée le nombre d'équipe souhaité");
int nbEquipe = Int32.Parse(Console.ReadLine());

do
{
    for(int i = 0; i < nbEquipe; i++)
    {
        if (personne.Count > 0)
        {
            int choosenPersonne = rand.Next(0, personne.Count());
            Console.WriteLine(personne[choosenPersonne] + " seras dans l'équipe " + i);
            personne.RemoveAt(choosenPersonne);
        }
    }

} while (personne.Count > 0);
