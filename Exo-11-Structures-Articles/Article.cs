namespace Exo_11_Structures_Articles;

internal struct Article
{
    // Les propriétés d'une classe ou d'une struct commence par une majuscule
    public string Nom;
    public string Categorie;
    public int Stock;

    public Emballage Emballage;

    public Article(string nom, string categorie, int stock, Emballage emballage)
    {
        Nom = nom;
        Categorie = categorie;
        Stock = stock;
        Emballage = emballage;
    }

    // comme je suis dans mon ficheir article
    // et que je veux appelé ma méthode sans crée d'objet
    // j'ajoute le mot clée static
    public static Article Creer(Emballage emballage)
    {
        Console.WriteLine("Crée votre article");
        Console.Write("Nom de l'article ? ");
        string nom = Console.ReadLine();
        Console.Write("Catégorie de l'article ? ");
        string categorie = Console.ReadLine();
        Console.Write("Nombe en stock ? ");
        int stock = int.Parse(Console.ReadLine());

        return new Article(nom, categorie, stock, emballage);
    }
}
