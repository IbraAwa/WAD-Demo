

namespace Exo_11_Structures_Articles;

internal struct Emballage
{
    public string Couleur;
    public bool Vrac;

    public string Matiere;

    public Emballage(string couleur, bool vrac, string matiere)
    {
        Couleur = couleur;
        Vrac = vrac;
        Matiere = matiere;
    }

    public static Emballage CreerEmballage()
    {
        Console.WriteLine("Création d'emballage");
        Console.WriteLine("Quel couleur est votre emballage ?");
        string couleur = Console.ReadLine();
        Console.WriteLine("Est-il en vrac ? (true/false");
        bool vrac = bool.Parse(Console.ReadLine());
        Console.WriteLine("De quel matière est l'emballage");
        string matiere = Console.ReadLine();

        return new Emballage(couleur, vrac, matiere);
    }
}


// Couleur
// Vrac (oui/non)
// Matiere (plastic ou carton)