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
}
